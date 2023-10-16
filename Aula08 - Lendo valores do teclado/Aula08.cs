using System;

class Aula08 {
  static void Main() {

        string name;
        int value1, value2, soma;

        Console.WriteLine("Digite seu nome: "); // O método WriteLine imprime valores no console.
        name = Console.ReadLine(); // O método ReadLine captura valores no console e o armazena em variáveis ou constantes.
        //Porém, tudo que é lido e capturado pelo teclado vem em formato de string (texto),
        //então para armazenarmos o valor da soma em uma variável do tipo int, precisamos de converter esse valor.
        Console.WriteLine("Digite o primeiro valor:");

        // O método int.Parse(), tudo que é passado para ele, para o tipo int.

        value1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite o segundo valor:");
        value2 = int.Parse(Console.ReadLine());

        soma = value1 + value2;
            
        Console.WriteLine("Olá {0}", name);
        Console.WriteLine("O resultado da soma dos valores é {0}", soma);

  }
}