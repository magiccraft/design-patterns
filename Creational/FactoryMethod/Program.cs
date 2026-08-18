internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("=== Factory Method Pattern Örneği ===");

        // E-posta Bildirim Fabrikası üzerinden bildirim gönderimi
        NotificationFactory emailFactory = new EmailNotificationFactory();
        emailFactory.NotifyUser("Hesabınız başarıyla oluşturuldu.");

        Console.WriteLine();

        // SMS Bildirim Fabrikası üzerinden bildirim gönderimi
        NotificationFactory smsFactory = new SmsNotificationFactory();
        smsFactory.NotifyUser("Doğrulama kodunuz: 492815");
    }
}
