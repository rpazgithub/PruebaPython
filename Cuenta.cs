using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoCuenta
{
    class Cuenta
    {

        private decimal saldo;

        public Cuenta(decimal saldoInicial)
        {

            Saldo = saldoInicial;
                              
        }

        public decimal Saldo
        {

            set
            {

                if (value >= 0)
                    saldo = value;

            }

            get
            {

                return saldo;

            }

        }

        public void Acredita( decimal monto )
        {

            Saldo = Saldo + monto;

        }

    }
}
