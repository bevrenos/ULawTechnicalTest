using ULaw.ApplicationProcessor;

namespace Ulaw.ApplicationProcessor.Interfaces
{
    public interface IDegreeServiceBuilder
    {
        string DegreeGradeTwoTwoService(Application application);
        string DegreeGradeThirdService(Application application);
        string DegreeSubjectLawBusinessService(Application application);
        string DegreeSubjectOtherBusinessService(Application application);
    }
}
