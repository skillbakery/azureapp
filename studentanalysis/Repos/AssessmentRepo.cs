using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using studentanalysis.Models;

namespace studentanalysis.Repos
{
    public class AssessmentRepo : IAssessmentRepo
    {
        public List<AssessmentViewModel> GetAssessments()
        {
            var assessments = new List<AssessmentViewModel>
            {
                new AssessmentViewModel(){ StudentId =20220001, Name = "Alice Smith", Level =300, Course = "Web Development with JavaScript", Score=92 },
                new AssessmentViewModel(){ StudentId =20220002, Name = "Bob Johnson", Level =300, Course = "ASP.Net Core", Score=88 },
                new AssessmentViewModel(){ StudentId =20220003, Name = "Eva Wilson", Level =300, Course = "React.js Fundamentals", Score=95 },
                new AssessmentViewModel(){ StudentId =20220004, Name = "Michael Davis", Level =300, Course = "Node.js Basics", Score=91 },
                new AssessmentViewModel(){ StudentId =20220005, Name = "Sophia Miller", Level =300, Course = "Front-end Web Development", Score=89 },
            };
            return assessments;
        }
    }
}
