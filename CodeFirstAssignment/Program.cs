using CodeFirstAssignment.Models;

namespace CodeFirstAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                using (var db = new MyDbContext())
                {
                    Students star = new Students();
                    star.StudentId = 001;
                    star.FirstName = "Vheeky";
                    star.LastName= "Miguel";
                    star.SchoolFees = 34000.0m;
                    star.MatricNo = "ak22516j";
                    star.UniType = UniversityType.Federal;
                    //star.Audiences= new List<Admission>();  
                    db.Students.Add(star);
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadLine();
        }
    }
}