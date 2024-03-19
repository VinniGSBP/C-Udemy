using Aula42;
using System;
using System.Globalization;

namespace Course {
    class Program {
        // versao atualizada do comentario aula git hub
        static void Main(string[] args) {

            Produto p = new Produto("TV", 500.00, 10);

            p.Nome = "T";
            Console.WriteLine(p.Nome);
            Console.WriteLine(p.Preco);
            Console.WriteLine(p.Quantidade);
        }
    }
}