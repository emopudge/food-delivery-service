using System;
using FoodDelivery.Core.Interfaces;

namespace FoodDelivery.Core.Strategies
{
    // стратегия скидок с фиксированной суммой
    public class FixedDiscountStrategy : IDiscountStrategy
    {
        // специальное поле
        public decimal _fixedDiscount;

        // конструктор
        public FixedDiscountStrategy(decimal fixedDiscount)
        {
            _fixedDiscount = fixedDiscount;
        }

        // метод
        public decimal ApplyDiscount(decimal price)
        {
            return Math.Max(0, price - _fixedDiscount);
        }
    }
}