using System.Collections.Generic;
using System.Diagnostics;

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
        }
    }
}
