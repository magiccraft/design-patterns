public class Contractor
{ IHouseBuilder _builder;

    public Contractor(IHouseBuilder builder)
    {
        _builder = builder;
    }

    public void ConstructHouse()
    {
        _builder.BuildBasement();
        _builder.BuildStructure();
        _builder.BuildRoof();
        _builder.BuildInterior();
    }
    
    
}