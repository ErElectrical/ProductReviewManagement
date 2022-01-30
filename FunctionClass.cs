﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;


namespace ProductReviewManagement
{
    public class FunctionClass
    {
        public readonly DataTable table = new DataTable();

        /// <summary>
        /// Function Fetch Top 3 records from the source
        /// </summary>
        /// <param name="review"></param>
        public void TopRecords(List<ProductReviewModel> review)
        {
            var records = (from Products in review
                           orderby Products.Rating descending
                           select Products).Take(3);
            Console.WriteLine("Fetch Top 3 records Having Highest Rating");
            foreach(var ls in records)
            {
                Console.WriteLine("ProductId -- " + ls.ProductId + "\n UserId --" + ls.UserId + "\n Review " + ls.review + "\n rating " + ls.Rating + "\n Islike" + ls.Islike);
                Console.WriteLine("----------------------------------------------------");
            }
        }
        /// <summary>
        /// method fetch highest rating records based on given ProductId
        /// </summary>
        /// <param name="review"></param>
        public void SelectRecords(List<ProductReviewModel> review)
        {
            var records = from products in review
                          where (products.ProductId == 1 || products.ProductId == 4 || products.ProductId == 9) && products.Rating >= 3
                          select products;
            Console.WriteLine("Fetch record for selected ProductId");
            foreach(var ls in records)
            {
                Console.WriteLine("ProductId -- " + ls.ProductId + "\n UserId --" + ls.UserId + "\n Review " + ls.review + "\n rating " + ls.Rating + "\n Islike" + ls.Islike);
                Console.WriteLine("----------------------------------------------------");
            }
        }
    }
}
