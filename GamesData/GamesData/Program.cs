using GameBlocApi.Services.Interface;
using GameBlocApi.Services;
using GamesData.Services.Interface;
using GamesData.Services;
using GamesData.Services.Filters.Interface;
using GamesData.Services.Filters;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddTransient<IAllGame, AllGameService>();
builder.Services.AddTransient<IAddGame, AddGameService>();
builder.Services.AddTransient<IDeleteGame, DeleteGameService>();
builder.Services.AddTransient<IOneGame, OneGameService>();
builder.Services.AddTransient<IPatchGame, PatchGameService>();
builder.Services.AddTransient<IYearRelease, FilterYearReleaseService>();
builder.Services.AddTransient<IFilterName, FilterNameService>();
builder.Services.AddTransient<IRatingFilter, FilterRatingService>();
var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
