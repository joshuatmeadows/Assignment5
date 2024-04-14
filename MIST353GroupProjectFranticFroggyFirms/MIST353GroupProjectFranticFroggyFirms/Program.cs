using Microsoft.EntityFrameworkCore;
using MIST353GroupProjectFranticFroggyFirms.Data;
using MIST353GroupProjectFranticFroggyFirms.Repositories;



var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<DbContextClass>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});
builder.Services.AddScoped<IEllaAPI, EllaAPI>(); // Register EllaAPI class
builder.Services.AddScoped<IHotelRoomAvail, HotelRoomAvail>(); //brooke api
builder.Services.AddScoped<IHotelReview, HotelReviewService>(); //brooke api

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
// allow cros-site scripting
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowMyRazorPagesApp",
        builder =>
        {
            builder.WithOrigins("https://localhost:7141")
            .AllowAnyHeader()
            .AllowAnyMethod();
        }

        );
});
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseCors("AllowMyRazorPagesApp");

app.UseAuthorization();

app.MapControllers();

app.Run();
