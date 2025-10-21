namespace Creational_Pattern_Builder_Composite_Builder;

public class DrinkIngredientBuilder(Drink drink) : Drink.DrinkBuilder(drink)
{
    public DrinkIngredientBuilder AddSugar()
    {
        drink.HasSugar = true;
        return this;
    }

    public DrinkIngredientBuilder AddAlcohol()
    {
        drink.HasAlcohol = true;
        return this;
    }

    public DrinkIngredientBuilder UseFreshFruits()
    {
        drink.FromFreshFruits = true;
        return this;
    }
}