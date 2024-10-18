namespace THFontEnd.Models
{
    public class PaymentRequestModel
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public decimal Amount { get; set; }
        public string Description { get; set; } = "";
        public string Status { get; set; } = "";
        public LifeCircleType LifeCircleType { get; set; }
        public DateTime? ProcessedDate { get; set; }
        public DateTime CreatedUtcDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string PaymentRequestCode { get; set; } = "";
        public string RequesterName { get; set; } = "";
        public ICollection<PaymentRequestStep> PaymentRequestSteps { get; set; } = new List<PaymentRequestStep>();
    }
}
