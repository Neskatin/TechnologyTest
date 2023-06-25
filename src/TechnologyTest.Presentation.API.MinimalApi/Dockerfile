FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["src/TechnologyTest.Todo.Presentation.API.MinimalApi/TechnologyTest.Todo.Presentation.API.MinimalApi.csproj", "src/TechnologyTest.Todo.Presentation.API.MinimalApi/"]
RUN dotnet restore "src/TechnologyTest.Todo.Presentation.API.MinimalApi/TechnologyTest.Todo.Presentation.API.MinimalApi.csproj"
COPY . .
WORKDIR "/src/src/TechnologyTest.Todo.Presentation.API.MinimalApi"
RUN dotnet build "TechnologyTest.Todo.Presentation.API.MinimalApi.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "TechnologyTest.Todo.Presentation.API.MinimalApi.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "TechnologyTest.Todo.Presentation.API.MinimalApi.dll"]
