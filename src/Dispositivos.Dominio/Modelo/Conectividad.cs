using Dispositivos.Dominio.Bases;

namespace Dispositivos.Dominio.Modelo
{
    public class Conectividad : Entidad
    {
        public TipoConectividad? Tipo { get; private set; }
        public Guid IdDispositivo { get; private set; }
    }
}
