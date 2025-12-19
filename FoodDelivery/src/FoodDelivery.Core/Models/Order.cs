using System;
using System.Collections.Generic;
using System.Linq;
using FoodDelivery.Core.Interfaces;
using FoodDelivery.Core.States;
using FoodDelivery.Core.Calculators;

namespace FoodDelivery.Core.Models
{
    // класс заказов
    public class Order : IOrder
    {
        // поля и свойства
        private IOrderState _state;
        public List<MenuItem> Items { get; }
        public decimal TotalPrice { get; private set; }
        public string CurrentStatus => _state?.StatusName ?? "не определен"; // null-conditional operator
        private List<IOrderCommand> _commands = new(); // список предпочтений

        // конструктор
        public Order()
        {
            Items = new List<MenuItem>();
            TotalPrice = 0;
            _state = new PreparingState();
        }

        // методы
        public void AddItem(MenuItem item)
        {
            Items.Add(item);
            TotalPrice += item.Price;
        }

        // для State
        public void SetState(IOrderState newState)
        {
            _state = newState;
        }

        public void ProcessOrder()
        {
            _state.Process(this);
        }

        public bool CanCancel()
        {
            return _state.CanCancel();
        }


        public void Cancel()
        {
            if (!CanCancel())
                throw new InvalidOperationException("в данном состоянии нельзя отменить заказ:(");

            Items.Clear();
            TotalPrice = 0;
        }

        public decimal CalculateTotal()
        {
            return TotalPrice;
        }

        // для Template
        public decimal CalculateTotalWithTaxes(OrderCalculator calculator)
        {
            return calculator.CalculateTotal(this);
        }

        // для Command
        public void AddPreference(IOrderCommand command)
        {
            _commands.Add(command);
        }

        public string GetPreferences()
        {
            if (_commands.Count == 0)
                return "без особых предпочтений";

            var prefs = string.Join(", ", _commands.Select(c => c.Description));
            return prefs;
        }

        // получить информацию по заказу
        public string GetInfo()
        {
            var itemsText = string.Join(", ", Items.Select(i => i.Name));
            return $"заказ состоит из {Items}, общая стоимость: {TotalPrice}," +
            $"статус: {CurrentStatus}. особые предпочтения: {GetPreferences()}";
        }
    }
}