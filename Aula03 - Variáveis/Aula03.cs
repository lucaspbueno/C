// Declara��o e tipos de vari�veis
using System;

class Aula03
{
    static void Main()
    {
        // Primeiro o tipo depois o nome

        //Posso declarar multiplas vari�veis na mesma linha
        int n1 = 1, n2;
        n2 = 2;

        // Pode declarar uma vari�vel sem atribuir valor a ela 
        int num;
        num = 0;
        // Declarando uma vari�vel atribuindo valor a ela 
        int age = 18; //Inteiro, pode receber valores negativos e positivos
        byte n3 = 1;  //S� numeros positivos, n�o aceita sinais, vai de 0 a 255
        float valor = 5.3f; //N�meros com v�rgula, usa-se o f no final para indicar que � um float
        char letra = 'A'; //Caracter, usa aspas simples, pode armazenar apenas 1 caracter
        string nome = "lucas"; //Conjunto de caracteres, utiliza as aspas duplas


        var aux = 10; //Quando uso o operador var estou dizendo que n�o estou especificando o tipo da vari�vel
                      //em sua declara��o, ela recebe um tipo apenas no ato de atribui��o e n�o na declara��o.

        //N�o � aconselhavel mudar o tipo da vari�vel var posteriormente, uma vez atribu�do tipo a ela, ela deve
        //permanecer com esse tipo

        var test = nome;
        //Teste no processo de compila��o, ser� do tipo string, com o valor da vai�vel nome, no caso Lucas
        Console.WriteLine(n1);
        Console.WriteLine(n2);
        Console.WriteLine(num);
        Console.WriteLine(age);
        Console.WriteLine(n3);
        Console.WriteLine(valor);
        Console.WriteLine(letra);
        Console.WriteLine(nome);
        Console.WriteLine(test);
        Console.WriteLine(aux);

    }
}