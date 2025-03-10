using System;
using System.Collections.Generic;
using System.Linq;
namespace baitap4
{
    class Program
    {
        static List<Product> library = new List<Product>();

        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            while (true)
            {
                Console.WriteLine("\n========== QUẢN LÝ THƯ VIỆN ==========");
                Console.WriteLine("1. Thêm sách mới");
                Console.WriteLine("2. Hiển thị danh sách sách");
                Console.WriteLine("3. Tìm kiếm sách theo tiêu đề");
                Console.WriteLine("4. Lọc sách theo tác giả");
                Console.WriteLine("0. Thoát");
                Console.Write("Chọn chức năng: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        ThemSachMoi();
                        break;
                    case "2":
                        HienThiDanhSach();
                        break;
                    case "3":
                        TimKiemTheoTieuDe();
                        break;
                    case "4":
                        LocTheoTacGia();
                        break;
                    case "0":
                        Console.WriteLine("Thoát chương trình. Tạm biệt!");
                        return;
                    default:
                        Console.WriteLine("Lựa chọn không hợp lệ! Vui lòng nhập lại.");
                        break;
                }
            }
        }

        static void ThemSachMoi()
        {
            Product book = new Product();
            book.InputProduct();
            library.Add(book);
            Console.WriteLine("📚 Đã thêm sách mới vào thư viện!");
        }

        static void HienThiDanhSach()
        {
            if (library.Count == 0)
            {
                Console.WriteLine("📂 Thư viện trống!");
                return;
            }
            Console.WriteLine("\n📚 DANH SÁCH SÁCH TRONG THƯ VIỆN:");
            foreach (var book in library)
            {
                book.DisplayProduct();
            }
        }

        static void TimKiemTheoTieuDe()
        {
            Console.Write("🔍 Nhập tiêu đề sách cần tìm: ");
            string keyword = Console.ReadLine().ToLower();
            var foundBooks = library.Where(b => b.NameBook.ToLower().Contains(keyword)).ToList();

            if (foundBooks.Count == 0)
            {
                Console.WriteLine("❌ Không tìm thấy sách nào có tiêu đề này.");
                return;
            }

            Console.WriteLine("\n📚 KẾT QUẢ TÌM KIẾM:");
            foreach (var book in foundBooks)
            {
                book.DisplayProduct();
            }
        }

        static void LocTheoTacGia()
        {
            Console.Write("🔍 Nhập tên tác giả cần lọc: ");
            string author = Console.ReadLine().ToLower();
            var filteredBooks = library.Where(b => b.NameAuthor.ToLower() == author).ToList();

            if (filteredBooks.Count == 0)
            {
                Console.WriteLine("❌ Không tìm thấy sách nào của tác giả này.");
                return;
            }

            Console.WriteLine("\n📚 DANH SÁCH SÁCH CỦA TÁC GIẢ:");
            foreach (var book in filteredBooks)
            {
                book.DisplayProduct();
            }
        }
    }
}
