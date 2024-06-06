using DataAPIContentNegotiationEx.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers().AddXmlSerializerFormatters();
builder.Services.AddDbContextPool<CompanyContext>(opt=>opt.UseSqlServer(builder.Configuration.GetConnectionString("scon")));
var app = builder.Build();

app.MapControllers();
app.Run();
