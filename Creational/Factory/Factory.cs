namespace DesignPatterns.Creational.Factory
{
    public interface IBeer
    {
        void Drink();
    }

    class MarketPiss : IBeer
    {
        public void Drink()
        {
            System.Console.WriteLine("Tastes like piss!");
        }
    }

    class Stout : IBeer
    {
        public void Drink()
        {
            System.Console.WriteLine("Tss. Gulgulgul. Not bad.");
        }
    }

    class BananaCornelius : IBeer
    {
        public void Drink()
        {
            System.Console.WriteLine("Gulgulgul. Delicious!");
        }
    }

    public abstract class BeerFactory
    {
        abstract protected IBeer MakeBeer(int budget);
        public void SellAndDrinkBeer(int budget)
        {
            var beer = this.MakeBeer(budget);
            beer.Drink();
        }
    }

    public class Monopolowy : BeerFactory
    {
        protected override IBeer MakeBeer(int budget)
        {
            if (budget < 2)
            {
                return new MarketPiss();
            }
            if (budget < 5)
            {
                return new Stout();
            }
            return new BananaCornelius();
        }
    }
}