namespace CarShowroomChain
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class DatabaseModel : DbContext
    {
        public DatabaseModel()
            : base("name=DatabaseModel")
        {
        }

        public virtual DbSet<car> car { get; set; }
        public virtual DbSet<car_sell> car_sell { get; set; }
        public virtual DbSet<car_shop> car_shop { get; set; }
        public virtual DbSet<client> client { get; set; }
        public virtual DbSet<client_order> client_order { get; set; }
        public virtual DbSet<dict_body> dict_body { get; set; }
        public virtual DbSet<dict_color> dict_color { get; set; }
        public virtual DbSet<dict_engine> dict_engine { get; set; }
        public virtual DbSet<dict_fuel> dict_fuel { get; set; }
        public virtual DbSet<dict_gearbox> dict_gearbox { get; set; }
        public virtual DbSet<dict_series> dict_series { get; set; }
        public virtual DbSet<dict_service> dict_service { get; set; }
        public virtual DbSet<model> model { get; set; }
        public virtual DbSet<reservation> reservation { get; set; }
        public virtual DbSet<role> role { get; set; }
        public virtual DbSet<user_data> user_data { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<car>()
                .HasMany(e => e.car_sell)
                .WithRequired(e => e.car)
                .HasForeignKey(e => e.id_car)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<car>()
                .HasMany(e => e.reservation)
                .WithRequired(e => e.car)
                .HasForeignKey(e => e.id_car)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<car_shop>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<car_shop>()
                .Property(e => e.address)
                .IsUnicode(false);

            modelBuilder.Entity<car_shop>()
                .Property(e => e.phone)
                .IsUnicode(false);

            modelBuilder.Entity<car_shop>()
                .Property(e => e.www)
                .IsUnicode(false);

            modelBuilder.Entity<car_shop>()
                .HasMany(e => e.car)
                .WithRequired(e => e.car_shop)
                .HasForeignKey(e => e.id_car_shop)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<car_shop>()
                .HasMany(e => e.client_order)
                .WithRequired(e => e.car_shop)
                .HasForeignKey(e => e.id_car_shop)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<car_shop>()
                .HasMany(e => e.user_data)
                .WithRequired(e => e.car_shop)
                .HasForeignKey(e => e.id_car_shop)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<client>()
                .Property(e => e.first_name)
                .IsUnicode(false);

            modelBuilder.Entity<client>()
                .Property(e => e.last_name)
                .IsUnicode(false);

            modelBuilder.Entity<client>()
                .Property(e => e.address)
                .IsUnicode(false);

            modelBuilder.Entity<client>()
                .Property(e => e.phone)
                .IsUnicode(false);

            modelBuilder.Entity<client>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<client>()
                .HasMany(e => e.car_sell)
                .WithRequired(e => e.client)
                .HasForeignKey(e => e.id_client)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<client>()
                .HasMany(e => e.client_order)
                .WithRequired(e => e.client)
                .HasForeignKey(e => e.id_client)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<client>()
                .HasMany(e => e.reservation)
                .WithRequired(e => e.client)
                .HasForeignKey(e => e.id_client)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<client_order>()
                .Property(e => e.comment)
                .IsUnicode(false);

            modelBuilder.Entity<dict_body>()
                .Property(e => e.body)
                .IsUnicode(false);

            modelBuilder.Entity<dict_body>()
                .HasMany(e => e.car)
                .WithRequired(e => e.dict_body)
                .HasForeignKey(e => e.id_body)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<dict_color>()
                .Property(e => e.color)
                .IsUnicode(false);

            modelBuilder.Entity<dict_color>()
                .HasMany(e => e.car)
                .WithRequired(e => e.dict_color)
                .HasForeignKey(e => e.id_color)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<dict_engine>()
                .Property(e => e.engine)
                .IsUnicode(false);

            modelBuilder.Entity<dict_engine>()
                .HasMany(e => e.car)
                .WithRequired(e => e.dict_engine)
                .HasForeignKey(e => e.id_engine)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<dict_fuel>()
                .Property(e => e.fuel)
                .IsUnicode(false);

            modelBuilder.Entity<dict_fuel>()
                .HasMany(e => e.car)
                .WithRequired(e => e.dict_fuel)
                .HasForeignKey(e => e.id_fuel)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<dict_gearbox>()
                .Property(e => e.gearbox)
                .IsUnicode(false);

            modelBuilder.Entity<dict_gearbox>()
                .HasMany(e => e.car)
                .WithRequired(e => e.dict_gearbox)
                .HasForeignKey(e => e.id_gearbox)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<dict_series>()
                .Property(e => e.series)
                .IsUnicode(false);

            modelBuilder.Entity<dict_series>()
                .HasMany(e => e.car)
                .WithRequired(e => e.dict_series)
                .HasForeignKey(e => e.id_series)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<dict_service>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<dict_service>()
                .HasMany(e => e.client_order)
                .WithRequired(e => e.dict_service)
                .HasForeignKey(e => e.id_service)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<model>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<model>()
                .HasMany(e => e.car)
                .WithRequired(e => e.model)
                .HasForeignKey(e => e.id_model)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<role>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<user_data>()
                .Property(e => e.login)
                .IsUnicode(false);

            modelBuilder.Entity<user_data>()
                .Property(e => e.password)
                .IsUnicode(false);

            modelBuilder.Entity<user_data>()
                .Property(e => e.first_name)
                .IsUnicode(false);

            modelBuilder.Entity<user_data>()
                .Property(e => e.last_name)
                .IsUnicode(false);

            modelBuilder.Entity<user_data>()
                .Property(e => e.address)
                .IsUnicode(false);

            modelBuilder.Entity<user_data>()
                .Property(e => e.phone)
                .IsUnicode(false);

            modelBuilder.Entity<user_data>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<user_data>()
                .HasMany(e => e.car_sell)
                .WithRequired(e => e.user_data)
                .HasForeignKey(e => e.id_user)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<user_data>()
                .HasMany(e => e.client_order)
                .WithRequired(e => e.user_data)
                .HasForeignKey(e => e.id_user)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<user_data>()
                .HasMany(e => e.reservation)
                .WithRequired(e => e.user_data)
                .HasForeignKey(e => e.id_user)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<user_data>()
                .HasMany(e => e.role)
                .WithMany(e => e.user_data)
                .Map(m => m.ToTable("user_role").MapLeftKey("id_user").MapRightKey("id_role"));
        }
    }
}
