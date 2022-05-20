using System.Collections.Generic;
using TerrariosFascinam.Model;

namespace TerrariosFascinam.Repository
{
    public interface IClientRepository
    {
        Client Create(Client client);
        Client FindById(long id);
        List<Client> FindAll();
        Client Update(Client client);
        void Delete(long id);
        bool Exists(long id);
    }
}
