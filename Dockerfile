FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS build
WORKDIR /src
COPY *.csproj buiding/
WORKDIR /src/buiding
RUN dotnet restore

COPY . .
WORKDIR /src/buiding
RUN dotnet publish -c Release -o /src/publish

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1 AS runtime
WORKDIR /app
EXPOSE 5000
EXPOSE 5001
COPY --from=build /src/publish .
ENTRYPOINT ["dotnet", "mysqlEfApi.dll"]