namespace Application.CompositeSpecificationPattern
{
    public class AndSpecification<T> : CompositeSpecification<T>
    {
        public AndSpecification(ISpecification<T> left, ISpecification<T> right) : base(left, right)
        {
        }

        public override bool IsSatisfied(T value)
        {
            return Right.IsSatisfied(value) && Left.IsSatisfied(value);
        }
    }
}