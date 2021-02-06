using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProductFunction;
using System;
using System.Collections.Generic;
using System.Text;
using UnitTestProject;

namespace ProductFunction.Tests
{
    [TestClass()]
    public class Class1Tests
    {
        [TestMethod()]
        [Owner("Sian")]
        [TestCategory("Class1")]
        [TestProperty("Class1", "GetUserName")]
        public void GetUserName_輸入的UserName為空值_應回傳提示訊息()
        {
            //arrange
            var target = new Class1();
            var name = string.Empty;
            var expected = "請輸入使用者姓名!";

            //act
            var actual = target.GetUserName(name);

            //assert
            actual.Should().Be(expected);
        }

        [TestMethod()]
        [Owner("Sian")]
        [TestCategory("Class1")]
        [TestProperty("Class1", "GetUserName")]
        public void GetUserName_輸入的UserName為Null_應回傳提示訊息()
        {
            //arrange
            var target = new Class1();
            string name = null;
            var expected = "請輸入使用者姓名!";

            //act
            var actual = target.GetUserName(name);

            //assert
            actual.Should().Be(expected);
        }

        [TestMethod()]
        [Owner("Sian")]
        [TestCategory("Class1")]
        [TestProperty("Class1", "GetUserName")]
        public void GetUserName_輸入的UserName不為空_應回傳正確訊息()
        {
            //arrange
            var target = new Class1();
            string name = "Sian";
            var expected = $"Hi!{name}，歡迎使用";

            //act
            var actual = target.GetUserName(name);

            //assert
            actual.Should().Be(expected);
        }

        [TestMethod()]
        [Owner("Sian")]
        [TestCategory("Class1")]
        [TestProperty("Class1", "ExceptionTest")]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ExceptionTest_輸入的UserName為空_應回傳ArgumentNullException()
        {
            //arrange
            var target = new Class1();
            string name = string.Empty;

            //act
            var actual = target.ExceptionTest(name);
        }

        [TestMethod()]
        [Owner("Sian")]
        [TestCategory("Class1")]
        [TestProperty("Class1", "Object")]
        public void ObjectTest_比較兩個相同物件_應回傳正確結果()
        {
            //arrange 
            var fistObject = new TestModel
            {
                Account = "abc",
                UserName = "Sian"
            };

            var secondObject = new TestModel
            {
                Account = "abc",
                UserName = "Sian"
            };

            //secondObject.Should().Be(fistObject);
            //Assert.AreEqual(fistObject,secondObject);
            //Assert.AreSame(fistObject, secondObject);
            secondObject.Should().BeEquivalentTo(fistObject);
        }

        [TestMethod()]
        [Owner("Sian")]
        [TestCategory("Class1")]
        [TestProperty("Class1", "CollectionTest")]
        public void CollectionTest_比較兩個集合_應回傳正確結果()
        {
            //arrange 
            var fistCollection = new List<TestModel>
            {
                new TestModel
                {
                    Account = "abc",
                    UserName = "Sian"
                }
            };

            var secondCollection = new List<TestModel>
            {
                new TestModel
                {
                    Account = "abc",
                    UserName = "Sian"
                }
            };

            secondCollection.Should().BeEquivalentTo(fistCollection);
        }

        [TestMethod()]
        [Owner("Sian")]
        [TestCategory("Class1")]
        [TestProperty("Class1", "GetNewYear")]
        public void GetNewYear_若今天是新年_應回傳提示訊息()
        {
            //arrange
            var target = new Class1();
            var expected = "Happy NEW YEAR!";

            SystemTime.SetToday = () => new DateTime(year: 2021, month: 1, day: 1);

            //act
            var actual = target.GetNewYear();

            //assert
            actual.Should().Be(expected);
        }

        [TestMethod()]
        [Owner("Sian")]
        [TestCategory("Class1")]
        [TestProperty("Class1", "GetNewYear")]
        public void GetNewYear_若今天不是新年_應回傳提示訊息()
        {
            //arrange
            var target = new Class1();
            var expected = "Today is not Holiday";

            //act
            var actual = target.GetNewYear();

            //assert
            actual.Should().Be(expected);
        }

        

        [TestInitialize]
        public void TestInitial()
        {
            SystemTime.SetToday = () => DateTime.Today;
        }

        [TestCleanup]
        public void TestClean()
        {
            SystemTime.SetToday = () => DateTime.Today;
        }
    }
}
