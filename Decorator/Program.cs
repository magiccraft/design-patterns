using System;

class Program
{
    static void Main()
    {
            // //Simple mesaj
            // IMessage message = new SimpleMessage();
            // Console.WriteLine(message.GetContent());

            // //encrypted mesaj
            // message = new EncryptedMessage(message);
            // Console.WriteLine(message.GetContent());

            // //compressed + encrypted mesaj mesaj
            // message = new CompressedMessage(message);
            // Console.WriteLine(message.GetContent());

            // IMessage messageTwo = new SimpleMessage();

            
            // IDataLogger logger = new BaseDataLogger();
            // logger = new DataEncryptor(logger);
            // logger.Write("araba");
    

            // IDrink drink = new Espresso();
            // System.Console.WriteLine($"{drink.AciklamaGetir()}: {drink.GetPrice()}");

            // drink = new Milk(drink);
            // System.Console.WriteLine($"{drink.AciklamaGetir()}: {drink.GetPrice()}");

            IExporter exporter = new BaseExporter();
            exporter = new CompressedExporter(exporter);
            exporter = new EncryptedExporter(exporter);

            System.Console.WriteLine(exporter.Export("veri"));
    }
}