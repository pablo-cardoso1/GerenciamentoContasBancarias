public class ContaBancaria
{
    public int NumeroConta { get; set; }
    public string Titular { get; set; }
    public double Saldo { get; set; }

    public void MostrarSaldo()
    {
        Console.WriteLine($"Saldo atual: R${Saldo}");
    }

    public virtual double Depositar(double valor)
    {
        if (valor > 0)
        {
            Saldo += valor; // Corrigido
            Console.WriteLine($"Você depositou R${valor}. Seu saldo atual é R${Saldo}.");
        }
        else
        {
            Console.WriteLine("O valor do depósito deve ser maior que zero.");
        }
        return Saldo;
    }

    public virtual double Sacar(double valor)
    {
        if (valor <= Saldo && valor > 0)
        {
            Saldo -= valor; // Corrigido
            Console.WriteLine($"Você sacou R${valor}. Seu saldo atual é R${Saldo}.");
        }
        else if (valor <= 0)
        {
            Console.WriteLine("O valor do saque deve ser maior que zero.");
        }
        else
        {
            Console.WriteLine("Saldo insuficiente.");
        }
        return Saldo;
    }
}

public class ContaCorrente : ContaBancaria
{
    public override double Sacar(double valor)
    {
        const double taxaPercentual = 0.10;
        double taxa = valor * taxaPercentual;
        if (valor + taxa <= Saldo && valor > 0)
        {
            Saldo -= (valor + taxa);
            Console.WriteLine($"Você sacou R${valor}. Seu saldo atual é R${Saldo}.");
        }
        else if (valor <= 0)
        {
            Console.WriteLine("O valor do saque deve ser maior que zero.");
        }
        else
        {
            Console.WriteLine("Saldo insuficiente.");
        }
        return Saldo;
    }
}

public class ContaPoupanca : ContaBancaria
{
    private int saques = 0;
    private const int limiteSaquePorMes = 5;

    public override double Sacar(double valor)
    {
        if (saques < limiteSaquePorMes) 
        {
            if (valor > 0 && valor <= Saldo)
            {
                Saldo -= valor;
                saques++;
                Console.WriteLine($"Você sacou R${valor}. Seu saldo atual é R${Saldo}. Você já realizou {saques} saques este mês.");
            }
            else if (valor <= 0)
            {
                Console.WriteLine("O valor do saque deve ser maior que zero.");
            }
            else
            {
                Console.WriteLine("Saldo insuficiente.");
            }
        }
        else
        {
            Console.WriteLine("Você atingiu o limite máximo de saques no mês.");
        }

        return Saldo;
    }
}
