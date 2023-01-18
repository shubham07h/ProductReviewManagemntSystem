using ProductReview;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductReview
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> product = new List<Product>()
        {
        new Product{ProductID=1,    Userid=1,Rating=5,Review="Very Good",IsLike=true },
        new Product{ProductID = 2,  Userid = 2, Rating = 5, Review = " Good", IsLike = true },
        new Product{ProductID= 3,   Userid= 3, Rating= 2, Review= "Bad", IsLike= false },
        new Product{ProductID = 4,  Userid = 4, Rating = 5, Review = "Very Good", IsLike = true },
        new Product{ProductID = 5,  Userid = 5, Rating = 2, Review = "Bad", IsLike = true },
        new Product{ProductID = 6,  Userid = 6, Rating = 4, Review = "Good", IsLike = true },
        new Product{ProductID = 7,  Userid = 7, Rating = 5, Review = "Very Good", IsLike = true },
        new Product{ProductID = 8,  Userid = 8, Rating = 4, Review = " Good", IsLike = true },
        new Product{ProductID = 9,  Userid = 9, Rating = 5, Review = "Nice", IsLike = true},
        new Product{ProductID = 10, Userid = 10, Rating = 3, Review = "Bad", IsLike = false },
        new Product{ProductID = 11, Userid = 11, Rating = 5, Review = "Fantastic", IsLike = true },
        new Product{ProductID = 12, Userid = 12, Rating = 5, Review = "Very Good", IsLike = true },
        new Product{ProductID = 13, Userid = 13, Rating = 5, Review = "Good", IsLike = true },
        new Product{ProductID = 14, Userid = 14, Rating = 3, Review = "Bad", IsLike = false },
        new Product{ProductID = 15, Userid = 15, Rating = 5, Review = "Nice", IsLike = true},
        new Product{ProductID = 16, Userid = 16, Rating = 4, Review = "Good", IsLike = true},
        new Product{ProductID = 17, Userid = 17, Rating = 5, Review = "Very Good", IsLike = true },
        new Product{ProductID = 18, Userid = 18, Rating = 4, Review = " Good", IsLike = true },
        new Product{ProductID = 19, Userid =19, Rating = 5, Review = "Nice", IsLike = false },
        new Product{ProductID = 20, Userid = 20, Rating = 2, Review = "Bad", IsLike = true },
        new Product{ProductID = 21, Userid = 21, Rating = 5, Review = "Fantastic", IsLike = true },
        new Product{ProductID = 22, Userid = 22, Rating = 5, Review = "Very Good", IsLike = true },
        new Product{ProductID = 23, Userid = 23, Rating = 5, Review = "Good", IsLike = true},
        new Product{ProductID = 24, Userid = 24, Rating = 2, Review = "Bad", IsLike = false},
        new Product{ProductID = 25, Userid = 25, Rating = 4, Review = "Nice", IsLike = true},
        };

            ProductManagement.Top3Records(product);


        }
    }
}
