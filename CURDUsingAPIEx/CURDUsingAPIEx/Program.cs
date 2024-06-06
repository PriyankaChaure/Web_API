using CURDUsingAPIEx.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers().AddNewtonsoftJson();
builder.Services.AddDbContext<CompanyContext>(opt => opt.UseSqlServer(builder.Configuration.GetConnectionString("scon")));
builder.Services.AddEndpointsApiExplorer();
var xmlfile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
var xmlpath = Path.Combine(AppContext.BaseDirectory, xmlfile);

builder.Services.AddSwaggerGen(
    c => {
        c.SwaggerDoc("v1", new OpenApiInfo
        {
            Title = "DEMO CURD API",
            Description = "Demo API for CURD Operations, using JQuery Client!",
            Contact = new OpenApiContact()
            {
                Name = "Suresh",
                Email ="Suresh@gmail.com",
                Url=new Uri("https://www.ritechpune.com")
            }
        });
        c.IncludeXmlComments(xmlpath);
     }
    ).AddSwaggerGenNewtonsoftSupport();

builder.Services.AddCors(
     opt => {
         opt.AddDefaultPolicy(
              p => {
                  p.AllowAnyOrigin();
                  p.AllowAnyMethod();
                  p.AllowAnyHeader();
              }
             );
      }
    );
var app = builder.Build();
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseCors();
app.MapControllers();
app.Run();
