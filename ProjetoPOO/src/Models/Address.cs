namespace ProjetoPOO.Models;
class Address
{
    private string Street { get; set; }
    private uint Number { get; set; }
    private string Neighborhood { get; set; }
    private uint Zipcode { get; set; }

    public Address(string Street, uint Number, string Neighborhood, uint Zipcode){
        this.Street = Street;
        this.Number = Number;
        this.Neighborhood = Neighborhood;
        this.Zipcode = Zipcode;
    }
}