namespace InsuranceOrg.Tests;

public class ControllerTestsBase
{
    //TO DO add cleint factory here
    protected HttpClient CreateClient()
    {
        return new HttpClient();
    }
}