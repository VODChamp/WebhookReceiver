FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["VodChamp.Backend.WebhookReceiver/VodChamp.Backend.WebhookReceiver.csproj", "VodChamp.Backend.WebhookReceiver/"]
RUN dotnet restore "VodChamp.Backend.WebhookReceiver/VodChamp.Backend.WebhookReceiver.csproj"
COPY . .
WORKDIR "/src/VodChamp.Backend.WebhookReceiver"
RUN dotnet build "VodChamp.Backend.WebhookReceiver.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "VodChamp.Backend.WebhookReceiver.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "VodChamp.Backend.WebhookReceiver.dll"]
