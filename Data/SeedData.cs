using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;
using RJ35.Models;

namespace RJ35.Data;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new RJ35Context(
            serviceProvider.GetRequiredService<
                DbContextOptions<RJ35Context>>()))
        {
            // Look for any movies.
            if (!context.ProductCategory.Any())
            {
                context.ProductCategory.AddRange(
                    new ProductCategory
                    {
                        Name = "Cable"
                    },
                    new ProductCategory
                    {
                        Name = "Device"
                    },
                    new ProductCategory
                    {
                        Name = "Rack"
                    },
                    new ProductCategory
                    {
                        Name = "Accessory"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}