
namespace Task_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product(15, "A");
            var anouProduct = product.CreateProduct();
            Console.WriteLine(anouProduct);

            string str = "Hello, World!";
            Console.WriteLine(str.CountWords());

            int x = 14;
            Console.WriteLine(x.IsEven());

            DateTime dt = new DateTime(2008, 5, 20);
            Console.WriteLine(dt.Age());

            string s = "hello";
            Console.WriteLine(s.Reversed());

        }
    }

}
