using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using RJ35.Data;


namespace RJ35.Models.Products.ViewModels;

public class CableViewModel : ProductViewModel
{
    private readonly Cable Cable;

    public string Color { get { return Cable.Color; } }
    public string CableType { get { return Cable.CableType; } }
    public string Category { get { return Cable.Category; } }


    public CableViewModel(Product product, Cable cable) : base(product)
    {
        Cable = cable;
    }
    public CableViewModel(Product product, decimal productRating, Cable cable) : base(product, productRating)
    {
        Cable = cable;
    }
}