using System;
using System.Collections.Generic;
using System.Linq;
using TerrariosFascinam.Model;
using TerrariosFascinam.Model.Context;

namespace TerrariosFascinam.Repository.Implamentations
{
    public class ClientRepositoryImplementation : IClientRepository
    {
        private MySQLContext _context;

        //Class Constructor
        public ClientRepositoryImplementation(MySQLContext context)
        {
            _context = context;
        }

        public Client Create(Client client)
        {
            try
            {
                _context.Add(client);
                _context.SaveChanges();
            }
            catch(Exception)
            {
                throw;
            }
            return client;
        }

        public void Delete(long id)
        {
            var result = _context.Clients.SingleOrDefault(c => c.Id.Equals(id));
            if (result != null)
            {
                try
                {
                    _context.Clients.Remove(result);
                    _context.SaveChanges();
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        public List<Client> FindAll()
        {
            return _context.Clients.ToList();
        }

        public Client FindById(long id)
        {
            return _context.Clients.SingleOrDefault(c => c.Id.Equals(id));
        }

        public Client Update(Client client)
        {
            if (!Exists(client.Id)) return null;

            var result = _context.Clients.SingleOrDefault(c => c.Id.Equals(client.Id));
            if (result != null)
            {
                try
                {
                    _context.Entry(result).CurrentValues.SetValues(client);
                    _context.SaveChanges();
                }
                catch (Exception)
                {
                    throw;
                }
            }
            return client;
        }

        public bool Exists(long id)
        {
            return _context.Clients.Any(c => c.Id.Equals(id));
        }
    }
}
