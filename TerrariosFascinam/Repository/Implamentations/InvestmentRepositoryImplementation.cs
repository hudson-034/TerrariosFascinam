using System;
using System.Collections.Generic;
using System.Linq;
using TerrariosFascinam.Model;
using TerrariosFascinam.Model.Context;

namespace TerrariosFascinam.Repository.Implamentations
{
    public class InvestmentRepositoryImplementation : IInvestmentRepository
    {
        private MySQLContext _context;

        public InvestmentRepositoryImplementation(MySQLContext context)
        {
            _context = context;
        }

        public Investment Create(Investment investment)
        {
            try
            {
                _context.Add(investment);
                _context.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
            return investment;
        }

        public void Delete(long id)
        {
            var result = _context.Investments.SingleOrDefault(i => i.Id.Equals(id));
            if (result != null)
            {
                try
                {
                    _context.Investments.Remove(result);
                    _context.SaveChanges();
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        public List<Investment> FindAll()
        {
            return _context.Investments.ToList();
        }

        public Investment FindById(long id)
        {
            return _context.Investments.SingleOrDefault(i =>i.Id.Equals(id));
        }

        public Investment Update(Investment investment)
        {
            if (!Exists(investment.Id)) return null;

            var result = _context.Investments.SingleOrDefault(i =>i.Id.Equals(investment.Id));
            if (result != null)
            {
                try
                {
                    _context.Entry(result).CurrentValues.SetValues(investment);
                    _context.SaveChanges();
                }
                catch (Exception)
                {

                    throw;
                }
            }
            return investment;
        }

        public bool Exists(long id)
        {
            return _context.Investments.Any(i => i.Id.Equals(id));
        }
    }
}
