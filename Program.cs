using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Metrics;

namespace LINQSession2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            //Get top 3 most expensive products 
            //var result = Source.ProductList.OrderByDescending(p => p.UnitPrice).Take(3);

            //foreach (var p in result)
            //{
            //    Console.WriteLine(p);
            //}

            #endregion

            #region Q2
            //show page 2 of products, with page size = 5 

            //int pageNumber = 2;
            //int pageSize = 5;

            //var result = Source.ProductList.Skip((pageNumber - 1) * pageSize).Take(pageSize);

            //foreach (var p in result)
            //{
            //    Console.WriteLine(p);
            //}
            #endregion

            #region Q3
            //Take products from the list as long as Their UnitPrice is less than $25(list is ordered by price).

            //var result = Source.ProductList.OrderBy(p => p.UnitPrice).TakeWhile(p => p.UnitPrice < 25);

            //foreach (var p in result)
            //{
            //    Console.WriteLine(p);
            //}
            #endregion

            #region Q4
            //Check if ALL products in the "Seafood" category are in stock 

            //var result = Source.ProductList.Where(p => p.Category == "Seafood").All(p => p.UnitsInStock > 0);

            //Console.WriteLine($"are all products in the \"Seafood\" category are in stock: {result}");
            #endregion

            #region Q5
            // Check if the ID list contains 9 int[] ids = { 3, 9, 13, 18 };

            //int[] ids = { 3, 9, 13, 18 };

            //bool result = ids.Contains(9);
            //Console.WriteLine(result);
            #endregion

            #region Q6
            // Group all products by Category and print each group with its product count.

            //var result = Source.ProductList.GroupBy(p => p.Category);

            //foreach (var pgroup in result)
            //{
            //    Console.WriteLine($"Category: {pgroup.Key} has {pgroup.Count()} products");
            //}
            #endregion

            #region Q7
            //Group products by Category and project only product names per group

            //var result = Source.ProductList.GroupBy(p => p.Category)
            //                                .Select(g => new
            //                                {
            //                                    Category = g.Key,
            //                                    Products = g.Select(p => p.ProductName)
            //                                });

            //foreach (var pgroup in result)
            //{
            //    Console.WriteLine($"Category: {pgroup.Category}");

            //    foreach (var pname in pgroup.Products)
            //    {
            //        Console.WriteLine($"{pname}");
            //    }
            //    Console.WriteLine("--------------");
            //}
            #endregion

            #region Q8
            //Find all categories that have MORE THAN 3 products 

            //var result = Source.ProductList.GroupBy(p => p.Category).Where(g => g.Count() > 3).Select(g => g.Key);

            //foreach (var c in result)
            //{
            //    Console.WriteLine(c);
            //}
            #endregion

            #region Q9
            //Using QUERY SYNTAX, group customers by Country, and for each group select { Country, Count, TotalOrderValue }. 

            //var result = from c in Source.CustomerList
            //             group c by c.Country into g
            //             select new
            //             {
            //                 Country = g.Key,
            //                 Count = g.Count(),
            //                 TotalOrderValue = g.SelectMany(c => c.Orders).Sum(o => o.Total)
            //             };

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
        }
    }
}
