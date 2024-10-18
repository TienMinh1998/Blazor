using System.ComponentModel.DataAnnotations;

namespace THFontEnd.Models
{
	public class LoginModelRequest
	{
		[Required(ErrorMessage = "Không được để trống tên tài khoản")]
		public string UserName { get; set; }
		[Required(ErrorMessage = "Không được để trống mật khẩu")]
		public string Passwork { get; set; }
    }
}
