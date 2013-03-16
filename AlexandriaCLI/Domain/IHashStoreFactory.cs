using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AlexandriaCLI.Domain
{
    public interface IHashStoreFactory
    {
        void Add(HashStore hashStore);
        void Update(HashStore hashStore);
        void Delete(HashStore hashStore);
        HashStore GetById(Guid Id);
        HashStore GetByHashSize(String fileHash, int fileSize);
        int CountDuplicatedHashSize(String fileHash, int fileSize);
        ICollection<HashStore> GetAllbyHashSize(String fileHash, int fileSize);
    }
}
