using MiniChallengeEightToTen.Services.EightBall;
using MiniChallengeEightToTen.Services.GuessIt;
using MiniChallengeEightToTen.Services.RestaurantPicker;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IRestaurantPickerService, ResturantPickerService>();
builder.Services.AddScoped<IEightBallService, EightBallService>();
builder.Services.AddScoped<IGuessItService, GuessItService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
