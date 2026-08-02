//builder arayüzü
public interface IHouseBuilder
{
    void BuildBasement();
    void BuildStructure();
    void BuildRoof();
    void BuildInterior();
    House GetHouse();
}