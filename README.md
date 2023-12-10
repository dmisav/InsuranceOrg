# InsuranceOrg

Net 8, Gherkin, html/css

<b><u> Web API </u></b> 
 <br/>
  Swagger / DI / Automapper, DTOs / Global exception handling / Custom Action Filters / Global Model Validation / Action based routing / API versioning / JWT authentication / File Upload / TDD (Nunit) / BDD (Specflow) / Cors

<br/>
<b><u> Web UI </u></b> 
<br/>
  Blazor / Http Client / OpenApi generated http client

<br/>
 sudo npm install -g autorest
 autorest --help       
 autorest --input-file=http://localhost:5112/swagger/v1/swagger.json --csharp --output-folder=InsuranceOrg.UI/Data/OpenApiClient/ --namespace=insurance
