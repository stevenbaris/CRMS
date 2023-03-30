using CustomersAPI.Data;
using CustomersAPI.Repository;
using CustomersAPI.Repository.MSSQL;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<CustomerDBContext>();

builder.Services.AddScoped<ICustomerDBRepository, CustomerDBRepo>();
builder.Services.AddScoped<ITransactionDBRepository, TransactionDBRepo>();
builder.Services.AddScoped<CustomerTransactionService>();







var app = builder.Build();

// Configure the HTTP request pipeline.
app.UseSwagger();

app.UseSwaggerUI();

app.UseAuthorization();

app.MapControllers();

app.Run();
