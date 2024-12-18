using Dispositivos.Dominio.Bases;

namespace Dispositivos.Dominio.Modelo
{
    public class Compra(string tienda, DateTime fecha, decimal precio) : ObjetoValor<Compra>
    {
        public string Tienda { get; private set; } = tienda;
        public DateTime? Fecha { get; private set; } = fecha;
        public decimal? Precio { get; private set; } = precio;

        public override IEnumerable<object> GetEqualityComponents()
        {
            yield return Tienda;
            yield return Fecha??default;
            yield return Precio??default;
        }
    }
}
