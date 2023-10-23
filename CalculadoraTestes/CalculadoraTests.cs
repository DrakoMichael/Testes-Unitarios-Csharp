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

}