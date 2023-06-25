using TechnologyTest.Application;
using TechnologyTest.Persistence.CockroachDB;
using TechnologyTest.Persistence.CosmosDB;
using TechnologyTest.Persistence.DgraphDB;
using TechnologyTest.Persistence.EFCore;
using TechnologyTest.Persistence.FaunaDB;
using TechnologyTest.Persistence.Firestore;
using TechnologyTest.Persistence.MongoDB;
using TechnologyTest.Persistence.RavenDB;
using TechnologyTest.Persistence.Redis;
using TechnologyTest.Persistence.SurrealDB;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddProjectApplication(builder.Configuration);

switch (builder.Configuration.GetValue<string>("DATABASE_TYPE"))
{
    case "CosmosDB":
        builder.Services.AddProjectCosmosDb(builder.Configuration);
        break;
    case "EFCore":
        builder.Services.AddProjectEfCore(builder.Configuration);
        break;
    case "Firestore":
        builder.Services.AddProjectFirestore(builder.Configuration);
        break;
    case "MongoDB":
        builder.Services.AddProjectMongoDb(builder.Configuration);
        break;
    case "RavenDB":
        builder.Services.AddProjectRavenDb(builder.Configuration);
        break;
    case "CockroachDB":
        builder.Services.AddProjectCockroachDb(builder.Configuration);
        break;
    case "DgraphDB":
        builder.Services.AddProjectDgraphDb(builder.Configuration);
        break;
    case "FaunaDB":
        builder.Services.AddProjectFaunaDb(builder.Configuration);
        break;
    case "Redis":
        builder.Services.AddProjectRedis(builder.Configuration);
        break;
    case "SurrealDB":
        builder.Services.AddProjectSurrealDb(builder.Configuration);
        break;
}

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();



app.Run();