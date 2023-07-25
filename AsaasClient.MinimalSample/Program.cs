using AsaasClient;
using AsaasClient.Core.Response;
using AsaasClient.Models.Common.Enums;
using AsaasClient.Models.Customer;
using AsaasClient.Models.Payment;
using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


// Add services to the container.
builder.Services.AddAsaas(builder.Configuration);

var app = builder.Build();
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
// Configure the HTTP request pipeline.
app.MapGet("/pagar", async ([FromServices] IAsaasService asaasService) =>
{

    ResponseObject<Customer> customerResponse = await asaasService.Customer.Find("cus_13bFHumeyglN");

    if (customerResponse.WasSucessfull())
    {
        Customer customer = customerResponse.Data;

        ResponseObject<Payment> paymentResponse = await asaasService.Payment.Create(new CreatePaymentRequest()
        {
            CustomerId = customer.Id,
            BillingType = BillingType.BOLETO,
            Value = 32.55M,
            DueDate = DateTime.Parse("12/12/2020")
        });

        return Results.Ok(paymentResponse);
    }

    return Results.BadRequest(customerResponse);

})
    .WithName("pagar")
    .WithOpenApi(); ;

app.Run();
