using Application.Recipes;
using Application.Users;
using Domain.Foundation;
using Infrastructure.Foundation;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using System.Text;
using WebAPI.Security.Auths;
using WebAPI.Services.Recipe;
using WebAPI.Services.User;

var builder = WebApplication.CreateBuilder( args );

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IUserApiService, UserApiService>();
builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();

builder.Services.AddScoped<IRecipeApiService, RecipeApiService>();
builder.Services.AddScoped<IRecipeService, RecipeService>();
//builder.Services.AddScoped<IRecipeRepository, RecipeRepository>();

builder.Services.AddScoped<ITokenService, TokenService>();

builder.Services.AddDbContext<TLRecipesDbContext>( c => c.UseSqlServer( builder.Configuration.GetConnectionString( "DbConnection" ) ) );

// TODO ����� ������� � ����� ����������
builder.Services.AddAuthentication( options =>
{
    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
} )
.AddJwtBearer( options =>
{
    options.SaveToken = true;
    options.RequireHttpsMetadata = false;
    options.Audience = AuthOptions.AUDIENCE;
    options.TokenValidationParameters = new TokenValidationParameters()
    {
        ValidateIssuer = true,
        ValidateAudience = true,
        ValidAudience = AuthOptions.AUDIENCE,
        ValidIssuer = AuthOptions.ISSUER,
        IssuerSigningKey = new SymmetricSecurityKey( Encoding.UTF8.GetBytes( AuthOptions.KEY ) )
    };
} );
builder.Services.AddSwaggerGen( swagger =>
{
    swagger.SwaggerDoc( "v1", new OpenApiInfo
    {
        Version = "v1",
        Title = "JWT Token Authentication API",
        Description = "ASP.NET Core 5.0 Web API"
    } );
    swagger.AddSecurityDefinition( "Bearer", new OpenApiSecurityScheme()
    {
        Name = "Authorization",
        Type = SecuritySchemeType.ApiKey,
        Scheme = "Bearer",
        BearerFormat = "JWT",
        In = ParameterLocation.Header,
        Description = "JWT Authorization header using the Bearer scheme. \r\n\r\n Enter 'Bearer' [space] and then your token in the text input below.\r\n\r\nExample: \"Bearer 12345abcdef\"",
    } );
    swagger.AddSecurityRequirement( new OpenApiSecurityRequirement
    {
        {
            new OpenApiSecurityScheme
            {
                Reference = new OpenApiReference
                {
                    Type = ReferenceType.SecurityScheme,
                    Id = "Bearer"
                }
            },
            new string[] {}
        }
    } );
} );

var app = builder.Build();

// Configure the HTTP request pipeline.
if ( app.Environment.IsDevelopment() )
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthentication();
app.UseAuthorization();
app.MapControllers();
DefaultFilesOptions options = new DefaultFilesOptions();
options.DefaultFileNames.Clear(); 
options.DefaultFileNames.Add("index.html"); 
app.UseDefaultFiles(options); 
app.UseStaticFiles();

app.Run();
