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
        public void checkUserInDatabaseTest()
        {
            SuperVisorUsers superV = new SuperVisorUsers();
            string userInDatabase = "anowak";
            bool actual;
            bool expected = true;
            actual = superV.checkUserInDatabase(userInDatabase);
            Assert.AreEqual(expected, actual);
         
        }
    }
}
