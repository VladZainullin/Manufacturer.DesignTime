namespace Domain.Brands.Parameters;

public readonly struct SetBrandDescriptionParameters
{
    public required string Description { get; init; }

    public required TimeProvider TimeProvider { get; init; }
}