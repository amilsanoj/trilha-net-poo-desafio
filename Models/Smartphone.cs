using System.Reflection.Emit;

namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        private string modelo;
        private string imei;
        private int memoria;

        public string Numero { get; set; }


        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            this.modelo = modelo;
            this.imei = imei;
            this.memoria = memoria;
        }

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public abstract void InstalarAplicativo(string nomeApp);

        public override string ToString()
        {
            return $"Os dados do telefone são:\nModelo:{modelo}\nNúmero:{Numero}\nIMEI:{imei}\nMemória:{memoria}GB\n";
        }
    }
}