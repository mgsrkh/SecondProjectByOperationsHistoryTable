using SecondProjectByHistoryTable_Log_.Models;
using System.Threading.Tasks;

namespace SecondProjectByHistoryTable_Log_.InferaStructure.IRepositories
{
    public interface IHistoryRepository
    {
        Task<int> InsertHistoryAsync(History history);
    }
}
