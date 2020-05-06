namespace AfpaTinderMvc
{
    using InitDataBase;
    using Models;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class AfpaTinderContext : DbContext
    {
        public AfpaTinderContext() : base("name=AfpaTinderMvc")
        {
            Database.SetInitializer(new AfpaTinderDbInit());
        }

        public virtual DbSet<Personne> Personnes { get; set; }
        public virtual DbSet<Loisir> Loisirs { get; set; }
        public virtual DbSet<Ville> Villes { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}