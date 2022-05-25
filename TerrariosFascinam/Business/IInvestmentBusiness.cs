using System.Collections.Generic;
using TerrariosFascinam.Model;

namespace TerrariosFascinam.Business
{
    public interface IInvestmentBusiness
    {
        Investment Create(Investment investment);
        Investment FindById(long id);
        List<Investment> FindAll();
        Investment Update(Investment investment);
        void Delete(long id);
    }
}
