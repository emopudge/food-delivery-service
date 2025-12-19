using FoodDelivery.Core.Interfaces;

namespace FoodDelivery.Core.Commands
{
    // петтерн команда: без лука, наследование от интерфейса команд
    public class NoOnionCommand : IOrderCommand
    {
        public string Description => "без лука";
        public string Execute()
        {
            return "убрать лук из всех блюд";
        }
    }
}