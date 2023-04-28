using Api.DTO;

namespace Api.Service
{
    public interface IRetailersService
    {
        Task<int> CreateRetailerAsync(RetailerModel retailer);
        Task<RetailerModel> ReadRetailerAsync(int id);
        Task<bool> UpdateRetailerAsync(RetailerModel retailer);
        Task<bool> DeleteRetailerAsync(int id);
    }
}