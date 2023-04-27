namespace Api
{
    public class RetailersRepository : IRetailersRepository
    {
        public async Task<IEnumerable<RetailerModel>> GetAllRetailersAsync()
        {
            using (var connection = new SqlConnection("YourConnectionString"))
            {
                connection.Open();

                var command = new SqlCommand("SELECT * FROM Retailers", connection);
                using (var reader = await command.ExecuteReaderAsync())
                {
                    var list = new List<RetailerModel>();
                    while (reader.Read())
                    {
                        list.Add(new RetailerModel
                        {
                            Id = reader.GetInt32(0),
                            Name = reader.GetString(1),
                            Address = reader.GetString(2),
                            PhoneNumber = reader.GetString(3)
                        });
                    }

                    return list;
                }
            }
        }

        public async Task<RetailerModel> GetRetailerByIdAsync(int id)
        {
            using (var connection = new SqlConnection("YourConnectionString"))
            {
                connection.Open();

                var command = new SqlCommand("SELECT * FROM Retailers WHERE Id = @Id", connection);
                command.Parameters.AddWithValue("@Id", id);

                using (var reader = await command.ExecuteReaderAsync())
                {
                    if (reader.Read())
                    {
                        return new RetailerModel
                        {
                            Id = reader.GetInt32(0),
                            Name = reader.GetString(1),
                            Address = reader.GetString(2),
                            PhoneNumber = reader.GetString(3)
                        };
                    }

                    return null;
                }
            }
        }

        public async Task<int> CreateRetailerAsync(RetailerModel model)
        {
            using (var connection = new SqlConnection("YourConnectionString"))
            {
                connection.Open();

                var command = new SqlCommand("INSERT INTO Retailers(Name, Address, PhoneNumber) VALUES (@Name, @Address, @PhoneNumber)", connection);
                command.Parameters.AddWithValue("@Name", model.Name);
                command.Parameters.AddWithValue("@Address", model.Address);
                command.Parameters.AddWithValue("@PhoneNumber", model.PhoneNumber);

                return await command.ExecuteNonQueryAsync();
            }
        }

        public async Task<int> UpdateRetailerAsync(RetailerModel model)
        {
            using (var connection = new SqlConnection("YourConnectionString"))
            {
                connection.Open();

                var command = new SqlCommand("UPDATE Retailers SET Name = @Name, Address = @Address, PhoneNumber = @PhoneNumber WHERE Id = @Id", connection);
                command.Parameters.AddWithValue("@Name", model.Name);
                command.Parameters.AddWithValue("@Address", model.Address);
                command.Parameters.AddWithValue("@PhoneNumber", model.PhoneNumber);
                command.Parameters.AddWithValue("@Id", model.Id);

                return await command.ExecuteNonQueryAsync();
            }
        }

        public async Task<int> DeleteRetailerAsync(int id)
        {
            using (var connection = new SqlConnection("YourConnectionString"))
            {
                connection.Open();

                var command = new SqlCommand("DELETE FROM Retailers WHERE Id = @Id", connection);
                command.Parameters.AddWithValue("@Id", id);

                return await command.ExecuteNonQueryAsync();
            }
        }
    }
}