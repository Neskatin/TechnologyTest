FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["src/TechnologyTest.Todo.Presentation.API.FastEndpoint/TechnologyTest.Todo.Presentation.API.FastEndpoint.csproj", "src/TechnologyTest.Todo.Presentation.API.FastEndpoint/"]
RUN dotnet restore "src/TechnologyTest.Todo.Presentation.API.FastEndpoint/TechnologyTest.Todo.Presentation.API.FastEndpoint.csproj"
COPY . .
WORKDIR "/src/src/TechnologyTest.Todo.Presentation.API.FastEndpoint"
RUN dotnet build "TechnologyTest.Todo.Presentation.API.FastEndpoint.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "TechnologyTest.Todo.Presentation.API.FastEndpoint.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "TechnologyTest.Todo.Presentation.API.FastEndpoint.dll"]
