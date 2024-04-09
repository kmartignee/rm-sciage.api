namespace rm_sciage.domain.Model.Settings;

public class CorsSettings
{
    public const string Key = "Security";
    public string[] AllowedHosts { get; set; } = [];
}