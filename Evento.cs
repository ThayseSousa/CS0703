using CSharp0703.Exercício;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp0703
{
    class Evento
    {
        public void Executa()
        {
            Televisao tv = new Televisao();
            tv.Ligada += Aviso1;
            tv.Ligada += Aviso2; //atribuindo
            Console.WriteLine("Ligando a TV");
            tv.Ligar();
            tv.Ligada -= Aviso1; //cancelando atribuição
            Console.WriteLine("Ligando a TV novamente");
            tv.Ligar();
            Console.WriteLine("Mudando o canal da TV");
            //tv.MudouCanal += Aviso1Canal;
            //tv.MudarCanal;
            Console.WriteLine("Desligando a TV");
            tv.Desligada += Aviso1Desligada;
            tv.Desligar("TV1");
            //tv.Desligada(this, new EventArgs()); //usando o event não deixa que a gente chame o evento, ela s´vai ser chamada atraves da classe

        }  
        private void Aviso1()
        {
            Console.WriteLine("Foi executado aviso 1");
        }

        private void Aviso2()
        {
            Console.WriteLine("Foi executado aviso 2");
        }

        private void Aviso1Desligada(object sender, TelevisaoEventArgs args)
        {
            Console.WriteLine($"Foi executado aviso 1 de Desligar {args.Nome}");
        }

        private void Aviso1Canal(object sender, EventHandler args)
        {
            Console.WriteLine("Foi executado aviso 1 mudou canal");
        }
    }
}
