using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AlexandriaCLI.Domain;

namespace AlexandriaCLI.Repositories
{
    class HashStoreFactory : IHashStoreFactory
    {
        public void Add(HashStore hashStore)
        {
            throw new NotImplementedException();
        }

        public void Update(HashStore hashStore)
        {
            throw new NotImplementedException();
        }

        public void Remove(HashStore hashStore)
        {
            throw new NotImplementedException();
        }

        HashStore GetByHashSize(String fileHash, int fileSize)
        {
            throw new NotImplementedException();
        }
        int CountDuplicatedHashSize(String fileHash, int fileSize)
        {
            throw new NotImplementedException();
        }
        ICollection<HashStore> GetAllbyHashSize(String fileHash, int fileSize)
        {
            throw new NotImplementedException();
        }
    }
}
