namespace Creational_Pattern_Builder_Composite_Builder;

public class DrinkInfoBuilder(Drink drink) : Drink.DrinkBuilder(drink)
{
    public DrinkInfoBuilder SetType(DrinkType type)
    {
        drink.Type = type;
        return this;
    }

    public DrinkInfoBuilder SetSize(DrinkSize size)
    {
        drink.Size = size;
        return this;
    }
}
