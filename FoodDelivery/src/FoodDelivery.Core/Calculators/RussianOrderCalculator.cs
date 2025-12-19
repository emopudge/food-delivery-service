namespace FoodDelivery.Core.Calculators
{
    // наследник шаблона калькулятора: калькулятор для русских
    public class RussianOrderCalculator : OrderCalculator
    {
        // специальные для России поля
        private readonly decimal _taxRate = 1.2m; // НДС в РФ 20%
        private readonly decimal _deliveryFee;

        // конструктор
        public RussianOrderCalculator(decimal deliveryFee)
        {
            _deliveryFee = deliveryFee;
        }

        // переопределенные родительские методы
        protected override decimal ApplyDiscounts(decimal price)
        {
            // ДОБАВИТЬ РЕАЛИЗАЦИЮ
            return price;
        }

        protected override decimal ApplyTaxes(decimal price)
        {
            return price * _taxRate;
        }

        protected override decimal ApplyDeliveryFee(decimal price)
        {
            return price + _deliveryFee;
        }
    }
}