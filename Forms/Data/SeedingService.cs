using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Forms.Models;
using Forms.Models.Enums;

namespace Forms.Data
{
    public class SeedingService
    {
        private FormsContext _context;


        public SeedingService(FormsContext context)
        {
            _context = context;
        }

        public void Seed()
        {
            if (_context.Departament.Any() || 
                _context.Seller.Any() ||
                _context.SalesRecords.Any())
            {
                return; // DB Já foi populado
            }

            Departament d1 = new Departament(1, "Computers");
            Departament d2 = new Departament(2, "Electronics");
            Departament d3 = new Departament(3, "Books");
            Departament d4 = new Departament(4, "Admnistration");

            Seller s1 = new Seller(1, "Joao", "joao@gmail.com", new DateTime(1998, 1, 21), 900.0, d1);
            Seller s2 = new Seller(2, "Maria", "maria@gmail.com", new DateTime(1989, 10, 18), 1200.0, d2);
            Seller s3 = new Seller(3, "Ana", "ana@gmail.com", new DateTime(1977, 12, 30), 1800.0, d3);
            Seller s4 = new Seller(4, "Bianca", "bianca@gmail.com", new DateTime(1999, 2, 10), 3500.0, d4);
            Seller s5 = new Seller(5, "Bruna", "bruna@gmail.com", new DateTime(1988, 6, 05), 2000.0, d3);


            SalesRecord r1 = new SalesRecord(1, new DateTime(2021, 01, 25), 1100.0, SaleStatus.Billed, s1);
            SalesRecord r2 = new SalesRecord(2, new DateTime(2021, 01, 02), 1500.0, SaleStatus.Billed, s2);
            SalesRecord r3 = new SalesRecord(3, new DateTime(2021, 01, 05), 1800.0, SaleStatus.Billed, s3);
            SalesRecord r4 = new SalesRecord(4, new DateTime(2021, 01, 11), 1700.0, SaleStatus.Billed, s4);
            SalesRecord r5 = new SalesRecord(5, new DateTime(2021, 01, 29), 1200.0, SaleStatus.Billed, s3);
            SalesRecord r6 = new SalesRecord(6, new DateTime(2021, 01, 08), 80000.0, SaleStatus.Billed, s1);

            _context.Departament.AddRange(d1, d2, d3, d4);
            _context.Seller.AddRange(s1, s2, s3, s4, s5);
            _context.SalesRecords.AddRange(r1, r2, r3, r4, r5, r6);

            _context.SaveChanges();

        }
    }
}
