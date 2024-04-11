using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;
using RJ35.Models;
using Microsoft.AspNet.Identity;

namespace RJ35.Data;

public static class SeedData
{
    public static async Task Initialize(RJ35Context context)
    {

            // Look for any movies.
            // if (!context.ProductCategory.Any())
            // {
            //     context.ProductCategory.AddRange(
            //         new ProductCategory
            //         {
            //             Name = "Cable"
            //         },
            //         new ProductCategory
            //         {
            //             Name = "Device"
            //         },
            //         new ProductCategory
            //         {
            //             Name = "Rack"
            //         },
            //         new ProductCategory
            //         {
            //             Name = "Accessory"
            //         }
            //     );
            //     context.SaveChanges();
            // }

    }
}