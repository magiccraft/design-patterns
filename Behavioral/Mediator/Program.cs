internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("=== Mediator Pattern Örneği ===");

        // Arabulucu (Mediator)
        IChatRoomMediator chatRoom = new ChatRoom();

        // Kullanıcılar (Colleagues)
        User ali = new ChatUser("Ali", chatRoom);
        User ayse = new ChatUser("Ayşe", chatRoom);
        User mehmet = new ChatUser("Mehmet", chatRoom);

        // Kullanıcıları odaya kaydediyoruz
        chatRoom.RegisterUser(ali);
        chatRoom.RegisterUser(ayse);
        chatRoom.RegisterUser(mehmet);

        // Genel mesajlaşma
        ali.Send("Herkese selam! Bugünkü toplantı saat 15:00'te.");
        ayse.Send("Harika, ben sunumu hazırladım.");

        // Birebir özel mesajlaşma
        mehmet.SendTo("Toplantı linkini tekrar atabilir misin?", "Ayşe");
    }
}
