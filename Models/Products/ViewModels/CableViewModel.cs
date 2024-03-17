using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using RJ35.Data;


namespace RJ35.Models.Products.ViewModels;

public class CableViewModel
{
    public required Product Product { get; set; }
    public required Cable Cable { get; set; }
}