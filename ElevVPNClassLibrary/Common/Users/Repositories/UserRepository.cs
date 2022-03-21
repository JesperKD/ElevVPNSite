using ElevVPNClassLibrary.Common.Users.Entities;
using ElevVPNClassLibrary.Common.Users.Factories;
using ElevVPNClassLibrary.Core.Database.Managers;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;

namespace ElevVPNClassLibrary.Common.Users.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly ISqlDbManager _sqlDbManager;
        private readonly UserEntityFactory _factory;

        public UserRepository(ISqlDbManager sqlDbManager, UserEntityFactory factory)
        {
            _sqlDbManager = sqlDbManager;
            _factory = factory;
        }


        public Task<IUser> CreateAsync(IUser entity)
        {
            throw new NotImplementedException();
        }

        public Task<List<IUser>> GetAllAsync()
        {
            try
            {
                using (var mysqlconnection = _sqlDbManager.GetSqlConnection())
                {
                    string strData = string.Empty;

                    mysqlconnection.Open();
                    using (MySqlCommand cmd = mysqlconnection.CreateCommand())
                    {
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandTimeout = 300;
                        cmd.CommandText = "SELECT * FROM Users";

                        object objValue = cmd.ExecuteScalar();
                        if (objValue == null)
                        {
                            cmd.Dispose();

                            return null;
                        }
                        else
                        {
                            strData = (string)cmd.ExecuteScalar();
                            cmd.Dispose();
                        }

                        mysqlconnection.Close();

                        return null;
                    }

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
        }

        public Task<IUser> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> RemoveAsync(IUser entity)
        {
            throw new NotImplementedException();
        }

        public Task<IUser> UpdateAsync(IUser entity)
        {
            throw new NotImplementedException();
        }
    }
}
