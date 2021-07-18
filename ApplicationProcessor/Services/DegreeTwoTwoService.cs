using Ulaw.ApplicationProcessor.Interfaces;

namespace Ulaw.ApplicationProcessor
{
    public class DegreeTwoTwoService : IDegreeService<DegreeTwoTwoService>
    {
        public string Publish(ULaw.ApplicationProcessor.Application application)
        {
            return new DegreeGradeTwoTwoResultBuilder(application).Publish().AddFooter().Build();
        }
    }
}
