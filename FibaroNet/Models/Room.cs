namespace FibaroNet.Models
{
    public class Room
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int SectionID { get; set; }
        public bool IsDefault { get; set; }
        public bool Visible { get; set; }
        public string Icon { get; set; }
        public DefaultSensors DefaultSensors { get; set; }
        public Meters Meters { get; set; }
        public int DefaultThermostat { get; set; }
        public int SortOrder { get; set; }
        public string Category { get; set; }
    }
}
