FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["InsuranceOrgWebAPI/InsuranceOrgWebAPI.csproj", "InsuranceOrgWebAPI/"]
RUN dotnet restore "InsuranceOrgWebAPI/InsuranceOrgWebAPI.csproj"
COPY . .
WORKDIR "/src/InsuranceOrgWebAPI"
RUN dotnet build "InsuranceOrgWebAPI.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "InsuranceOrgWebAPI.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "InsuranceOrgWebAPI.dll"]
