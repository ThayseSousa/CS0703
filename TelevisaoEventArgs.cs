using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp0703.Exercício
{
    public class TelevisaoEventArgs : EventArgs
    {
        public TelevisaoEventArgs(string nome)
        {
            Nome = nome;
        }

        public string Nome { get; } //selecionar toda a linha e dar ctrl + . para gerar o contrutor automaticamente
    }
}
