namespace MockDynamicsApi.Data
{
    public class DynamicsContext : DbContext
    {
        public DynamicsContext(DbContextOptions<DynamicsContext> options): base(options)
        {
            
        }

        public DbSet<Entity> Entities {get; set;}
        public DbSet<Record> Records {get; set;}
    }
}