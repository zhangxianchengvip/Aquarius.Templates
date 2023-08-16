using Aquarius.Tests;
using AutoMapper;

namespace Aquarius;

public class AquariusApplicationAutoMapperProfile : Profile
{
    public AquariusApplicationAutoMapperProfile()
    {
        /* You can configure your AutoMapper mapping configuration here.
         * Alternatively, you can split your mapping configurations
         * into multiple profile classes for a better organization. */
        CreateMap<Test, TestViewModel>();
    }
}
