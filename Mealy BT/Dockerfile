FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["Mealy BT/Mealy BT.csproj", "Mealy BT/"]
RUN dotnet restore "Mealy BT/Mealy BT.csproj"
COPY . .
WORKDIR "/src/Mealy BT"
RUN dotnet build "Mealy BT.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Mealy BT.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Mealy BT.dll"]
