namespace scribal.Server.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Post>().HasData(
                new Post
                {
                    Id = 1,
                    Title = "Title",
                    Content = "Expedita non rem delectus cumque ab architecto repellendus voluptas. Consequatur eos similique dicta. Ea iure vitae non quos. Cumque magni ullam sint optio sit molestias. Quo quis consequatur recusandae praesentium debitis harum beatae. Doloribus nisi error consectetur aut eveniet tempora omnis nihil.",
                },
                new Post
                {
                    Id = 2,
                    Title = "Title",
                    Content = "Expedita non rem delectus cumque ab architecto repellendus voluptas. Consequatur eos similique dicta. Ea iure vitae non quos. Cumque magni ullam sint optio sit molestias. Quo quis consequatur recusandae praesentium debitis harum beatae. Doloribus nisi error consectetur aut eveniet tempora omnis nihil.",
                }
            );

        }

        public DbSet<Post> Posts { get; set; }

    }
}
