using Ulaw.ApplicationProcessor.Builders;
using Ulaw.ApplicationProcessor.Interfaces;
using ULaw.ApplicationProcessor;

namespace Ulaw.ApplicationProcessor.Services
{
    public class DegreeSubjectOtherBusinessService : IDegreeService<DegreeSubjectOtherBusinessService>
    {
        public string Publish(Application application)
        {
            return new DegreeSubjectOtherBusinessResultBuilder(application).Publish().AddFooter().Build();
        }
    }
}
