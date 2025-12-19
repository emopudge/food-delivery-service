using System;
using FoodDelivery.Core.Models;

namespace FoodDelivery.Core.Interfaces
{
    // интерфейс для поведенческого паттерна стратегий скидки
    public interface IDiscountStrategy
    {
        protected decimal ApplyDiscount(decimal price);
    }
}