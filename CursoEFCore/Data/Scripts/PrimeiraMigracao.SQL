CREATE TABLE IF NOT EXISTS "__EFMigrationsHistory" (
    "MigrationId" TEXT NOT NULL CONSTRAINT "PK___EFMigrationsHistory" PRIMARY KEY,
    "ProductVersion" TEXT NOT NULL
);

BEGIN TRANSACTION;

CREATE TABLE "clientes" (
    "Id" INTEGER NOT NULL CONSTRAINT "PK_clientes" PRIMARY KEY AUTOINCREMENT,
    "Nome" TEXT NOT NULL,
    "Fone" TEXT NOT NULL,
    "Cidade" TEXT NOT NULL,
    "Estado" TEXT NOT NULL,
    "CEP" TEXT NOT NULL
);

CREATE TABLE "Produto" (
    "Id" INTEGER NOT NULL CONSTRAINT "PK_Produto" PRIMARY KEY AUTOINCREMENT,
    "CodigoBarras" TEXT NOT NULL,
    "Descricao" TEXT NOT NULL,
    "Valor" TEXT NOT NULL,
    "TipoProduto" INTEGER NOT NULL,
    "Ativos" INTEGER NOT NULL
);

CREATE TABLE "Pedidos" (
    "Id" INTEGER NOT NULL CONSTRAINT "PK_Pedidos" PRIMARY KEY AUTOINCREMENT,
    "ClienteId" INTEGER NOT NULL,
    "IniciadoEm" TEXT NOT NULL,
    "FinalizadoEm" TEXT NOT NULL,
    "TipoFrete" INTEGER NOT NULL,
    "StatusPedido" INTEGER NOT NULL,
    "Observacao" TEXT NOT NULL,
    CONSTRAINT "FK_Pedidos_clientes_ClienteId" FOREIGN KEY ("ClienteId") REFERENCES "clientes" ("Id") ON DELETE CASCADE
);

CREATE TABLE "PedidoItem" (
    "Id" INTEGER NOT NULL CONSTRAINT "PK_PedidoItem" PRIMARY KEY AUTOINCREMENT,
    "PedidoId" INTEGER NOT NULL,
    "ProdutoId" INTEGER NOT NULL,
    "Quantidade" INTEGER NOT NULL,
    "Valor" TEXT NOT NULL,
    "Desconto" TEXT NOT NULL,
    CONSTRAINT "FK_PedidoItem_Pedidos_PedidoId" FOREIGN KEY ("PedidoId") REFERENCES "Pedidos" ("Id") ON DELETE CASCADE,
    CONSTRAINT "FK_PedidoItem_Produto_ProdutoId" FOREIGN KEY ("ProdutoId") REFERENCES "Produto" ("Id") ON DELETE CASCADE
);

CREATE INDEX "IX_PedidoItem_PedidoId" ON "PedidoItem" ("PedidoId");

CREATE INDEX "IX_PedidoItem_ProdutoId" ON "PedidoItem" ("ProdutoId");

CREATE INDEX "IX_Pedidos_ClienteId" ON "Pedidos" ("ClienteId");

INSERT INTO "__EFMigrationsHistory" ("MigrationId", "ProductVersion")
VALUES ('20240706210528_PrimeiraMigracao', '8.0.6');

COMMIT;

