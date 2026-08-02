//Concrete builder (arayüzü uygular ve nesneyi oluşturur)

public class LuxuryHouseBuilder : IHouseBuilder
{
    House _house = new House();


    public void BuildBasement()
    {
        _house.AddPart("Güçlendirilmiş Beton Zemin");
    }

    public void BuildInterior()
    {
        _house.AddPart("Akıllı Ev Sistemleri İç Mekan");
    }

    public void BuildRoof()
    {
        _house.AddPart("Güneş Panelli Çatı");
    }

    public void BuildStructure()
    {
        _house.AddPart("Çelik ve Cam Gövde");
    }

    public House GetHouse()
    {
        House result = _house;
        _house = new House();
        return result;

    }
}