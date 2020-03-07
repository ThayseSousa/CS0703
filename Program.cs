using CSharp0703.Exercício;
using CSharp0703.Exercicio2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp0703
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Exercicio1
            //Criar uma classe Alarme
            //Criar a propriedade action para identificar o alarme disparado
            //Criar metodo para disparar Alarme
            //Criar objeto da classe Alarme
            //Criar 2 metodos que 'escutarão' o evento de alarme

            //Eventos2 eventos = new Eventos2();
            //eventos.Executa();

            //Exercicio2
            //Criar uma Classe Pessoa, nome e sobrenome
            //Criar uma Classe Derivada de EventArgs, contendo 3 propriedades:
            //     1 - Mensagem
            //     2 - Remetente
            //     3 - Destinatario
            //Criar uma Classe Chat que contenha
            //propriedade do tipo EventHandler  usando a classe Derivada
            //Metodo enviar mensagem com Remetente, Destinatario e Msg
            //Criar uma instancia da classe chat, assinar o evento de mensagem
            //e enviar uma mensagem

            Event @event = new Event();
            @event.Executa();

            Console.ReadKey();

        }
        
    }
}
