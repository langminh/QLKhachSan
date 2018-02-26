namespace ProductMvc.Entity
{
    using ProductMvc.Entity.EF;
    using System.Data.Entity;

    public partial class DataEntities : DbContext
    {
        public DataEntities()
            : base("name=DataEntities")
        {
        }

        public virtual DbSet<Config> Configs { get; set; }
        public virtual DbSet<Floor> Floors { get; set; }
        public virtual DbSet<InOut> InOuts { get; set; }
        public virtual DbSet<InOut_OtherServices> InOut_OtherServices { get; set; }
        public virtual DbSet<OtherService> OtherServices { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<Room> Rooms { get; set; }
        public virtual DbSet<RoomServicePrice> RoomServicePrices { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .Property(e => e.Phone)
                .IsUnicode(false);
        }
    }
}
