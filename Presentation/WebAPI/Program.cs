using Application;
using Persistence;
using Microsoft.EntityFrameworkCore;
using Persistence.Context; // <- Seed sýnýfýný burada ekle

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddPersistenceService();
builder.Services.AddApplicationService();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddControllers();

var app = builder.Build();

// MIGRATION ve SEED DATA iþlemleri buradan yapýlýr
using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;
    var context = services.GetRequiredService<ApplicationContext>();

    // Veritabaný yoksa otomatik oluþturur (Migration varsa uygular)
    await context.Database.MigrateAsync();

    // Seed data otomatik olarak eklenecek (zaten kontrol var: varsa eklenmez)
    await ApplicationContextSeed.SeedAsync(context);
}

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
