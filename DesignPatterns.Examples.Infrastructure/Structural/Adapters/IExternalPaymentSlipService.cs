using DesignPatterns.Examples.Application.Models;

namespace DesignPatterns.Examples.Infrastructure.Structural.Adapters;

public interface IExternalPaymentSlipService
{
    ExternalPaymentSlipModel GeneratePaymentSlip(OrderInputModel model);
}