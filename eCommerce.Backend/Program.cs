using eCommerce.Backend.Data;
using Microsoft.EntityFrameworkCore;
using eCommerce.Shared.Constants;
using eCommerce.Backend.Services;
using AutoMapper;

var builder = WebApplication.CreateBuilder(args);

ConfigurationManager configuration = builder.Configuration;
IWebHostEnvironment environment = builder.Environment;

builder.Services.AddDbContext<ApplicationDbContext>(option=>
    option.UseSqlServer(builder.Configuration.GetConnectionString(SystemConstants.MainConnectionString)));
builder.Services.AddTransient<IFileStorageService,FileStorageService>();

// Add services to the container.
builder.Services.AddHttpClient();
builder.Services.AddHttpContextAccessor();
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

if (string.IsNullOrWhiteSpace(environment.WebRootPath))
{
   environment.WebRootPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot");
}

if (environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
    app.UseMigrationsEndPoint();
}
else
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}
app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseCors("AllowOrigins");
app.UseRouting();

app.UseEndpoints(endpoints =>
        {
            endpoints.MapGet("/", async context =>
            {
                await context.Response.WriteAsync("Hello World!");
            });
        });

app.UseAuthorization();

app.MapControllers();

app.Run();

