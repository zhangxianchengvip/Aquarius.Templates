using Aquarius.Tests.Cmds;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace Aquarius.Tests;
public interface ITestApp:IApplicationService
{
    Task<TestViewModel> Create(Create input);
    Task<TestViewModel> UpdteAge(UpdateAge input);
}
