using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Specifications;

namespace Aquarius.Tests.Specifications;
public class TestNameEqualSpec : Specification<Test>
{
    private readonly string _name;

    public TestNameEqualSpec(string name)
    {
        _name = name;
    }


    public override Expression<Func<Test, bool>> ToExpression()
    {
        return s => s.Name.Equals(_name);
    }
}
