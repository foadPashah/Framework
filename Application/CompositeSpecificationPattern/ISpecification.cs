namespace Application.CompositeSpecificationPattern
{
    public interface ISpecification<T>
    {
        bool IsSatisfied(T value);
    }
}
