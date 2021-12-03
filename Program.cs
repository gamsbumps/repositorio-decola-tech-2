using System;
using Classe;
using Interface;
using Enum;

namespace CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var pessoa = (Pessoas)0;
            Pessoas pessoa2 = Pessoas.Amanda;
            Pessoas pessoa3 = (Pessoas)4;


            Pessoa person = new Pessoa();

            person.Nome = "Guilherme";
            person.Idade = 27;
            person.Estado = "PE";

            Pessoa person2 = new Pessoa();

            person2.Nome = "Amanda";
            person2.Idade = 27;
            person2.Estado = "PE";

            Animal animal = new Animal();

            animal.Nome = "Luna";
            animal.Dono = "Guilherme";
            animal.Especie = "Cachorro";

            Console.WriteLine(pessoa3);
        }
    }
}