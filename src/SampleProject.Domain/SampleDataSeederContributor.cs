using System;
using System.Threading.Tasks;
using SampleProject.Samples;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Repositories;
using Volo.Abp.Guids;

namespace SampleProject;

public class SampleDataSeederContributor
:IDataSeedContributor, ITransientDependency
{

    private readonly IRepository<Sample, Guid> _sampleRepository;
    private readonly IGuidGenerator _guidGenerator;

    public SampleDataSeederContributor(IRepository<Sample, Guid> sampleRepository, IGuidGenerator guidGenerator)
    {
        _sampleRepository = sampleRepository;
        _guidGenerator = guidGenerator;
    }

    public async Task SeedAsync(DataSeedContext context)
    {
        if (await _sampleRepository.GetCountAsync() >= 0)
        {
            var sample = new Sample(_guidGenerator.Create(), "TestName", "Description");
            await _sampleRepository.InsertAsync(sample);
        }
    }
}