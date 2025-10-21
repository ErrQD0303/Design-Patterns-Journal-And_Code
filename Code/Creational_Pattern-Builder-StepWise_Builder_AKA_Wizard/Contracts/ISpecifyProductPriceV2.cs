namespace Creational_Pattern_Builder_StepWise_Builder_AKA_Wizard.Contracts;

public interface ISpecifyProductPriceV2
{
    ISpecifyProductType WithPrice(decimal price);
}