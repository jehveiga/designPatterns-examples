namespace DesignPatterns.Examples.Application.Models;

public class PaymentMethodViewModel
{
    public PaymentMethodViewModel(string guidanceText, decimal? minimumValue, decimal? maximumValue)
    {
        GuidanceText = guidanceText;
        MinimumValue = minimumValue;
        MaximumValue = maximumValue;
    }

    public string GuidanceText { get; private set; }
    public decimal? MinimumValue { get; private set; }
    public decimal? MaximumValue { get; private set; }
}