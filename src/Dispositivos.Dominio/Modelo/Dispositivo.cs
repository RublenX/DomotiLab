using Dispositivos.Dominio.Bases;

namespace Dispositivos.Dominio.Modelo
{
    public class Dispositivo(string marca, string modelo, string version, Compra compra, IEnumerable<Conectividad> conectividades) : Entidad
    {
        public string Marca { get; private set; } = marca;
        public string Modelo { get; private set; } = modelo;
        public string Version { get; private set; } = version;
        public Compra Compra { get; private set; } = compra;
        public IEnumerable<Conectividad> Conectividades { get; private set; } = conectividades;

        // Métodos para mantener la consistencia del agregado
        public void EstablecerCompra(Compra compra)
        {
            if (!Compra.Equals(compra))
            {
                Compra = compra;
                base.UpdatedAt = DateTime.Now;
            }
        }
    }


}
