using System;

namespace ProductReviewManagement
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Product Review Mangement");
            AddToDataTable data = new AddToDataTable();
            data.AddToTable();
        }
    }


}
