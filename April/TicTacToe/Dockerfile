FROM mcr.microsoft.com/dotnet/sdk:6.0

WORKDIR /build
COPY . .

RUN dotnet restore

RUN dotnet build

RUN dotnet test --collect:"XPlat Code Coverage" -- DataCollectionRunSettings.DataCollectors.DataCollector.Configuration.Format=cobertura
