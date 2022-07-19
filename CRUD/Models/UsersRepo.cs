namespace CRUD.Models
{
    public class UsersRepo
    {
        static UsersRepo()
        {
            Users = new List<User>()
            {
            new User() { Id=1, Name="Tasneem",Age=21},
            new User() { Id=2, Name="Shahad",Age=25},
            new User() { Id=3, Name="Yasmeen",Age=20},
            new User() { Id=4, Name="Salwa",Age=30},
            new User() { Id=5, Name="Sali",Age=35},

        };

        }

        public static List<User> Users { get; private set; }

        public static List<User> GetAll()
        {
            return Users;
        }

        public static User GetUser(int id)
        {
            return Users.FirstOrDefault(user => user.Id == id);
        }


        public static void Delete(int id)
        {
            var user = GetUser(id);
            if (user != null)
                Users.Remove(user);
        }
        public static void Add(User user)
        {
         Users.Add(user);
        }
        public static void Update(User user)
        {

            User _user = GetUser(user.Id);
            _user.Name = user.Name;
            _user.Age = user.Age;
            
        }
    }
}



