using System;
using System.Diagnostics;
using Desafio.Models;

// Coloca o encoding para UTF8 para exibir acentuação
Console.OutputEncoding = System.Text.Encoding.UTF8;

decimal precoInicial = 0;
decimal precoPorHora = 0;

Console.WriteLine("Bem Vindo ao menu De Gerenciamento do estacionamento\n" + "Digite o Valor Do Preço Inicial");
precoInicial = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Agora Digite o Preço por hora.");
precoPorHora = Convert.ToDecimal(Console.ReadLine());


Estacionamento estacionamento = new Estacionamento(precoInicial, precoPorHora);


string opcao = string.Empty;

bool exibirMenu = true;

while (exibirMenu)
{
  Console.Clear();
  Console.WriteLine("1 - Cadastrar Veiculos");
  Console.WriteLine("2 - Remover Veiculos");
  Console.WriteLine("3 - Lista de Veiculo");
  Console.WriteLine("4 - Encerrar");

    switch(Console.ReadLine())
  {
    case "1" :
      estacionamento.AdicionarVeiculo();
      break;
    
    case "2" :
      estacionamento.RemoverVeiculo();
      break;
    case "3" :
      estacionamento.ListarVeiculos();
      break;
    case "4" :
      exibirMenu = false;
      break;
    default:
      Console.WriteLine("Opçao Invalida");
      break;
  }
  Console.WriteLine("Pressione uma tecla para continuar");
  Console.ReadLine();
}
Console.WriteLine("O programa se encerrou");