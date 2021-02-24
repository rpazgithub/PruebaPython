using System;

namespace ProyectoCuenta
{
    class PruebaCuenta
    {
        static void Main(string[] args)
        {
            Cuenta cuenta1 = new Cuenta( 50.00M );
            Cuenta cuenta2 = new Cuenta(-7.53M);

            Console.WriteLine( "Saldo de cuenta 1: {0:C}", cuenta1.Saldo );
            Console.WriteLine( "Saldo de cuenta 2: {0:C}", cuenta2.Saldo );

            decimal montoDeposito;

            Console.Write( "Escriba el monto a depositar para la cuenta 1: " );
            montoDeposito = Convert.ToDecimal( Console.ReadLine() );

            Console.WriteLine( "Se sumo {0:C} al saldo de la cuenta 1", montoDeposito );
            cuenta1.Acredita( montoDeposito );

            Console.Write( "Escriba el monto a depositar para a cuenta 2: ");
            montoDeposito = Convert.ToDecimal( Console.ReadLine() );

            Console.WriteLine( "Se sumo {0:C} al saldo de la cuenta 2: ", montoDeposito );
            cuenta2.Acredita( montoDeposito );

            Console.WriteLine( "Saldo de cuenta 1: {0:C}", cuenta1.Saldo );
            Console.WriteLine( "Saldo de cuenta 2: {0:C}", cuenta2.Saldo );



        }
    }
}
