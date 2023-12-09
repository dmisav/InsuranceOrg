FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY ["InsuranceOrg.UI/InsuranceOrg.UI.csproj", "InsuranceOrg.UI/"]
RUN dotnet restore "InsuranceOrg.UI/InsuranceOrg.UI.csproj"
COPY . .
WORKDIR "/src/InsuranceOrg.UI"
RUN dotnet build "InsuranceOrg.UI.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "InsuranceOrg.UI.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "InsuranceOrg.UI.dll"]
