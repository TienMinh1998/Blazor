using THFontEnd.Models;

namespace THFontEnd.Services
{
    public interface ITaskApiClient
    {
        Task<PaymentRequestModel> GetRequestById(int Id);
        Task<List<PaymentRequestModel>> GetListByEmployeId(int emID);

        Task<bool> CreateNewPaymentRequest(PaymentRequest request);

        Task<bool> Approved(ApproveRequestModel request);

        Task<bool> RejectRequest(RejectRequest request);

        Task<LoginResultModel> Login(string userName, string password);

        Task<bool> AccountAsignment(int paymentRequestId);

        Task<List<int>> GetPaymentTypesByUserId(int userid);
    }
}
