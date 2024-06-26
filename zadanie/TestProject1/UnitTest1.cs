using LegacyApp;

namespace TestProject1;

public class UnitTest1
{
    [Fact]
    public void AddUser_Should_Return_False_When_Email_Without_At_And_Dot()
    {
        //Arrange
        string name = "John";
        string lastName = "Doe";
        DateTime birthDate = new DateTime(1998, 2, 1);
        int clientId = 1;
        string email = "doe";
        var service = new UserService();

        //Act

        bool result = service.AddUser(name, lastName, email, birthDate, clientId);
        
        //Assert
        
        Assert.Equal(false,result);
        
    }
}