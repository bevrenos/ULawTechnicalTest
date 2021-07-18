using System;
using ULaw.ApplicationProcessor;
using Ulaw.ApplicationProcessor.Interfaces;
using Ulaw.ApplicationProcessor.Services;

namespace Ulaw.ApplicationProcessor.Builders
{
    public class DegreeServiceBuilder : IDegreeServiceBuilder
    {
        private readonly IDegreeService<DegreeTwoTwoService> _degreeTwoTwoGradeService;
        private readonly IDegreeService<DegreeThirdService> _degreeThirdGradeService;
        private readonly IDegreeService<DegreeSubjectLawBusinessService> _degreeSubjectLawBusinessService;
        private readonly IDegreeService<DegreeSubjectOtherBusinessService> _degreeSubjectOthersBusinessService;

        public DegreeServiceBuilder(IDegreeService<DegreeTwoTwoService> degreeTwoTwoGradeService,
            IDegreeService<DegreeThirdService> degreeThirdGradeService,
            IDegreeService<DegreeSubjectLawBusinessService> degreeSubjectLawBusinessService,
            IDegreeService<DegreeSubjectOtherBusinessService> degreeSubjectOthersBusinessService)
        {
            _degreeTwoTwoGradeService = degreeTwoTwoGradeService ?? throw new ArgumentNullException(nameof(degreeTwoTwoGradeService));
            _degreeThirdGradeService = degreeThirdGradeService ?? throw new ArgumentNullException(nameof(degreeThirdGradeService));
            _degreeSubjectLawBusinessService = degreeSubjectLawBusinessService ?? throw new ArgumentNullException(nameof(degreeSubjectLawBusinessService));
            _degreeSubjectOthersBusinessService = degreeSubjectOthersBusinessService ?? throw new ArgumentNullException(nameof(degreeSubjectOthersBusinessService));
        }

        public string DegreeGradeTwoTwoService(Application application)
        {
            return _degreeTwoTwoGradeService.Publish(application);
        }

        public string DegreeGradeThirdService(Application application)
        {
            return _degreeThirdGradeService.Publish(application);
        }

        public string DegreeSubjectLawBusinessService(Application application)
        {
            return _degreeSubjectLawBusinessService.Publish(application);
        }

        public string DegreeSubjectOtherBusinessService(Application application)
        {
            return _degreeSubjectOthersBusinessService.Publish(application);
        }
    }
}
