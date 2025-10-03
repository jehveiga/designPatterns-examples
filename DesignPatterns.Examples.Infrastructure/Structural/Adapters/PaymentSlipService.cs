using DesignPatterns.Examples.Application.Models;

namespace DesignPatterns.Examples.Infrastructure.Structural.Adapters;

internal class PaymentSlipService : IPaymentService
{
    private readonly IExternalPaymentSlipService _externalService;

    public PaymentSlipService(IExternalPaymentSlipService externalService)
    {
        _externalService = externalService;
    }

    public object Process(OrderInputModel model)
    {
        PaymentSlipServiceAdapter paymentSlipServiceAdapter = new(_externalService);
        _ = paymentSlipServiceAdapter.GeneratePaymentSlip(model);

        return "Dados do Boleto";
    }
}