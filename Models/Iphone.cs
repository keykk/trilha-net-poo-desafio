namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Iphone : Smartphone
    {
        private String modelo2;
        public Iphone(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
            modelo2 = modelo;
        }

        // TODO: Sobrescrever o método "InstalarAplicativo"
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"[{modelo2}]: Promoção, pague apenas R$ 10.000,50 para instalar o aplicativo {nomeApp}, também aceitamos o rim como entrada.");
        }
    }
}