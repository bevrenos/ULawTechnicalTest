using Ulaw.ApplicationProcessor.Builders;
using Ulaw.ApplicationProcessor.Interfaces;
using ULaw.ApplicationProcessor;

namespace Ulaw.ApplicationProcessor.Services
{
    public class DegreeSubjectLawBusinessService : IDegreeService<DegreeSubjectLawBusinessService>
    {
        public string Publish(Application application)
        {
            return new DegreeSubjectLawBusinessResultBuilder(application).Publish().AddFooter().Build();
        }
    }
}
