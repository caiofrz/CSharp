namespace Solucao_Exercicio2
{
    class FileLogger : ILogger
    {
        public void Registrar(string mensagem)
        {
            File.WriteAllText(@"c:\dados\log\LogOcorrencias.txt", mensagem);
        }
    }
}
