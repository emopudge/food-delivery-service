using System;
using FoodDelivery.Core.Interfaces;

namespace FoodDelivery.Core.Strategies
{
    // стратегия скидок по процентам
    public class PercentageDiscountStrategy : IDiscountStrategy
    {
        // специальное поле
        private decimal _percantage;

        // конструктор
        public PercentageDiscountStrategy(decimal percentage)
        {
            _percantage = percentage;
        }

        public decimal ApplyDiscount(decimal price)
        {
            return price * (1 - _percantage / 100);
        }
    }
}