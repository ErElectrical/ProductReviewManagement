using System;
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

        /// <summary>
        /// Method count the number of ProductId we have
        /// and how many Products are there in a single ProductId
        /// </summary>
        /// <param name="review"></param>
        public void RetriveCountOfRecords(List<ProductReviewModel> review)
        {
            var records = review.GroupBy(x => x.ProductId).Select(x => new { productId = x.Key, Count = x.Count() });
            Console.WriteLine("Fetch record for each ProductId");
            foreach (var ls in records)
            {
                Console.WriteLine(ls.productId + " ---- " + ls.Count);
                Console.WriteLine("---------------------------------");
            }
        }

        /// <summary>
        /// retrirve productId with their rating
        /// </summary>
        /// <param name="review"></param>
        public void RetriveProductIdAndReview(List<ProductReviewModel> review)
        {
            var records = from products in review
                          select products;
            Console.WriteLine("ProductId with their review is ");
            foreach(var ls in records)
            {
                Console.WriteLine(ls.ProductId + "--------" + ls.review);
                Console.WriteLine("-----------------------------");
            }
                          
        }
        /// <summary>
        /// Method skip top 5 records and display the below records
        /// </summary>
        /// <param name="review"></param>
        public void SkipTopRecords(List<ProductReviewModel> review)
        {
            //The Skip operator bypasses a specified number of contiguous rows from a sequence/table and returns the remaining table.
            //It can skip rows from the top or can be for a certain criteria,
            //in other words it can also skip rows depending on a certain criteria.
            //It works like NOT IN in SQL.

            var records = (from products in review
                           select products).Skip(5);
            Console.WriteLine("Records skipping top 5 records ");
            foreach (var ls in records)
            {
                Console.WriteLine("ProductId -- " + ls.ProductId + "\n UserId --" + ls.UserId + "\n Review " + ls.review + "\n rating " + ls.Rating + "\n Islike" + ls.Islike);
                Console.WriteLine("----------------------------------------------------");
            }


        }

        /// <summary>
        /// Method is responsible to deal with datatables
        /// It will give us Product description whose rating is avg or above avg
        /// </summary>
        /// <param name="tb"></param>
        public void retriveAverageRating(DataTable tb)
        {
            var records = from table in tb.AsEnumerable()
                          where table.Field<int>("Rating") >= 3
                          select table;
            Console.WriteLine("Records from Data table is ");
            foreach (var ls in records)
            {
                Console.WriteLine("ProductId -- " + ls.Field<string>("ProductId") + "\n UserId --" + ls.Field<string>("UserId") + "\n Review " + ls.Field<string>("review") + "\n rating " + ls.Field<string>("Rating") + "\n Islike" + ls.Field<string>("Islike"));
                Console.WriteLine("----------------------------------------------------");

            }
        }

        /// <summary>
        /// Method is responsible to deal with datatable
        /// it will retrive data having good review with it.
        /// </summary>
        /// <param name="table"></param>

        public void RetriveReviewGood(DataTable table)
        {
            var records = from tb in table.AsEnumerable()
                          where tb.Field<string>("Review") == "Good"
                          select tb;
            Console.WriteLine("retrive data having review Good ");
            foreach (var ls in records)
            {
                Console.WriteLine("ProductId -- " + ls.Field<string>("ProductId") + "\n UserId --" + ls.Field<string>("UserId") + "\n Review " + ls.Field<string>("review") + "\n rating " + ls.Field<string>("Rating") + "\n Islike" + ls.Field<string>("Islike"));
                Console.WriteLine("----------------------------------------------------");

            }

        }
        /// <summary>
        /// 
        /// Method deal with userid 10
        /// retrive data in descending order based on the rating given by the end user
        /// </summary>
        /// <param name="table"></param>
        public void RetriveDataForParticulrUser(DataTable table)
        {
            var records = from tb in table.AsEnumerable()
                          orderby tb.Field<string>("Rating") descending
                          where tb.Field<string>("UserId") == "10"
                          select tb;
            Console.WriteLine("retrive data For userId 10");
            foreach (var ls in records)
            {
                Console.WriteLine("ProductId -- " + ls.Field<string>("ProductId") + "\n UserId --" + ls.Field<string>("UserId") + "\n Review " + ls.Field<string>("review") + "\n rating " + ls.Field<string>("Rating") + "\n Islike" + ls.Field<string>("Islike"));
                Console.WriteLine("----------------------------------------------------");

            }

        }
    }
}
