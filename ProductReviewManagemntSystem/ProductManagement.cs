using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductReview
{
    internal class ProductManagement
    {
        public static void Top3Records(List<Product> productReviewList)
        {
            var productdata = (from reviewlist in productReviewList
                               where reviewlist.Rating == 5
                               select reviewlist).Take(3);
            foreach (var list in productdata)
            {
                Console.WriteLine("ProductId:" + list.ProductID + " " + "Userid:" + list.Userid + " " +
                    "Rating:" + list.Rating + " " + " Review:" + list.Review + " " + "IsLike:" + list.IsLike);


            }
        }
    }
}