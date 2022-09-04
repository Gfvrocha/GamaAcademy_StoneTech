using Livraria;

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

var listaDeItenEmprestados = new ItensEmprestados();
var listaDeItensRarosEmprestados = new ItensRarosEmprestados();

var bibliotecaDeGibi = new Biblioteca(listaDeItenEmprestados);

var publicacao = bibliotecaDeGibi.PegarPublicacao("Ficção");
var publicacao2 =bibliotecaDeGibi.PegarPublicacao("Romance");

var bibliotecaComedia = new Biblioteca(listaDeItenEmprestados);
var publicacao3 = bibliotecaComedia.PegarPublicacao("Comédia");

var bibliotecaDeDocumentosImportantes = new Biblioteca(listaDeItensRarosEmprestados);
