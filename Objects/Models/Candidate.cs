using RandomDataGenerator.FieldOptions;
using RandomDataGenerator.Randomizers;
using System;
using System.Collections.Generic;
using System.IO;
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
        public DateTime PhotoIdDate { get; set; }

        public Candidate(string firstName, string middleName, string lastName, int candidateNumber, string gender, string nativeLanguage, string countryOfResidence, DateTime birthdate, string email, string landLineNumber, string mobileNumber, string address1, string address2, string postalCode, string town, string province, string photoIdType, string photoIdNumber, DateTime photoIdDate) {
            
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

        public Candidate() {
            FirstName = RandomizerFactory.GetRandomizer(new FieldOptionsFirstName()).Generate();

            MiddleName = RandomizerFactory.GetRandomizer(new FieldOptionsFirstName()).Generate();

            LastName = RandomizerFactory.GetRandomizer(new FieldOptionsLastName()).Generate();

            CandidateNumber = (int)RandomizerFactory.GetRandomizer(new FieldOptionsInteger()).Generate();

            if ((bool)RandomizerFactory.GetRandomizer(new FieldOptionsBoolean()).Generate()) {
                Gender = "Male";
            } else {
                Gender = "Female";
            }

            NativeLanguage = RandomizerFactory.GetRandomizer(new FieldOptionsCountry()).Generate();

            CountryOfResidence = RandomizerFactory.GetRandomizer(new FieldOptionsCountry()).Generate();

            Birthdate = (DateTime)RandomizerFactory.GetRandomizer(new FieldOptionsDateTime()).Generate();

            Email = RandomizerFactory.GetRandomizer(new FieldOptionsEmailAddress()).Generate();

            LandLineNumber = RandomLandLine();

            MobileNumber = RandomMobile();

            Address1 = RandomizerFactory.GetRandomizer(new FieldOptionsFullName()).Generate();

            FieldOptionsShort shorts = new FieldOptionsShort();
            shorts.Max = 250;
            Address2 = RandomizerFactory.GetRandomizer(shorts).Generate().ToString();

            FieldOptionsInteger pc = new FieldOptionsInteger();
            pc.Max = 99999;
            PostalCode = RandomizerFactory.GetRandomizer(pc).Generate().ToString();

            Town = RandomizerFactory.GetRandomizer(new FieldOptionsCity()).Generate();

            Province = RandomizerFactory.GetRandomizer(new FieldOptionsCity()).Generate();

            if ((bool)RandomizerFactory.GetRandomizer(new FieldOptionsBoolean()).Generate()) {
                PhotoIdType = "National ID Card";
            } else {
                PhotoIdType = "Passport";
            }

            PhotoIdNumber = RandomId();

            PhotoIdDate = (DateTime)RandomizerFactory.GetRandomizer(new FieldOptionsDateTime()).Generate();


        }
        static string RandomMobile() {
            StringBuilder sb = new StringBuilder();
            sb.Append("+30");
            FieldOptionsLong fieldOptionsLong = new FieldOptionsLong();
            fieldOptionsLong.Min = 6900000000;
            fieldOptionsLong.Max = 6999999999;
            sb.Append(RandomizerFactory.GetRandomizer(fieldOptionsLong).Generate());
            return sb.ToString();
        }
        static string RandomLandLine() {
            StringBuilder sb = new StringBuilder();
            sb.Append("+210");
            FieldOptionsLong fieldOptionsLong = new FieldOptionsLong();
            fieldOptionsLong.Min = 1000000;
            fieldOptionsLong.Max = 9999999;
            sb.Append(RandomizerFactory.GetRandomizer(fieldOptionsLong).Generate());
            return sb.ToString();
        }

        static string RandomId() {
            StringBuilder sb = new StringBuilder();
            FieldOptionsText twoLetters = new FieldOptionsText();
            twoLetters.Min = 2;
            twoLetters.Max = 2;
            sb.Append(RandomizerFactory.GetRandomizer(twoLetters).Generate());
            FieldOptionsInteger fieldOptionsInt = new FieldOptionsInteger();
            fieldOptionsInt.Min = 100000;
            fieldOptionsInt.Max = 999999;
            sb.Append(RandomizerFactory.GetRandomizer(fieldOptionsInt).Generate());
            return sb.ToString();
        }

        public override string ToString() {
            return $"FirstName = {FirstName}\nMiddleName = {MiddleName}\nLastName = {LastName}\nCandidateNumber = {CandidateNumber}\nGender = {Gender}\nNativeLanguage = {NativeLanguage}\nCountryOfResidence = {CountryOfResidence}\nBirthdate = {Birthdate}\nEmail = {Email} \nLandLineNumber = {LandLineNumber} \nMobileNumber = {MobileNumber} \nAddress1 = {Address1}\nAddress2 = {Address2}\nPostalCode = {PostalCode}\nTown = {Town}\nProvince = {Province}\nPhotoIdType = {PhotoIdType}\nPhotoIdNumber = {PhotoIdNumber}\nPhotoIdDate {PhotoIdDate}";
        }
    }
}
