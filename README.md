
# Asaas SDK for .NET

<p align="start">
<img src="https://img.shields.io/badge/Platform-.NET-lightgrey.svg" style="max-height: 300px;">
</p>

The **Asaas SDK for .NET** enables .NET developers to easily work with [Asaas](https://www.asaas.com) services.

This is a **unficial** SDK, feel free to contribute or report any issues ou improvements :)

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
