namespace RulerDraw.Models
{
    public class ErrorViewModel
    {
        public string? RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}
//File này thông báo lỗi khi có lỗi xảy ra trong quá trình xử lý yêu cầu của người dùng.
//Nó chứa thông tin về mã yêu cầu và có một thuộc tính để xác định xem mã yêu cầu có được hiển thị hay không.
//Khi có lỗi, thông tin này sẽ được sử dụng để hiển thị thông báo lỗi cho người dùng.
