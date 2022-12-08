using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objects.Models {
    internal class Certificate {
        public string TitleOfCertificate { get; set; }
        public Candidate Candidate { get; set; }
        public int AssessmentTestCode { get; set; }
        public DateTime ExaminationDate { get; set; }
        public DateTime ScoreReportDate { get; set; }
        public int CandidateScore { get; set; }
        public int MaximumScore { get; set; }
        public string AssessmentResultLabel { get; set; }
        public string PercentageScore { get; set; }
        
        
        public Certificate(string titleOfCertificate, Candidate candidate, int assessmentTestCode, DateTime examinationDate, DateTime scoreReportDate, int candidateScore, int maximumScore, string assessmentResultLabel, string percentageScore) {
            TitleOfCertificate = titleOfCertificate;
            Candidate = candidate;
            AssessmentTestCode = assessmentTestCode;
            ExaminationDate = examinationDate;
            ScoreReportDate = scoreReportDate;
            CandidateScore = candidateScore;
            MaximumScore = maximumScore;
            AssessmentResultLabel = assessmentResultLabel;
            PercentageScore = percentageScore;
        }
    }
}
