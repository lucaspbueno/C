using System;

class Aula04 {
    //Variáveis Globais
    static int num = 10;

    static void Main(string[] args){
        //Variáveis só podem ser acessadas dentro do escopo em que foram declaradas.
        int num2 = 20;
        Console.WriteLine(num);
        Console.WriteLine("Main " + num);
    }
    static void Teste(){
        int num3 = 50;
        Console.WriteLine("Teste " + num);
        //Esse código abaixo vai dar um erro
        //Console.WriteLine(num2);
    }
}