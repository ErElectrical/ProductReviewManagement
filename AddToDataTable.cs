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
            table.Columns.Add("Id");
            table.Columns.Add("ProductName");

            table.Rows.Add("1", "toffe");
            table.Rows.Add("2", "chai");
            table.Rows.Add("3", "Coffee");

            Display(table);

        }

        public void Display(DataTable table)
        {
            //LINQ (Language Integrated Query) is uniform query syntax in C# and VB.NET
            //to retrieve data from different sources and formats.
            //It is integrated in C# or VB, thereby eliminating the mismatch between programming languages and databases,
            //as well as providing a single querying interface for different types of data sources.


            var productNames = from products in table.AsEnumerable() select products.Field<string>("ProductName");

            //Query syntax starts with a From clause followed by a Range variable.
            //The From clause is structured like "From rangeVariableName in IEnumerablecollection".
            //In English, this means, from each object in the collection.
            //It is similar to a foreach loop: foreach(Student s in studentList).

            //After the From clause, you can use different Standard Query Operators to filter, group, join elements of the collection.
            //There are around 50 Standard Query Operators available in LINQ. 
            //here we use directly select as we donot have condition with it.

            //LINQ query syntax always ends with a Select or Group clause. The Select clause is used to shape the data.

            Console.WriteLine("Products are : ");
            foreach(var pro in productNames)
            {
                Console.WriteLine(pro);
            }
        }
        
        
    }
}
