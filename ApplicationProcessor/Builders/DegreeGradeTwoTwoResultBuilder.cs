using System.Text;
using ULaw.ApplicationProcessor;

namespace Ulaw.ApplicationProcessor
{
    public class DegreeGradeTwoTwoResultBuilder : ResultBuilder
    {
        public DegreeGradeTwoTwoResultBuilder(Application application) :base(application)
        {
            Application = application;
        }

        protected override StringBuilder Result { get; set; }
        protected override Application Application { get; set; }

        public override ResultBuilder Publish()
        {
            Result.Append(string.Format("<p/> Further to your recent application for our course reference: {0} starting on {1}, we are writing to inform you that we are currently assessing your information and will be in touch shortly.", Application.CourseCode, Application.StartDate.ToLongDateString()));
            Result.Append("<br/> If you wish to discuss any aspect of your application, please contact us at AdmissionsTeam@Ulaw.co.uk.");
            return this;
        }
    }
}
