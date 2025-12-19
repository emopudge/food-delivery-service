using FoodDelivery.Core.Calculators;
using Xunit;
using FoodDelivery.Core.Models;

namespace FoodDelivery.Tests
{
    // тесты для расчета цен в России
    public class RussianCalculatorTests
    {
        [Fact]
        public void RussianCalculator_Adds20PercentTax()
        {
            var order = new Order();
            order.AddItem(new MenuItem("Пицца", 500));
            
            var calculator = new RussianOrderCalculator(100); // доставка 100 руб
            
            var total = calculator.CalculateTotal(order);
            // 500 * 1.20 (налог) + 100 (доставка) = 700
            Assert.Equal(700, total);
        }
    }
}