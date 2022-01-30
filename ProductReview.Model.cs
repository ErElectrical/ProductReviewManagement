using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductReviewManagement
{
    public class ProductReviewModel
    {
        /// <summary>
        /// field Varible 
        /// </summary>
        public int ProductId { get; set; }
        public int UserId { get; set; }

        public double Rating { get; set; }

        public string review { get; set; }

        public bool Islike { get; set; }

    }
}
