namespace Dispositivos.Dominio.Bases
{
    public abstract class ObjetoValor<T> : IEquatable<T> where T : ObjetoValor<T>
    {
        public abstract IEnumerable<object> GetEqualityComponents();

        public bool Equals(T? other)
        {
            if (other == null)
                return false;

            return GetEqualityComponents().SequenceEqual(other.GetEqualityComponents());
        }

        public override bool Equals(object? obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;

            return Equals((T)obj);
        }

        public override int GetHashCode()
        {
            return GetEqualityComponents()
                .Aggregate(1, (current, obj) =>
                {
                    unchecked
                    {
                        return current * 23 + (obj?.GetHashCode() ?? 0);
                    }
                });
        }

        public T? GetCopy()
        {
            return MemberwiseClone() as T;
        }
    }
}
