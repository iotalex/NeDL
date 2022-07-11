class Program
{
    static Order[] Orders = 
        new Order[] { new Order() { Id = 1, Total = 100.00M }};

    public Order Find(int id)
    {
        return Orders.First(o => o.Id == id);
    }
    public void SendEmail(Order order)
    {
        Console.WriteLine($"Email for {order.Id}");
    }
    public void SendNotification(int id)
    {
        var orderAccessor = new OrderAccessor();
        var order = orderAccessor.Find(id);
        var emailAccessor = new EmailAccessor();
        emailAccessor.SendEmail(order);
    }
    static void Main(string[] args)
    {
        var manager = new OrderManager();
        manager.SendNotification(1);
    }
    
}
