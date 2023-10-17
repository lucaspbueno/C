using System;

class ProjectForms
{

    static void Main()
    {

        // Projeto com o intuito de exercitar os conhecimentos aprendidos durante as aula 01 a 08.

        string name, lastName, fullName, job, description;
        int age;
        float size;

        Console.WriteLine("Qual o seu nome:");
        name = Console.ReadLine();

        Console.WriteLine("Qual o seu sobrenome:");
        lastName = Console.ReadLine();

        Console.WriteLine("Qual o seu emprego:");
        job = Console.ReadLine();

        Console.WriteLine("Fale sobre você:");
        description = Console.ReadLine();

        Console.WriteLine("Qual a sua idade:");
        age = int.Parse(Console.ReadLine());

        Console.WriteLine("Qual a sua altura:");
        size = float.Parse(Console.ReadLine());

        // Exibindo as informações para o usuário:

        fullName = name + " " + lastName;

        Console.WriteLine("Nome Completo: {0,15}", fullName);
        Console.WriteLine("Descrição: {0,15}", description);
        Console.WriteLine("Idade: {0,15}", age);
        Console.WriteLine("Altura: {0,15}", size);
    }
}