using CloudCustomers.API.Models;

namespace CloudCustomers.UnitTests.Fixtures
{
    public class UsersFixture
    {
        public static List<User> GetTestUsers() =>
        new()
        {
            new User
            {
                Name = "Matt",
                Email = "matt@test.com",
                Address = new Address
                {
                    Street = "124 Albert St",
                    City = "Earth",
                    ZipCode ="45423"
                }
            },
            new User
            {
                Name = "Mary",
                Email = "mary@test.com",
                Address = new Address
                {
                    Street = "24 Alt St",
                    City = "Land",
                    ZipCode ="4423"
                }
            }

        };
    }
}
