using Aquarius.Tests.Cmds;
using FluentValidation;
using Microsoft.Extensions.Logging;

namespace Microsoft.eShopOnContainers.Services.Ordering.API.Application.Validations;


public class TestCreateValidator : AbstractValidator<CreateDto>
{
    public TestCreateValidator(ILogger<TestCreateValidator> logger)
    {
        RuleFor(command => command.Name).NotEmpty().NotNull().Length(6,10);
    }
}
