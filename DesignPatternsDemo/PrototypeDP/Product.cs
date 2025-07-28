using Microsoft.AspNetCore.Components.Routing;

namespace DesignPatternsDemo.PrototypeDP
{
    public class Product : IPrototype<Product>
    {
        public string? Name { get; set; }
        public decimal Price { get; set; }
        public string? Description { get; set; }
        public string? Category { get; set; }

        public Location? InventoryLocation { get; set; }

        public Product Clone()
        {
            Product clonedProduct = (Product)this.MemberwiseClone();
            clonedProduct.InventoryLocation = this.InventoryLocation!.Clone();

            return (Product)this.MemberwiseClone();
        }
    }
}
