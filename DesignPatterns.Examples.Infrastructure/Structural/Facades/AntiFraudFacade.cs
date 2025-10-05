using System.Text;
using System.Text.Json;

namespace DesignPatterns.Examples.Infrastructure.Structural.Facades;

public class AntiFraudFacade : IAntiFraudFacade
{
    public AntiFraudResultModel Check(AntiFraudModel model)
    {
        string json = JsonSerializer.Serialize(model);
        StringContent content = new(json, Encoding.UTF8, "application/json");
        string url = "https://63178ecbece2736550b65df3.mockapi.io/api/v1/anti-fraud";

        using HttpClient client = new();

        HttpResponseMessage antiFraudRequestResult = client.PostAsync(url, content).Result;
        string antiFraudResultString = antiFraudRequestResult.Content.ReadAsStringAsync().Result;
        return JsonSerializer.Deserialize<AntiFraudResultModel>(antiFraudResultString);
    }
}