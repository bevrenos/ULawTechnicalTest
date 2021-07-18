using System;
using Ulaw.ApplicationProcessor.Interfaces;
using ULaw.ApplicationProcessor;
using ULaw.ApplicationProcessor.Enums;

namespace Ulaw.ApplicationProcessor
{
    public class ApplicationService : IApplicationService
    {
        private readonly IDegreeServiceBuilder _degreeServiceBuilder;

        public ApplicationService(IDegreeServiceBuilder degreeServiceBuilder)
        {
            _degreeServiceBuilder = degreeServiceBuilder ?? throw new ArgumentNullException(nameof(degreeServiceBuilder));
        }

        public string Process(Application application)
        {
            switch (application.DegreeGrade)
            {
                case DegreeGradeEnum.twoTwo:
                    return _degreeServiceBuilder.DegreeGradeTwoTwoService(application);
                case DegreeGradeEnum.third:
                    return _degreeServiceBuilder.DegreeGradeThirdService(application);
                default:
                    {
                        if (application.DegreeSubject == DegreeSubjectEnum.law || application.DegreeSubject == DegreeSubjectEnum.lawAndBusiness)
                            return _degreeServiceBuilder.DegreeSubjectLawBusinessService(application);

                        return _degreeServiceBuilder.DegreeSubjectOtherBusinessService(application);
                    }
            }
        }
    }
}
