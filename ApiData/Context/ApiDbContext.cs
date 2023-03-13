using ApiData.Model;
using Microsoft.EntityFrameworkCore;

namespace ApiData.Context
{
    public class ApiDbContext: DbContext
    {

       public ApiDbContext(DbContextOptions <ApiDbContext> options)   :base(options) { 



        }
        
        public DbSet<ModelUsuarios> Users { get; set; } 
        




    }




}
