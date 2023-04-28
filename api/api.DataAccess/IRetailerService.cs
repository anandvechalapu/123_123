using Api.DTO.Retailers;

namespace Api.Service
{
    public interface IRetailerService
    {
        Task<int> CreateAsync(RetailerModel retailer);
        Task<RetailerModel> ReadAsync(int id);
        Task<bool> UpdateAsync(RetailerModel retailer);
        Task<bool> DeleteAsync(int id);
    }
}