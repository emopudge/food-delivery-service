using Xunit;
using FoodDelivery.Core.Models;
using FoodDelivery.Core.Decorators;

namespace FoodDelivery.Tests
{
    // тесты для декораторов
    public class DecoratorTests
    {
        [Fact]
        public void ExpressDecorator_AddsFee()
        {
            var order = new Order();
            order.AddItem(new MenuItem("Пицца", 500));
            
            var expressOrder = new ExpressDeliveryDecorator(order, 100);
            
            Assert.Equal(600, expressOrder.CalculateTotal());
        }
        
        [Fact]
        public void ExpressDecorator_ChangesDescription()
        {
            var order = new Order();
            order.AddItem(new MenuItem("Суши", 300));
            
            var expressOrder = new ExpressDeliveryDecorator(order, 150);
            
            Assert.Contains("ЭКСПРЕСС-", expressOrder.GetInfo());
        }
    }
}