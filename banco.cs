using System;

public class EjercicioBanco
{
    public static void Ejecutar()
    {
        CuentaBancaria cuenta1 = new CuentaBancaria("123", "Ana", 500);
        CuentaBancaria cuenta2 = new CuentaBancaria("456", "Luis", 300);

        Banco banco = new Banco();

        Console.WriteLine("Saldo inicial de Ana: $" + cuenta1.ObtenerSaldo());
        Console.WriteLine("Saldo inicial de Luis: $" + cuenta2.ObtenerSaldo());

        banco.Depositar(cuenta1, 200);
        Console.WriteLine("\nDespués de depositar $200 a Ana: $" + cuenta1.ObtenerSaldo());

        bool exito = banco.Extraer(cuenta2, 100);
        Console.WriteLine("Luis extrajo $100: " + (exito ? "Éxito" : "Fallo"));
        Console.WriteLine("Saldo de Luis: $" + cuenta2.ObtenerSaldo());

        bool transferenciaExitosa = banco.Transferencia(cuenta1, 250, cuenta2);
        Console.WriteLine("\nTransferencia de $250 de Ana a Luis: " + (transferenciaExitosa ? "Éxito" : "Fallo"));
        Console.WriteLine("Saldo de Ana: $" + cuenta1.ObtenerSaldo());
        Console.WriteLine("Saldo de Luis: $" + cuenta2.ObtenerSaldo());
    }
}

public class CuentaBancaria
{
    private string numeroCuenta;
    private double saldo;
    private string titular;

    public CuentaBancaria(string numeroCuenta, string titular, double saldoInicial = 0)
    {
        this.numeroCuenta = numeroCuenta;
        this.titular = titular;
        this.saldo = saldoInicial;
    }

    public string ObtenerNumeroCuenta() => numeroCuenta;

    public double ObtenerSaldo() => saldo;

    public void ModificarSaldo(double nuevoSaldo) => saldo = nuevoSaldo;

    public string ObtenerTitular() => titular;
}

public class Banco
{
    public bool Depositar(CuentaBancaria cuenta, double monto)
    {
        if (monto > 0)
        {
            double nuevoSaldo = cuenta.ObtenerSaldo() + monto;
            cuenta.ModificarSaldo(nuevoSaldo);
            return true;
        }
        return false;
    }

    public bool Extraer(CuentaBancaria cuenta, double monto)
    {
        if (monto > 0 && cuenta.ObtenerSaldo() >= monto)
        {
            double nuevoSaldo = cuenta.ObtenerSaldo() - monto;
            cuenta.ModificarSaldo(nuevoSaldo);
            return true;
        }
        return false;
    }

    public bool Transferencia(CuentaBancaria cuentaOrigen, double monto, CuentaBancaria cuentaDestino)
    {
        if (Extraer(cuentaOrigen, monto))
        {
            Depositar(cuentaDestino, monto);
            return true;
        }
        return false;
    }
}
