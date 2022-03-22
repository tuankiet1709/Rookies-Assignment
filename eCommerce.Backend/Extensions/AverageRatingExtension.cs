using Microsoft.EntityFrameworkCore;
using eCommerce.Shared.Dto;
using eCommerce.Shared.Enum;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Linq.Dynamic.Core;
using eCommerce.Shared.Constants;
using eCommerce.Backend.Models;

namespace eCommerce.Backend.Extension
{
    public static class AverageRatingExtension
    {
        public static int CalculateAverageRating(this List<Rating> productRatings)
        {
            var totalReviews = productRatings.Count!=0?productRatings.Count:1;

            var totalRatings = productRatings.Sum(pr => pr.RatePoint);

            int averageRatings = totalRatings / totalReviews;

            return averageRatings;
        }
    }
}