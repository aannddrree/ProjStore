// See https://aka.ms/new-console-template for more information
using Controllers;
using Models;

Console.WriteLine("Projeto Loja");

var data = new Store()
{
    Description = "Teste",
    Address = "Rua do alem"
};

string returnInformation = (new StoreController().Insert(data) ? "Inserido" : "Erro");
Console.WriteLine(returnInformation);

new StoreController().GetAll().ForEach(x => Console.WriteLine(x));
