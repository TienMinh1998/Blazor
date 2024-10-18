using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.JSInterop;
using THFontEnd.Models;
using THFontEnd.Services;

namespace THFontEnd.Pages
{
    
    public partial class TodoList
    {
        [Inject] private HttpClient Http { get; set; }
       
        private AddPaymentRequest AddPaymentRequest { get; set; } = new AddPaymentRequest(); 

        [Inject] private ITaskApiClient TaskApiClient { get; set; }

        private PaymentRequestModel paymentModel;

        private List<PaymentRequestModel> list;

        protected override async Task OnInitializedAsync()
        {
            var userId = await JS.InvokeAsync<string>("localStorageHelper.getUserId");

            // Get by TaskID
          //  paymentModel = await TaskApiClient.GetById(1);
            // Get by ID
            list = await TaskApiClient.GetListByEmployeId(int.Parse(userId));
        }

        public void CreateNew(EditContext context)
        {
            var desc = AddPaymentRequest.Description;
            var amout = AddPaymentRequest.Amount;
            // call Apil;

        }
    }

    public class AddPaymentRequest
    {
        public decimal Amount { get; set; } = 0;
        public string Description { get; set; } = "";
    }
}
