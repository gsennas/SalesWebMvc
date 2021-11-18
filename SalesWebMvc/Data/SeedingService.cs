using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SalesWebMvc.Models;
using SalesWebMvc.Models.Enums;

namespace SalesWebMvc.Data
{
    public class SeedingService
    {
        private SalesWebMvcContext _context;

        public SeedingService(SalesWebMvcContext context)
        {
            _context = context;
        }
        public void Seed()
        {
            if (_context.Department.Any() ||
                _context.Seller.Any() ||
                _context.SalesRecord.Any())
            {
                return;
            }

            Department d1 = new Department(1, "Computers");
            Department d2 = new Department(2, "Bed and Bath");
            Department d3 = new Department(3, "Fashion");
            Department d4 = new Department(4, "Kitchen");

            Seller a1 = new Seller(1, "Glaucio Senna", "gsennaeua@gmail.com", new DateTime(1979, 6, 23), 1000, d1);
            Seller a2 = new Seller(2, "Joice Silva", "joice@gmail.com", new DateTime(1980, 1, 11), 3000, d2);
            Seller a3 = new Seller(3, "Lucas Silva", "lucas@gmail.com", new DateTime(2000, 1, 2), 2000, d2);
            Seller a4 = new Seller(4, "Carlos", "carlos@gmail.com", new DateTime(1950, 1, 9), 2000, d4);
            Seller a5 = new Seller(5, "Leila", "leila@gmail.com", new DateTime(1960, 1, 2), 2900, d4);
            Seller a6 = new Seller(6, "Ivone", "ivones@gmail.com", new DateTime(1974, 1, 2), 2200, d3);

            SalesRecord s1 = new SalesRecord(1, new DateTime(2000, 1, 22), 3000, SaleStatus.Billed, a2);
            SalesRecord s2 = new SalesRecord(2, new DateTime(2000, 1, 3), 3100, SaleStatus.Canceled, a1);
            SalesRecord s3 = new SalesRecord(3, new DateTime(2000, 1, 14), 3300, SaleStatus.Pending, a1);
            SalesRecord s4 = new SalesRecord(4, new DateTime(2000, 1, 5), 2000, SaleStatus.Canceled, a4);
            SalesRecord s5 = new SalesRecord(5, new DateTime(2000, 1, 6), 1000, SaleStatus.Billed, a5);
            SalesRecord s6 = new SalesRecord(6, new DateTime(2000, 1, 22), 4000, SaleStatus.Billed, a6);
            SalesRecord s7 = new SalesRecord(7, new DateTime(2000, 1, 22), 6000, SaleStatus.Billed, a1);
            SalesRecord s8 = new SalesRecord(8, new DateTime(2000, 1, 3), 1000, SaleStatus.Canceled, a1);
            SalesRecord s9 = new SalesRecord(9, new DateTime(2000, 1, 14), 300, SaleStatus.Billed, a3);
            SalesRecord s10 = new SalesRecord(10, new DateTime(2000, 1, 9), 3100, SaleStatus.Pending, a6);
            SalesRecord s11 = new SalesRecord(11, new DateTime(2000, 1, 27), 200, SaleStatus.Pending, a3);

            _context.Department.AddRange(d1, d2, d3, d4);
            _context.Seller.AddRange(a1, a2, a3, a4, a5, a6);
            _context.SalesRecord.AddRange(s1, s2, s3, s4, s5, s6, s7, s8, s9, s10, s11);
            _context.SaveChanges();
        }
    }
}
