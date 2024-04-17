using System;

class Program {
  public static void Main (string[] args) {
    // Exercício 1 -----------------------------------
    // Escreva um programa que leia o código de um determinado produto e mostre a sua classificação. Utilize a tabela abaixo como referência:(Código – Descrição)
    // 1 – Alimento não-perecível
    // 2 – Alimento perecível
    // 3 – Vestuário
    // 4 – Limpeza
    // 5 – Cosmético

    int codigo = Convert.ToInt32(Console.ReadLine());

    switch(codigo){
    case 1:
      Console.WriteLine("Alimento não-perecível");
      break;
    case 2:
      Console.WriteLine("Alimento perecível");
      break;
    case 3:
      Console.WriteLine("Vestuário");
      break;
    case 4:
      Console.WriteLine("Limpeza");
      break;
    case 5:
      Console.WriteLine("Cosmético");
      break;
    default:
      Console.WriteLine("Código não encontrado");
      break;
    }


  }
}