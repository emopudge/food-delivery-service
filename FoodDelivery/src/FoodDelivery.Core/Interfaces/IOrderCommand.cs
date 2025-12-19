namespace FoodDelivery.Core.Interfaces
{
    // интерфейс поведенческого паттерна Command для персонализации заказов
    public interface IOrderCommand
    {
        public string Execute(); // возвращает вместе с заказом комментарий для повара
        public string Description { get; }
    }
}