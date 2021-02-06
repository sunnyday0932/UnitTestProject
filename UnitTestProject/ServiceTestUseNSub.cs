using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NSubstitute;
using ProductFunction;
using Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTestProject
{
    [TestClass()]
    public class ServiceTestUseNSub
    {
        private ILog _log;
        private IRepository _repository;

        [TestInitialize]
        public void TestInitialize()
        { 
            this._log = Substitute.For<ILog>();
            this._repository = Substitute.For<IRepository>();
        }
        private Service GetSystemUnderTest()
        {
            var sut = new Service(this._repository,this._log);

            return sut;
        }

        [TestMethod()]
        [Owner("Sian")]
        [TestCategory("ServiceTest")]
        [TestProperty("ServiceTests", "GetAccount")]
        public void GetAccount_傳入存在的帳號_應回傳正確帳號資訊()
        {
            //arrange
            var account = "123";
            var expect = new AccountModel
            {
                Account = "123",
                UserName = "test"
            };
            var service = Substitute.For<IService>();
            service.GetAccount(account).Returns(expect);

            //act
            var actual = service.GetAccount(account);

            //assert
            actual.Should().NotBeNull();
            actual.Should().BeEquivalentTo(expect);
        }

        [TestMethod()]
        [Owner("Sian")]
        [TestCategory("ServiceTest")]
        [TestProperty("ServiceTests", "Check")]
        public void log_是否有被呼叫()
        {
            //arrange
            var sut = GetSystemUnderTest();

            //act
            var actual = sut.Check(string.Empty);

            //assert
            actual.Should().BeFalse();
            this._log.Received(1);
        }

        [TestMethod()]
        [Owner("Sian")]
        [TestCategory("ServiceTest")]
        [TestProperty("ServiceTests", "Check")]
        public void log_有被呼叫_應記下正確內容()
        {
            //arrange
            var sut = GetSystemUnderTest();
            //act
            var actual = sut.Check(string.Empty);

            //assert
            actual.Should().BeFalse();
            this._log.Received(1).SaveLog(Arg.Is<string>(x => x.Contains("text")));
        }

        [TestMethod()]
        [Owner("Sian")]
        [TestCategory("ServiceTest")]
        [TestProperty("ServiceTests", "Check")]
        public void log_沒有被呼叫()
        {
            //arrange
            var sut = GetSystemUnderTest();
            //act
            var actual = sut.Check("123");

            //assert
            actual.Should().BeTrue();
            this._log.DidNotReceive();
        }

        [TestMethod()]
        [Owner("Sian")]
        [TestCategory("ServiceTest")]
        [TestProperty("ServiceTests", "InsertAccount")]
        public void InsertAccount_成功_應回傳true()
        {
            //arrange
            var data = new AccountModel
            {
                Account = "123",
                UserName = "Sian"
            };
            var sut = GetSystemUnderTest();
            this._repository.InsertAccount(Arg.Any<AccountModel>()).Returns(true);

            //act
            var actual = sut.InserAccount(data);

            //assert
            actual.Should().BeTrue();
        }

        [TestMethod()]
        [Owner("Sian")]
        [TestCategory("ServiceTest")]
        [TestProperty("ServiceTests", "InsertAccount")]
        public void InsertAccount_失敗_應回傳False()
        {
            //arrange
            var data = new AccountModel
            {
                Account = "123",
                UserName = "Sian"
            };
            var sut = GetSystemUnderTest();
            this._repository.InsertAccount(Arg.Any<AccountModel>()).Returns(false);

            //actr
            var actual = sut.InserAccount(data);

            //assert
            actual.Should().BeFalse();
        }
    }
}
