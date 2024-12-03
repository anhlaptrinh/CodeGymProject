namespace Condition
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhập một số từ 1 đến 7: ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out int day))
            {
                switch (day)
                {
                    case 1:
                        Console.WriteLine("Thứ Hai");
                        break;
                    case 2:
                        Console.WriteLine("Thứ Ba");
                        break;
                    case 3:
                        Console.WriteLine("Thứ Tư");
                        break;
                    case 4:
                        Console.WriteLine("Thứ Năm");
                        break;
                    case 5:
                        Console.WriteLine("Thứ Sáu");
                        break;
                    case 6:
                        Console.WriteLine("Thứ Bảy");
                        break;
                    case 7:
                        Console.WriteLine("Chủ Nhật");
                        break;
                    default:
                        Console.WriteLine("Lỗi: Số bạn nhập không hợp lệ. Vui lòng nhập từ 1 đến 7.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Lỗi: Vui lòng nhập một số nguyên hợp lệ.");
            }
        }
    }
}
