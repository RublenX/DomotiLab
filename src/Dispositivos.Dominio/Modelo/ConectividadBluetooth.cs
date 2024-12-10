using Dispositivos.Dominio.Bases;

namespace Dispositivos.Dominio.Modelo
{
    /// <summary>
    /// Clase para almacenar los parámetros de la conectividad Bluetooth
    /// </summary>
    public class ConectividadBluetooth : Entidad
    {
        /// <summary>
        /// Conectividad del dispositivo al que pertenece
        /// </summary>
        public Guid IdConectividad { get; private set; }
        /// <summary>
        /// Nombre público con el que se puede encontrar
        /// </summary>
        public string? NombreCompartido { get; private set; }
        /// <summary>
        ///  Dirección MAC del dispositivo
        /// </summary>
        public string? DireccionMac { get; private set; }
        /// <summary>
        /// Versión compatible de Bluetooth
        /// </summary>
        public string? VersionBluetooth { get; private set; }
    }
}
