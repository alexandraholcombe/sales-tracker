using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;
using SalesTracker.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace SalesTracker.Tests
{
    public class ItemControllerTest
    {
        [Fact]
        public void Get_ViewResult_Details_Test()
        {
            //Arrange
            ItemController controller = new ItemController();

            //Act
            var result = controller.Index();

            //Assert
            Assert.IsType<ViewResult>(result);
        }
    }
}
