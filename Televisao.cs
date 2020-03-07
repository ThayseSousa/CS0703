using CSharp0703.Exercício;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp0703
{
    public class Televisao
    {

        public Action Ligada { get; set; }

        public  EventHandler MudouCanal { get; set; }

        public event EventHandler<TelevisaoEventArgs> Desligada;

        public void Ligar()
        {
            if (Ligada != null)
                Ligada(); //executar o evento
            
        }

        public void Desligar(string nome)
        {
            if (Desligada != null)
                Desligada(this, new TelevisaoEventArgs(nome)); //necessario informar quem esta chamando e oq vai acontecer 

        }

        public void MudarCanal()
        {
            if (MudouCanal != null)
                MudouCanal(this, new EventArgs()); //necessario informar quem esta chamando e oq vai acontecer 

        }

    }
}
