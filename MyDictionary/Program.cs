using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductDictionary<string> Product = new ProductDictionary<string>();
            Product.Add("Elma");
            Console.WriteLine("Liste Eleman Sayıları");
            Console.WriteLine();
            Console.WriteLine("Liste Eleman Sayısı:" + Product.Length);

            Product.Add("Kayısı");
            Product.Add("Armut");
            Console.WriteLine("Liste Eleman Sayısı:" + Product.Length);

            Console.WriteLine("--------");
            Console.WriteLine("Ürün İçeriği");
            foreach (var product in Product.Items)
            {
                Console.WriteLine(product);
            }
        }
    }
}
