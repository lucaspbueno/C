using System;

class Aula08 {
  static void Main() {

        string name;
        int value1, value2, soma;

        Console.WriteLine("Digite seu nome: "); // O m�todo WriteLine imprime valores no console.
        name = Console.ReadLine(); // O m�todo ReadLine captura valores no console e o armazena em vari�veis ou constantes.
        //Por�m, tudo que � lido e capturado pelo teclado vem em formato de string (texto),
        //ent�o para armazenarmos o valor da soma em uma vari�vel do tipo int, precisamos de converter esse valor.
        Console.WriteLine("Digite o primeiro valor:");

        // O m�todo int.Parse(), tudo que � passado para ele, para o tipo int.

        value1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite o segundo valor:");
        value2 = int.Parse(Console.ReadLine());

        soma = value1 + value2;
            
        Console.WriteLine("Ol� {0}", name);
        Console.WriteLine("O resultado da soma dos valores � {0}", soma);

  }
}