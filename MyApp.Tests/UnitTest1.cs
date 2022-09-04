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
        output.Should().Be("yay!");
    }

    [Fact]
      public void test_of_user_input_and_output_nay()
    {
        // Arrange
        using var writer = new StringWriter();
        Console.SetOut(writer);
        using var reader = new StringReader("1866");
        Console.SetIn(reader);

        // Act
        Program.userInterfaceLeapYear();

        // Assert
        var output = writer.GetStringBuilder().ToString().TrimEnd();
        output.Should().Be("nay!");
    }

    [Fact]
    public void test_input_is_not_an_int()
    {
        // Arrange
        using var writer = new StringWriter();
        Console.SetOut(writer);
        using var reader = new StringReader("hey");
        Console.SetIn(reader);

        // Act
        Program.userInterfaceLeapYear();

        // Assert
        var output = writer.GetStringBuilder().ToString().TrimEnd();
        output.Should().Be("Please input an integer!");
    }

    [Fact]
    public void test_input_is_lower_than_1582()
    {
        // Arrange
        using var writer = new StringWriter();
        Console.SetOut(writer);
        using var reader = new StringReader("1500");
        Console.SetIn(reader);

        // Act
        Program.userInterfaceLeapYear();

        // Assert
        var output = writer.GetStringBuilder().ToString().TrimEnd();
        output.Should().Be("Please input a year equal or higher than 1582");
    }
    

      [Fact]
    public void test_input_is_an_int_and_a_character()
    {
        // Arrange
        using var writer = new StringWriter();
        Console.SetOut(writer);
        using var reader = new StringReader("1900a");
        Console.SetIn(reader);

        // Act
        Program.userInterfaceLeapYear();

        // Assert
        var output = writer.GetStringBuilder().ToString().TrimEnd();
        output.Should().Be("Please input an integer!");
    }
    
}
