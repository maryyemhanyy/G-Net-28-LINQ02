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

            #region Q10
            //Calculate the total number of units in stock across all products 

            //var result = Source.ProductList.Sum(p => p.UnitsInStock);

            //Console.WriteLine(result);
            #endregion

            #region Q11
            //Find the CHEAPEST and MOST EXPENSIVE product prices 

            //var cheapest = Source.ProductList.Min(p => p.UnitPrice);
            //var expensive = Source.ProductList.Max(p => p.UnitPrice);

            //Console.WriteLine($"CHEAPEST: {cheapest}");
            //Console.WriteLine($"MOST EXPENSIVE: {expensive}");
            #endregion

            #region Q12
            //Get a distinct list of all product categories 

            //var result = Source.ProductList.Select(p => p.Category).Distinct();

            //foreach (var p in result)
            //{
            //    Console.WriteLine(p);
            //}
            #endregion

            #region Q13
            /*find product IDs that are in setA but NOT in setB 
              int[] setA = { 1, 3, 5, 7, 9, 11, 13 };      
              int[] setB = { 3, 6, 9, 12, 15, 13 }; */

            //int[] setA = { 1, 3, 5, 7, 9, 11, 13 };
            //int[] setB = { 3, 6, 9, 12, 15, 13 };

            //var result = setA.Except(setB);

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Q14
            /*Find countries that  appear in list1 but NOT in list2 (case-insensitive). 
              string[] list1 = { "Germany", "France", "UK", "Spain" }; 
              string[] list2 = { "france", "SPAIN", "Italy" }; */

            //string[] list1 = { "Germany", "France", "UK", "Spain" };
            //string[] list2 = { "france", "SPAIN", "Italy" };

            //var result = list1.Except(list2, StringComparer.OrdinalIgnoreCase);

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Q15
            //Build a Dictionary<int, Product> keyed by ProductID. Then retrieve and print the product with ID = 18.

            //var result = Source.ProductList.ToDictionary(p => p.ProductID);

            //var product = result[18];

            //Console.WriteLine(product);
            #endregion

            #region Q16
            //Get the first product whose price is greater than $50.

            //var result = Source.ProductList.FirstOrDefault(p => p.UnitPrice > 50);

            //Console.WriteLine(result);
            #endregion
        }
    }
}
