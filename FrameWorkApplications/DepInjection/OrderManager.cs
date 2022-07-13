class OrderManager
{
    public void SendNotification(int id)
    {
        var orderAccessor = new OrderAccessor();
        var order = orderAccessor.Find(id);
        var emailAccessor = new EmailAccessor();
        emailAccessor.SendEmail(order);
    }
}
