using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AlexandriaCLI.Domain;
using NHibernate;

namespace AlexandriaCLI.Repositories
{
    class HashStoreFactory : IHashStoreFactory
    {
        public void Add(HashStore hashStore)
        {
            using (ISession session = nHibernateHelper.OpenSession())
                using (ITransaction transaction = session.BeginTransaction())
                {
                    session.Save(hashStore);
                    transaction.Commit();
                }
        }
        public void Update(HashStore hashStore)
        {
            throw new NotImplementedException();
        }
        public void Delete(HashStore hashStore)
        {
            throw new NotImplementedException();
        }
        public HashStore GetById(Guid guid)
        {
            throw new NotImplementedException();
        }
        public HashStore GetByHashSize(String fileHash, int fileSize)
        {
            throw new NotImplementedException();
        }
        public int CountDuplicatedHashSize(String fileHash, int fileSize)
        {
            throw new NotImplementedException();
        }
        public ICollection<HashStore> GetAllbyHashSize(String fileHash, int fileSize)
        {
            throw new NotImplementedException();
        }
    }
}
