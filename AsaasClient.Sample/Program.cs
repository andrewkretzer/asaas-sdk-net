using AsaasClient;
using AsaasClient.Core;
using AsaasClient.Core.Response;
using AsaasClient.Models.Common.Enums;
using AsaasClient.Models.Customer;
using AsaasClient.Models.Payment;

ApiSettings apiSettings = new ApiSettings("YOUR_ACCESS_TOKEN", AsaasEnvironment.SANDBOX);

AsaasApi asaasApi = new AsaasApi(apiSettings);

ResponseObject<Customer> customerResponse = await asaasApi.Customer.Find("cus_13bFHumeyglN");

if (customerResponse.WasSucessfull())
{
    Customer customer = customerResponse.Data;

    ResponseObject<Payment> paymentResponse = await asaasApi.Payment.Create(new CreatePaymentRequest()
    {
        CustomerId = customer.Id,
        BillingType = BillingType.BOLETO,
        Value = 32.55M,
        DueDate = DateTime.Parse("12/12/2020")
    });
}