using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PodrozeSluzbowe.Supervisor;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace PodrozeSluzbowe.Supervisor.Tests
{
    [TestClass()]
    public class SuperVisorUsersTests
    {
        [TestMethod()]
        public void checkUserInDatabaseTestAnowak()
        {
            SuperVisorUsers superV = new SuperVisorUsers();
            string userInDatabase = "anowak";
            bool actual;
            bool expected = true;
            actual = superV.checkUserInDatabase(userInDatabase);
            Assert.AreEqual(expected, actual);
         
        }

        [TestMethod()]
        public void CheckUserInDatabaseTestCkowalski()
        {
            SuperVisorUsers superV = new SuperVisorUsers();
            string userInDatabase = "ckowalski";
            bool actual;
            bool expected = false;
            actual = superV.checkUserInDatabase(userInDatabase);
            Assert.AreEqual(expected, actual);

        }
        string login;
        string password;
        string password2;
        string firstName;
        string surName;
        string departmentId;

        [TestMethod()]
        public void AddUserTestanowak()
        {
            string expectedstring;
            string actualstring;
            login = "anowak";
             password = "12345";
            password2 = "12345";
             firstName = "Andrzej";
             surName = "Nowak";
             departmentId = "IT";
            SuperVisorUsers superV = new SuperVisorUsers();
             actualstring = superV.AddUser(login, password, password2, firstName, surName, departmentId);
              expectedstring = "userExists";

              Assert.AreEqual(expectedstring, actualstring);
        }

    }
}
