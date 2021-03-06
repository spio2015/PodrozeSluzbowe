﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PodrozeSluzbowe.Supervisor;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace PodrozeSluzbowe.Supervisor.Tests
{
    [TestClass()]
    public class SuperVisorCarTests
    {
        bool actual;
        private bool expected;
        private short numberOfSeats;
        private string registrationNuber;
        private SuperVisorCar superVisorCar;
        [TestInitialize()]
        public void TestInitialize()
        {
            superVisorCar = new SuperVisorCar();
        }




        [TestMethod()]
        public void checkNumberOfSeatsValueTest11()
        {
            
             numberOfSeats = 11;
           
            actual = superVisorCar.checkNumberOfSeatsValue(numberOfSeats);
        
            expected = false;

            Assert.AreEqual(actual,expected);
            //Assert.Fail();
        }
        [TestMethod()]
        public void checkNumberOfSeatsValueTest4()
        {
            superVisorCar = new SuperVisorCar();
           numberOfSeats = 4;
            bool actual;
            actual = superVisorCar.checkNumberOfSeatsValue(numberOfSeats);

            expected = true;

            Assert.AreEqual(actual, expected);
            //Assert.Fail();
        }

        [TestMethod()]
        public void CheckCarInDatabaseTestPo12345()
        {
            registrationNuber = "PO 12345";
            actual = superVisorCar.checkCarInDatabase(registrationNuber);
            expected = true;
            Assert.AreEqual(actual,expected);
        }

        [TestMethod()]
        public void checkCarInDatabaseTestZW12311()
        {
            registrationNuber = "ZW 12311";
            actual = superVisorCar.checkCarInDatabase(registrationNuber);
            expected = false;
            Assert.AreEqual(actual, expected);
        }

        private string brand;
        private string model;
        private string registrationNuberer;
        private string expectedString;
        private string actualString;
        private short numbererOfSeats;
        [TestMethod()]
        public void AddCarTestPO12345()
        {
            brand = "Opel";
            model = "Astra";
             registrationNuberer = "PO 12345";
             numbererOfSeats = 5;
            actualString = superVisorCar.AddCar(brand, model, registrationNuberer, numbererOfSeats);
            expectedString = "CarExists";
            Assert.AreEqual(actualString,expectedString);
        }

        [TestMethod()]
        public void AddCarTestPO12345ToManySeats()
        {
            brand = "Opel";
            model = "Astra";
            registrationNuberer = "PO 12345";
             numbererOfSeats = 11;
            actualString = superVisorCar.AddCar(brand, model, registrationNuberer, numbererOfSeats);
            expectedString = "toManySeats";
            Assert.AreEqual(actualString, expectedString);
        }



    }
}
