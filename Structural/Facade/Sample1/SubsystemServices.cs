// Subsystem 1: Stok Yönetim Servisi
public class InventoryService
{
    public bool CheckStock(string productId, int quantity)
    {
        Console.WriteLine($"[Stok Servisi] '{productId}' için {quantity} adet stok kontrol ediliyor... Stokta VAR.");
        return true;
    }

    public void ReserveStock(string productId, int quantity)
    {
        Console.WriteLine($"[Stok Servisi] '{productId}' için {quantity} adet stok rezerve edildi.");
    }
}

// Subsystem 2: Ödeme Servisi
public class PaymentService
{
    public bool ProcessPayment(string customerName, decimal amount)
    {
        Console.WriteLine($"[Ödeme Servisi] {customerName} isimli müşteriden {amount:C2} tutarında ödeme alındı.");
        return true;
    }
}

// Subsystem 3: Kargo Servisi
public class ShippingService
{
    public string CreateShipment(string customerAddress, string productId)
    {
        string trackingNumber = "TRK-" + Guid.NewGuid().ToString("N")[..8].ToUpper();
        Console.WriteLine($"[Kargo Servisi] Kargo paketi hazırlandı. Adres: '{customerAddress}'. Takip No: {trackingNumber}");
        return trackingNumber;
    }
}
