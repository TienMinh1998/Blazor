using System.ComponentModel.DataAnnotations;

namespace THFontEnd.Models
{
    public class PaymentRequest
    {
        [Required(ErrorMessage ="Không được để trống mô tả")]
        public string Description { get; set; } = "";

        [Required(ErrorMessage = "Không được để trống số tiền")]
        [Range(20000, 200000, ErrorMessage = "Số tiền phải nằm trong khoảng từ 20,000 đến 200,000")]
        public decimal Amount { get; set; } = 0;
        [Required(ErrorMessage = "Vui lòng chọn loại thanh toán")]
        public PaymentType paymentTypeId { get; set; }

        public int RequesterId { get; set; } = 3; // Đang test, thực tế làm khác
    }
}
