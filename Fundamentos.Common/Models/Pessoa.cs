using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fundamentos.Common.Models
{
    /// <summary>
    /// Representa uma pessoa física, passe como parâmetro "nome", idade
    /// </summary>
    public class Pessoa
    {
        public string Nome { get; private set; }
        public int Idade { get; set; }
        public bool EstaCorrendo { get; private set; }
        public DateTime Data { get; private set; }
        public Pessoa(string nome, int idade)
        {
            Nome = nome;
            Idade = idade;
            EstaCorrendo = false; // Não precisava declarar, por padrão é falso
        }

        /// <summary>
        /// Faz a pessoa correr
        /// </summary>
        public void Correr()
        {
            if(EstaCorrendo)
            {
                Console.WriteLine($"{Nome} já está Correndo..");
            }
            else
            {
                Data = DateTime.Now;
                Console.WriteLine($"Vou correr para me preparar para o TAF. Vou marcar o tempo. A data e hora atual é: {Data.ToString("dd/MM/yyy HH:mm")}");
                EstaCorrendo = true;
            }
            Thread.Sleep(2000); // Pausa de 2 segundo
        }

        /// <summary>
        /// Faz a pessoa parar de correr
        /// </summary>
        public void Parar()
        {
            if(EstaCorrendo)
            {
                Data = Data.AddHours(3).AddMinutes(12);
                Console.WriteLine($"Cansei de correr, vou parar um pouco. Já são {Data.ToString("HH:mm")}.. Corri por mais de 3 horas!");
                EstaCorrendo = false;
            }
            else
            {
                Console.WriteLine($"{Nome} não está correndo..");
            }
            Thread.Sleep(2000); // Pausa de 2 segundo
        }


        /// <summary>
        /// Faz a pessoa se apresentar
        /// </summary>
        public void Apresentar()
        {
            if (EstaCorrendo)
            {
                Console.WriteLine("Olá, quem é você?");
                Thread.Sleep(1000); // Pausa de 1 segundo
                Console.WriteLine("Estou Ocupada. Estou correndo...");
            }
            else
            {
                Console.WriteLine("Olá, quem é você?");
                Thread.Sleep(1000); // Pausa de 1 segundo
                Console.WriteLine($"Olá, meu nome é {Nome}, e tenho {Idade} anos");
            }
            Thread.Sleep(2000); // Pausa de 2 segundo
            
        }
    }
}