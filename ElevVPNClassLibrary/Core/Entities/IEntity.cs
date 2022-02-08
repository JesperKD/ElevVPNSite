namespace ElevVPNClassLibrary.Core.Entities
{
    public interface IEntity<TGenericType>
    {
        public TGenericType Id { get; }
    }
}
