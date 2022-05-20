using System.Collections.Generic;
using TerrariosFascinam.Model;

namespace TerrariosFascinam.Services
{
    public interface IClientService
    {
        Client Create(Client client);
        Client FindById(long id);
        List<Client> FindAll();
        Client Update(Client client);
        void Delete(long id);
    }
}
