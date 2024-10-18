namespace THFontEnd.Models
{
    public class AccountAsignmentRequest
    {
        /// <summary>
        /// Id muốn định khoản
        /// </summary>
        public int PaymentRequestId { get; set; }

        public AccountAsignmentRequest(int paymentRqId)
        {
            PaymentRequestId = paymentRqId; 
        }
    }
}
