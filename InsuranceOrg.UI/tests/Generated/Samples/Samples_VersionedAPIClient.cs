// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Identity;
using NUnit.Framework;
using insurance;

namespace insurance.Samples
{
    public partial class Samples_VersionedAPIClient
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Register_ShortVersion()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            VersionedAPIClient client = new VersionedAPIClient(endpoint);

            using RequestContent content = null;
            Response response = client.Register(content, new ContentType("application/json"));

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Register_ShortVersion_Async()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            VersionedAPIClient client = new VersionedAPIClient(endpoint);

            using RequestContent content = null;
            Response response = await client.RegisterAsync(content, new ContentType("application/json"));

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Register_AllParameters()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            VersionedAPIClient client = new VersionedAPIClient(endpoint);

            using RequestContent content = RequestContent.Create(new
            {
                username = "<username>",
                password = "<password>",
                roles = new object[]
            {
"<roles>"
            },
            });
            Response response = client.Register(content, new ContentType("application/json"));

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Register_AllParameters_Async()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            VersionedAPIClient client = new VersionedAPIClient(endpoint);

            using RequestContent content = RequestContent.Create(new
            {
                username = "<username>",
                password = "<password>",
                roles = new object[]
            {
"<roles>"
            },
            });
            Response response = await client.RegisterAsync(content, new ContentType("application/json"));

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_PostClaim_ShortVersion()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            VersionedAPIClient client = new VersionedAPIClient(endpoint);

            using RequestContent content = null;
            Response response = client.PostClaim(content, new ContentType("application/json"));

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_PostClaim_ShortVersion_Async()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            VersionedAPIClient client = new VersionedAPIClient(endpoint);

            using RequestContent content = null;
            Response response = await client.PostClaimAsync(content, new ContentType("application/json"));

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_PostClaim_AllParameters()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            VersionedAPIClient client = new VersionedAPIClient(endpoint);

            using RequestContent content = RequestContent.Create(new
            {
                date = "2022-05-10T18:57:31.2311892Z",
                type = "0",
                issuerName = "<issuerName>",
                code = "<code>",
                amount = 1234,
                otherInfo = "<otherInfo>",
            });
            Response response = client.PostClaim(content, new ContentType("application/json"));

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_PostClaim_AllParameters_Async()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            VersionedAPIClient client = new VersionedAPIClient(endpoint);

            using RequestContent content = RequestContent.Create(new
            {
                date = "2022-05-10T18:57:31.2311892Z",
                type = "0",
                issuerName = "<issuerName>",
                code = "<code>",
                amount = 1234,
                otherInfo = "<otherInfo>",
            });
            Response response = await client.PostClaimAsync(content, new ContentType("application/json"));

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetProcessedClaims_ShortVersion()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            VersionedAPIClient client = new VersionedAPIClient(endpoint);

            Response response = client.GetProcessedClaims();

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetProcessedClaims_ShortVersion_Async()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            VersionedAPIClient client = new VersionedAPIClient(endpoint);

            Response response = await client.GetProcessedClaimsAsync();

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetProcessedClaims_AllParameters()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            VersionedAPIClient client = new VersionedAPIClient(endpoint);

            Response response = client.GetProcessedClaims();

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetProcessedClaims_AllParameters_Async()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            VersionedAPIClient client = new VersionedAPIClient(endpoint);

            Response response = await client.GetProcessedClaimsAsync();

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetPendingClaims_ShortVersion()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            VersionedAPIClient client = new VersionedAPIClient(endpoint);

            Response response = client.GetPendingClaims();

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetPendingClaims_ShortVersion_Async()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            VersionedAPIClient client = new VersionedAPIClient(endpoint);

            Response response = await client.GetPendingClaimsAsync();

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetPendingClaims_AllParameters()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            VersionedAPIClient client = new VersionedAPIClient(endpoint);

            Response response = client.GetPendingClaims();

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetPendingClaims_AllParameters_Async()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            VersionedAPIClient client = new VersionedAPIClient(endpoint);

            Response response = await client.GetPendingClaimsAsync();

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_UploadImage_ShortVersion()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            VersionedAPIClient client = new VersionedAPIClient(endpoint);

            using RequestContent content = RequestContent.Create(File.OpenRead("<filePath>"));
            Response response = client.UploadImage(content);

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_UploadImage_ShortVersion_Async()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            VersionedAPIClient client = new VersionedAPIClient(endpoint);

            using RequestContent content = RequestContent.Create(File.OpenRead("<filePath>"));
            Response response = await client.UploadImageAsync(content);

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_UploadImage_AllParameters()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            VersionedAPIClient client = new VersionedAPIClient(endpoint);

            using RequestContent content = RequestContent.Create(File.OpenRead("<filePath>"));
            Response response = client.UploadImage(content);

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_UploadImage_AllParameters_Async()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            VersionedAPIClient client = new VersionedAPIClient(endpoint);

            using RequestContent content = RequestContent.Create(File.OpenRead("<filePath>"));
            Response response = await client.UploadImageAsync(content);

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetDentalCoverage_ShortVersion()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            VersionedAPIClient client = new VersionedAPIClient(endpoint);

            Response response = client.GetDentalCoverage(null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result[0].ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetDentalCoverage_ShortVersion_Async()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            VersionedAPIClient client = new VersionedAPIClient(endpoint);

            Response response = await client.GetDentalCoverageAsync(null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result[0].ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetDentalCoverage_AllParameters()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            VersionedAPIClient client = new VersionedAPIClient(endpoint);

            Response response = client.GetDentalCoverage(null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result[0].GetProperty("maxCoverageAmount").ToString());
            Console.WriteLine(result[0].GetProperty("customerId").ToString());
            Console.WriteLine(result[0].GetProperty("dentalCleaningAmount").ToString());
            Console.WriteLine(result[0].GetProperty("orthodentalAmount").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetDentalCoverage_AllParameters_Async()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            VersionedAPIClient client = new VersionedAPIClient(endpoint);

            Response response = await client.GetDentalCoverageAsync(null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result[0].GetProperty("maxCoverageAmount").ToString());
            Console.WriteLine(result[0].GetProperty("customerId").ToString());
            Console.WriteLine(result[0].GetProperty("dentalCleaningAmount").ToString());
            Console.WriteLine(result[0].GetProperty("orthodentalAmount").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetHealthCoverage_ShortVersion()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            VersionedAPIClient client = new VersionedAPIClient(endpoint);

            Response response = client.GetHealthCoverage(null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result[0].ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetHealthCoverage_ShortVersion_Async()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            VersionedAPIClient client = new VersionedAPIClient(endpoint);

            Response response = await client.GetHealthCoverageAsync(null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result[0].ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetHealthCoverage_AllParameters()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            VersionedAPIClient client = new VersionedAPIClient(endpoint);

            Response response = client.GetHealthCoverage(null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result[0].GetProperty("maxCoverageAmount").ToString());
            Console.WriteLine(result[0].GetProperty("customerId").ToString());
            Console.WriteLine(result[0].GetProperty("massageAllowanceAmount").ToString());
            Console.WriteLine(result[0].GetProperty("chiropractorAllowanceAmunt").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetHealthCoverage_AllParameters_Async()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            VersionedAPIClient client = new VersionedAPIClient(endpoint);

            Response response = await client.GetHealthCoverageAsync(null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result[0].GetProperty("maxCoverageAmount").ToString());
            Console.WriteLine(result[0].GetProperty("customerId").ToString());
            Console.WriteLine(result[0].GetProperty("massageAllowanceAmount").ToString());
            Console.WriteLine(result[0].GetProperty("chiropractorAllowanceAmunt").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetMimicException_ShortVersion()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            VersionedAPIClient client = new VersionedAPIClient(endpoint);

            Response response = client.GetMimicException();

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetMimicException_ShortVersion_Async()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            VersionedAPIClient client = new VersionedAPIClient(endpoint);

            Response response = await client.GetMimicExceptionAsync();

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetMimicException_AllParameters()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            VersionedAPIClient client = new VersionedAPIClient(endpoint);

            Response response = client.GetMimicException();

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetMimicException_AllParameters_Async()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            VersionedAPIClient client = new VersionedAPIClient(endpoint);

            Response response = await client.GetMimicExceptionAsync();

            Console.WriteLine(response.Status);
        }
    }
}