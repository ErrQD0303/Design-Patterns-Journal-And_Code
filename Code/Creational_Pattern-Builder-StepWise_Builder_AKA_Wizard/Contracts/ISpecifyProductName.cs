namespace Creational_Pattern_Builder_StepWise_Builder_AKA_Wizard.Contracts;

public interface ISpecifyProductName
{
    ISpecifyProductPrice WithName(string name);
}