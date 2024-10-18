
using Blazored.Toast.Services;
using System.Net;
using System.Net.Http.Json;
using THFontEnd.Models;

namespace THFontEnd.Services
{
    public class TaskApiClient : ITaskApiClient
    {
        private readonly HttpClient _httpClient;
        private readonly IToastService toastService;
        public TaskApiClient(HttpClient httpClient, IToastService toastService)
        {
            _httpClient = httpClient;
            this.toastService = toastService;
        }

        public async Task<bool> AccountAsignment(int paymentRequestId)
        {
            AccountAsignmentRequest request = new AccountAsignmentRequest(paymentRequestId);
            var result = await _httpClient.PutAsJsonAsync("/PaymentRequest/account-assignment", request);
            if (result.IsSuccessStatusCode)
            {
                return true;
            }
            return false;
        }

        public async Task<bool> Approved(ApproveRequestModel request)
        {
            var result = await _httpClient.PutAsJsonAsync("/PaymentRequest/approve", request);
            if (result.IsSuccessStatusCode)
            {
                return true;
            }
            return false;
        }

        public async Task<bool> CreateNewPaymentRequest(PaymentRequest request)
        {
            var result = await _httpClient.PostAsJsonAsync("/PaymentRequest", request);
            if (result.IsSuccessStatusCode)
            {
                return true;
            }
            if (result.StatusCode == HttpStatusCode.Forbidden)
            {
                toastService.ShowError("Bạn không có quyền tạo yêu cầu này");
                return false;
            }
            return false;
        }

        public async Task<PaymentRequestModel> GetRequestById(int Id)
        {
            var result = await _httpClient.GetFromJsonAsync<PaymentRequestModel>($"/PaymentRequest/{Id}");
            return result;
        }

        public async Task<List<PaymentRequestModel>> GetListByEmployeId(int emID)
        {
            var result = await _httpClient.GetFromJsonAsync<List<PaymentRequestModel>>($"/PaymentRequest/list/{emID}");
            return result;
        }

        public async Task<LoginResultModel> Login(string userName, string password)
        {
            LoginRequest request = new LoginRequest
            {
                Password = password
                ,
                UserName = userName
            };
            var response = await _httpClient.PostAsJsonAsync("/User", request);

            if (response.IsSuccessStatusCode)
            {
                var result = await response.Content.ReadFromJsonAsync<LoginResultModel>();
                return result;
            }
            else
            {
                // Xử lý lỗi hoặc throw exception
                throw new Exception("Error during request");
            }
        }

        public async Task<bool> RejectRequest(RejectRequest request)
        {
            var result = await _httpClient.PutAsJsonAsync("/PaymentRequest/reject", request);
            if (result.IsSuccessStatusCode)
            {
                return true;
            }
            return false;
        }

        public  async Task<List<int>> GetPaymentTypesByUserId(int userid)
        {
            var result = await _httpClient.GetFromJsonAsync<List<int>>($"/User/{userid}/paymenttype");
            return result;
        }
    }
}
