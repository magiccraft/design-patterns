internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("=== Facade Pattern Örneği ===");

        // İstemci alt sistemlerin detaylarıyla uğraşmak yerine tek bir Facade metodu çağırır
        OrderFacade orderFacade = new OrderFacade();

        orderFacade.PlaceOrder(
            customerName: "Caner Yıldız",
            customerAddress: "Atatürk Cad. No:42 Kadıköy / İstanbul",
            productId: "LAPTOP-M3-MAX",
            quantity: 1,
            price: 65000.00m
        );
    }
}
