using System.Text;
using ULaw.ApplicationProcessor;

namespace Ulaw.ApplicationProcessor.Builders
{
    public class DegreeSubjectLawBusinessResultBuilder : ResultBuilder
    {
        public DegreeSubjectLawBusinessResultBuilder(Application application) : base(application)
        {
            Application = application;
        }

        protected override StringBuilder Result { get; set; }
        protected override Application Application { get; set; }

        public override ResultBuilder Publish()
        {
            decimal depositAmount = 350.00M;
            Result.Append(string.Format("<p/> Further to your recent application for our course reference: {0} starting on {1}, we are writing to inform you that we are currently assessing your information and will be in touch shortly.", Application.CourseCode, Application.StartDate.ToLongDateString()));
            Result.Append(string.Format("<p/> Further to your recent application, we are delighted to offer you a place on our course reference: {0} starting on {1}.", Application.CourseCode, Application.StartDate.ToLongDateString()));
            Result.Append(string.Format("<br/> This offer will be subject to evidence of your qualifying {0} degree at grade: {1}.", Application.DegreeSubject.ToDescription(), Application.DegreeGrade.ToDescription()));
            Result.Append(string.Format("<br/> Please contact us as soon as possible to confirm your acceptance of your place and arrange payment of the £{0} deposit fee to secure your place.", depositAmount.ToString()));
            Result.Append(string.Format("<br/> We look forward to welcoming you to the University,"));
            return this;
        }
    }
}
