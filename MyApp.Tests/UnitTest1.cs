namespace MyApp.Tests;

public class UnitTest1
{
    [Fact]
    public void first_rule_divided_by_4_true()
    {
        // Arrange
        

        // Act
        var answer = Program.IsLeapYear(2004);

        // Assert
        answer.Should().Be(true);
    }
     [Fact]
      public void first_rule_divided_by_4_false()
    {
        // Arrange

        // Act
        var answer = Program.IsLeapYear(2001);

        // Assert
        answer.Should().Be(false);
    }
        [Fact]
      public void rule_divided_by_100()
    {
        // Arrange

        // Act
        var answer = Program.IsLeapYear(1700);

        // Assert
        answer.Should().Be(false);
    }
        [Fact]
      public void rule_divided_by_400()
    {
        // Arrange

        // Act
        var answer = Program.IsLeapYear(1600);

        // Assert
        answer.Should().Be(true);
    }

            [Fact]
      public void rule_divided_by_4()
    {
        // Arrange

        // Act
        var answer = Program.IsLeapYear(1864);

        // Assert
        answer.Should().Be(true);
    }

    [Fact]
      public void test_of_user_input_and_output_yay()
    {
        // Arrange
        using var writer = new StringWriter();
        Console.SetOut(writer);
        using var reader = new StringReader("1864");
        Console.SetIn(reader);

        // Act
        
        Program.userInterfaceLeapYear();

        // Assert
        var output = writer.GetStringBuilder().ToString().TrimEnd();
        output.Should().Be("yay");
    }
    
}
