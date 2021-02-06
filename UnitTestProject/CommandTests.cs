using Microsoft.VisualStudio.TestTools.UnitTesting;
using NSubstitute;
using ProductFunction;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProductFunction.Tests
{
    [TestClass()]
    public class CommandTests
    {
        private ICommand _command;
        private int _numberOfTimesToCall;

        [TestInitialize]
        public void TestInitialize()
        {
            this._command = Substitute.For<ICommand>();
        }
        private Command GetSystemUnderTest()
        {
            var sut = new Command(this._command, this._numberOfTimesToCall);

            return sut;
        }

        [TestMethod()]
        [Owner("Sian")]
        [TestCategory("CommandTests")]
        [TestProperty("CommandTests", "Execute")]
        public void Execute_被執行了3次_正確計算應為3()
        {
            //arrange
            this._numberOfTimesToCall = 3;
            var sut = GetSystemUnderTest();

            //Act
            sut.Execute();

            //Assert
            this._command.Received(3).Execute();
        }

        [TestMethod()]
        [Owner("Sian")]
        [TestCategory("CommandTests")]
        [TestProperty("CommandTests", "Execute")]
        public void Execute_被執行了4次_計算為3會報錯()
        {
            //arrange
            this._numberOfTimesToCall = 4;
            var sut = GetSystemUnderTest();

            //Act
            sut.Execute();

            //Assert
            this._command.Received(3).Execute();
        }
    }
}