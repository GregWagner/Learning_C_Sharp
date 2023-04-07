namespace Uqs.Arithmetic.Tests.Unit;

public class DivisionTests {
    [Fact]
    public void Divide_DivisibleIntegers_WholeNumber() {
        // arrange
        const int dividend = 10;
        const int divisor = 5;
        const decimal expectedQuotient = 2;

        // act
        decimal actualQuotient = Division.Divide(dividend, divisor);
       
        // assert
        Assert.Equal(expectedQuotient, actualQuotient);
    }

    [Fact]
    public void Divide_IndivisibleIntegers_DecimalNumbers() {
        // arrange
        const int dividend = 10;
        const int divisor = 4;
        const decimal expectedQuotient = 2.5m;
        
        // act
        decimal actualQuotient = Division.Divide(dividend, divisor);
        
        // assert
        Assert.Equal(expectedQuotient, actualQuotient);
    }

    [Fact]
    public void Divide_ZeroDivisor_DivideByZeroException() {
        // arrange
        const int dividend = 10;
        const int divisor = 0;

        // act
        Exception e = Record.Exception(() => Division.Divide(dividend, divisor));
        

        // assert
        Assert.IsType<DivideByZeroException>(e);
    }
    
    [Theory]
    [InlineData(int.MaxValue, int.MinValue, -0.999999999534)]
    [InlineData(-int.MaxValue, int.MinValue, 0.999999999534)]
    [InlineData(int.MinValue, int.MaxValue, -1.000000000466)]
    [InlineData(int.MinValue, -int.MaxValue, 1.000000000466)]
    public void Divide_ExtremeInput_CorrectCalculation(
        int dividend, int divisor, decimal expectedQuotient) {
        // arrange
        
        // act
        decimal actualQuotient = Division.Divide(dividend, divisor);
        
        // assert
        Assert.Equal(expectedQuotient, actualQuotient, 12);
    }
}
