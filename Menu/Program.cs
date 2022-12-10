using ConsoleTools;
using Objects.Models;
using System;
using System.ComponentModel.Design;

namespace Menu {
    public class Program {
        public static void Main(string[] args) {

            var adminSubMenu = new ConsoleMenu(args, level: 1)
            .Add("1. Candidate CRUD", () => CrudMethod())
            .Add("2. Candidate Result", () => CandidateResults())
            .Add("3. Back", ConsoleMenu.Close)
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
                config.WriteHeaderAction = () => Console.WriteLine("Welcome to the best certification company! Select your login!");
                
            };
        }
    }
}
