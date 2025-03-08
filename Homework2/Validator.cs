using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2
{
    internal class Validator
    {
        public static string validateString(string input, string fieldName)
        {
            while (string.IsNullOrWhiteSpace(input))
            {
                Console.Write($"{fieldName} khong duoc de trong, vui long nhap lai: ");
                input = Console.ReadLine();
            }
            return input;
        }

        public static int KiemTraId(string input)
        {
            input = validateString(input, "Id");
            while (!int.TryParse(input, out int result) || result <= 0)
            {
                Console.Write("Id phai la so duong, vui long nhap lai: ");
                input = Console.ReadLine();
            }
            return int.Parse(input);
        }

        public static string KiemTraName(string input)
        {
            return validateString(input, "Ten san pham");
        }

        public static int KiemTraPrice(string input)
        {
            input = validateString(input, "Gia san pham");
            while (!int.TryParse(input, out int result) || result < 0)
            {
                Console.WriteLine("Gia san pham phai lon hon 0, vui long nhap lai: ");
                input = Console.ReadLine();
            }
            return int.Parse(input);
        }
    }
}
