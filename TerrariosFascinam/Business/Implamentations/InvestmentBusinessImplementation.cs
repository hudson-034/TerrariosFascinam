using System.Collections.Generic;
using TerrariosFascinam.Model;
using TerrariosFascinam.Repository;

namespace TerrariosFascinam.Business.Implamentations
{
    public class InvestmentBusinessImplementation : IInvestmentBusiness
    {
        private readonly IInvestmentRepository _investmentRepository;

        public InvestmentBusinessImplementation(IInvestmentRepository investmentRepository)
        {
            _investmentRepository = investmentRepository;
        }

        public Investment Create(Investment investment)
        {
            return _investmentRepository.Create(investment);
        }

        public void Delete(long id)
        {
            _investmentRepository.Delete(id);
        }

        public List<Investment> FindAll()
        {
            return _investmentRepository.FindAll();
        }

        public Investment FindById(long id)
        {
            return _investmentRepository.FindById(id);
        }

        public Investment Update(Investment investment)
        {
            return _investmentRepository.Update(investment);
        }
    }
}
