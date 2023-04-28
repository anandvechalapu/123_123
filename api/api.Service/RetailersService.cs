namespace Api.Service
{
    public class RetailersService
    {
        private readonly RetailerRepository _repository;

        public RetailersService(RetailerRepository repository)
        {
            _repository = repository;
        }

        public async Task<int> CreateRetailerAsync(RetailerModel retailer)
        {
            return await _repository.CreateAsync(retailer);
        }

        public async Task<RetailerModel> ReadRetailerAsync(int id)
        {
            return await _repository.ReadAsync(id);
        }

        public async Task<bool> UpdateRetailerAsync(RetailerModel retailer)
        {
            return await _repository.UpdateAsync(retailer);
        }

        public async Task<bool> DeleteRetailerAsync(int id)
        {
            return await _repository.DeleteAsync(id);
        }
    }
}