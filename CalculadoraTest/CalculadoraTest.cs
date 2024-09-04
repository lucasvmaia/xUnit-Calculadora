using Calculadora.Services;
namespace CalculadoraTest;

public class CalculadoraTest
{
    private readonly CalculadoraService _calculadora;
    public CalculadoraTest()
    {
        _calculadora = new CalculadoraService();
    }
    [Theory]
    [InlineData (1, 2, 3)]
    public void SomarTest(int num1, int num2, int resultado)
    {
        int resultadoCalculadora = _calculadora.Somar(num1, num2);
        Assert.Equal(resultado, resultadoCalculadora);
    }

    [Theory]
    [InlineData (5, 2, 3)]
    public void SubtrairTest(int num1, int num2, int resultado)
    {
        int resultadoCalculadora = _calculadora.Subtrair(num1, num2);
        Assert.Equal(resultado, resultadoCalculadora);
    }

    [Theory]
    [InlineData (5, 2, 10)]
    public void MultiplicarTest(int num1, int num2, int resultado)
    {
        int resultadoCalculadora = _calculadora.Multiplicar(num1, num2);
        Assert.Equal(resultado, resultadoCalculadora);
    }

    [Theory]
    [InlineData (5, 5, 1)]
    public void DividirTest(int num1, int num2, int resultado)
    {
        int resultadoCalculadora = _calculadora.Dividir(num1, num2);
        Assert.Equal(resultado, resultadoCalculadora);
    }

    [Fact]
    public void TestarDivisaoPorZero()
    {
        Assert.Throws<DivideByZeroException>(
            () => _calculadora.Dividir(3,0)
        );
    }

    [Fact]
    public void HistoricoTest()
    {
        _calculadora.Somar(2,2);
        _calculadora.Somar(4,2);
        _calculadora.Somar(7,2);
        _calculadora.Somar(2,5);
        var lista = _calculadora.Historico();
        Assert.NotEmpty(lista);
        Assert.Equal(3, lista.Count);
    }
}