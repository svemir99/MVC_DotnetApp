namespace FirsttMvcApps.Models
{
    public class Attendance
    {
        private static List<string> attendants = new List<string>();



        public static void AddAttendant(Person person)
        {
            PeopleContext db = new PeopleContext();

            db.People.Add(person);

            db.SaveChanges();


        }


        public static List<Person> GetAttendants (){

            PeopleContext context = new PeopleContext();

            IEnumerable<Person> people = from p in context.People where p.IsDeleted != 1 select p;

            return people.ToList();

        }

        internal static object? GetAttendant(int id)
        {
            throw new NotImplementedException();
        }
    }
}
