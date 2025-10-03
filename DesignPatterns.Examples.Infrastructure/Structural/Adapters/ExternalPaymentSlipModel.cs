namespace DesignPatterns.Examples.Infrastructure.Structural.Adapters;

public class ExternalPaymentSlipModel
{
    public required string bar_code { get; set; }
    public required string number { get; set; }
    public DateTime exp_date { get; set; }
    public DateTime proc_date { get; set; }
    public decimal doc_amount { get; set; }
    public required string payer_name { get; set; }
    public required string payer_doc { get; set; }
    public required string payer_addr { get; set; }
    public required string receiver_name { get; set; }
    public required string receiver_doc { get; set; }
    public required string receiver_addr { get; set; }
}