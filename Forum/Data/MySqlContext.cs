using Microsoft.EntityFrameworkCore;

namespace Forum.Data
{
    public class MySqlContext : DbContext
    {
        public MySqlContext() { }
        public MySqlContext(DbContextOptions<MySqlContext> options) : base(options)
        {

        }


    }
}
