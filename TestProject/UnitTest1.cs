namespace TestProject;

public class Tests
{
    [SetUp]
    public void Setup()
    {

    }

    [Test]
    public void Test1()
    {
        //Arrange
        var testingnumber1 = 7;
        var testingnumber2 = 150;
        var expected = false;

        //Act
        var actual = Lucas.EasyMode.Winner(ref testingnumber1, ref testingnumber2);

        //Assert
        Assert.AreEqual(expected, actual);
    }

    [Test]
    public void Test2()
    {
        //Arrange
        var testingnumber1 = 8;
        var testingnumber2 = -50;
        var expected = false;

        //Act
        var actual = Lucas.EasyMode.Winner(ref testingnumber1, ref testingnumber2);

        //Assert
        Assert.AreEqual(expected, actual);
    }

    [Test]
    public void Test3()
    {
        //Arrange
        var testingnumber1 = 8;
        var testingnumber2 = 160;
        var expected = false;

        //Act
        // var actual = Jenneth.EasyMode.Winner(ref testingnumber1, ref testingnumber2);

        //Assert
        // Assert.AreEqual(expected, actual);
    }

    [Test]
    public void Test4()
    {
        //Arrange
        var testingnumber1 = 6;
        var testingnumber2 = -200;
        var expected = false;

        //Act
        var actual = Athanasia.HardMode.Winner(ref testingnumber1, ref testingnumber2);

        //Assert
        Assert.AreEqual(expected, actual);
    }
}