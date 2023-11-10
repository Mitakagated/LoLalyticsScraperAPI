var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
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

var summaries = new[]
{
    "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
};

app.MapGet("/{champion}/build", (string champName) =>
{
    
})
.WithOpenApi();

app.Run();

internal record LeagueChampion(string ChampName, double Winrate, int PositionRank, int PositionTotalRank, string Tier, double Pickrate, double Banrate, int Games, string Lane, RankTier Ranktier, string Patch, GameQueue Queue)
{

}

internal enum GameQueue
{
    Ranked,
    Aram
}