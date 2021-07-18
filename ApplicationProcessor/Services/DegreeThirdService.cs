using Ulaw.ApplicationProcessor.Builders;
using Ulaw.ApplicationProcessor.Interfaces;
using ULaw.ApplicationProcessor;

namespace Ulaw.ApplicationProcessor.Services
{
    public class DegreeThirdService : IDegreeService<DegreeThirdService>
    {
        public string Publish(Application application)
        {
            return new DegreeGradeThirdResultBuilder(application).Publish().AddFooter().Build();
        }
    }
}
