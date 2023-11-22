using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using studentanalysis.Models;

namespace studentanalysis.Repos
{
    public interface IAssessmentRepo
    {
        List<AssessmentViewModel> GetAssessments();
    }
}
