using System.Text.Json.Serialization;

namespace PayNlSdk.Sdk.DataTransferModels.TerminalPayments;

public class PinTransactionCancelResponse
{
    [JsonPropertyName("error")]
    public string? Error { get; set; }

    [JsonPropertyName("errormsg")]
    public string? ErrorMessage { get; set; }
}