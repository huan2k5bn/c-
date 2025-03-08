namespace Homework2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product();
            product.inputProduct();

            Console.WriteLine("\nThong tin san pham:");
            Console.WriteLine($"Id: {product.Id}");
            Console.WriteLine($"Ten san pham: {product.ProductName}");
            Console.WriteLine($"Gia: {product.Price}");
        }
    }
}
