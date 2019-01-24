FROM microsoft/dotnet:2.2-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 80

FROM microsoft/dotnet:2.2-sdk AS build
WORKDIR /src
COPY ["SnackBar.Api/SnackBar.Api.csproj", "SnackBar.Api/"]
COPY ["SnackBar.Domain/SnackBar.Domain.csproj", "SnackBar.Domain/"]
COPY ["SnackBAr.Shared/SnackBar.Shared.csproj", "SnackBAr.Shared/"]
COPY ["SnackBar.Infra/SnackBar.Infra.csproj", "SnackBar.Infra/"]
RUN dotnet restore "SnackBar.Api/SnackBar.Api.csproj"
COPY . .
WORKDIR "/src/SnackBar.Api"
RUN dotnet build "SnackBar.Api.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "SnackBar.Api.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "SnackBar.Api.dll"]