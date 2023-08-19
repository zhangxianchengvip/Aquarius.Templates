using Aquarius.Localization;
using Aquarius.Tests.Specifications;
using Microsoft.Extensions.Localization;
using System;
using System.Threading.Tasks;
using Volo.Abp;
using Volo.Abp.Domain.Repositories;
using Volo.Abp.Domain.Services;

namespace Aquarius.Tests;
public class TestManager : DomainService
{
    private readonly IRepository<Test, Guid> _repository;
    private readonly IStringLocalizer<AquariusResource> _localizableString;
    public TestManager(IRepository<Test, Guid> repository, IStringLocalizer<AquariusResource> localizableString)
    {
        _repository = repository;
        _localizableString = localizableString;
    }

    public async Task<Test> Create(string name)
    {
        var any = await _repository.AnyAsync(new TestNameEqualSpec(name));

        if (any)
        {
            var ss = _localizableString[AquariusDomainErrorCodes.TestExist];

           throw new BusinessException(AquariusDomainErrorCodes.TestExist)
            {
                Data = { { "Name", name } }
            };
        }

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
                Data = { { "Id", id } }
            };
        }

        test.SetAge(age);

        return await _repository.UpdateAsync(test);
    }
}
