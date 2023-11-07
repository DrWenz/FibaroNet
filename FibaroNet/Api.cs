using FibaroNet.Commands;
using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text.Json;
using System.Threading.Tasks;

namespace FibaroNet
{
    public sealed partial class Api : IDisposable
    {
        private readonly HttpClient _httpClient;

        public Api(Uri homeCenterUrl, string userName, string password) {
            var authenticationString = $"{userName}:{password}";
            var base64EncodedAuthenticationString = Convert.ToBase64String(System.Text.Encoding.ASCII.GetBytes(authenticationString));

            _httpClient = new HttpClient() {
                BaseAddress = homeCenterUrl
            };
            _httpClient.DefaultRequestHeaders.Add("Accept", "application/json");
            _httpClient.DefaultRequestHeaders.Add("X-FibaroNet-Version", "2");
            _httpClient.DefaultRequestHeaders.Add("Accept-language", "de");
            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", base64EncodedAuthenticationString);

            CreateDefaultCommands();
        }
        public async Task<CommandResult<T>> SendCommandAsync<T>(ICommand<T> command) where T : class {
            command.Prepare();
            using var requestMessage = new HttpRequestMessage {
                Method = command.Method,
                RequestUri = new Uri(_httpClient.BaseAddress, command.Endpoint),
                Content = command.Content == null
                ? null
                : JsonContent.Create(command.Content, new MediaTypeHeaderValue("application/json"), new JsonSerializerOptions {
                    DefaultIgnoreCondition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
                    PropertyNamingPolicy = JsonNamingPolicy.CamelCase
                })
            };
            if(command.Method == HttpMethod.Get)
                requestMessage.Headers.Add("Accept", "application/json");
            else if(command.Method == HttpMethod.Post || command.Method == HttpMethod.Post || command.Method == HttpMethod.Delete)
                requestMessage.Headers.Add("Accept", "*/*");

            var response = await _httpClient.SendAsync(requestMessage);
            if(!response.IsSuccessStatusCode)
                return CommandResult<T>.FromError(TimeSpan.FromSeconds(0), await response.Content.ReadAsStringAsync());

            T responseObject = typeof(T) == typeof(string)
                ? (T)Convert.ChangeType(await response.Content.ReadAsStringAsync(), typeof(T))
                : await response.Content.ReadFromJsonAsync<T>();
            responseObject = command.TransformResult(responseObject);
            return CommandResult<T>.FromSuccess(TimeSpan.FromSeconds(0), responseObject);
        }
        public void Dispose() {
            _httpClient.Dispose();
        }
    }
}
