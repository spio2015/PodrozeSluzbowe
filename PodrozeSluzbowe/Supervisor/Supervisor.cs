using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Database;
using System.Data.Entity;

namespace PodrozeSluzbowe.Supervisor
{
    class SuperVisorCar
    {            

        public void deleteCar(Cars cars)
        {
            using (PodrozeEntities context = new PodrozeEntities())
            {
               
                 
                    int Id = cars.Id;
                    cars = context.Cars.Where(c => c.Id == Id).First();
                    cars.Active = false;
                    context.SaveChanges();
               

            }

        }



        public void AddCar(string Brand,string Model,string RegistrationNumber, short NumberOfSeats)
        {
            if (checkCarInDatabase(RegistrationNumber) == false)
            {
                using (PodrozeEntities context = new PodrozeEntities())
                {
                    Cars cars = new Cars();
                    cars.Brand = Brand;
                    cars.Model = Model;
                    cars.RegistrationNumber = RegistrationNumber;
                    cars.NumberOfSeats = NumberOfSeats;
                    cars.Active = true;
                    context.Cars.Add(cars);

                    context.SaveChanges();
                        System.Windows.Forms.MessageBox.Show("Pojazd " + Brand+" "+Model+" " + RegistrationNumber+ " został utworzony");
                }
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Pojazd " + Brand + " " + Model + " " + RegistrationNumber + " istnieje w bazie");
            }
        }
        
        public bool checkCarInDatabase(string registrationNumber)
        {
            bool isCarInDatabase = false;

            using (PodrozeEntities context = new PodrozeEntities())
            {

                var carInDatabase = (from car in context.Cars
                                      where car.RegistrationNumber == registrationNumber
                                      select car
                    );
                List<Cars> carList = carInDatabase.ToList();
                if (carList.Count != 0)
                {
                    isCarInDatabase = true;

                  //  System.Windows.Forms.MessageBox.Show("w bazie jest "+ carList.Count.ToString() + " samochodów o rejestracji " + registrationNumber);
                }
                else
                {
                  //  System.Windows.Forms.MessageBox.Show("Brak w bazie samochodu o rejestracji " + registrationNumber);
                }
            }
            return isCarInDatabase;
        }
    }

    class SuperVisorUsers
    {


        public void AddUser(string Login, string Password, string FirstName, string SurName, string Department)
        {
            int DepartmentId=1;
            
            if (checkUserInDatabase(Login) == false)
            {
                using (PodrozeEntities context = new PodrozeEntities())
                {
                    var depart = (from department in context.Departments
                                  where department.DepartmentName == Department
                                  select department.Id
                                      );                    
                    DepartmentId = depart.ToList()[0];

                    Users users = new Users();
                    //  users.Id = Id;
                    users.Login = Login;
                    users.Password = Password;
                    users.FirstName = FirstName;
                    users.SurName = SurName;
                    users.DepartmentId = DepartmentId;
                    users.Active = true;
                    context.Users.Add(users);
                    context.SaveChanges();
                    System.Windows.Forms.MessageBox.Show("Użytkownik " + Login + " został utworzony");
                }
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Użytkownik " + Login + " znajduje się już w bazie danych");
            }


        }




        public void AddUser(string Login, string Password, string FirstName, string SurName, int DepartmentId)
        {
    

            if (checkUserInDatabase(Login) == false)
            {
                using (PodrozeEntities context = new PodrozeEntities())
                {
                    Users users = new Users();
                    //  users.Id = Id;
                    users.Login = Login.ToLower();
                    users.Password = Password;
                    users.FirstName = FirstName;
                    users.SurName = SurName;
                    users.DepartmentId = DepartmentId;
                    users.Active = true;
                    context.Users.Add(users);
                    context.SaveChanges();
                    System.Windows.Forms.MessageBox.Show("Użytkownik " + Login + " został utworzony");
                }
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Użytkownik " + Login + " znajduje się już w bazie danych");
            }
        }

        public void deleteUser(Users user)
        {

            using (PodrozeEntities context = new PodrozeEntities())
            {
               
                   
                    int Id = user.Id;
                    user = context.Users.Where(c => c.Id == Id).First();
                    user.Active = false;
                    context.SaveChanges();
                

            }

        }


        public bool checkUserInDatabase(string checkedUser)
        {
            bool isUserInDatabase = false;
            using (PodrozeEntities context = new PodrozeEntities())
            {
                var userInDatabase = (from user in context.Users
                                      where user.Login == checkedUser
                                      select user
                    );
                List<Users> userList = userInDatabase.ToList();
                if (userList.Count != 0)
                {
                    isUserInDatabase = true;
                }
            }
            return isUserInDatabase;
        }

        public List<string> getUsersLogins()
        {
            List<string> users = new List<string>();

            using (PodrozeEntities context1 = new PodrozeEntities())
            {
         
                var usersInDatabase = (from user in context1.Users
                                             where user.Active == true
                                             select user.Login);
                users = usersInDatabase.ToList();
            }
             
             return users;


        }

        public List<string> getDepartments()
        {

            PodrozeEntities context1 = new PodrozeEntities();
            List<string> departments = new List<string>();
            var departmentsInDatabase = (from department in context1.Departments
                                         where department.Active == true
                                         select department.DepartmentName);
            departments = departmentsInDatabase.ToList();
             return departments;
        }
    
    }
    
}
