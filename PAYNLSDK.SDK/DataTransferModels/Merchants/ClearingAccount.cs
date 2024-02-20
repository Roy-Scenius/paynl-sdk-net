using System.Text.Json.Serialization;

namespace PayNlSdk.Sdk.DataTransferModels.Merchants;

public class ClearingAccount
{
    [JsonPropertyName("method")]
    public string? Method { get; set; }

    [JsonPropertyName("iban")]
    public Iban? Iban { get; set; }
}