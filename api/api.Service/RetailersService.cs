namespace Api.Services
{
    public class RetailersService : IRetailersService
    {
        private readonly IRetailersRepository _retailersRepository;

        public RetailersService(IRetailersRepository retailersRepository)
        {
            _retailersRepository = retailersRepository;
        }

        public async Task<IEnumerable<RetailerModel>> GetAllRetailersAsync()
        {
            return await _retailersRepository.GetAllRetailersAsync();
        }

        public async Task<RetailerModel> GetRetailerByIdAsync(int id)
        {
            return await _retailersRepository.GetRetailerByIdAsync(id);
        }

        public async Task<int> CreateRetailerAsync(RetailerModel model)
        {
            return await _retailersRepository.CreateRetailerAsync(model);
        }

        public async Task<int> UpdateRetailerAsync(RetailerModel model)
        {
            return await _retailersRepository.UpdateRetailerAsync(model);
        }

        public async Task<int> DeleteRetailerAsync(int id)
        {
            return await _retailersRepository.DeleteRetailerAsync(id);
        }
    }
}