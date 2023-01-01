namespace Application.CompositeSpecificationPattern
{
    public class GreaterAndEquelThanDoubleSpecification : Specification<double>
    {
        private readonly double _target;

        public GreaterAndEquelThanDoubleSpecification(double target)
        {
            _target = target;
        }

        public override bool IsSatisfied(double value)
        {
            return value >= _target;
        }
    }
}