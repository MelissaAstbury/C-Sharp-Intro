using System.Diagnostics;
using Threading;
using Xunit;

namespace Test
{
    public class PizzaBuilderTest
    {
        [Fact]
        public void IsServedOnTime()
        {
            // arrange
            var pizzaBuilder = new PizzaBuilder();

            // act
            var stopwatch = Stopwatch.StartNew();
            var pizza = pizzaBuilder.Build();
            stopwatch.Stop();

            // assert
            Assert.True(stopwatch.ElapsedMilliseconds < 5000);
        }

        [Fact]
        public void IsServedWithSauce()
        {
            // arrange
            var pizzaBuilder = new PizzaBuilder();

            // act

            var pizza = pizzaBuilder.Build();


            // assert
            Assert.Equal("Ketchup", pizza["Sauce"]);
        }

        [Fact]
        public void IsServedWithCheese()
        {
            // arrange
            var pizzaBuilder = new PizzaBuilder();

            // act

            var pizza = pizzaBuilder.Build();


            // assert
            Assert.Equal("Babybell", pizza["Cheese"]);
        }

        [Fact]
        public void IsServedWithToppingOne()
        {
            // arrange
            var pizzaBuilder = new PizzaBuilder();

            // act

            var pizza = pizzaBuilder.Build();


            // assert
            Assert.Equal("A potato", pizza["ToppingOne"]);
        }

        [Fact]
        public void IsServedWithToppingTwo()
        {
            // arrange
            var pizzaBuilder = new PizzaBuilder();

            // act

            var pizza = pizzaBuilder.Build();


            // assert
            Assert.Equal("Prosciutto", pizza["ToppingTwo"]);
        }
    }
}
