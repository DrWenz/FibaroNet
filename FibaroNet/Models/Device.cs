using System.Collections.Generic;

namespace FibaroNet.Models
{
    public partial class Device
    {
        public bool ViewXml { get; set; }
        public bool HasUIView { get; set; }
        public List<object> View { get; set; }
        public List<string> Interfaces { get; set; }
        public bool Visible { get; set; }
        public int Created { get; set; }
        public string Type { get; set; }
        public int RemoteGatewayId { get; set; }
        public bool Enabled { get; set; }
        public double ParentId { get; set; }
        public int RoomID { get; set; }
        public string BaseType { get; set; }
        public int SortOrder { get; set; }
        public string Name { get; set; }
        public bool ConfigXml { get; set; }
        public object Config { get; set; }
        public int Modified { get; set; }
        public int Id { get; set; }
        public Dictionary<string, object> Actions { get; set; }
        public Dictionary<string, object> Properties { get; set; }
        public bool Dead { get; set; }
        public string PollingTimeSec { get; set; }
        public string Manufacturer { get; set; }
        public string MoveLeftPath { get; set; }
        public string ZWaveInfo { get; set; }
        public string DeadReason { get; set; }
        public string MoveDownPath { get; set; }
        public int EmailNotificationId { get; set; }
        public double ProtectionState { get; set; }
        public int AlarmLevel { get; set; }
        public List<object> Categories { get; set; }
        public int RFProtectionState { get; set; }
        public double TargetLevelStep { get; set; }
        public List<object> ZWaveScheduleClimatePanelCompatibleBlocks { get; set; }
        public int BatteryLevel { get; set; }
        public int Timestamp { get; set; }
        public int PushNotificationId { get; set; }
        public string UserDescription { get; set; }
        public int DeviceIcon { get; set; }
        public string LogTemp { get; set; }
        public double ProtectionExclusiveControl { get; set; }
        public double TargetLevelTimestamp { get; set; }
        public int MaxInterval { get; set; }
        public bool Armed { get; set; }
        public bool SendStopAfterMove { get; set; }
        public string MoveUpPath { get; set; }
        public List<object> DeviceGroup { get; set; }
        public int RFProtectionSupport { get; set; }
        public double StepInterval { get; set; }
        public int DefInterval { get; set; }
        public string ZWaveCompany { get; set; }
        public bool ShowEnergy { get; set; }
        public string MoveRightPath { get; set; }
        public string MoveStopPath { get; set; }
        public string RateType { get; set; }
        public double Mode { get; set; }
        public int DisplayOnMainPage { get; set; }
        public bool Configured { get; set; }
        public int EmailNotificationType { get; set; }
        public string SerialNumber { get; set; }
        public string LiliOffCommand { get; set; }
        public string Offset { get; set; }
        public bool HttpsEnabled { get; set; }
        public bool PollingDeadDevice { get; set; }
        public int DeviceGroupMaster { get; set; }
        public string LiliOnCommand { get; set; }
        public double WakeUpTime { get; set; }
        public string Unit { get; set; }
        public bool UseTemplate { get; set; }
        public string MjpgPath { get; set; }
        public int NodeId { get; set; }
        public List<object> Parameters { get; set; }
        public bool SaveLogs { get; set; }
        public bool SaveToEnergyPanel { get; set; }
        public string ZWaveVersion { get; set; }
        public bool BatteryLowNotification { get; set; }
        public int SmsNotificationId { get; set; }
        public double ProtectionExclusiveControlSupport { get; set; }
        public int ButtonType { get; set; }
        public double TargetLevelMin { get; set; }
        public List<object> Schedules { get; set; }
        public int LocalProtectionSupport { get; set; }
        public int EndPointId { get; set; }
        public double TargetLevel { get; set; }
        public int ClimateZoneId { get; set; }
        public string JpgPath { get; set; }
        public int CameraType { get; set; }
        public bool MarkAsDead { get; set; }
        public int DeviceControlType { get; set; }
        public string DeviceRole { get; set; }
        public List<string> SupportedDeviceRoles { get; set; }
        public int AlarmType { get; set; }
        public int MinInterval { get; set; }
        public double PushNotificationType { get; set; }
        public double SmsNotificationType { get; set; }
        public string ClimateZoneHash { get; set; }
        public int AssociationMode { get; set; }
        public double TargetLevelMax { get; set; }
        public string Username { get; set; }
        public string SipUserPassword { get; set; }
        public string SipDisplayName { get; set; }
        public string SipUserID { get; set; }
        public bool SipUserEnabled { get; set; }
        public List<string> SupportedThermostatFanModes { get; set; }
        public List<string> SupportedThermostatModes { get; set; }
        public string ThermostatFanMode { get; set; }
        public bool ThermostatFanOff { get; set; }
        public string ThermostatFanState { get; set; }
        public string ThermostatMode { get; set; }
        public string ThermostatModeFuture { get; set; }
        public string ThermostatOperatingState { get; set; }
        public string SecurityLevel { get; set; }
        public List<string> SecuritySchemes { get; set; }

        public override string ToString() {
            return Name;
        }
    }
}
