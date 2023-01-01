
namespace Application.CompositeSpecificationPattern
{
    public abstract class CompositeSpecification<T> : Specification<T>
    {
        public ISpecification<T> Left { get; set; }

        public ISpecification<T> Right { get; set; }

        protected CompositeSpecification(ISpecification<T> left, ISpecification<T> right)
        {
            Left = left;
            Right = right;
        }
    }
}
