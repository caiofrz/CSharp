namespace ED;

class Dicionario
{
    public static void main(){
        Dictionary<int, string> nomes = new Dictionary<int, string>
        {
            { 1, "Caio" },
            { 2, "Caio0" }
        };
        
        nomes.Add(3, "Caio1");

        Console.WriteLine(nomes[0]);
        Console.WriteLine(nomes.GetEnumerator());
    }
}