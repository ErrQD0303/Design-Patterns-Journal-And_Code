using Creational_Pattern_Builder_StepWise_Builder_AKA_Wizard.Enums;

namespace Creational_Pattern_Builder_StepWise_Builder_AKA_Wizard.Contracts;

public interface ISpecifyProductType
{
    IBuildProduct WithType(ProductType productType);
}