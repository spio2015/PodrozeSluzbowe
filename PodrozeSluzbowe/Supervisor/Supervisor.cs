﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Database;
using System.Data.Entity;

namespace PodrozeSluzbowe.Supervisor
{
   public class SuperVisorCar
    {            
      const short maxNumberOfSeats = 9;
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

        public string AddCar(string Brand, string Model, string RegistrationNumber, short NumberOfSeats)
        {

            if (NumberOfSeats <= maxNumberOfSeats)
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
                        System.Windows.Forms.MessageBox.Show("Pojazd " + Brand + " " + Model + " " + RegistrationNumber + " został utworzony");
                        return "CarAdded";
                    }
                }
                else
                {
                    // System.Windows.Forms.MessageBox.Show("Pojazd " + Brand + " " + Model + " " + RegistrationNumber + " istnieje w bazie");

                    using (PodrozeEntities context = new PodrozeEntities())
                    {
                        Cars carar = new Cars();
                        carar = context.Cars.Where(c => c.RegistrationNumber == RegistrationNumber).First();
                        if (carar.Active == true)
                        {
                            System.Windows.Forms.MessageBox.Show("Pojazd " + Brand + " " + Model + " " + RegistrationNumber + " istnieje w bazie");
                            return "CarExists";
                        }
                        else
                        {
                            if (System.Windows.Forms.DialogResult.Yes == System.Windows.Forms.MessageBox.Show("Pojazd o numerze rejestracyjnym " + RegistrationNumber + " istnieje w bazie pojazdów jako nieaktywny. Czy chcesz przywrócić samochód? Pojazd zostanie przywrócony z poprzednimi parametrami", "Info", System.Windows.Forms.MessageBoxButtons.YesNo))
                            {

                                carar.Active = true;
                                context.SaveChanges();
                                return "CarAdded";
                            }
                            else
                            {
                                System.Windows.Forms.MessageBox.Show("Zaniechano dodawania pojazdu");
                                return "addAborted";
                            }
                        }

                    }
                }
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("liczba miejsc w samochodze nie może być większa niż " + maxNumberOfSeats.ToString());
                return "toManySeats";
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

       public bool checkNumberOfSeatsValue(short nmbOfSeats)
        {
           bool isThatGoodValue = false;
           if (nmbOfSeats < maxNumberOfSeats) { isThatGoodValue = true; }

           return isThatGoodValue;
        }
    }

  public  class SuperVisorUsers
    {
        public string AddUser(string Login, string Password, string Password2, string FirstName, string SurName, string Department)
        {
            int DepartmentId=1;
            if (checkUserInDatabase(Login) == false)            
            {
                if (Password == Password2)
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
                    return "userAdded";
                }
                    else
                    {
                        System.Windows.Forms.MessageBox.Show("wpisane hasła nie są jednakowe");
                        return "passwordMismatch";
                    }        
            }            
            else
            {
                using (PodrozeEntities context = new PodrozeEntities())
                {
                    Users user = new Users();                   
                    user = context.Users.Where(c => c.Login == Login).First();
                    if (user.Active == true)
                    {
                        System.Windows.Forms.MessageBox.Show("Użytkownik " + Login + " znajduje się już w bazie danych");
                        return "userExists";
                    }
                    else
                    {
                        if (System.Windows.Forms.DialogResult.Yes == System.Windows.Forms.MessageBox.Show("Użytkownik " + Login + " znajduje się w bazie użytkowników jako nieaktywny. Czy chcesz przywrócić użytkownika? Użytkownik zostanie przywrócony z poprzednimi parametrami", "Info", System.Windows.Forms.MessageBoxButtons.YesNo))
                        {
                            user.Active = true;
                            context.SaveChanges();
                            return "userReplaced";
                        }
                        else
                        {
                            System.Windows.Forms.MessageBox.Show("Zaniechano dodawania użytkownika");
                            return "userAddAbort";
                        }
                    }
                }             
            }
        }
        public void AddUser(string Login, string Password, string FirstName, string SurName, int DepartmentId)
        {
            if (checkUserInDatabase(Login) == false)
            {
                using (PodrozeEntities context = new PodrozeEntities())
                {
                    Users users = new Users();                
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
