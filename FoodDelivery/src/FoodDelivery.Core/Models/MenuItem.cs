using System;

namespace FoodDelivery.Core.Models
{
    // класс блюд из меню
    public class MenuItem
    {
        // свойства
        public string Name {get; }
        public decimal Price { get; }

        // конструктор
        public MenuItem(string name, decimal price)
        {
            Name = name;
            Price = price;
        }
    }
}