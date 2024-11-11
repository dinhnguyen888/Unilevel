using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using SendGrid;


var builder = WebApplication.CreateBuilder(args);

// Configure DbContext with SQL Server
string connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(connectionString));

builder.Services.AddIdentity<IdentityUser, IdentityRole>()
    .AddEntityFrameworkStores<AppDbContext>()
    .AddDefaultTokenProviders();

var sendGridApiKey = builder.Configuration["SendGrid:ApiKey"];
builder.Services.AddSingleton<ISendGridClient>(new SendGridClient(sendGridApiKey));
builder.Services.AddScoped<EmailService>();
builder.Services.AddScoped<AuthService>();



builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


   
var app = builder.Build();

// Configure the HTTP request pipeline
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

using (var scope = app.Services.CreateScope())
{
    var dbContext = scope.ServiceProvider.GetRequiredService<AppDbContext>();
    if (dbContext.Database.CanConnect())
    {
        Console.WriteLine("Database connection OK.");
    }
    else
    {
        Console.WriteLine("Database connection failed.");
    }

}
    app.UseHttpsRedirection();

// Add Authentication and Authorization Middleware
app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();

        

// Configure Identity
//builder.Services.AddIdentity<Account, IdentityRole<int>>(options =>
//{
//    options.Password.RequireDigit = true;
//    options.Password.RequireLowercase = true;
//    options.Password.RequireUppercase = true;
//    options.Password.RequireNonAlphanumeric = false;
//    options.Password.RequiredLength = 6;
//})
//.AddEntityFrameworkStores<UniLevelDbContext>()
//.AddDefaultTokenProviders();

// Configure JWT Authentication
//builder.Services.AddAuthentication(options =>
//{
//    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
//    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
//}).AddJwtBearer(options =>
//{
//    options.TokenValidationParameters = new TokenValidationParameters
//    {
//        ValidateIssuer = true,
//        ValidateAudience = true,
//        ValidateLifetime = true,
//        ValidateIssuerSigningKey = true,
//        ValidIssuer = builder.Configuration["Jwt:Issuer"],
//        ValidAudience = builder.Configuration["Jwt:Issuer"],
//        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration["Jwt:Key"]))
//    };
//});

// Register AuthService for dependency injection
//builder.Services.AddScoped<AuthService>();



// Ensure database connection at startup
//using (var scope = app.Services.CreateScope())
//{
//    var dbContext = scope.ServiceProvider.GetRequiredService<UniLevelDbContext>();
//    if (dbContext.Database.CanConnect())
//    {
//        Console.WriteLine("Database connection OK.");
//    }
//    else
//    {
//        Console.WriteLine("Database connection failed.");
//    }
//}
