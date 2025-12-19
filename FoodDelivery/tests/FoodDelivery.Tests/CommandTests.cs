using Xunit;
using FoodDelivery.Core.Commands;
using FoodDelivery.Core.Models;

namespace FoodDelivery.Tests
{
    public class CommandTests
    {
        [Fact]
        public void Order_CanAddPreferences()
        {
            var order = new Order();
            
            order.AddPreference(new NoOnionCommand());
            order.AddPreference(new ExtraSauceCommand());
            
            var prefs = order.GetPreferences();
            
            Assert.Contains("без лука", prefs);
            Assert.Contains("больше соуса", prefs);
        }
        
        [Fact]
        public void Commands_ExecuteCorrectly()
        {
            var spicyCmd = new SpicyCommand();
            var noOnionCmd = new NoOnionCommand();
            
            Assert.Equal("острое", spicyCmd.Description);
            Assert.Equal("добавить острый соус ко всем блюдам", spicyCmd.Execute());
            Assert.Equal("убрать лук из всех блюд", noOnionCmd.Execute());
        }
    }
}