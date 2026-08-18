// Facade (Karmaşık alt sistemleri tek ve basit bir arayüz arkasında toplar)
public class OrderFacade
{
    private readonly InventoryService _inventoryService;
    private readonly PaymentService _paymentService;
    private readonly ShippingService _shippingService;

    public OrderFacade()
    {
        _inventoryService = new InventoryService();
        _paymentService = new PaymentService();
        _shippingService = new ShippingService();
    }

    public bool PlaceOrder(string customerName, string customerAddress, string productId, int quantity, decimal price)
    {
        Console.WriteLine($"\n[OrderFacade] Sipariş işlemi başlatılıyor: {customerName} -> Ürün: {productId}");

        // 1. Adım: Stok Kontrolü
        if (!_inventoryService.CheckStock(productId, quantity))
        {
            Console.WriteLine("[OrderFacade] Hata: Ürün stokta yetersiz!");
            return false;
        }

        // 2. Adım: Stok Rezerve Etme
        _inventoryService.ReserveStock(productId, quantity);

        // 3. Adım: Ödeme Alma
        decimal totalAmount = price * quantity;
        if (!_paymentService.ProcessPayment(customerName, totalAmount))
        {
            Console.WriteLine("[OrderFacade] Hata: Ödeme başarısız oldu!");
            return false;
        }

        // 4. Adım: Kargo Oluşturma
        string trackingNo = _shippingService.CreateShipment(customerAddress, productId);

        Console.WriteLine($"[OrderFacade] Sipariş başarıyla tamamlandı! Kargo Takip Kodu: {trackingNo}\n");
        return true;
    }
}
