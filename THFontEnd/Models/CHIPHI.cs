using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace THFontEnd.Models
{

    /// <summary>
    /// Chi thường xuyên hoặc không thường xuyên;
    /// </summary>

    public enum PaymentType
    {
        [Display(Name = "Refund tiền hóa đơn cho khách hàng.")]
        REFUND =1,
        [Display(Name = "Đền bù tổn thất cho khách hàng.")]
        DEN_BU_TON_THAT_KHACH_HANG =2 ,
        [Display(Name = "Chi phí doanh nghiệp.")]
        CHI_PHI_DOANH_NGHIEP,
        [Display(Name = "Chi trả công nợ.")]
        CONG_NO,
        [Display(Name = "Thanh toán ngoại tệ.")]
        THANH_TOAN_MUA_NGOAI_TE,
        [Display(Name = "Tạm ứng.")]
        TAM_UNG,
        [Display(Name = "Thanh toán cá nhân.")]
        THANH_TOAN_CA_NHAN,
        [Display(Name = "Chi lương.")]
        CHI_LUONG,
        [Display(Name = "Chi thưởng.")]
        CHI_THUONG,
        [Display(Name = "Chi tiền mặt.")]
        CHI_TIEN_MAT,
       
    }

    public enum LifeCircleType
    {
        [Display(Name = "Quy trình cấp 1")]
        LEVEL1 = 1, // cấp quy trình 1
        [Display(Name = "Quy trình cấp 2")]
        LEVEL2 = 2 ,// cấp quy trình 2
        [Display(Name = "Quy trình cấp 3")]
        LEVEL3 = 3 // cấp quy trình 3
    }
}
