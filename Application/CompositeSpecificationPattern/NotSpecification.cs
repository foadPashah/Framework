﻿namespace Application.CompositeSpecificationPattern
{
    public class NotSpecification<T> : Specification<T>
    {
        private readonly ISpecification<T> _target;
        public NotSpecification(ISpecification<T> target)
        {
            _target = target;
        }
        public override bool IsSatisfied(T value)
        {
            return !_target.IsSatisfied(value);
        }
    }
}