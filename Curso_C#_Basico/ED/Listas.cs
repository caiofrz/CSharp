namespace ED;

class Listas
{
    public static void main(){
        List<String> nomes = new List<string>();
        nomes.Add("Caio");
        nomes.Add("Caio0");
        nomes.Add("Caio1");

        Console.WriteLine(nomes[0]);
        Console.WriteLine(nomes.ElementAt(1));
    }
}