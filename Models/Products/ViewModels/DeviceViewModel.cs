using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using RJ35.Data;


namespace RJ35.Models.Products.ViewModels;

public class DeviceViewModel : ProductViewModel
{
    private readonly Device Device;

    public string Model { get { return Device.Model; } }
    public string DeviceType { get { return Device.DeviceType.Name; } }

    public DeviceViewModel(Product product, Device device) : base(product)
    {
        Device = device;
    }
    public DeviceViewModel(Product product, decimal productRating, Device device) : base(product, productRating)
    {
        Device = device;
    }
}