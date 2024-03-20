using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using RJ35.Models.Products;
using RJ35.Data;


namespace RJ35.Models.Products.ViewModels;

public class ProductViewModel
{
    private readonly Product _product;

    public int ProductId { get { return _product.ProductId; } }
    public string Name { get { return _product.Name; } }
    public string Brand { get { return _product.Brand; } }
    public string? Description { get { return _product.Description; } }
    public decimal Price { get { return _product.Price; } }
    public string Image { get { return _product.Image; } }
    public ProductCategory ProductCategory { get { return _product.ProductCategory; } }
    public int Stock { get { return _product.Stock; } }
    public DateTime CreatedAt { get { return _product.CreatedAt; } }


    public readonly decimal ProductRating;
    // public IEnumerable<ProductReview>? ProductReviews { get; set; }

    public ProductViewModel(Product product)
    {
        _product = product;
        ProductRating = -1;
    }

    public ProductViewModel(Product product, decimal productRating)
    {
        _product = product;
        ProductRating = productRating;
    }
}