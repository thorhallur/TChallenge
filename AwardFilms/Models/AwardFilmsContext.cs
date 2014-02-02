using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace AwardFilms.Models
{
    public class AwardFilmsContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, add the following
        // code to the Application_Start method in your Global.asax file.
        // Note: this will destroy and re-create your database with every model change.
        // 
        // System.Data.Entity.Database.SetInitializer(new System.Data.Entity.DropCreateDatabaseIfModelChanges<AwardFilms.Models.AwardFilmsContext>());

        public AwardFilmsContext() : base("name=AwardFilmsContext")
        {
            Database.SetInitializer<Models.AwardFilmsContext>(null);
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Title>().ToTable("Title");
            modelBuilder.Entity<StoryLine>().ToTable("StoryLine");
        }

        public DbSet<Title> Titles { get; set; }
        public DbSet<StoryLine> StoryLines { get; set; }

    }
}
