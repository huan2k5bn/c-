using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2
{
    class Product
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public int Price { get; set; }

        public void inputProduct()
        {
            Console.Write("Nhap id san pham: ");
            Id = Validator.KiemTraId(Console.ReadLine());

            Console.Write("Nhap ten san pham: ");
            ProductName = Validator.KiemTraName(Console.ReadLine());

            Console.Write("Nhap gia san pham: ");
            Price = Validator.KiemTraPrice(Console.ReadLine());
        }
    }
}
