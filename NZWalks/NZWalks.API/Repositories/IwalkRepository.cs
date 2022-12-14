using NZWalks.API.Models.Domain;

namespace NZWalks.API.Repositories
{
    public interface IwalkRepository
    {
        Task<IEnumerable<Walk>>GetAllAsync();
        Task<Walk>GetAsync(Guid id);
        Task<Walk> AddAsync(Walk walk);
        Task<Walk> UpdateAsync(Guid id, Walk walk);
        Task<Walk> DeleteAsync(Guid id);

        
    }
}
