using System;
using System.Collections.Generic;

namespace ProductReviewManagement
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Product Review Mangement");
            AddToDataTable data = new AddToDataTable();
            data.AddToTable();

            List<ProductReviewModel> productReview = new List<ProductReviewModel>()
            {
                  new ProductReviewModel() { ProductId = 1, UserId = 1, Rating = 1, review = "very bad ", Islike = false },
                  new ProductReviewModel() { ProductId = 2, UserId = 2, Rating = 3, review = "good ", Islike = true },
                  new ProductReviewModel() { ProductId = 3, UserId = 3, Rating = 2, review = "average ", Islike = false },
                  new ProductReviewModel() { ProductId = 4, UserId = 4, Rating = 3, review = "good ", Islike = true },
                  new ProductReviewModel() { ProductId = 5, UserId = 5, Rating = 4, review = "very good ", Islike = true },
                  new ProductReviewModel() { ProductId = 6, UserId = 6, Rating = 5, review = "best ", Islike = true },
                  new ProductReviewModel() { ProductId = 7, UserId = 7, Rating = 2, review = "bad  ", Islike = false },
                  new ProductReviewModel() { ProductId = 8, UserId = 8, Rating = 3, review = "good ", Islike = true },
                  new ProductReviewModel() { ProductId = 9, UserId = 9, Rating = 4, review = "very good ", Islike = true },
                  new ProductReviewModel() { ProductId = 10, UserId = 10, Rating = 0, review = "worse ", Islike = false }



            };

            foreach(var list in productReview)
            {
                Console.WriteLine("ProductId -- " + list.ProductId + "\n UserId -- " + list.UserId + "\n Review " + list.review + "\n Rating -- " + list.Rating + "\n Islike " + list.Islike);
                Console.WriteLine("-------------------------------------------------------------------------");
                Console.WriteLine();
            }

            FunctionClass fun = new FunctionClass();
           // fun.TopRecords(productReview);

            fun.SelectRecords(productReview);

        }
    }


}
