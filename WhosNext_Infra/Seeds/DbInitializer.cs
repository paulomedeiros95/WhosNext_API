using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WhosNext_Domain.Account;

namespace WhosNext_Infra.Seeds
{
    public class DbInitializer
    {
        private readonly ModelBuilder modelBuilder;

        public DbInitializer(ModelBuilder modelBuilder)
        {
            this.modelBuilder = modelBuilder;
        }

        public void Seed()
        {
            modelBuilder.Entity<AccountDomain>().HasData(
                  new AccountDomain()
                  {
                      Id = 1,
                      Name = "Receita",
                      AcceptIncommings = false,
                      ExternalCode = "1",
                      UpperId = null,
                      CreatedAt = DateTime.Now,
                  },

                new AccountDomain()
                {
                    Id = 2,
                    Name = "Despesas",
                    AcceptIncommings = false,
                    ExternalCode = "2",
                    UpperId = null,
                    CreatedAt = DateTime.Now,
                },

                new AccountDomain()
                {
                    Id = 3,
                    Name = "Com pessoal",
                    AcceptIncommings = false,
                    ExternalCode = "2.1",
                    UpperId = 2,
                    CreatedAt = DateTime.Now,
                },

                new AccountDomain()
                {
                    Id = 4,
                    Name = "Mensais",
                    AcceptIncommings = false,
                    ExternalCode = "2.2",
                    UpperId = 2,
                    CreatedAt = DateTime.Now,
                },

                 new AccountDomain()
                 {
                     Id = 5,
                     Name = "Manutenção",
                     AcceptIncommings = false,
                     ExternalCode = "2.3",
                     UpperId = 2,
                     CreatedAt = DateTime.Now,
                 },

                new AccountDomain()
                {
                    Id = 6,
                    Name = "Diversas",
                    AcceptIncommings = false,
                    ExternalCode = "2.4",
                    UpperId = 2,
                    CreatedAt = DateTime.Now,
                },

                new AccountDomain()
                {
                    Id = 7,
                    Name = "Despesas bancárias",
                    AcceptIncommings = false,
                    ExternalCode = "3",
                    UpperId = null,
                    CreatedAt = DateTime.Now,
                },

                new AccountDomain()
                {
                    Id = 8,
                    Name = "Outras receitas",
                    AcceptIncommings = false,
                    ExternalCode = "4",
                    UpperId = null,
                    CreatedAt = DateTime.Now,
                }


            );
        }
    }
}
