using FoodDelivery.Core.Interfaces;

namespace FoodDelivery.Core.Decorators
{
    // поведенческий паттерн декоратор (абстрактный класс обычного заказа)
    public abstract class OrderDecorator: IOrder
    {
        // поле
        protected readonly IOrder _order;

        // конструктор
        public OrderDecorator(IOrder order)
        {
            _order = order;
        }

        // методы
        public virtual decimal CalculateTotal()
        {
            return _order.CalculateTotal();
        }

        public virtual string GetInfo()
        {
            return _order.GetInfo();
        }

    }

}