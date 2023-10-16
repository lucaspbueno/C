using System;

class Aula05
{
    static void Main(string[] args)
    {
        //Operador de Atribui��o
        int num = 10;

        //Operador matem�ticos b�sicos

        //Soma
        int sum = 10 + 5;
        //Subtra��o
        int sub = 10 - 5;
        //Divis�o
        int div = 10 / 5;
        //Multiplica��o
        int mult = 10 * 5;

        //Operadores relacionais // Retornam verdadeiro ou falso
        bool maior = 10 < 5; // tipo primitivo booleano, retornando o valor false
        bool menor = 10 > 5; // tipo primitivo booleano, retornando o valor true
        bool maiorOuIgual = 10 >= 5;
        bool menorOuIgual = 10 <= 5;
        bool diferente = 5 != 5; //Verifica se um valor é diferente do outro

        //Operadores de incremento e decremento
        int incremento = 10;
        incremento++; //ou
        incremento += 1;

        int decremento = 10;
        decremento--; //ou
        decremento -= 1;

        //Operadores Lógicos
        bool and = 5 > 3 && 10 > 5; //Operador E, retorna verdadeiro se todas as afirmações forem verdadeiras, se uma for false ele retorna false
        bool or = 5 < 3 | 10 > 5;  //Operador Ou, retornar verdaderio se qualquer uma das afirmações for verdadeira, independente se as outras forem falsas
    }
}