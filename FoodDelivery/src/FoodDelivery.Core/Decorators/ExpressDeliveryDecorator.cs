using FoodDelivery.Core.Interfaces;

namespace FoodDelivery.Core.Decorators
{
    // декоратор для экспресс-доставки
    public class ExpressDeliveryDecorator: OrderDecorator
    {
        // специальное поле
        private readonly decimal _expressFee;

        // конструктор
        public ExpressDeliveryDecorator(IOrder order, decimal expressFee)
        : base(order)
        {
            _expressFee = expressFee;
        }

        // переопределенные методы 
        public override decimal CalculateTotal()
        {
            return base.CalculateTotal() + _expressFee;
        }

        public override string GetInfo()
        {
            return "ЭКСПРЕСС-" + base.GetInfo();
        }



    }
}