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
    }
}
