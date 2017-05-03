using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SalesTracker.Models;
using Xunit;

namespace SalesTracker.Tests
{
    public class UserTest
    {
        [Fact]
        public void GetUserNameTest()
        {
            //Arrange
            var user = new User();
            user.UserName = "geekang";
            //Act
            var result = user.UserName;

            //Assert
            Assert.Equal("geekang", result);
        }

        //public void Dispose()
        //{
        //    User.DeleteAll();
        //}
    }
}
