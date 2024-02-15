namespace DesafioPOO.Models
{
    // Implementado!!
    public class Iphone : Smartphone
    {
       public Iphone(string numero,string modelo,string imei,int memoria):base(numero,modelo,imei,memoria)
        {
            
        }
        // Implementado!!
        public override void InstalarAplicativo(string nomeApp)
        {
            System.Console.WriteLine($"Instalando o Aplicativo: ''{nomeApp}'' No Iphone");
        }
    }
}