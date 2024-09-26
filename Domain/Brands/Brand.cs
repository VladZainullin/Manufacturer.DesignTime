using Domain.Brands.Parameters;
using Domain.Manufacturers;

namespace Domain.Brands;

public sealed class Brand
{
    private Guid _id = Guid.NewGuid();
    
    private string _title = default!;
    private string _description = default!;

    private Guid _manufacturerId;
    private Manufacturer _manufacturer = default!;
    
    private Brand()
    {
    }

    public Brand(CreateBrandParameters parameters) : this()
    {
        SetTitle(new SetBrandTitleParameters
        {
            Title = parameters.Title
        });
        
        SetDescription(new SetBrandDescriptionParameters
        {
            Description = parameters.Description
        });
        
        SetManufacturer(new SetBrandManufacturerParameters
        {
            Manufacturer = parameters.Manufacturer
        });
    }

    public Guid Id => _id;

    public string Title => _title;

    public void SetTitle(SetBrandTitleParameters parameters)
    {
        _title = parameters.Title.Trim();
    }
    
    public string Description => _description;
    
    public void SetDescription(SetBrandDescriptionParameters parameters)
    {
        _description = parameters.Description.Trim();
    }

    public Guid ManufacturerId => _manufacturerId;
    public Manufacturer Manufacturer => _manufacturer;

    public void SetManufacturer(SetBrandManufacturerParameters parameters)
    {
        _manufacturerId = parameters.Manufacturer.Id;
        _manufacturer = parameters.Manufacturer;
    }
}