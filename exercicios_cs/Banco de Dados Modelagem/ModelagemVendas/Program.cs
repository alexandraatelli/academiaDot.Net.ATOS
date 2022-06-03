﻿/*Modelagem Lógica do Sistema de Vendas:

Cliente(codCliente, nome, rua, numero, complemento, ep, cidade, estado, fone)
	codCliente é chave primária

Vendedor(codVendedor, nome, fone, senha)
	codVendedor é chave primária

Prateleira(codPrateleira, localizacao)
	codPrateleira é chave primária

Produto(codProduto, codigoBarras, descricao, codPrateleira)
	codProduto é chave primária
    codPrateleira referencia Prateleira

Venda(numeroNotaFiscal, dataNotafiscal, codProduto, codVendedor, codCliente)
	numeroNotaFiscal é chave primária
    codProduto referencia Produto
    codVendedor referencia Vendedor
    codCliente referencia Cliente

Entidade = classe
Atributo/Coluna se for uma chave estrangeira, no diagrama fica subentendido Relacionamento indica quem visita quem (chave primária visita outra entidade  como chave estrangeira)
    -Uma chave estrangeira deve ser uma chave primária na sua entidade/classe de origem;
Cardinalidade: mostra como se dará a visita (quem terá a chave estrangeira)


Cliente 0..n---------- - 1..n Produto->cardinalidade n x n, gera uma nova tabela de venda
Vendedor 1..n ---------- 1..n Cliente -> cardinalidade n x n, gera uma nova tabela de Venda
Vendedor 0..n ----------- 1..n Produto -> cardinalidade n x n, gera uma nova tabela de Venda
Produto 0..n ----------- 1..1 Prateleira -> cardinalidade 1 x n leva chave estrangeira para o lado do n.*/

public class Cliente
{
	int codCliente;
	string nomeCliente;
	string enderecoCliente;
	int numeroEnderCliente;
	string complementoEnderCliente;
	string cepCliente;
	string cidadeCliente;
	string estadoCliente;
	string foneCliente;

	// propriedade

	// Get/Set
}

public class Vendedor
{
	int codVendedor;
	string nomeVendedor;
	string foneVendedor;
	string senhaCliente;

	// propriedade

	// Get/Set
}

public class Prateleira
{
	int codPrateleira;
	string localizacao;

	// propriedade

	// Get/Set
}

public class Produto
{
	int codProduto;
	int codBarra;
	string descricao;
	Prateleira prateleira;

	// propriedade

	// Get/Set
}
public class Venda
{
	int numeroNotaFiscal;
	DateTime dataNotafiscal;
	Produto Produto;
	Vendedor vendedor;
	Cliente cliente;

	// propriedade

	// Get/Set
}
