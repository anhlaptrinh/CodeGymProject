namespace DemoListDictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("\nMenu:");
                Console.WriteLine("1. Thêm và hiển thị phần tử");
                Console.WriteLine("2. Tìm giá trị lớn nhất, nhỏ nhất");
                Console.WriteLine("3. Xóa phần tử");
                Console.WriteLine("4. Sắp xếp danh sách");
                Console.WriteLine("5. Đếm số lần xuất hiện của từ");
                Console.WriteLine("6. Quản lý danh bạ");
                Console.WriteLine("7. Xếp hạng sinh viên");
                Console.WriteLine("8. Thống kê danh sách sản phẩm");
                Console.WriteLine("9. Thoát");
                Console.Write("Chọn chức năng: ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        AddAndDisplayElements();
                        break;
                    case 2:
                        FindMaxMin();
                        break;
                    case 3:
                        RemoveElement();
                        break;
                    case 4:
                        SortList();
                        break;
                    case 5:
                        CountWordOccurrences();
                        break;
                    case 6:
                        ManageContacts();
                        break;
                    case 7:
                        RankStudents();
                        break;
                    case 8:
                        ProductStatistics();
                        break;
                    case 9:
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Lựa chọn không hợp lệ.");
                        break;
                }
            }
        }

        static void AddAndDisplayElements()
        {
            List<int> numbers = new List<int>();
            Console.WriteLine("Nhập các số nguyên, nhập 'end' để kết thúc:");
            while (true)
            {
                string input = Console.ReadLine();
                if (input.ToLower() == "end") break;
                numbers.Add(int.Parse(input));
            }
            Console.WriteLine("Danh sách các số đã nhập: " + string.Join(", ", numbers));
        }

        static void FindMaxMin()
        {
            Console.WriteLine("Nhập các số nguyên (cách nhau bởi dấu cách):");
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            Console.WriteLine($"Số lớn nhất: {numbers.Max()}, Số nhỏ nhất: {numbers.Min()}");
        }

        static void RemoveElement()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8; // Đảm bảo hiển thị tiếng Việt

            Console.WriteLine("Nhập các số nguyên (cách nhau bởi dấu cách):");
            string input = Console.ReadLine();

            // Kiểm tra chuỗi nhập vào
            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Danh sách không được để trống. Vui lòng thử lại.");
                return;
            }

            List<int> numbers;
            try
            {
                numbers = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                               .Select(int.Parse)
                               .ToList();
            }
            catch (FormatException)
            {
                Console.WriteLine("Danh sách chứa ký tự không hợp lệ. Vui lòng nhập lại.");
                return;
            }

            Console.Write("Nhập số cần xóa: ");
            string numberInput = Console.ReadLine();
            if (!int.TryParse(numberInput, out int numberToRemove))
            {
                Console.WriteLine("Số cần xóa không hợp lệ. Vui lòng nhập một số nguyên.");
                return;
            }

            // Xóa số và hiển thị kết quả
            if (numbers.Remove(numberToRemove))
            {
                Console.WriteLine($"Đã xóa {numberToRemove}. Danh sách mới: " + string.Join(", ", numbers));
            }
            else
            {
                Console.WriteLine("Số không tồn tại trong danh sách.");
            }
        }

        static void SortList()
        {
            Console.WriteLine("Nhập các số nguyên (cách nhau bởi dấu cách):");
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            Console.WriteLine("Danh sách tăng dần: " + string.Join(", ", numbers.OrderBy(x => x)));
            Console.WriteLine("Danh sách giảm dần: " + string.Join(", ", numbers.OrderByDescending(x => x)));
        }

        static void CountWordOccurrences()
        {
            Console.WriteLine("Nhập đoạn văn bản:");
            string text = Console.ReadLine();
            var wordCounts = text.Split(' ', StringSplitOptions.RemoveEmptyEntries)
                                 .GroupBy(word => word.ToLower())
                                 .ToDictionary(g => g.Key, g => g.Count());

            foreach (var kvp in wordCounts)
            {
                Console.WriteLine($"Từ '{kvp.Key}': {kvp.Value} lần");
            }
        }

        static void ManageContacts()
        {
            Dictionary<string, string> contacts = new Dictionary<string, string>();
            bool manage = true;
            while (manage)
            {
                Console.WriteLine("\nDanh bạ:");
                Console.WriteLine("1. Thêm liên hệ");
                Console.WriteLine("2. Hiển thị danh bạ");
                Console.WriteLine("3. Tìm kiếm số điện thoại");
                Console.WriteLine("4. Quay lại");
                Console.Write("Chọn chức năng: ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Nhập tên: ");
                        string name = Console.ReadLine();
                        Console.Write("Nhập số điện thoại: ");
                        string phone = Console.ReadLine();
                        contacts[name] = phone;
                        break;
                    case 2:
                        foreach (var contact in contacts)
                        {
                            Console.WriteLine($"{contact.Key}: {contact.Value}");
                        }
                        break;
                    case 3:
                        Console.Write("Nhập tên cần tìm: ");
                        string searchName = Console.ReadLine();
                        if (contacts.TryGetValue(searchName, out string phoneNumber))
                        {
                            Console.WriteLine($"Số điện thoại của {searchName}: {phoneNumber}");
                        }
                        else
                        {
                            Console.WriteLine("Không tìm thấy liên hệ.");
                        }
                        break;
                    case 4:
                        manage = false;
                        break;
                    default:
                        Console.WriteLine("Lựa chọn không hợp lệ.");
                        break;
                }
            }
        }

        static void RankStudents()
        {
            Dictionary<string, int> students = new Dictionary<string, int>();
            Console.WriteLine("Nhập danh sách sinh viên (tên và điểm, cách nhau bởi dấu cách). Nhập 'end' để kết thúc:");
            while (true)
            {
                string input = Console.ReadLine();
                if (input.ToLower() == "end") break;
                string[] parts = input.Split();
                string name = parts[0];
                int score = int.Parse(parts[1]);
                students[name] = score;
            }

            var sortedStudents = students.OrderByDescending(s => s.Value);
            Console.WriteLine("Xếp hạng sinh viên:");
            foreach (var student in sortedStudents)
            {
                Console.WriteLine($"{student.Key}: {student.Value}");
            }
        }

        static void ProductStatistics()
        {
            Dictionary<string, decimal> products = new Dictionary<string, decimal>();
            Console.WriteLine("Nhập danh sách sản phẩm (tên và giá, cách nhau bởi dấu cách). Nhập 'end' để kết thúc:");
            while (true)
            {
                string input = Console.ReadLine();
                if (input.ToLower() == "end") break;
                string[] parts = input.Split();
                string productName = parts[0];
                decimal price = decimal.Parse(parts[1]);
                products[productName] = price;
            }

            var maxProduct = products.OrderByDescending(p => p.Value).First();
            var minProduct = products.OrderBy(p => p.Value).First();

            Console.WriteLine($"Sản phẩm có giá cao nhất: {maxProduct.Key} - {maxProduct.Value}");
            Console.WriteLine($"Sản phẩm có giá thấp nhất: {minProduct.Key} - {minProduct.Value}");
        }
    }
}
