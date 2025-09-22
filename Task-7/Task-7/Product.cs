namespace Task_7
{
    public class Product
    {
        public int Price { get; set; }
        public string Name { get; set; }
        public Product(int price, string name)
        {
            Price = price;
            Name = name;
        }
        public object CreateProduct()
        {
            return new
            {
                price = Price,
                name = Name
            };
        }
    }

}
