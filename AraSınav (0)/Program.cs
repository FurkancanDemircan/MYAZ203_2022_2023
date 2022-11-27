namespace MYAZ203.AraSınav__0_
{
    public class Program
    {
        public static void Main()
        {
            var productManager = new ProductManager();

            productManager.Add(new Product() { Id = 1, ProductName = "TV", Price = 15_000 });
            productManager.Add(new Product() { Id = 2, ProductName = "Phone", Price = 12_000 });
            productManager.Add(new Product() { Id = 3, ProductName = "Computer", Price = 17_000 });
            productManager.Add(new Product() { Id = 4, ProductName = "Computer", Price = 17_000 });
            productManager.Add(new Product() { Id = 5, ProductName = "Computer", Price = 17_000 });
            productManager.Add(new Product() { Id = 6, ProductName = "Computer", Price = 17_000 });

            Console.WriteLine(productManager);
            Console.ReadKey();
        }
    }
}
