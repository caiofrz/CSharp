namespace Solucao_Exercicio3
{
    interface ICalcularImpostoPais
    {
        decimal TotalRenda{ get; set; }
        decimal TotalDeducao { get; set; }
        decimal CalcularValorImposto();
    }
}
