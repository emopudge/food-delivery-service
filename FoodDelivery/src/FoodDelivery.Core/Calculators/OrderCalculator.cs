using FoodDelivery.Core.Interfaces;

namespace FoodDelivery.Core.Calculators
{
    // абстрактный класс template method - база для калькуляторов цен в разных странах 
    // с учетом местных налогов и цены доставки
    public abstract class OrderCalculator
    {
        public decimal CalculateTotal(IOrder order)
        {
            decimal total = GetBasePrice(order);
            total = ApplyDiscounts(total);
            total = ApplyTaxes(total);
            total = ApplyDeliveryFee(total);
            return total;
        }

        // переопределяемые шаги для наследников
        protected virtual decimal GetBasePrice(IOrder order)
        {
            return order.CalculateTotal();
        }

        protected abstract decimal ApplyDiscounts(decimal price);
        protected abstract decimal ApplyTaxes(decimal price);
        protected abstract decimal ApplyDeliveryFee(decimal price);
    }
}