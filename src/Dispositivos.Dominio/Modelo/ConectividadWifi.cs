using Dispositivos.Dominio.Bases;

namespace Dispositivos.Dominio.Modelo
{
    /// <summary>
    /// Clase para almacenar los parámetros de la conectividad Wifi
    /// </summary>
    public class ConectividadWifi : Entidad
    {
        /// <summary>
        /// Conectividad del dispositivo al que pertenece
        /// </summary>
        public Guid IdConectividad { get; private set; }
        /// <summary>
        /// Nombre de la red Wifi a la que está conectada
        /// </summary>
        public string? NombreSsid { get; private set; }
        /// <summary>
        /// Dirección IP ya sea la versión 4 o la 6
        /// </summary>
        public string? DireccionIp { get; private set; }
        /// <summary>
        ///  Dirección MAC del dispositivo
        /// </summary>
        public string? DireccionMac { get; private set; }
        /// <summary>
        /// Tipos de redes Wifi que soporta
        /// </summary>
        public string? WifisSoportadas { get; private set; }

    }
}
