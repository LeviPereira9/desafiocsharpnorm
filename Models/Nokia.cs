namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Nokia : Smartphone
    {

        
        public Nokia(string numero, string modelo, string imei) : base(numero, modelo, imei)
        {
        }

        // TODO: Sobrescrever o método "InstalarAplicativo"
        public override void InstalarAplicativo(string nomeApp)
        {
            aplicativos.Add(nomeApp);
        }
    }
}