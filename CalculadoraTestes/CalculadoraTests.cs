using Calculadora.Services;

namespace CalculadoraTestes;

public class CalculadoraTests
{

    private CalculadoraImp _calc;

    public CalculadoraTests()
    {
        _calc = new CalculadoraImp();
    }


    [Fact]
    public void DeveSomar10c10Retornar20()
    {
        //Arrange
        int num1 = 10;
        int num2 = 10;

        //Act
        int resultado = _calc.Somar(num1, num2);

        //Assert
        Assert.Equal(20, resultado);

    }
    [Fact]
    public void DeveVerificarSe4ehParEretornarVerdadeiro()
    {
        //Arrange
        int numero = 4;
        //Act
        bool resultado = _calc.EhPar(numero);
        //Assert
        Assert.True(resultado);

    }

    [Theory]
    [InlineData(new int[] {2, 4})]
    [InlineData(new int[] {6, 8, 3})]
    public void DeveVerificarSeOsNumerosSaoParesERetornarVerdadeiro(int[] numeros)
    {
        //act /assert

        //Exemplo em ForEach
        // foreach (var item in numeros)
        // {
        //     Assert.True(_calc.EhPar(item));
        // }
        
        //Maneira alternativa
        Assert.All(numeros, num => Assert.True(_calc.EhPar(num)));
    }
}