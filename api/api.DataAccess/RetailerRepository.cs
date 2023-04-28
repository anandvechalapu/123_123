using Api.DTO.Retailers;

namespace Api
{
    public class RetailerRepository
    {
        public async Task<int> CreateAsync(RetailerModel retailer)
        {
            // Create retailer logic goes here
            return await Task.FromResult(1);
        }

        public async Task<RetailerModel> ReadAsync(int id)
        {
            // Read retailer logic goes here
            return await Task.FromResult(new RetailerModel());
        }

        public async Task<bool> UpdateAsync(RetailerModel retailer)
        {
            // Update retailer logic goes here
            return await Task.FromResult(true);
        }

        public async Task<bool> DeleteAsync(int id)
        {
            // Delete retailer logic goes here
            return await Task.FromResult(true);
        }
    }
}