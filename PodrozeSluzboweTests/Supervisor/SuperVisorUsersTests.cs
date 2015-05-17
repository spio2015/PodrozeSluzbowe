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

    }
}
