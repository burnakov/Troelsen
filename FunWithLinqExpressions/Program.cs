using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithLinqExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**** Fun with query expressions ****");
            ProductInfo[] products = new[]
            {
                new ProductInfo { Name = "Vapor art", Description = "Best tobacco liquid", NumberInStock = 10 },
                new ProductInfo { Name = "Jam monster", Description = "Liquids with jam flavor", NumberInStock = 23 },
                new ProductInfo { Name = "Siren 2", Description = "Digiflavor mtl atomizer", NumberInStock = 100 },
                new ProductInfo { Name = "Cotton bacon", Description = "Vapor cotton made in USA", NumberInStock = 15 },
                new ProductInfo { Name = "Drag", Description = "18650 box mod", NumberInStock = 2 },
                new ProductInfo { Name = "Pulse", Description = "Tony B bf box mod", NumberInStock = 65 }
            };
            SelectEveryThing(products);
            ListProductsNames(products);
            GetOverStockItems(products);
            GetNamesAndDescriptions(products);
            Array objs = GetProjectedSubset(products);
            foreach (var item in objs)
                Console.WriteLine(item.ToString());
            Console.WriteLine();
            GetCountFromQuery(products);
            ReverseEverything(products);
            AlphabetizeProductNames(products);

            List<string> cars1 = new List<string> { "BMW", "VW", "Mercedes", "Hyundai" };
            List<string> cars2 = new List<string> { "Lada", "BMW", "VW", "Ford" };
            DisplayExcept(cars1, cars2);
            DisplayIntersection(cars1, cars2);
            DisplayUnion(cars1, cars2);
            DisplayConcat(cars1, cars2);
            DisplayConcatWithoutDups(cars1, cars2);
            AggregateOps();

            Console.ReadLine();
        }

        private static void AggregateOps()
        {
            double[] temperature = { 2.5, -5.3, -15.8, -30, -18.7, -3.1, 0 };
            Console.WriteLine("Max temperature: {0}", (from t in temperature select t).Max());
            Console.WriteLine("Min temperature: {0}", (from t in temperature select t).Min());
            Console.WriteLine("Sum temperature: {0}", (from t in temperature select t).Sum());
            Console.WriteLine("Average temperature: {0}", (from t in temperature select t).Average());
            Console.WriteLine();
        }

        private static void DisplayConcatWithoutDups(List<string> cars1, List<string> cars2)
        {
            Console.WriteLine("Delete duplicates from concat subset:");
            var concat = (from c in cars1 select c).Concat(from c in cars2 select c);
            foreach (var item in concat.Distinct())
                Console.WriteLine(item.ToString());
            Console.WriteLine();
        }

        private static void DisplayConcat(List<string> cars1, List<string> cars2)
        {
            Console.WriteLine("All items in both cars1 and cars2 with duplicates:");
            var concat = (from c in cars1 select c).Concat(from c in cars2 select c);
            foreach (var item in concat)
                Console.WriteLine(item.ToString());
            Console.WriteLine();
        }

        private static void DisplayUnion(List<string> cars1, List<string> cars2)
        {
            Console.WriteLine("All items in cars1 and cars2 without duplicates:");
            var all = (from c in cars1 select c).Union(from c in cars2 select c);
            foreach (var item in all)
                Console.WriteLine(item.ToString());
            Console.WriteLine();
        }

        private static void DisplayIntersection(List<string> cars1, List<string> cars2)
        {
            Console.WriteLine("Exist in both cars1 and cars2:");
            var inter = (from c in cars1 select c).Intersect(from c in cars2 select c);
            foreach (var item in inter)
                Console.WriteLine(item.ToString());
            Console.WriteLine();
        }

        private static void DisplayExcept(List<string> cars1, List<string> cars2)
        {

            var diff = (from c in cars1 select c).Except(from c in cars2 select c);
            Console.WriteLine("Exist only in cars1:");
            foreach (var item in diff)
                Console.WriteLine(item);
            Console.WriteLine();
        }

        private static void AlphabetizeProductNames(ProductInfo[] products)
        {
            var names = from p in products orderby p.Name descending select p.Name;
            foreach (var item in names)
                Console.WriteLine(item.ToString());
            Console.WriteLine();
        }

        private static void ReverseEverything(ProductInfo[] products)
        {
            Console.WriteLine("All Products in reverse:");
            var allItems = from p in products select p;
            foreach (var item in allItems.Reverse())
                Console.WriteLine(item.ToString());
            Console.WriteLine();
        }

        private static void GetCountFromQuery(ProductInfo[] products)
        {
            int longNames = (from p in products where p.Name.Length > 6 select p).Count();
            Console.WriteLine("There are {0} items with long names.", longNames);
            Console.WriteLine();
        }

        private static Array GetProjectedSubset(ProductInfo[] products)
        {
            var nameDesc = from p in products select new { p.Name, p.Description };
            return nameDesc.ToArray();
        }

        private static void GetNamesAndDescriptions(ProductInfo[] products)
        {
            var nameDesc = from p in products select new { p.Name, p.Description };
            foreach (var item in nameDesc)
                Console.WriteLine(item.ToString());
            Console.WriteLine();
        }

        private static void GetOverStockItems(ProductInfo[] products)
        {
            Console.WriteLine("Here is over stock items:");
            var overStock = from p in products where p.NumberInStock > 25 select p;
            foreach (var item in overStock)
                Console.WriteLine(item.ToString());
            Console.WriteLine();
        }

        private static void ListProductsNames(ProductInfo[] products)
        {
            var names = from n in products select n.Name;
            foreach (var name in names)
                Console.WriteLine(name);
            Console.WriteLine();
        }

        private static void SelectEveryThing(ProductInfo[] products)
        {
            var allItems = from p in products select p;
            foreach (var item in allItems)
                Console.WriteLine(item);
            Console.WriteLine();
        }
    }
}
