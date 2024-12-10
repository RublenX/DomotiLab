using Dispositivos.Dominio.Bases;

namespace Dispositivos.Dominio.Modelo
{
    /// <summary>
    /// Esta clase pertenece a una tabla fija cacheada, pudiendo tener los valores de Bluetooth, WIFI, Ethernet, NFC, RFIC, etc... puede tener su CRUD pero su modificación será rara
    /// </summary>
    public class TipoConectividad : Entidad
    {
        /// <summary>
        /// Nombre del tipo de conexión
        /// </summary>
        public string? Nombre { get; private set; }
        /// <summary>
        /// Descripción con los detalles que se quiera incorporar, como parametrización o porqué se ha incluido
        /// </summary>
        public string? Descripcion { get; private set; }
    }
}