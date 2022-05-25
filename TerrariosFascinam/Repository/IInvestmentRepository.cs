using System.Collections.Generic;
using TerrariosFascinam.Model;

namespace TerrariosFascinam.Repository
{
    public interface IInvestmentRepository
    {
        Investment Create(Investment investment);
        Investment FindById(long id);
        List<Investment> FindAll();
        Investment Update(Investment investment);
        void Delete(long id);
        bool Exists(long id);
    }
}
