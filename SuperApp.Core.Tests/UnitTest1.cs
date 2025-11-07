using SuperApp.Core;
using Xunit;
public class GreeterTests
{
	[Fact]
	public void Greet_ValidName_ReturnsCorrectMessage()
	{
		// Arrange
		var name = "CLI Master";
		// Act
		var result = Greeter.Greet(name);
		// Assert
		Assert.Equal("Hello, CLI Master! Welcome to SuperApp!", result);
	}
}
