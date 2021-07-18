using System.Text;
using ULaw.ApplicationProcessor;

namespace Ulaw.ApplicationProcessor.Builders
{
    public class DegreeGradeThirdResultBuilder : ResultBuilder 
    {
        public DegreeGradeThirdResultBuilder(Application application) : base(application)
        {
            Application = application;
        }
        protected override StringBuilder Result { get; set; }
        protected override Application Application { get; set; }

        public override ResultBuilder Publish()
        {
            Result.Append("<p/> Further to your recent application, we are sorry to inform you that you have not been successful on this occasion.");
            Result.Append("<br/> If you wish to discuss the decision further, or discuss the possibility of applying for an alternative course with us, please contact us at AdmissionsTeam@Ulaw.co.uk.");
            return this;
        }
    }
}
