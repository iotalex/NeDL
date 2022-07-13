class OrderAccessor
{
    static Order[] Orders = 
        new Order[] { new Order() { Id = 1, Total = 100.00M }};

    public Order Find(int id)
    {
        return Orders.First(o => o.Id == id);
    }
}
