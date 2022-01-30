using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace ProductReviewManagement
{
    public class AddToDataTable
    {
        public void AddToTable()
        {

            //The DataTable class in C# ADO.NET is a database table representation and provides a collection of columns and rows
            //to store data in a grid form. 

            DataTable table = new DataTable();
            table.Columns.Add("ProductId");
            table.Columns.Add("UserId");
            table.Columns.Add("Review");
            table.Columns.Add("Rating");
            table.Columns.Add("Islike");

            table.Rows.Add("1", "1","average","3","True");
            table.Rows.Add("2", "3","good","3.5","True");
            table.Rows.Add("3", "12","Bad","1","False");
            table.Rows.Add("4", "4", "Worse", "0", "False");
            table.Rows.Add("5", "5", "very good", "4", "True");
            table.Rows.Add("6", "6", "Best", "5", "True");
            table.Rows.Add("7", "7", "avg", "2.7", "False");
            table.Rows.Add("8", "8", "good", "3.6", "True");
            table.Rows.Add("9", "9", "very good", "4.5", "True");
            table.Rows.Add("10", "3", "very bad", "0", "False");








            Display(table);

        }

        public void Display(DataTable table)
        {
            //LINQ (Language Integrated Query) is uniform query syntax in C# and VB.NET
            //to retrieve data from different sources and formats.
            //It is integrated in C# or VB, thereby eliminating the mismatch between programming languages and databases,
            //as well as providing a single querying interface for different types of data sources.


            foreach(DataRow dr in table.Rows)
            {
                string productId = dr.Field <string>("ProductId");
                string Usid = dr.Field<string>("UserId");
                string review = dr.Field<string>("Review");
                string rating = dr.Field<string>("Rating");
                string islike = dr.Field<string>("Islike");

                Console.WriteLine("Products are : ");

                Console.WriteLine("{0} {1} {2} {3} {4} ", productId, Usid, review, rating, islike);
            }

            //Query syntax starts with a From clause followed by a Range variable.
            //The From clause is structured like "From rangeVariableName in IEnumerablecollection".
            //In English, this means, from each object in the collection.
            //It is similar to a foreach loop: foreach(Student s in studentList).

            //After the From clause, you can use different Standard Query Operators to filter, group, join elements of the collection.
            //There are around 50 Standard Query Operators available in LINQ. 
            //here we use directly select as we donot have condition with it.

            //LINQ query syntax always ends with a Select or Group clause. The Select clause is used to shape the data.

           
          
        }
        
        
    }
}
