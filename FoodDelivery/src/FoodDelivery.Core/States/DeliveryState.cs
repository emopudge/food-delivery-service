using System;
using FoodDelivery.Core.Interfaces;
using FoodDelivery.Core.Models;


namespace FoodDelivery.Core.States
{
    // состояние "доставляется"
    public class DeliveryState : IOrderState
    {
        public string StatusName => "доставляется";
        public bool CanCancel() => false;
        public void Process(Order order)
        {
            order.SetState(new CompletedState());
        }
    }
}