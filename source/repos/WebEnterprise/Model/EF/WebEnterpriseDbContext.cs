namespace Model.EF
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class WebEnterpriseDbContext : DbContext
    {
        public WebEnterpriseDbContext()
            : base("name=WebEnterprise")
        {
        }

        public virtual DbSet<Address> Addresses { get; set; }
        public virtual DbSet<Comment> Comments { get; set; }
        public virtual DbSet<CommentID> CommentIDs { get; set; }
        public virtual DbSet<DepartmentCategolory> DepartmentCategolories { get; set; }
        public virtual DbSet<Document> Documents { get; set; }
        public virtual DbSet<GroupUser> GroupUsers { get; set; }
        public virtual DbSet<SchoolYear> SchoolYears { get; set; }
        public virtual DbSet<Semester> Semesters { get; set; }
        public virtual DbSet<SemesterDayTime> SemesterDayTimes { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Address>()
                .HasMany(e => e.Users)
                .WithRequired(e => e.Address)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CommentID>()
                .Property(e => e.CContent)
                .IsUnicode(false);

            modelBuilder.Entity<DepartmentCategolory>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Document>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Document>()
                .Property(e => e.FileType)
                .IsUnicode(false);

            modelBuilder.Entity<Document>()
                .Property(e => e.DataFile)
                .IsUnicode(false);

            modelBuilder.Entity<GroupUser>()
                .Property(e => e.Name)
                .IsFixedLength();

            modelBuilder.Entity<GroupUser>()
                .HasMany(e => e.Users)
                .WithRequired(e => e.GroupUser)
                .HasForeignKey(e => e.IdGroupUser)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Semester>()
                .HasMany(e => e.SchoolYears)
                .WithRequired(e => e.Semester)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SemesterDayTime>()
                .HasMany(e => e.Semesters)
                .WithRequired(e => e.SemesterDayTime)
                .HasForeignKey(e => e.DayTImeID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .Property(e => e.FisrtName)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .HasMany(e => e.CommentIDs)
                .WithRequired(e => e.User)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .HasMany(e => e.DepartmentCategolories)
                .WithRequired(e => e.User)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .HasMany(e => e.Documents)
                .WithRequired(e => e.User)
                .WillCascadeOnDelete(false);
        }
    }
}
