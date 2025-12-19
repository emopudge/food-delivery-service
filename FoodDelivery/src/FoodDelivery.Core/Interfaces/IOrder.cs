using System;
using FoodDelivery.Core.Models;

namespace FoodDelivery.Core.Interfaces
{
    // интерфейс заказа
    public interface IOrder
    {
        public decimal CalculateTotal();
        public string GetInfo();
    }
}