using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace HappyPass
{
    public class Database
    {
        SQLiteAsyncConnection _database;
        public Database(string dbpath)
        {
            _database = new SQLiteAsyncConnection(dbpath);
            _database.CreateTableAsync<User>().Wait();
        }

        public Task<List<User>> GetUsersAsync()
        {
            return _database.Table<User>().ToListAsync();
        }
        public Task<int> SaveUserAsync(User user)
        {
            return _database.InsertAsync(user);
        }
        public async Task<bool> CheckUserAsync(long userID)
        {
            var isIn =  _database.Table<User>().Where(u => u.UserID == userID);
            var result = await isIn.FirstOrDefaultAsync();         
            if (isIn != null)
                return true;
            else return false;
        }
    }
}
