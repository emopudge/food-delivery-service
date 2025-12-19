using System;
using FoodDelivery.Core.Models;

namespace FoodDelivery.Core.Interfaces
{
    // интерфейс для разных состояний заказа (поведенческий паттерн)
    public interface IOrderState
    {
        void Process(Order order);
        bool CanCancel();
        string StatusName { get; }
    }
}