using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CBC_APIDataAccess;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new APIContext())
            {
                db.Benefits.Add(new CBC_APIDataEntitiesV1.Benefit() { Name = "Healthcare" });
                db.SaveChanges();
                Console.WriteLine(db.Benefits.FirstOrDefault(a => a.Name == "Healthcare").Name);
                Console.Write("Done");
                Console.ReadKey();
            }
        }
    }
}
