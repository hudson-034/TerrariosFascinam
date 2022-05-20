using System;
using System.Collections.Generic;
using System.Linq;
using TerrariosFascinam.Model;
using TerrariosFascinam.Model.Context;
using TerrariosFascinam.Repository;

namespace TerrariosFascinam.Business.Implamentations
{
    public class ClientBusinessImplementation : IClientBusiness
    {
        private readonly IClientRepository _repository;

        //Class Constructor
        public ClientBusinessImplementation(IClientRepository repository)
        {
            _repository = repository;
        }

        public Client Create(Client client)
        {
            return _repository.Create(client);
        }

        public void Delete(long id)
        {
            _repository.Delete(id);
        }

        public List<Client> FindAll()
        {
            return _repository.FindAll();
        }

        public Client FindById(long id)
        {
            return _repository.FindById(id);
        }

        public Client Update(Client client)
        {
            return _repository.Update(client);
        }
    }
}
