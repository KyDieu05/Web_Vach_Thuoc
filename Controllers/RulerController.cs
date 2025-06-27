//File logic cho nhập dữ liệu và vẽ thước kẻ:
using Microsoft.AspNetCore.Mvc;
using Ruler.Models;

namespace Ruler.Controllers
{
    public class RulerController : Controller
    {
        //Nhập dữ liệu cho thước kẻ:
        [HttpGet]
        public IActionResult Index()
        {
            return View(new RulerViewModel());
        }

        [HttpPost]
        public IActionResult Index(RulerViewModel input)
        {
            var marks = new List<(double pos, double height)>();
            DrawRuler(0, input.Length, input.height, marks);

            var model = new RulerViewModel
            {
                Length = input.Length,
                height = input.height,
                Marks = marks
            };
            return View(model);
        }

        // Vẽ thước kẻ theo dữ liệu nhập vào:
        private void DrawRuler(double left, double right, double height, List<(double, double)> result)
        {
            // Nếu độ cao là 0 hoặc khoảng cách không hợp lệ (vẽ hết rồi), kết thúc đệ quy
            if (height == 0 || left >= right) return;
            double mid = (left + right) / 2; // Tính vị trí giữa của đoạn thước kẻ
            DrawRuler(left, mid, height - 1, result); // Vẽ nửa bên trái
            result.Add((mid, height));// Thêm vạch đánh dấu tại vị trí giữa với cấp độ hiện tại
            DrawRuler(mid, right, height - 1, result); // Vẽ nửa bên phải
        }
    }
}
