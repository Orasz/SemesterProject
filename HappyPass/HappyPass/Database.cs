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
        public  bool CheckUserAsync(long userID)
        {
            var isIn = from u in _database.Table<User>()
                       where u.UserID == userID
                       select u;
            if (isIn != null)
                return true;
            else return false;
        }
    }
}
