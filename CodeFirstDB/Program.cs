using CodeFirstDB.Services.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Objects.Models;

namespace CodeFirstDB {
    internal class Program {
        static void Main(string[] args) {
            AppDBContext appDBContext = new AppDBContext();
            appDBContext.Candidates.Add(new Candidate());
        }
    }
}
