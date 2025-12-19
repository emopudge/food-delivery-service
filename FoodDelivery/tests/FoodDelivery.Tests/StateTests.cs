using Xunit;
using FoodDelivery.Core.Models;
using FoodDelivery.Core.States;

namespace FoodDelivery.Tests
{
    // тесты для проверки состояний заказов
    public class StateTests
    {
        [Fact]
        public void Order_StartsWithPreparingState()
        {
            var order = new Order();
            Assert.Equal("готовится", order.CurrentStatus);
        }
        
        [Fact]
        public void Order_CanCancel_InPreparingState_ReturnsTrue()
        {
            var order = new Order();
            Assert.True(order.CanCancel());
        }
        
        [Fact]
        public void Order_ProcessOrder_ChangesState()
        {
            var order = new Order();
            
            order.ProcessOrder(); 
            Assert.Equal("доставляется", order.CurrentStatus);
            
            order.ProcessOrder(); 
            Assert.Equal("завершен", order.CurrentStatus);
        }
        
        [Fact]
        public void Order_CannotCancel_InDeliveryState()
        {
            var order = new Order();
            order.ProcessOrder(); 
            
            Assert.False(order.CanCancel());
            Assert.Throws<InvalidOperationException>(() => order.Cancel());
        }
    }
}