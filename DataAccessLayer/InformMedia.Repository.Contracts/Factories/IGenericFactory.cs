namespace InformMedia.Repository.Contracts.Factories
{
    public interface IGenericFactory
    {
        T Create<T>() where T : new();

        T Create<T>(Func<T> factoryMethod);
    }
}
