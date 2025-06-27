namespace Ruler.Models
{
    public class RulerViewModel
    {
        public double Length { get; set; }
        public double height { get; set; }
        public List<(double pos, double level)> Marks { get; set; } = new();
    }
}
// File này định nghĩa một lớp RulerViewModel để chứa dữ liệu cần thiết cho việc vẽ thước kẻ.