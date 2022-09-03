namespace MyApp.Tests;

public class UnitTest1
{
    [Fact]
    public void first_rule_divided_by_4_true()
    {
        // Arrange
        var program = new Program();
        
        // Act
        var answer = program.IsLeapYear(2004);

        // Assert
        answer.Should().Be(true);
    }
     [Fact]
      public void first_rule_divided_by_4_false()
    {
        // Arrange
        var program = new Program();

        // Act
        var answer = program.IsLeapYear(2001);

        // Assert
        answer.Should().Be(false);
    }
        [Fact]
      public void rule_divided_by_100()
    {
        // Arrange
        var program = new Program();

        // Act
        var answer = program.IsLeapYear(1700);

        // Assert
        answer.Should().Be(false);
    }
        [Fact]
      public void rule_divided_by_400()
    {
        // Arrange
        var program = new Program();

        // Act
        var answer = program.IsLeapYear(1600);

        // Assert
        answer.Should().Be(true);
    }

            [Fact]
      public void rule_divided_by_4()
    {
        // Arrange
        var program = new Program();

        // Act
        var answer = program.IsLeapYear(1864);

        // Assert
        answer.Should().Be(true);
    }
    
}