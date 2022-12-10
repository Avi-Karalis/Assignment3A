using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objects.Models {
    [Table("Certificates")]
    public class Certificate {
        [Key]
        public string TitleOfCertificate { get; set; }
        // Must have CANDIDATE
        [ForeignKey("CandidateId")]
        public Candidate Candidate { get; set; }
        public int AssessmentTestCode { get; set; }
        public DateTime ExaminationDate { get; set; }
        public DateTime ScoreReportDate { get; set; }
        public int CandidateScore { get 
                { return CandidateScore; 
            } 
            set {
                CandidateScore = value;
                PercentageScoreValue =  (value/ MaximumScore)*100;
            }
        }
        public int MaximumScore { get; private set; } = 100;
        public string AssessmentResultLabel { get; set; }
        private int PercentageScoreValue {
            get { return PercentageScoreValue; }
            set {
                
                if (value >= 65) {
                    AssessmentResultLabel = "Pass";
                } else {
                    AssessmentResultLabel = "Fail";
                }
                PercentageScoreValue = value;
                PercentageScore = value + "%";
            }
        }
        public string PercentageScore { get; private set; }


        public Certificate(string titleOfCertificate, Candidate candidate, int assessmentTestCode, DateTime examinationDate, DateTime scoreReportDate, int candidateScore, string assessmentResultLabel, string percentageScore) {
            TitleOfCertificate = titleOfCertificate;
            Candidate = candidate;
            AssessmentTestCode = assessmentTestCode;
            ExaminationDate = examinationDate;
            ScoreReportDate = scoreReportDate;
            CandidateScore = candidateScore;
            AssessmentResultLabel = assessmentResultLabel;
            PercentageScore = percentageScore;
        }

    }

}
