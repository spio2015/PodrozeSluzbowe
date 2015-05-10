﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Database;
using System.Data.Entity;

namespace PodrozeSluzbowe.Supervisor
{
    class SuperVisor
    {
        public void AddUser(string Login, string Password, string FirstName, string SurName, int DepartmentId)
        {
            /*
            using (PodrozeEntities context = new PodrozeEntities())
            {
                Destinations destination = new Destinations();
                destination.Address = Address;
                destination.Latitude = Latitude;
                destination.Longitude = Longitude;
                context.Destinations.Add(destination);
                context.SaveChanges();
                return destination.Id;
            }
             */

            if (checkUserInDatabase(Login) == false)
            {
                using (PodrozeEntities context = new PodrozeEntities())
                {
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
        /*
        public void AddCar(string Brand,string Model,string RegistrationNumber, short NumberOfSeats, bool Active)
        {
            using (PodrozeEntities context = new PodrozeEntities())
                {
                    Cars cars = new Cars();
                cars.Brand = Brand;
                cars.Model = Model;
                cars.RegistrationNumber = RegistrationNumber;
                cars.NumberOfSeats = NumberOfSeats;
                cars.Active = true;
                 //   context.Users.Add(cars);
                    context.SaveChanges();
                //    System.Windows.Forms.MessageBox.Show("Pojazd " + Brand+" "+Model+" " + " został utworzony");
                }
            
         

        }
        */
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

                    System.Windows.Forms.MessageBox.Show("w bazie jest "+ carList.Count.ToString() + " samochodów o rejestracji " + registrationNumber);
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("Brak w bazie samochodu o rejestracji " + registrationNumber);

                }

            }

            return isCarInDatabase;
        }


    }
}
