namespace Creational_Pattern_Builder_StepWise_Builder_AKA_Wizard.Contracts;

public interface ISpecifyProductNameV2
{
    ISpecifyProductPriceV2 WithName(string name);
}