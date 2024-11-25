namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
   
    public class Nokia : Smartphone
    {
        private String modelo2;
        public Nokia(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
            modelo2 = modelo;
        }

        // TODO: Sobrescrever o método "InstalarAplicativo"


        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando o aplicativo {nomeApp} no {modelo2}");
        }
    }
}