using atividade.ativiade_3;
using atividade.atividade_1;
using atividade.atividade_2;
using atividade.atividade_4;
using atividade.atividade_5;
using atividade.atividade_6;
using atividade.atividade_7;
using atividade.atividade_8;
using atividade.atividade_9;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace atividade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ex1
            //Escola.DescobrirNome();

            //Sesi sesi = new Sesi();
            //sesi.CalcularMedia();

            //Senai senai = new Senai();
            //senai.CalcularMedia();

            ////ex2
            //Desenvolvedor desenvolvedor = new Desenvolvedor();
            //desenvolvedor.CalcularHorasExtras();

            //Bancario bancario = new Bancario();
            //bancario.CalcularHorasExtras();

            //GerenteTI gerenteTI = new GerenteTI();
            //gerenteTI.CalcularHorasExtras();

            //ex3
            //Estudante estudante = new Estudante();
            //Projeto projeto = new Projeto();
            //projeto.EscolherProfissão();

            //ex 4
            //DigitarInformacaoes();

            //ex5
            Empresario empresario = new Empresario();

            empresario.nome = "Gustavo";
            empresario.cnpj = "10001";
            empresario.endereco = "AV Paineiras";
            empresario.cidade = "Garça";
            empresario.nomeEmpresa = "Nissan";

            Json();

            //ex6
            Losangulo losangulo = new Losangulo();
            Retangulo retangulo = new Retangulo();
            losangulo.CalcArea();
            retangulo.CalcArea();

            //ex7
            Animal();

            //ex8
            Midia midia = new Midia();

            midia.ImprimirDados();

            Dvd dvd = new Dvd();

            dvd.filme = 4;
            dvd.VerFilmes();

            Console.WriteLine(dvd.filme);

            Usb usb = new Usb();

            usb.musicas = 1;
            usb.CapacidadeArmazenamento = "Caben 2000 musicas em 1 dvd de 8GB";
            usb.LerMusicas();

            Console.WriteLine(usb.musicas);
            Console.WriteLine(usb.CapacidadeArmazenamento);

            //ex9
            Console.Write("Digite o valor a ser depositado: ");
            double depositValue = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite o valor a ser sacado: ");
            double saqueValue = Convert.ToDouble(Console.ReadLine());

            ContaBancaria contaBancaria = new ContaBancaria();
            contaBancaria.Depositar(depositValue);
            contaBancaria.Sacar(saqueValue);
        }

        public static void DigitarInformacaoes()
        {
            Console.WriteLine("Digite o seu nome");
            string nome = Console.ReadLine();
            Console.WriteLine("Digite a sua idade");
            int Idade = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite a sua cidade");
            string Cidade = Console.ReadLine();
            Console.WriteLine("Digite o seu rg");
            string rg = Console.ReadLine();
            Console.WriteLine("Digite a sua área");
            string area = Console.ReadLine();
            Programador programador = new Programador();
            programador.nome = nome;
            programador.idade = Idade;
            programador.cidade = Cidade;
            programador.rg = rg;
            programador.area = area;

            string JsonString = JsonConvert.SerializeObject(programador, Formatting.Indented);
            dynamic stringJson = JsonConvert.DeserializeObject(JsonString);

            File.WriteAllText("text.json", JsonString);
            string text = File.ReadAllText("atividade_4.json");
            Console.WriteLine(text);
        }
        public static void Animal()
        {
            Console.WriteLine("Digite o nome do seu pet");
            string nome = Console.ReadLine();
            Console.WriteLine("Digite a idade do seu pet");
            int idade = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(nome + " " + idade);
            Animal animal = new Animal();
            animal.Nome = nome;
            animal.Idade = idade;


            string JsonString = JsonConvert.SerializeObject(animal, Formatting.Indented);
            dynamic stringJson = JsonConvert.DeserializeObject(JsonString);

            File.WriteAllText("animal.test", JsonString);
            string text = File.ReadAllText("animal.test");
            Console.WriteLine(text);
        }
        public void Definir()
        {

        }

        public static void Json()
        {
            Empresario empresario = new Empresario();
            empresario.nome = "Astolfo";
            empresario.idade = 16;
            empresario.nomeEmpresa = "Microsoft";
            empresario.cidade = "Marilia";

            Empresario empresario1 = new Empresario
            {
                nome = "Leonardo",
                idade = 27,
                nomeEmpresa = "BobSoft",
                cidade = "Jafa",
            };

            Empresario empresario2 = new Empresario
            {
                nome = "Wallace",
                idade = 27,
                nomeEmpresa = "Sony",
                cidade = "Jafa",
            };

            Empresario empresario3 = new Empresario
            {
                nome = "Bill Gates",
                idade = 27,
                nomeEmpresa = "Apple",
                cidade = "Jafa",
            };


            string Jsonstring = JsonConvert.SerializeObject(empresario);
            string Jsonstring1 = JsonConvert.SerializeObject(empresario1);
            string Jsonstring2 = JsonConvert.SerializeObject(empresario2);
            string jsonString3 = JsonConvert.SerializeObject(empresario3);

            Console.WriteLine(empresario.nome);
            Console.WriteLine(empresario.idade);
            Console.WriteLine(empresario.nomeEmpresa);
            Console.WriteLine(empresario.cidade);

            Console.WriteLine(empresario1.nome);
            Console.WriteLine(empresario1.idade);
            Console.WriteLine(empresario1.nomeEmpresa);
            Console.WriteLine(empresario1.cidade);

            Console.WriteLine(empresario2.nome);
            Console.WriteLine(empresario2.idade);
            Console.WriteLine(empresario2.nomeEmpresa);
            Console.WriteLine(empresario2.cidade);

            Console.WriteLine(empresario3.nome);
            Console.WriteLine(empresario3.idade);
            Console.WriteLine(empresario3.nomeEmpresa);
            Console.WriteLine(empresario3.cidade);

            File.WriteAllText("Gustavo.json", Jsonstring + Jsonstring1 + Jsonstring2 + jsonString3);
            string text = File.ReadAllText("text.json");
            Console.WriteLine(text);


        }
    }
}
