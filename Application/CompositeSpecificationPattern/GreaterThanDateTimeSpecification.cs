namespace Application.CompositeSpecificationPattern
{
    public class GreaterThanDateTimeSpecification : Specification<DateTime>
    {
        private readonly DateTime _target;

        public GreaterThanDateTimeSpecification(DateTime target)
        {
            _target = target;
        }

        public override bool IsSatisfied(DateTime value)
        {
            return value > _target;
        }
    }
}