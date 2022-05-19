using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing1
{
    [TestClass]
    public class tstStaff
    {
        String StaffName = "John Smith";
        String Role = "User";
        String Gender = "Male";
        String JoinDate = DateTime.Now.Date.ToString();



        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //test to see that it exists
            Assert.IsNotNull(AnStaff);



        }
        [TestMethod]
        public void StaffIdPropertyOK()
        {
            //Create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //create some test data to assign to the property
            int TestData = 3;
            //assign the data to the property
            AnStaff.StaffID = TestData;
            //test to see the twp values are the same
            Assert.AreEqual(AnStaff.StaffID, TestData);
        }
        [TestMethod]
        public void JoinDatePropertyOK()
        {
            clsStaff AnStaff = new clsStaff();
            DateTime TestData = DateTime.Now.Date;
            AnStaff.JoinDate = TestData;
            Assert.AreEqual(AnStaff.JoinDate, TestData);
        }
        [TestMethod]
        public void StaffNamePropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //create some test data to assign to the property
            string TestData = " ADE ";
            //assign the data to the property
            AnStaff.StaffName = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnStaff.StaffName, TestData);
        }
        [TestMethod]
        public void RolePropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //create some test data to assign to the property
            string TestData = "User";
            //assign the data to the property
            AnStaff.Role = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnStaff.Role, TestData);
        }
        [TestMethod]
        public void GenderPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //create some test data to assign to the property
            string TestData = "MALE";
            //assign the data to the property
            AnStaff.Gender = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnStaff.Gender, TestData);
        }
        [TestMethod]
        public void EighteenPlusPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //create some test data to assign to the property
            Boolean TestData = true;
            //assign the data to the property
            AnStaff.EighteenPlus = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnStaff.EighteenPlus, TestData);
        }

        [TestMethod]
        public void TestStaffIdFound()
        {
            clsStaff AnStaff = new clsStaff();
            Boolean Found = false;
            Boolean OK = true;
            Int32 StaffID = 3;
            Found = AnStaff.Find(StaffID);
            if (AnStaff.StaffID != 3)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestJoinDateFound()
        {
            clsStaff AnStaff = new clsStaff();
            Boolean Found = false;
            Boolean OK = true;
            Int32 StaffID = 3;
            Found = AnStaff.Find(StaffID);
            if (AnStaff.JoinDate != Convert.ToDateTime("03/02/2020"))
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestStaffNameFound()
        {
            clsStaff AnStaff = new clsStaff();
            Boolean Found = false;
            Boolean OK = true;
            Int32 StaffID = 3;
            Found = AnStaff.Find(StaffID);
            if (AnStaff.StaffName != "Robert Smith")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]

        public void TestRoleFound()
        {
            clsStaff AnStaff = new clsStaff();
            Boolean Found = false;
            Boolean OK = true;
            Int32 StaffID = 3;
            Found = AnStaff.Find(StaffID);
            if (AnStaff.Role != "Administrator")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestGenderFound()
        {
            clsStaff AnStaff = new clsStaff();
            Boolean Found = false;
            Boolean OK = true;
            Int32 StaffID = 3;
            Found = AnStaff.Find(StaffID);
            if (AnStaff.Gender != "FEMALE")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestEighteenPlusFound()
        {
            clsStaff AnStaff = new clsStaff();
            Boolean Found = false;
            Boolean OK = true;
            Int32 StaffID = 3;
            Found = AnStaff.Find(StaffID);
            if (AnStaff.EighteenPlus != true)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            clsStaff AnStaff = new clsStaff();
            Boolean Found = false;
            Int32 StaffID = 3;
            Found = AnStaff.Find(StaffID);
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void ValidMethodOK()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            Error = AnStaff.Valid(StaffName, JoinDate, Role, Gender);
            Assert.AreEqual(Error, "");


        }

        [TestMethod]
        public void StaffNameMinLessOne()
        {
            clsStaff Anstaff = new clsStaff();
            String Error = "";
            String StaffName = "";
            Error = Anstaff.Valid(StaffName, JoinDate, Role, Gender);
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void StaffNameMin()
        {
            clsStaff AnStaff = new clsStaff();
            string Error = "";
            String StaffName = "a";
            Error = AnStaff.Valid(StaffName, JoinDate, Role, Gender);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffNameMinPlusOne()
        {

            clsStaff AnStaff = new clsStaff();

            String Error = "";

            string StaffName = "aa";

            Error = AnStaff.Valid(StaffName, JoinDate, Role, Gender);

            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffNameMaxLessOne()
        {
            clsStaff AnStaff = new clsStaff();

            String Error = "";

            string StaffName = "aaaaa";

            Error = AnStaff.Valid(StaffName, JoinDate, Role, Gender);

            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void StaffNameMax()
        {
            clsStaff AnStaff = new clsStaff();

            String Error = "";

            string StaffName = "aaaaaa";

            Error = AnStaff.Valid(StaffName, JoinDate, Role, Gender);

            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void StaffNameMaxPlusOne()
        {
            clsStaff AnStaff = new clsStaff();

            String Error = "";

            string StaffName = "";
            StaffName.PadRight(51, 'a');

            Error = AnStaff.Valid(StaffName, JoinDate, Role, Gender);

            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void StaffNameMid()
        {
            clsStaff AnStaff = new clsStaff();

            String Error = "";

            string StaffName = "aaa";

            Error = AnStaff.Valid(StaffName, JoinDate, Role, Gender);

            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void StaffNameExtremeMax()
        {
            clsStaff AnStaff = new clsStaff();

            String Error = "";

            string StaffName = "";
            StaffName = StaffName.PadRight(500, 'a');

            Error = AnStaff.Valid(StaffName, JoinDate, Role, Gender);

            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void RoleMinLessOne()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            String Role = "";
            Error = AnStaff.Valid(StaffName, JoinDate, Role, Gender);
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void RoleMin()
        {
            clsStaff AnStaff = new clsStaff();
            string Error = "";
            String Role = "a";
            Error = AnStaff.Valid(StaffName, JoinDate, Role, Gender);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void RoleMinPlusOne()
        {

            clsStaff AnStaff = new clsStaff();

            String Error = "";

            string Role = "aa";

            Error = AnStaff.Valid(StaffName, JoinDate, Role, Gender);

            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void RoleMaxLessOne()
        {
            clsStaff AnStaff = new clsStaff();

            String Error = "";

            string Role = "aaaaa";

            Error = AnStaff.Valid(StaffName, JoinDate, Role, Gender);

            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void RoleMax()
        {
            clsStaff AnStaff = new clsStaff();

            String Error = "";

            string Role = "aaaaaa";

            Error = AnStaff.Valid(StaffName, JoinDate, Role, Gender);

            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void RoleMaxPlusOne()
        {
            clsStaff AnStaff = new clsStaff();

            String Error = "";

            string StaffName = "";
            Role.PadRight(51, 'a');

            Error = AnStaff.Valid(StaffName, JoinDate, Role, Gender);

            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void RoleMid()
        {
            clsStaff AnStaff = new clsStaff();

            String Error = "";

            string Role = "aaa";

            Error = AnStaff.Valid(StaffName, JoinDate, Role, Gender);

            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void RoleExtremeMax()
        {
            clsStaff AnStaff = new clsStaff();

            String Error = "";

            string Role = "";
            Role = Role.PadRight(500, 'a');

            Error = AnStaff.Valid(StaffName, JoinDate, Role, Gender);

            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void GenderMinLessOne()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            String Gender = "";
            Error = AnStaff.Valid(StaffName, JoinDate, Role, Gender);
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void GenderMin()
        {
            clsStaff AnStaff = new clsStaff();
            string Error = "";
            String Gender = "a";
            Error = AnStaff.Valid(StaffName, JoinDate, Role, Gender);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void GenderMinPlusOne()
        {

            clsStaff AnStaff = new clsStaff();

            String Error = "";

            string Gender = "aa";

            Error = AnStaff.Valid(StaffName, JoinDate, Role, Gender);

            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void GenderMaxLessOne()
        {
            clsStaff AnStaff = new clsStaff();

            String Error = "";

            string Gender = "aaaaa";

            Error = AnStaff.Valid(StaffName, JoinDate, Role, Gender);

            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void GenderMax()
        {
            clsStaff AnStaff = new clsStaff();

            String Error = "";

            string Gender = "aaaaaa";

            Error = AnStaff.Valid(StaffName, JoinDate, Role, Gender);

            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void GenderMaxPlusOne()
        {
            clsStaff AnStaff = new clsStaff();

            String Error = "";

            string Gender = "";
            Gender.PadRight(51, 'a');

            Error = AnStaff.Valid(StaffName, JoinDate, Role, Gender);

            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void GenderMid()
        {
            clsStaff AnStaff = new clsStaff();

            String Error = "";

            string Gender = "aaa";

            Error = AnStaff.Valid(StaffName, JoinDate, Role, Gender);

            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void GenderExtremeMax()
        {
            clsStaff AnStaff = new clsStaff();

            String Error = "";

            string Gender = "";
            Gender = Gender.PadRight(500, 'a');

            Error = AnStaff.Valid(StaffName, JoinDate, Role, Gender);

            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void JoinDateExtremeMin()
        {
            clsStaff AnStaff = new clsStaff();

            String Error = "";

            DateTime TestDate;

            TestDate = DateTime.Now.Date;

            TestDate = TestDate.AddYears(-100);

            string JoinDate = TestDate.ToString();

            Error = AnStaff.Valid(StaffName, JoinDate, Role, Gender);

            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void JoinDateMinLessOne()
        {
            clsStaff AnStaff = new clsStaff();

            String Error = "";

            DateTime TestDate;

            TestDate = DateTime.Now.Date;

            TestDate = TestDate.AddDays(-1);

            string JoinDate = TestDate.ToString();

            Error = AnStaff.Valid(StaffName, JoinDate, Role, Gender);

            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void JoinDateMin()
        {
            clsStaff AnStaff = new clsStaff();

            String Error = "";

            DateTime TestDate;

            TestDate = DateTime.Now.Date;


            string JoinDate = TestDate.ToString();

            Error = AnStaff.Valid(StaffName, JoinDate, Role, Gender);

            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void JoinDateMinPlusOne()
        {
            clsStaff AnStaff = new clsStaff();

            String Error = "";

            DateTime TestDate;

            TestDate = DateTime.Now.Date;

            TestDate = TestDate.AddDays(1);

            string JoinDate = TestDate.ToString();

            Error = AnStaff.Valid(StaffName, JoinDate, Role, Gender);

            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void JoinDateExtremeMax()
        {
            clsStaff AnStaff = new clsStaff();

            String Error = "";

            DateTime TestDate;

            TestDate = DateTime.Now.Date;

            TestDate = TestDate.AddYears(100);

            string JoinDate = TestDate.ToString();

            Error = AnStaff.Valid(StaffName, JoinDate, Role, Gender);

            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void JoinDateInvalidData()
        {
            clsStaff AnStaff = new clsStaff();

            String Error = "";

            string JoinDate = "this is not a date";

            Error = AnStaff.Valid(StaffName, JoinDate, Role, Gender);

            Assert.AreNotEqual(Error, "");
        }






    }
}