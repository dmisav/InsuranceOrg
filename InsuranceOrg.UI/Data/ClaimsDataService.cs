using Newtonsoft.Json;

namespace InsuranceOrg.UI.Data;

public class ClaimsDataService
{
    public async Task<IEnumerable<Claim>?> GetClaimsAsync()
    {
        HttpClient client = new HttpClient();
        List<Claim>? claims;
        try
        {
            using HttpResponseMessage response = await client.GetAsync("http://localhost:5112/api/v1/claim/GetProcessedClaims");
            response.EnsureSuccessStatusCode();
            string responseBody = await response.Content.ReadAsStringAsync();
            claims = JsonConvert.DeserializeObject<List<Claim>>(responseBody);
        }
        catch (HttpRequestException e)
        {
            throw new Exception("Exception Caught! Message :{0} ", new Exception(e.Message));
        }

        return claims;
    }
}