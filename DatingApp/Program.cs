var builder = WebApplication.CreateBuilder(args);

var connectionString = builder.Configuration.GetConnectionString("Default");
if (string.IsNullOrWhiteSpace(connectionString))
{
    throw new InvalidOperationException(
        "The database connection string 'Default' is missing. Configure ConnectionStrings:Default.");
}

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddProblemDetails();
builder.Services.AddHealthChecks();

builder.Services.AddDbContext<DatingAppDbContext>(options =>
    options.UseSqlServer(connectionString));

builder.Services.AddScoped<IUsersRepo, UsersRepo>();
builder.Services.AddScoped<IAppUserService, AppUserServices>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseExceptionHandler();
app.UseHttpsRedirection();
app.MapHealthChecks("/health");
app.MapControllers();

app.Run();
