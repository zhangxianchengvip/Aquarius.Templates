using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Specifications;

namespace Aquarius.Tests.Specifications;
public class TestIdEqualSpec : Specification<Test>
{
    private readonly Guid _id;

    public TestIdEqualSpec(Guid id)
    {
        _id = id;
    }

    public override Expression<Func<Test, bool>> ToExpression()
    {
        return s => s.Id.Equals(_id);
    }
}
