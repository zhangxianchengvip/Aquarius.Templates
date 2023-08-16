using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp;
using Volo.Abp.Domain.Entities;

namespace Aquarius.Tests;
public class Test : Entity<Guid>
{
    public string Name { get; init; }
    public int? Age { get; private set; }
    internal Test(Guid id, string name) : base(id)
    {
        Name = Check.NotNullOrEmpty(name, nameof(name));
    }


    internal Test SetAge(int age)
    {
        if (age <= 0 || age >= 100)
        {
            throw new BusinessException(AquariusDomainErrorCodes.AgeOutOfRange)
            {
                Data = { { "age", age } }
            };
        }

        Age = age;
        return this;
    }

}
