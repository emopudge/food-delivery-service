using Xunit;
using FoodDelivery.Core.Strategies;

namespace FoodDelivery.Tests
{
    public class StrategyTests
    {
        [Fact]
        public void PercentageDiscount_10Percent()
        {
            // скидка 10% от 1000 = 900
            var discount = new PercentageDiscountStrategy(10);
            
            var result = discount.ApplyDiscount(1000);
            
            Assert.Equal(900, result);
        }
        
        [Fact]
        public void FixedDiscount_200Rub()
        {
            // фиксированная скидка 200 от 800 = 600
            var discount = new FixedDiscountStrategy(200);
            
            var result = discount.ApplyDiscount(800);
            
            Assert.Equal(600, result);
        }
        
        [Fact]
        public void FixedDiscount_NotNegative()
        {
            // скидка 500 от 300 = 0 (не может быть отрицательной)
            var discount = new FixedDiscountStrategy(500);
            
            var result = discount.ApplyDiscount(300);
            
            Assert.Equal(0, result);
        }
    }
}