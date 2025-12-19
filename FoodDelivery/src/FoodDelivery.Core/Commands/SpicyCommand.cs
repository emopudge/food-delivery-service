using FoodDelivery.Core.Interfaces;

namespace FoodDelivery.Core.Commands
{
    // команда острота
    public class SpicyCommand : IOrderCommand
    {
        public string Description => "острое";
        public string Execute()
        {
            return "добавить острый соус ко всем блюдам";
        }
    }
}