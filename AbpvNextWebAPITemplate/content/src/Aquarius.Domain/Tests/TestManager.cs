using Aquarius.Tests.Specifications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Volo.Abp;
using Volo.Abp.Domain.Repositories;
using Volo.Abp.Domain.Services;
using Volo.Abp.Uow;

namespace Aquarius.Tests;
public class TestManager : DomainService
{
    private readonly IRepository<Test, Guid> _repository;

    public TestManager(IRepository<Test, Guid> repository)
    {
        _repository = repository;
    }

    public async Task<Test> Create(string name)
    {
        //var any = await _repository.AnyAsync(new TestNameEqualSpec(name));

        //if (any)
        //{
        //    throw new BusinessException(AquariusDomainErrorCodes.TestExist)
        //    {
        //        Data = { { "name", name } }
        //    };
        //}

        Test test = new(GuidGenerator.Create(), name);

        return await _repository.InsertAsync(test);
    }

    public async Task<Test> SetAge(Guid id, int age)
    {
        var test = await _repository.FindAsync(new TestIdEqualSpec(id));

        if (test == null)
        {
            throw new BusinessException(AquariusDomainErrorCodes.TestNotExist)
            {
                Data = { { "id", id } }
            };
        }

        test.SetAge(age);

        return await _repository.UpdateAsync(test);
    }
}
