using FoodDelivery.Core.Interfaces;

namespace FoodDelivery.Core.Commands
{
    // команда дополнительный соус
    public class ExtraSauceCommand : IOrderCommand
    {
        public string Description => "больше соуса";
        public string Execute()
        {
            return "добавить дополнительный соус";
        }
    }
}