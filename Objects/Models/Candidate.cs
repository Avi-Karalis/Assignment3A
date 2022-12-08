using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace Objects.Models {
    public class Candidate {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public int CandidateNumber  { get; set; }
        public string Gender { get; set; }
        public string NativeLanguage { get; set; }
        public string CountryOfResidence { get; set; }
        public DateTime Birthdate { get; set; }
        public string Email { get; set; }
        public string LandLineNumber { get; set; }
        public string MobileNumber { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string PostalCode { get; set; }
        public string Town { get; set; }
        public string Province { get; set; }
        public string PhotoIdType { get; set; }
        public string PhotoIdNumber { get; set; }
        public string PhotoIdDate { get; set; }

        public Candidate(string firstName, string middleName, string lastName, int candidateNumber, string gender, string nativeLanguage, string countryOfResidence, DateTime birthdate, string email, string landLineNumber, string mobileNumber, string address1, string address2, string postalCode, string town, string province, string photoIdType, string photoIdNumber, string photoIdDate) {
            
            FirstName = firstName;
            MiddleName = middleName;
            LastName = lastName;
            CandidateNumber = candidateNumber;
            Gender = gender;
            NativeLanguage = nativeLanguage;
            CountryOfResidence = countryOfResidence;
            Birthdate = birthdate;
            Email = email;
            LandLineNumber = landLineNumber;
            MobileNumber = mobileNumber;
            Address1 = address1;
            Address2 = address2;
            PostalCode = postalCode;
            Town = town;
            Province = province;
            PhotoIdType = photoIdType;
            PhotoIdNumber = photoIdNumber;
            PhotoIdDate = photoIdDate;
        }
    }
}
