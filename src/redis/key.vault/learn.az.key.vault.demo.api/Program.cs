using Microsoft.Azure.KeyVault;
using Microsoft.Azure.Services.AppAuthentication;
using Microsoft.Extensions.Configuration.AzureKeyVault;

var builder = WebApplication.CreateBuilder(args);

//
builder.Host.ConfigureAppConfiguration((context, config) => {
    var settings = config.Build();
    var keyVaultURL = settings["KeyVaultConfiguration:KeyVaultURL"];
    var keyVaultClientId = settings["KeyVaultConfiguration:ClientId"];
    var keyVaultClientSecret = settings["KeyVaultConfiguration:ClientSecret"];

    //var keyVaultClient = new KeyVaultClient(
    //                new KeyVaultClient.AuthenticationCallback(
    //                    azureServiceTokenProvider.KeyVaultTokenCallback));

    config.AddAzureKeyVault(keyVaultURL, keyVaultClientId, keyVaultClientSecret, new DefaultKeyVaultSecretManager());
});

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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
