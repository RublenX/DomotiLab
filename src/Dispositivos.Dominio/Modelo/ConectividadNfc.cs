using Dispositivos.Dominio.Bases;

namespace Dispositivos.Dominio.Modelo
{
    /// <summary>
    /// Clase para almacenar los parámetros de la conectividad NFC
    /// </summary>
    public class ConectividadNfc: Entidad
    {
        /// <summary>
        /// Conectividad del dispositivo al que pertenece
        /// </summary>
        public Guid IdConectividad { get; private set; }
        /// <summary>
        /// Por ejemplo Type A, Type B, FeliCa
        /// </summary>
        public string? TipoNfc { get; private set; }
        /// <summary>
        /// Identificador único (desconozco ahora mismo si es un GUID)
        /// </summary>
        public string? Uid { get; private set; }
    }
}
