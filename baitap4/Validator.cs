using System;

namespace baitap4
{
    class Validator
    {
        public static string ValidateString(string input, string fieldName)
        {
            while (string.IsNullOrWhiteSpace(input))
            {
                Console.Write($"{fieldName} không được để trống, vui lòng nhập lại: ");
                input = Console.ReadLine();
            }
            return input;
        }

        public static string KiemTraNameBook(string input)
        {
            return ValidateString(input, "Tên sách");
        }

        public static string KiemTraNameAuthor(string input)
        {
            return ValidateString(input, "Tên tác giả");
        }

        public static int KiemTraDay(string input, int month, int year)
        {
            int day;
            while (!int.TryParse(input, out day) || !IsValidDay(day, month, year))
            {
                Console.Write("Ngày nhập sách không hợp lệ, vui lòng nhập lại: ");
                input = Console.ReadLine();
            }
            return day;
        }

        public static int KiemTraMonth(string input)
        {
            int month;
            while (!int.TryParse(input, out month) || month < 1 || month > 12)
            {
                Console.Write("Tháng nhập sách phải từ 1 đến 12, vui lòng nhập lại: ");
                input = Console.ReadLine();
            }
            return month;
        }

        public static int KiemTraYear(string input)
        {
            int year;
            while (!int.TryParse(input, out year) || year <= 0 )
            {
                Console.Write("Năm nhập sách phải là số dương, vui lòng nhập lại: ");
                input = Console.ReadLine();
            }
            return year;
        }

        private static bool IsValidDay(int day, int month, int year)
        {
            int[] daysInMonth = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

            if (month == 2 && IsLeapYear(year))
                return day >= 1 && day <= 29;

            return day >= 1 && day <= daysInMonth[month - 1];
        }

        private static bool IsLeapYear(int year)
        {
            return (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);
        }
    }
}
