namespace CAServer.DataReporting.Dtos;

public class UserDeviceReportingDto
{
    public string DeviceId { get; set; }
    public string Token { get; set; }
    public long RefreshTime { get; set; }
    public NetworkType NetworkType { get; set; }
    public DeviceInfo DeviceInfo { get; set; }
}

public class AppStatusReportingDto
{
    public NetworkType NetworkType { get; set; }
    public AppStatus Status { get; set; }
}

public class DeviceInfo
{
    public DeviceType DeviceType { get; set; }
    public string DeviceBrand { get; set; }
    public string OperatingSystemVersion { get; set; }
}