namespace Application.CompositeSpecificationPattern
{
    public class OrSpecification<T> : CompositeSpecification<T>
    {
        public OrSpecification(ISpecification<T> left, ISpecification<T> right) : base(left, right)
        {
        }

        public override bool IsSatisfied(T value)
        {
            return Right.IsSatisfied(value) || Left.IsSatisfied(value);
        }
    }
}