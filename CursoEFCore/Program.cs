using CursoEFCore.Data;
using CursoEFCore.Domain;
using CursoEFCore.ValueObjects;
using Microsoft.EntityFrameworkCore;

// InserirDados();
// InserirDadosEmMassa();
// ConsultarDados();
// AtualizarDados();
RemoverRegistro();


static void InserirDados()
{
    var produto = new Produto
    {
        Descricao = "Produto teste",
        CodigoBarras = "1234567891234",
        Valor = 10m,
        TipoProduto = TipoProdutoEnum.Bebida,
        Ativos = true
    };

    var dbContext = new ApplicationContext();
    dbContext.Produtos.Add(produto);
    // dbContext.Set<Produto>().Add(produto);
    // dbContext.Entry(produto).State = EntityState.Added;
    // dbContext.Add(produto);

    var registros = dbContext.SaveChanges();
    Console.WriteLine($"Registros: {registros}");
}

static void InserirDadosEmMassa()
{
    var produto = new Produto
    {
        Descricao = "Produto teste",
        CodigoBarras = "1234567891234",
        Valor = 10m,
        TipoProduto = TipoProdutoEnum.Bebida,
        Ativos = true
    };

    var cliente = new Cliente
    {
        Nome = "Caio",
        CEP = "39999999",
        Cidade = "CIDADE",
        Estado = "MG",
        Telefone = "99999999999"
    };

    var dbContext = new ApplicationContext();
    dbContext.AddRange(produto, cliente);

    var registros = dbContext.SaveChanges();
    Console.WriteLine($"Registros: {registros}");
}

static void ConsultarDados()
{
    var dbContext = new ApplicationContext();
    // var registros = (from c in dbContext.Clientes where c.Id > 0 select c).ToList();
    var registros = dbContext.Clientes
    .Where(cliente => cliente.Id > 0)
    .ToList();

    Console.WriteLine($"Registros: {registros}");
}

static void AtualizarDados()
{
    var dbContext = new ApplicationContext();

    var cliente = dbContext.Clientes.Find(1);
    cliente.Nome = "Teste";

    // Update() força a atualização de todos os campos
    // dbContext.Clientes.Update(cliente);
    dbContext.SaveChanges();
}

static void RemoverRegistro()
{
    var dbContext = new ApplicationContext();

    var cliente = dbContext.Clientes.Find(1);

    // dbContext.Clientes.Remove(cliente);
    // dbContext.Remove(cliente);
    dbContext.Entry(cliente).State = EntityState.Deleted;

    dbContext.SaveChanges();
}