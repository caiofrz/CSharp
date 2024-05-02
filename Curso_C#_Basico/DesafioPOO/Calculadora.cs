namespace DesafioPOO;

/// <summary>
/// Classe responsavel por realizar calculos matematicos
/// </summary>
class Calculadora
{

    /// <summary>
    /// Metodo para somar dois numeros
    /// </summary>
    /// <param name="numero1">Primeiro numero</param>
    /// <param name="numero2">Segundo numero</param>
    /// <returns>Resultado de numero1 + numero2</returns>
    public static double somar(double numero1, double numero2){
        return numero1 + numero2;
    }
    public static double subtrair(double numero1, double numero2){
        return numero1 - numero2;
    }
    public static double multiplicar(double numero1, double numero2){
        return numero1 * numero2;
    }
    public static double dividir(double numero1, double numero2){
        if (numero2 == 0.0) throw new ArgumentException("Divisão por 0 não é possivel!");

        return numero1 / numero2;
    }
    public static int exponenciar(int numero1, int numero2){
        if (numero2 == 0) return 1;

        return numero1 ^ numero2;
    }

    public static void raizQuadrada(){
        // TODO Implementar algoritimo para raiz quadrada.
    }
}