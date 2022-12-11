using ConsoleTools;
using Objects.Models;
using Objects;
using System;
using System.ComponentModel.Design;
using System.Diagnostics;
using CodeFirstDB;
using CodeFirstDB.Services.Data;
using System.Data.Entity;
using System.Data.Entity.Validation;

namespace Menu {
    public class Program {
        public static void Main(string[] args) {

            var adminSubMenu = new ConsoleMenu(args, level: 1)
            .Add("1. Candidate CRUD", () => CrudMethod())
            .Add("2. Candidate Result", () => CandidateResults())
            .Add("3. Initialise Database", () => InitialiseDatabase())
            .Add("4. Back", ConsoleMenu.Close)
            .Configure(adminGetRekt());

            var candidateSubMenu = new ConsoleMenu(args, level: 1)
           .Add("1. Candidate Certificates", () => CrudMethod())
           .Add("2. Print to PDF", () => CandidateResults())
           .Add("3. Back", ConsoleMenu.Close)
           .Configure(getRekt());

            var mainMenu = new ConsoleMenu(args, level: 0)
            .Add("1. Admin", adminSubMenu.Show)
            .Add("2. Candidate", candidateSubMenu.Show)
            .Add("3. Exit", () => Environment.Exit(0))
            .Configure(getRekt());

            mainMenu.Show();
        }


        public static void InitialiseDatabase() {
            AppDBContext appDBContext = new AppDBContext();
            CertificateTitle CsFoundation = new CertificateTitle("C# Foundation");
            CertificateTitle CsAdvanced = new CertificateTitle("C# Advanced");
            CertificateTitle CssFoundation = new CertificateTitle("CSS Foundation");
            CertificateTitle JsFoundation = new CertificateTitle("Javascript Foundation");
            CertificateTitle HTMLFoundation = new CertificateTitle("HTML Foundation");

            Candidate candidate1 = new Candidate();
            Candidate candidate2 = new Candidate();
            Candidate candidate3 = new Candidate();
            Candidate candidate4 = new Candidate();
            Candidate candidate5 = new Candidate();

            DateTime certificate1Date1 = new DateTime(2022, 05, 12);
            DateTime certificate1Date2 = new DateTime(2022, 05, 13);
            Certificate certificate1 = new Certificate(CsFoundation, candidate1, 111111, certificate1Date1, certificate1Date2, 66);

            DateTime certificate1bDate1 = new DateTime(2022, 06, 02);
            DateTime certificate1bDate2 = new DateTime(2022, 06, 03);
            Certificate certificate1b = new Certificate(CssFoundation, candidate1, 111112, certificate1bDate1, certificate1bDate2, 20);

            DateTime certificate2Date1 = new DateTime(2021, 06, 05);
            DateTime certificate2Date2 = new DateTime(2022, 06, 13);
            Certificate certificate2 = new Certificate(CsFoundation, candidate2, 114431, certificate2Date1, certificate2Date2, 72);

            DateTime certificate2bDate1 = new DateTime(2019, 02, 03);
            DateTime certificate2bDate2 = new DateTime(2019, 02, 12);
            Certificate certificate2b = new Certificate(JsFoundation, candidate2, 114438, certificate2bDate1, certificate2bDate2, 50);

            DateTime certificate3Date1 = new DateTime(2022, 12, 05);
            DateTime certificate3Date2 = new DateTime(2022, 12, 06);
            Certificate certificate3 = new Certificate(CsFoundation, candidate3, 124352, certificate3Date1, certificate3Date2, 62);

            DateTime certificate4Date1 = new DateTime(2022, 01, 05);
            DateTime certificate4Date2 = new DateTime(2022, 01, 06);
            Certificate certificate4 = new Certificate(HTMLFoundation, candidate4, 24112, certificate4Date1, certificate4Date2, 75);

            DateTime certificate5Date1 = new DateTime(2022, 03, 22);
            DateTime certificate5Date2 = new DateTime(2022, 03, 23);
            Certificate certificate5 = new Certificate(CsAdvanced, candidate5, 124112, certificate5Date1, certificate5Date2, 99);



            CertificateTopic cssyntax = new CertificateTopic("C# Syntax", 80, certificate1);
            CertificateTopic csoop = new CertificateTopic("C# OOP", 69, certificate1);
            CertificateTopic cssfoundation1b = new CertificateTopic("CSS Basics", 100, certificate1b);
            CertificateTopic cssyntax2 = new CertificateTopic("C# Syntax", 59, certificate2);
            CertificateTopic jsfoundation2 = new CertificateTopic("Javascript Basic Syntax", 50, certificate2b);
            CertificateTopic csFoundation3 = new CertificateTopic("C# Syntax", 62, certificate3);
            CertificateTopic htmlfoundation4 = new CertificateTopic("Inline-Block Elements", 100, certificate4);
            CertificateTopic html2foundation4 = new CertificateTopic("Bootstrap", 0, certificate4);
            CertificateTopic csadvanced = new CertificateTopic("How to be the best C# programmer", 100, certificate5);

            appDBContext.CertificateTopics.Add(cssyntax);
           
            
        }

        public static void CrudMethod() {
            Console.WriteLine("I make a crud");
        }
        public static void CandidateResults() {
            Console.WriteLine("I show a list of Candidates");
        }

        static Action<MenuConfig> getRekt() {
            return config => {
                config.Selector = "8=D";
                config.SelectedItemForegroundColor = ConsoleColor.DarkMagenta;
                config.WriteHeaderAction = () => Console.WriteLine("Welcome to the best certification company! Select your login!");
                config.SelectedItemBackgroundColor = ConsoleColor.Yellow;
                config.ItemBackgroundColor = ConsoleColor.DarkRed;
                Console.BackgroundColor = ConsoleColor.DarkRed;
            };
        }
        static Action<MenuConfig> adminGetRekt() {
            return config => {
                config.Selector = "8==D";
                config.SelectedItemForegroundColor = ConsoleColor.Black;
                config.SelectedItemBackgroundColor= ConsoleColor.Green;
                config.ItemForegroundColor = ConsoleColor.Green;
                config.ItemBackgroundColor = ConsoleColor.Black;
                config.WriteHeaderAction = () => Console.WriteLine("The first thing you need to do is 'Initialize Database'!!!");
                
            };
        }
    }
}
