namespace THFontEnd.Models
{
    public class PaymentRequestStep
    {
        public int Id { get; set; }
        public int RequestId { get; set; }
        public int StepOrder { get; set; }
        public string StepName { get; set; }
        public string StepAction { get; set; }
        public string Status { get; set; }
        public DateTime ApprovedAt { get; set; }
    }
}