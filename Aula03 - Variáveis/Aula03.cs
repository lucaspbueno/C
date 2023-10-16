// Declaração e tipos de variáveis
using System;

class Aula03
{
    static void Main()
    {
        // Primeiro o tipo depois o nome

        //Posso declarar multiplas variáveis na mesma linha
        int n1 = 1, n2;
        n2 = 2;

        // Pode declarar uma variável sem atribuir valor a ela 
        int num;
        num = 0;
        // Declarando uma variável atribuindo valor a ela 
        int age = 18; //Inteiro, pode receber valores negativos e positivos
        byte n3 = 1;  //Só numeros positivos, não aceita sinais, vai de 0 a 255
        float valor = 5.3f; //Números com vírgula, usa-se o f no final para indicar que é um float
        char letra = 'A'; //Caracter, usa aspas simples, pode armazenar apenas 1 caracter
        string nome = "lucas"; //Conjunto de caracteres, utiliza as aspas duplas


        var aux = 10; //Quando uso o operador var estou dizendo que não estou especificando o tipo da variável
                      //em sua declaração, ela recebe um tipo apenas no ato de atribuição e não na declaração.

        //Não é aconselhavel mudar o tipo da variável var posteriormente, uma vez atribuído tipo a ela, ela deve
        //permanecer com esse tipo

        var test = nome;
        //Teste no processo de compilação, será do tipo string, com o valor da vaiável nome, no caso Lucas
        Console.WriteLine(n1);
        Console.WriteLine(n2);
        Console.WriteLine(num);
        Console.WriteLine(age);
        Console.WriteLine(n3);
        Console.WriteLine(valor);
        Console.WriteLine(letra);
        Console.WriteLine(nome);
        Console.WriteLine(aux);

    }
}