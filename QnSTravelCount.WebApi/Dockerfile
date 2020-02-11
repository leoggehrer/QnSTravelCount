#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["QnSTravelCount.WebApi/QnSTravelCount.WebApi.csproj", "QnSTravelCount.WebApi/"]
COPY ["QnSTravelCount.Transfer/QnSTravelCount.Transfer.csproj", "QnSTravelCount.Transfer/"]
COPY ["QnSTravelCount.Contracts/QnSTravelCount.Contracts.csproj", "QnSTravelCount.Contracts/"]
COPY ["CommonBase/CommonBase.csproj", "CommonBase/"]
COPY ["QnSTravelCount.Logic/QnSTravelCount.Logic.csproj", "QnSTravelCount.Logic/"]
RUN dotnet restore "QnSTravelCount.WebApi/QnSTravelCount.WebApi.csproj"
COPY . .
WORKDIR "/src/QnSTravelCount.WebApi"
RUN dotnet build "QnSTravelCount.WebApi.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "QnSTravelCount.WebApi.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "QnSTravelCount.WebApi.dll"]