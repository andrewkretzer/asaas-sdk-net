
# Asaas SDK for .NET

<p align="start">
<img src="https://img.shields.io/badge/Platform-.NET-lightgrey.svg" style="max-height: 300px;">
</p>

The **Asaas SDK for .NET** enables .NET developers to easily work with [Asaas](https://www.asaas.com) services.

This is a **unofficial** SDK, feel free to contribute or report any issues :)

## Documentation

To make any requests, you must generate your Access Token in the Asaas environment you want to use.
During the testing period we recommend using the [Sandbox](https://sandbox.asaas.com) environment provided by Asaas.
For more information, access the authentication section of the [Asaas documentation](https://asaasv3.docs.apiary.io/#introduction/autenticacao)

### Example

```csharp
ApiSettings apiSettings = new ApiSettings("YOUR_ACCESS_TOKEN", AsaasEnvironment.SANDBOX);

AsaasApi asaasApi = new AsaasApi(apiSettings);

ResponseObject<Customer> createdCustomerResponse = await asaasApi.Customer.Create(new CreateCustomerRequest
{
    Name = "João da Silva",
    CpfCnpj = "01020558075"
});

if (createdCustomerResponse.WasSucessfull())
{
    Customer customer = createdCustomerResponse.Data;

    ResponseObject<Payment> paymentResponse = await asaasApi.Payment.Create(new CreatePaymentRequest()
    {
        CustomerId = customer.Id,
        BillingType = BillingType.BOLETO,
        Value = 32.55M,
        DueDate = DateTime.Parse("12/12/2020")
    });
}
```

### ASP.NET 

To use the Asaas SDK in your ASP.NET application, follow the steps below

1. Modify the `appsettings.json` file to include Asaas settings:

```json
"ASAAS": {
    "AccessToken": "$aact_ssssssssssssssssssssss", // Replace with your AccessToken
    "BaseUrl": "https://sandbox.asaas.com" // Base URL of the Asaas environment (can be sandbox or production) --> Production: https://asaas.com
}
```

2. Add the Asaas service in your service configuration method:

```csharp

var builder = WebApplication.CreateBuilder(args);
// Add Assass Service
builder.Services.AddAsaas(builder.Configuration);

var app = builder.Build();

app.MapGet("/pay", async ([FromServices] IAsaasService asaasService) =>
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

app.Run();
```

## Installation

### [NuGet](https://www.nuget.org/packages/Asaas.SDK/)

To install this library via NuGet console, use:
```
Install-Package Asaas.SDK
```

## Contributors
 * Andrew Kretzer [Github](https://github.com/andrewkretzer)
 * Douglas Giovanella [Github](https://github.com/DouglasGiovanella)

## License

This project is available under the MIT license. See the LICENSE file for more info.

:)
