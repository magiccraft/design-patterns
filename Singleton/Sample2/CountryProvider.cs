public sealed class CountryProvider
{

    static CountryProvider? instance = null;
    private  List<Country>? Countries { get; set; }

    private CountryProvider()
    {
        Countries =
            [
                new Country() {Name = "Türkiye"},
                new Country() {Name = "Almanya"},
                new Country() {Name = "İtalya"}
            ];
    }
    public static CountryProvider Instance => instance ??= new CountryProvider();

    public List<Country>? GetCountries()
    {
        return Countries;
    }
}



