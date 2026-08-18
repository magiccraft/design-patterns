internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("=== Command Pattern (Undo Destekli) Örneği ===");

        // Alıcılar (Receivers)
        Light salonLambasi = new Light("Salon");
        Light mutfakLambasi = new Light("Mutfak");

        // Komutlar (Commands)
        ICommand salonAc = new LightOnCommand(salonLambasi);
        ICommand salonKapat = new LightOffCommand(salonLambasi);
        ICommand mutfakAc = new LightOnCommand(mutfakLambasi);

        // Çağırıcı (Invoker)
        RemoteControl kumanda = new RemoteControl();

        Console.WriteLine("\n--- Komutlar Çalıştırılıyor ---");
        kumanda.SubmitAndExecute(salonAc);
        kumanda.SubmitAndExecute(mutfakAc);
        kumanda.SubmitAndExecute(salonKapat);

        Console.WriteLine("\n--- Geri Alma (Undo) İşlemleri Tetikleniyor ---");
        kumanda.PressUndo(); // Salonu tekrar açmalı
        kumanda.PressUndo(); // Mutfağı kapatmalı
        kumanda.PressUndo(); // Salonu kapatmalı
        kumanda.PressUndo(); // Geçmiş boş uyarısı vermeli
    }
}
