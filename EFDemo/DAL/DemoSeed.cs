using System.Data.Entity;
using EFDemo.DomainModel;

namespace EFDemo.DAL
{
    public class DemoSeed : DropCreateDatabaseAlways<DemoContext>
    {
        protected override void Seed(DemoContext context)
        {
            context.Students.Add(new Student() {Name = "LARS"});
            base.Seed(context);
        }
    }
}
