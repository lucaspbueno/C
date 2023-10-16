using System;

class Aula06
{

    static void Main()
    {

        int n1, n2, n3;
        n1 = 10;
        n2 = 20;
        n3 = 30;

        //Imprimindo variáveis através dos índices
        Console.WriteLine("N1 é igual a \t{0}\nN2 é igual a \t{1}\nN3 é igual a \t{1}", n1, n2, n3);
        //O \n representa a tecla ENTER, então onde ele estiver vai quebrar a linha e continuar o texto na linha de baixo
        //O \t reprensenta o TAB, então onde ele estiver vai dar um espaço no conteúdo

        double valorCompra = 5.5;
        double valorVenda;
        double lucro = 0.1;
        string produto = "Pastel";

        valorVenda = valorCompra * lucro;

        Console.WriteLine("Produto.....:{0,15}", produto); //0.15 representa o espaçamento que será aplicado em relação ao elemento entre parênteses nesse caso o produto
        Console.WriteLine("Valor de Compra.....:{0,15:c}", valorCompra); //Para indicar que quero formatar o valor para um formato monetário. já adicionando o R$ 
        Console.WriteLine("Lucro.....:{0,15:p}", lucro);  //Para indicar que é um valor em porcentagem, e adiciona % ao valor
        Console.WriteLine("Valor de Venda.....:{0,15:c}", valorVenda);
    }
}