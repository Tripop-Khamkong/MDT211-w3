namespace week3_test;

public class UnitTest1
{
    [Fact]
    public void TestConvertValueToint() {
        int number = Program.ConvertValueToint("5523");

        Assert.Equal(number, 5523);
        }

    [Fact]
    public void TestConvertValueTointIsInCorrect() {
        
        Assert.Throws<Exception>(() => Program.ConvertValueToint("Fennik"));

    }
    [Fact]
    public void TestConvertStringToDouble() {
        double number = Program.ConvertStringToDouble("122724");

        Assert.Equal(number, 122724);
        }

    [Fact]
    public void TestConvertStringToDoubleIsInCorrect() {
        
        Assert.Throws<Exception>(() => Program.ConvertStringToDouble("Fennik"));
    }
}