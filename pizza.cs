using System;
 class Program
{
    static void Main(string[]args)
    {
        Order myOrder = new Order("Pizza Margarita",2,450.0);
        myOrder.DisplayInfo();
    }
}

public class Order
{
    private string dishName;
    private int quantity;
    private double pricePerPortion;

    public Order(string dishName, int quantity, double pricePerPortion)
    {
        this.dishName = dishName;
        this.quantity = quantity;
        this.pricePerPortion = pricePerPortion;
    }

    public double CalculateTotalCost()
    {
        return quantity*pricePerPortion;
    }

    public void DisplayInfo()
    {
        Console.WriteLine( "Информация о заказе");
        Console.WriteLine("Блюдо: {dishName}");
        Console.WriteLine("Количество порций: {quantity}");
        Console.WriteLine("Цена за порцию: {pricePerPortion} com.");
        Console.WriteLine("Общая стоимость: {CalculateTotalCost()} com.");
    }


}