namespace WebApplication3
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class Factory : DbContext
    {
       
        public Factory()
            : base("name=Factory")
        {
            Database.SetInitializer<Factory>(new CustomInit<Factory>());
        }

       
       public virtual DbSet<Worker> Workers { get; set; }
    }

    /// <summary>
    /// Worker DB Model
    /// </summary>
    public class Worker
    {
        /// <summary>
        /// Worker Id, will be ingored while insertion
        /// </summary>
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public decimal Salary { get; set; }
        public string Gender { get; set; }

    }
}