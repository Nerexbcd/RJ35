using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using RJ35.Models.Products;

namespace RJ35.Models;

public class ProductCartViewModel
{
    private readonly Product _product;
    private readonly ProductsCart _cart;


    public int ProductId { get { return _product.ProductId; }}
    public string Name { get { return _product.Name; }}
    public decimal ProductPrice { get { return _product.Price; }}
    public ProductCategory Category { get { return _product.ProductCategory; }}
    public string Image { get { return _product.Image; }}
    public decimal Price { get { return _cart.Quantity * _product.Price; }}
    public int Quantity { get { return _cart.Quantity; }}



    public ProductCartViewModel(ProductsCart cart, Product product)
    {
        _product = product;
        _cart = cart;
    }

}