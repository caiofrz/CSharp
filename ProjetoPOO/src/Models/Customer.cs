namespace ProjetoPOO.Models;
class Customer
{
    private string Name {get;set;}
    private string Cpf {get;set;}
    private string Email {get;set;}

    public Customer(string Name, string Cpf, string Email){
        this.Name = Name;
        this.Cpf = Cpf;
        this.Email = Email;
    }
}