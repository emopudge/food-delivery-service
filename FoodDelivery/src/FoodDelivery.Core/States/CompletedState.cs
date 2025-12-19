using System;
using FoodDelivery.Core.Interfaces;
using FoodDelivery.Core.Models;

namespace FoodDelivery.Core.States
{
    // состояние "завершен"
    public class CompletedState : IOrderState
    {
        public string StatusName => "завершен";
        public bool CanCancel() => false;
        public void Process(Order order)
        {
            throw new InvalidOperationException("завершенный заказ не может получить новый статус");
        }
    }
}