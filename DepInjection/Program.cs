class Program

{
    static void Main(string[] args){
        
    }
    static Order[] Orders = 
        new Order[] { new Order() { Id = 1, Total = 100.00M }};

    public OrderManager(OrderAccessor orderAccessor, EmailAccessor emailAccessor)
    {
        OrderAccessor = orderAccessor;
        EmailAccessor = emailAccessor; 
    }
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
        
        var order = orderAccessor.Find(id);
        OrderManager.SendNotification(1);
    }
    static void Main(string[] args)
    {
        var manager = new OrderManager();
        manager.SendNotification(1);
    }
    
}

