using Newtonsoft.Json;
using System;
using System.Linq;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            // Join in query 
            var innerJoinResult = from s in DummyData.ListStudent()
                                  join c in DummyData.ListCharacter() on s.Age equals c.CharacterAge
                                  select new
                                  {
                                      s.StudentName,
                                      c.CharacterName,
                                      s.Age,
                                      c.CharacterAge 
                                  };


            // Join in method
            var result = DummyData.ListStudent().Join(DummyData.ListCharacter(), s => s.Age, c => c.CharacterAge, (s, c) => new { s, c })
                                                .Where(z => z.c.CharacterName != z.s.StudentName).Select(x => new {
                                                    x.s.Age,
                                                    x.c.CharacterAge,
                                                    x.s.StudentName,
                                                    x.c.CharacterName
                                                });

            Console.WriteLine("\t\t\tExample of Join 2 list ");
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            // GroupBy and OrderBy
            Console.WriteLine("\t\t\tExample of Orderby and GroupBy ");
            var group = DummyData.ListStudent().OrderBy(g => g.Age).GroupBy(s => s.Age);

            foreach (var item in group)
            {
                Console.WriteLine("Group : " + item.Key);
                foreach (Student s in item)
                {
                    Console.WriteLine("\tName : "+s.StudentName);
                }
            }
            Console.WriteLine();

            // select list trong list 
            Console.WriteLine("\t\t\tExample of query List in List ");

            var rs = DummyData.ListCharacter().Where(x => x.ListJob != null && x.ListJob.Any() && x.ListJob.Any(c=>c.IsActive));
            foreach(var item in rs)
            {
                Console.WriteLine(JsonConvert.SerializeObject(item));
            }
            Console.WriteLine(rs.Count());

            Console.ReadKey();
        }
    }
}
