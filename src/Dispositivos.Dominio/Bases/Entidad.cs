namespace Dispositivos.Dominio.Bases
{
    public abstract class Entidad
    {
        Guid id;

        public virtual Guid Id
        {
            get { return id; }
            protected set { id = value; }
        }

        /// <summary>
        /// Columna de mantenimiento para fijar la creación del registro
        /// </summary>
        public DateTime CreatedAt { get; private set; } = DateTime.Now;
        /// <summary>
        /// Columna de mantenimiento para registrar la fecha de modificación
        /// </summary>
        public DateTime UpdatedAt { get; internal set; } = DateTime.Now;
    }
}
