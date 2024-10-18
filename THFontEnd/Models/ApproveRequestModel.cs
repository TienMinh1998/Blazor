namespace THFontEnd.Models
{
    public class ApproveRequestModel
    {
        public int RequestId { get; set; }
        public int UserId { get; set; }
        public string NoteForApproved { get; set; }
    }
}
