using Creational_Pattern_Builder_StepWise_Builder_AKA_Wizard.Contracts;
using Creational_Pattern_Builder_StepWise_Builder_AKA_Wizard.Enums;

namespace Creational_Pattern_Builder_StepWise_Builder_AKA_Wizard.Models;

public class Product
{
    public string Id { get; set; } = Guid.NewGuid().ToString();
    public string Name { get; set; } = string.Empty;
    public decimal Price { get; set; }

    public ProductType Type { get; set; }

    public override string ToString()
    {
        return $"Product Id: {Id}, Name: {Name}, Price: {Price}, Type: {Type}";
    }

    protected Product() { }

    public class ProductBuilder
    {
        private ImplV2 ImplObject { get; set; }
        protected ProductBuilder()
        {
            ImplObject = new();
        }

        public static ISpecifyProductNameV2 Create()
        {
            var builder = new ProductBuilder();

            return builder.ImplObject;
        }

        public override string ToString()
        {
            return ImplObject.ToString();
        }

        private class Impl : ISpecifyProductName, ISpecifyProductPrice, IBuildProduct
        {
            private Product Product { get; set; }

            public Impl()
            {
                Product = new Product();
            }

            public ISpecifyProductPrice WithName(string name)
            {
                Product.Name = name;
                return this;
            }

            public IBuildProduct WithPrice(decimal price)
            {
                Product.Price = price;
                return this;
            }

            public Product Build()
            {
                return Product;
            }

            public override string ToString()
            {
                return Product.ToString();
            }
        }

        private class ImplV2 : ISpecifyProductNameV2, ISpecifyProductPriceV2, ISpecifyProductType, IBuildProduct
        {
            private Product Product { get; set; }

            public ImplV2()
            {
                Product = new Product();
            }

            public ISpecifyProductPriceV2 WithName(string name)
            {
                Product.Name = name;
                return this;
            }

            public ISpecifyProductType WithPrice(decimal price)
            {
                Product.Price = price;
                return this;
            }

            public IBuildProduct WithType(ProductType productType)
            {
                Product.Type = productType;
                return this;
            }

            public Product Build() => Product;

            public override string ToString()
            {
                return Product.ToString();
            }
        }
    }
}