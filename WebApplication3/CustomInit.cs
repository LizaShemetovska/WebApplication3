using System.Data.Entity;

namespace WebApplication3
{
    internal class CustomInit<T> : DropCreateDatabaseIfModelChanges<Factory>
    {
        protected override void Seed(Factory context)
        {
            base.Seed(context);
            context.Workers.Add(new Worker
            {
                FirstName="Petro",
                LastName="Petrenko",
                Gender="Montagnik",
                Salary=9999m,
                Address="Rivne, Soborna str.,56"
            });
            context.Workers.Add(new Worker

            {
                FirstName = "Ivan",
                LastName = "Ivanenko",
                Gender = "Male",
                Salary = 109999m,
                Address = "Lutsk, Rivnenka str.,112"
            });
            context.Workers.Add(new Worker

            {
                FirstName = "Vitalik",
                LastName = "Klichko",
                Gender = "Mer",
                Salary = 100500m,
                Address = "Kyiv, Nezalegnosti midan ,1"
            });
            context.SaveChanges();
        }
    }
}