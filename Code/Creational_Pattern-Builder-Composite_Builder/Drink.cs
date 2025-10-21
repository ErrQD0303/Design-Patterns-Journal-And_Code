namespace Creational_Pattern_Builder_Composite_Builder;

public class Drink
{
    // Properties
    public DrinkType? Type { get; set; }
    public DrinkSize? Size { get; set; }
    public string Name { get; set; }

    // Ingredients
    public bool HasSugar { get; set; } = default;
    public bool HasAlcohol { get; set; } = default;
    public bool FromFreshFruits { get; set; } = default;

    protected Drink(string name)
    {
        Name = name;
    }

    public override string ToString()
    {
        return $"Drink: {Name}, Type: {Type}, Size: {Size}, " +
               $"HasSugar: {HasSugar}, HasAlcohol: {HasAlcohol}, FromFreshFruits: {FromFreshFruits}";
    }

    protected static DrinkBuilder Create(string name)
    {
        return DrinkBuilder.Create(name);
    }

    public class DrinkBuilder
    {
        protected Drink drink;

        protected DrinkBuilder(string name)
        {
            drink = Drink.Create(name);
        }

        // Used by subclasses
        protected DrinkBuilder(Drink drink)
        {
            this.drink = drink;
        }

        public static DrinkBuilder Create(string name)
        {
            return new DrinkBuilder(name);
        }

        // Subclass Instance Accessor
        public DrinkInfoBuilder Info => new(drink);
        public DrinkIngredientBuilder Ingredients => new(drink);

        public override string ToString()
        {
            return drink.ToString();
        }

        public static implicit operator Drink(DrinkBuilder builder)
        {
            return builder.drink;
        }

        public Drink Build() => drink;
    }
}
