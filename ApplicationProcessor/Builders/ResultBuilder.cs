using System.Text;

namespace Ulaw.ApplicationProcessor
{
    public abstract class ResultBuilder
    {
        protected abstract StringBuilder Result { get; set; }
        protected abstract ULaw.ApplicationProcessor.Application Application { get; set; }

        protected ResultBuilder(ULaw.ApplicationProcessor.Application application)
        {
            Result = new StringBuilder("<html><body><h1>Your Recent Application from the University of Law</h1>");
            Result.Append(string.Format("<p> Dear {0}, </p>", application.FirstName));
            Application = application;
        }

        public abstract ResultBuilder Publish();

        public ResultBuilder AddFooter()
        {
            Result.Append("<br/> Yours sincerely,");
            Result.Append("<p/> The Admissions Team,");
            return this;
        }
        public string Build()
        {
            Result.Append(string.Format("</body></html>"));
            return Result.ToString();
        }

    }
}
