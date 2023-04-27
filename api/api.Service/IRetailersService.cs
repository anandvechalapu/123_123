namespace Api.Services
{
    using Api.DTO;

    public interface IRetailersService
    {
        Task<IEnumerable<RetailerModel>> GetAllRetailersAsync();
        Task<RetailerModel> GetRetailerByIdAsync(int id);
        Task<int> CreateRetailerAsync(RetailerModel model);
        Task<int> UpdateRetailerAsync(RetailerModel model);
        Task<int> DeleteRetailerAsync(int id);
    }
}