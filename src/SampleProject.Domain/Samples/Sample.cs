using System;
using JetBrains.Annotations;
using Volo.Abp;
using Volo.Abp.Domain.Entities.Auditing;

namespace SampleProject.Samples;

public class Sample : FullAuditedAggregateRoot<Guid>
{
    public string Name { get; set; }
    public string Description { get; set; }


    public Sample()
    {
        
    }
    
    public Sample(Guid id,[NotNull] string name, [CanBeNull] string description = null)
   :base(id)
    {
        SetName(name);
        Description = description;
    }

    private void SetName([NotNull] string name)
    {
        Name = Check.NotNullOrWhiteSpace(name, nameof(name));
    }
}