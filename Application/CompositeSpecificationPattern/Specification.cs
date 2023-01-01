using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.CompositeSpecificationPattern
{
    public abstract class Specification<T> : ISpecification<T>
    {
        public abstract bool IsSatisfied(T value);

        public Specification<T> And(ISpecification<T> left)
        {
            return new AndSpecification<T>(this, left);
        }

        public Specification<T> Or(ISpecification<T> left)
        {
            return new OrSpecification<T>(this, left);
        }

        public Specification<T> Not()
        {
            return new NotSpecification<T>(this);
        }

        public Specification<DateTime> GreaterThan(DateTime value)
        {
            return new GreaterThanDateTimeSpecification(value);
        }

        public Specification<double> GreaterThan(double value)
        {
            return new GreaterAndEquelThanDoubleSpecification(value);
        }

    }
}
