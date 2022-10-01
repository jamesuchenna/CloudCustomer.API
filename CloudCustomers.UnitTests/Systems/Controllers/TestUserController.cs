using CloudCustomers.API.Controllers;
using CloudCustomers.API.Interfaces;
using CloudCustomers.API.Models;
using FluentAssertions;
using Microsoft.AspNetCore.Mvc;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace CloudCustomers.UnitTests.Systems.Controllers
{
    public class TestUserController
    {
        [Fact]
        public async Task Get_OnSuccess_ReturnStatusCode200()
        {
            // Arrange
            var sut = new UserController(IUserService);

            // Act
            var result = (OkObjectResult)await sut.Get();

            // Assert
            result.StatusCode.Should().Be(200);
        }

        public async Task Get_OnSuccess_InvokeUserService()
        {
            // Arrange
            var mockService = new Mock<IUserService>();
            mockService
                .Setup(service => service.GetAllUsers())
                .ReturnsAsync(new List<User>());

            var sut = new UserController(mockService.Object);

            // Act
            var result = (OkObjectResult)await sut.Get();

            // Assert
        }
    }
}
