# InsuranceOrg

Net 8, Gherkin, html/css

<b><mark> Web API </mark></b> 
 <br/>
  Swagger / DI / Automapper, DTOs / Global exception handling / Custom Action Filters / Global Model Validation / Action based routing / API versioning / JWT authentication / File Upload / TDD (Nunit) / BDD (Specflow) / Cors

<br/>
<b><cite> Web UI </cite></b> 
<br/>
  Blazor / Http Client / OpenApi generated http client
<br/>


-- Auto Rest Client Generation Code. Extra Azure SDK nuget packages are required to be installed
 <br/>
 sudo npm install -g autorest
 <br/>
 autorest --help       
 <br/>
 autorest --input-file=http://localhost:5112/swagger/v1/swagger.json --csharp --output-folder=InsuranceOrg.UI/Data/OpenApiClient/ --namespace=insurance
