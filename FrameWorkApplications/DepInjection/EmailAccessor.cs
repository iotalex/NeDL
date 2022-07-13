class EmailAccessor
{
    public void SendEmail(Order order)
    {
        Console.WriteLine($"Email for {order.Id}");
    }
}
