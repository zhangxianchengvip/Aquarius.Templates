﻿using System;
using Volo.Abp;
using Volo.Abp.Domain.Entities;

namespace Aquarius.Tests;
public class Test : BasicAggregateRoot<Guid>
{
    public string Name { get; init; }
    public int? Age { get; private set; }
    internal Test(Guid id, string name) : base(id)
    {
        Name = Check.NotNullOrEmpty(name, nameof(name));
    }


    internal Test SetAge(int age)
    {
        if (age < 0 || age > 120)
        {
            throw new BusinessException(AquariusDomainErrorCodes.AgeOutOfRange)
            {
                Data =
                {
                    { "Age", age }
                }
            };
        }

        Age = age;
        return this;
    }

}
