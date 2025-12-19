using System;
using FoodDelivery.Core.Interfaces;
using FoodDelivery.Core.Models;


namespace FoodDelivery.Core.States
{
    // класс состояния заказа, который еще готовится
    public class PreparingState : IOrderState
    {
        public string StatusName => "готовится";
        public bool CanCancel() => true;
        public void Process(Order order)
        {
            order.SetState(new DeliveryState());
        }
    }
}