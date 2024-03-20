using RJ35.Data;

namespace RJ35.Services;

public class ProductService : IProductService
{
    private readonly RJ35Context dbContext;

    public ProductService(RJ35Context dbContext)
    {
        this.dbContext = dbContext;
    }

    public decimal GetProductRating(int productId)
    {
        var reviews = dbContext.ProductReviews.Where(r => r.ProductId == productId);
        return reviews.Any() ? (decimal)reviews.Average(r => r.Rating) : 0;
    }
}