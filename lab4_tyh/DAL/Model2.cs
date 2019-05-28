namespace lab4_tyh
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using System.Collections.Generic;

    interface IGenericRepository<T> where T : class
    {
        void Create(T item);
        T FindById(int id);
        IEnumerable<T> Get();
        void Update(T item);
        void Remove(T id);
    }
    public class ModelRepository<T> : IGenericRepository<T> where T : class
    {
        DbContext _context;
        DbSet<T> _dbSet;
        public ModelRepository(DbContext context) 
        {
            _context = context;
            _dbSet = context.Set<T>();
        }
        public void Create(T item)
        {
            _dbSet.Add(item);
        }
        public void Update(T item)
        {
            _context.Entry(item).State = EntityState.Modified;
            _context.SaveChanges();
        }
        public void Remove(T item)
        {
            _dbSet.Remove(item);
            _context.SaveChanges();
        }
        public IEnumerable<T> Get()
        {
            return _dbSet.AsNoTracking().ToList();
        }
        public T FindById(int id)
        {
            return _dbSet.Find(id);
        }
    }
    public partial class Model : DbContext
    {
        public Model()
            : base("name=Model2")
        {
        }

        public virtual DbSet<Admin> Admin { get; set; }
        public virtual DbSet<Disease> Disease { get; set; }
        public virtual DbSet<Doctor> Doctor { get; set; }
        public virtual DbSet<Patient> Patient { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Disease>()
                .HasMany(e => e.Patient)
                .WithOptional(e => e.Disease)
                .HasForeignKey(e => e.Disease1);
        }
    }
}
