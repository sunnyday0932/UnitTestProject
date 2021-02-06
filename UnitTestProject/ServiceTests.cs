using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProductFunction;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProductFunction.Tests
{
    [TestClass()]
    public class ServiceTests
    {
        //[TestMethod()]
        //[Owner("Sian")]
        //[TestCategory("ServiceTest")]
        //[TestProperty("ServiceTests", "GetAccount")]
        //public void GetAccount_傳入存在的帳號_應回傳正確帳號資訊()
        //{
        //    //arrange
        //    var account = "123";
        //    var expect = new AccountModel
        //    {
        //        Account = "a123",
        //        UserName = "test"
        //    };
        //    var service = new AccountService();

        //    //act
        //    var actual = service.GetAccount(account);
        //    //assert

        //    actual.Should().BeEquivalentTo(expect);
        //}
    }

    //public class AccountService : IService
    //{
    //    public AccountModel GetAccount(string account)
    //    {
    //        return new AccountModel
    //        {
    //            Account = "a123",
    //            UserName = "test"
    //        };
    //    }

    //    public bool UpdateAccount(AccountModel model)
    //    {
    //        throw new NotImplementedException();
    //    }
    //}
}