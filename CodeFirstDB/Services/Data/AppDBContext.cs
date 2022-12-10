using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Objects.Models;
using System.Security.Cryptography.X509Certificates;

namespace CodeFirstDB.Services.Data {
    internal class AppDBContext : DbContext {

        public virtual DbSet<Certificate> Certificates { get; set; }
        public virtual DbSet<Candidate> Candidates { get; set; }


        public AppDBContext() : base("name=MyConnectionString") {
        }
    }
}
