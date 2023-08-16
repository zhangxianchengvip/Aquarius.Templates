using Aquarius.Tests.Cmds;
using Aquarius.Tests.Specifications;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Aquarius.Tests;
[Route("api/v1/[Controller]")]
public class TestApp : ApplicationService, ITestApp
{
    private readonly TestManager _manager;
    private readonly IRepository<Test, Guid> _repository;

    public TestApp(TestManager manager, IRepository<Test, Guid> repository)
    {
        _manager = manager;
        _repository = repository;
    }
    [HttpPost]
    public async Task<TestViewModel> Create(Create input)
    {
        var test = await _manager.Create(input.Name);

        return ObjectMapper.Map<Test, TestViewModel>(test);
    }
    [HttpPut]
    public async Task<TestViewModel> UpdteAge(UpdateAge input)
    {
        var test = await _manager.SetAge(input.Id, input.Age);

        return ObjectMapper.Map<Test, TestViewModel>(test);
    }

    [HttpGet]
    public async Task<TestViewModel> Get(Guid id)
    {
        var test = await _repository.FirstAsync(new TestIdEqualSpec(id));

        return ObjectMapper.Map<Test, TestViewModel>(test);
    }
}
