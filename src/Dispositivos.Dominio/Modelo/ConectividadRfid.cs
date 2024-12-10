using Dispositivos.Dominio.Bases;

namespace Dispositivos.Dominio.Modelo
{
    /// <summary>
    /// Clase para almacenar los parámetros de la conectividad RFID
    /// </summary>
    public class ConectividadRfid: Entidad
    {
        /// <summary>
        /// Conectividad del dispositivo al que pertenece
        /// </summary>
        public Guid IdConectividad { get; private set; }
        /// <summary>
        /// Tipos de frecuencia que usa, por ejemplo LF, HF, UHF
        /// </summary>
        public string? TipoRfid { get; private set; }
        /// <summary>
        /// Identificador único (desconozco ahora mismo si es un GUID)
        /// </summary>
        public string? Uid { get; private set; }
    }
}
