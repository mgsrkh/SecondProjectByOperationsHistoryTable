using SecondProjectByHistoryTable_Log_.InferaStructure.IRepositories;
using SecondProjectByHistoryTable_Log_.Models;
using SecondProjectEFCoreAttributes.Contexts;
using System.Threading.Tasks;

namespace SecondProjectByHistoryTable_Log_.InferaStructure.Repositories
{
    public class HistoryRepository : IHistoryRepository
    {
        private readonly ProjectContext _db;

        public HistoryRepository(ProjectContext db)
        {
            _db = db;
        }

        public async Task<int> InsertHistoryAsync(History history)
        {
            _db.History.Add(history);
            return await _db.SaveChangesAsync();
        }
    }
}
