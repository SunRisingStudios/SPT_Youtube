namespace SPTDataLayer.Database
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class DataModel : DbContext
    {
        public DataModel()
            : base("name=DataModel")
        {
        }

        public virtual DbSet<COMPANY> COMPANY { get; set; }
        public virtual DbSet<DIST_GUIDELINES> DIST_GUIDELINES { get; set; }
        public virtual DbSet<EMPL> EMPL { get; set; }
        public virtual DbSet<EMPL_STANDING> EMPL_STANDING { get; set; }
        public virtual DbSet<EMPL_STATUS> EMPL_STATUS { get; set; }
        public virtual DbSet<EMPL_TYPE> EMPL_TYPE { get; set; }
        public virtual DbSet<LOCATION> LOCATION { get; set; }
        public virtual DbSet<OPERATION> OPERATION { get; set; }
        public virtual DbSet<PCT_INCREASE> PCT_INCREASE { get; set; }
        public virtual DbSet<QUINTILE> QUINTILE { get; set; }
        public virtual DbSet<SALARY_RANGE> SALARY_RANGE { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<COMPANY>()
                .Property(e => e.COMPANY_NM)
                .IsUnicode(false);

            modelBuilder.Entity<COMPANY>()
                .HasMany(e => e.DIST_GUIDELINES)
                .WithRequired(e => e.COMPANY)
                .HasForeignKey(e => e.COMPANY_CO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<COMPANY>()
                .HasMany(e => e.EMPL)
                .WithRequired(e => e.COMPANY)
                .HasForeignKey(e => e.COMPANY_CO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DIST_GUIDELINES>()
                .Property(e => e.AMOUNT)
                .HasPrecision(18, 4);

            modelBuilder.Entity<DIST_GUIDELINES>()
                .HasMany(e => e.LOCATION)
                .WithRequired(e => e.DIST_GUIDELINES)
                .HasForeignKey(e => e.DIST_ID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DIST_GUIDELINES>()
                .HasMany(e => e.PCT_INCREASE)
                .WithRequired(e => e.DIST_GUIDELINES)
                .HasForeignKey(e => e.DIST_KEY)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DIST_GUIDELINES>()
                .HasMany(e => e.QUINTILE)
                .WithRequired(e => e.DIST_GUIDELINES)
                .HasForeignKey(e => e.DIST_KEY)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DIST_GUIDELINES>()
                .HasMany(e => e.SALARY_RANGE)
                .WithRequired(e => e.DIST_GUIDELINES)
                .HasForeignKey(e => e.DIST_KEY)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EMPL>()
                .Property(e => e.EMPL_NO)
                .IsUnicode(false);

            modelBuilder.Entity<EMPL>()
                .Property(e => e.NAME)
                .IsUnicode(false);

            modelBuilder.Entity<EMPL>()
                .Property(e => e.JOB_TITLE)
                .IsUnicode(false);

            modelBuilder.Entity<EMPL>()
                .Property(e => e.REPORTS_TO_ID)
                .IsUnicode(false);

            modelBuilder.Entity<EMPL_STANDING>()
                .Property(e => e.EMPL_STANDING_NM)
                .IsUnicode(false);

            modelBuilder.Entity<EMPL_STANDING>()
                .HasMany(e => e.EMPL)
                .WithRequired(e => e.EMPL_STANDING1)
                .HasForeignKey(e => e.EMPL_STANDING)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EMPL_STATUS>()
                .Property(e => e.EMPL_STATUS_NM)
                .IsUnicode(false);

            modelBuilder.Entity<EMPL_STATUS>()
                .HasMany(e => e.EMPL)
                .WithRequired(e => e.EMPL_STATUS)
                .HasForeignKey(e => e.FULL_PART_TIME)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EMPL_STATUS>()
                .HasMany(e => e.PCT_INCREASE)
                .WithRequired(e => e.EMPL_STATUS)
                .HasForeignKey(e => e.STATUS)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EMPL_STATUS>()
                .HasMany(e => e.QUINTILE)
                .WithRequired(e => e.EMPL_STATUS1)
                .HasForeignKey(e => e.EMPL_STATUS)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EMPL_STATUS>()
                .HasMany(e => e.SALARY_RANGE)
                .WithRequired(e => e.EMPL_STATUS)
                .HasForeignKey(e => e.STATUS)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EMPL_TYPE>()
                .Property(e => e.EMPL_TYPE_CD)
                .IsUnicode(false);

            modelBuilder.Entity<EMPL_TYPE>()
                .Property(e => e.EMPL_TYPE_NM)
                .IsUnicode(false);

            modelBuilder.Entity<EMPL_TYPE>()
                .HasMany(e => e.DIST_GUIDELINES)
                .WithRequired(e => e.EMPL_TYPE)
                .HasForeignKey(e => e.EMP_TYPE)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EMPL_TYPE>()
                .HasMany(e => e.EMPL)
                .WithRequired(e => e.EMPL_TYPE1)
                .HasForeignKey(e => e.EMPL_TYPE)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<LOCATION>()
                .Property(e => e.LOCATION_NM)
                .IsUnicode(false);

            modelBuilder.Entity<LOCATION>()
                .HasMany(e => e.EMPL)
                .WithRequired(e => e.LOCATION1)
                .HasForeignKey(e => e.LOCATION)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OPERATION>()
                .Property(e => e.OPERATION_NM)
                .IsUnicode(false);

            modelBuilder.Entity<OPERATION>()
                .HasMany(e => e.DIST_GUIDELINES)
                .WithRequired(e => e.OPERATION1)
                .HasForeignKey(e => e.OPERATION)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OPERATION>()
                .HasMany(e => e.EMPL)
                .WithRequired(e => e.OPERATION1)
                .HasForeignKey(e => e.OPERATION)
                .WillCascadeOnDelete(false);
        }
    }
}
