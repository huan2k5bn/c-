using System;   

namespace baitap4
{
    class Product
    {
        public string NameBook { get; set; }
        public string NameAuthor { get; set; }
        public int Day { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }

        public void InputProduct()
        {
            Console.Write("Nhập tên sách: ");
            NameBook = Validator.KiemTraNameBook(Console.ReadLine());

            Console.Write("Nhập tên tác giả: ");
            NameAuthor = Validator.KiemTraNameAuthor(Console.ReadLine());

            Console.Write("Nhập tháng thêm sách: ");
            Month = Validator.KiemTraMonth(Console.ReadLine());

            Console.Write("Nhập năm thêm sách: ");
            Year = Validator.KiemTraYear(Console.ReadLine());

            Console.Write("Nhập ngày thêm sách: ");
            Day = Validator.KiemTraDay(Console.ReadLine(), Month, Year);
        }

        public void DisplayProduct()
        {
            Console.WriteLine($"📖 Tiêu đề: {NameBook} | ✍️ Tác giả: {NameAuthor} | 📅 Ngày nhập: {Day}/{Month}/{Year}");
        }
    }
}
