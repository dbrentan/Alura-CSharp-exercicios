
namespace ByteBankParteSeis.src.Entities
{
    public class ContaCorrente
    {
        public Cliente Titular { get; set; }
        public static int TotalDeContasCriadas { get; private set; }
        private int _agencia;
        public int Agencia
        {
            get
            {
                return _agencia;
            }
            set
            {
                if ( value <= 0 )
                {
                    return;
                }

                _agencia = value;
            }
        }
        public int Numero {get; set;}
        private double _saldo = 100;


        public double Saldo
        {
            get
            {
                return _saldo;
            }
            set
            {
                if (value < 0)
                {
                    return;
                }

                _saldo = value;
            }
        }

        public ContaCorrente(int agencia, int numero)
        {
            Agencia = agencia;
            Numero = numero;

            TotalDeContasCriadas++;
        }

        public bool Sacar (double valor)
        {
            if (_saldo < valor)
            {
                Console.WriteLine($"Saldo insuficiente para saque no valor de {valor}");
                return false;
            }
                _saldo -= valor;
                return true;
        }

        public void Depositar (double valor)
        {
            _saldo += valor;
        }

        public bool Transferir (double valor, ContaCorrente contaDestino)
        {
            if (_saldo < valor)
            {
                Console.WriteLine($"Saldo insuficiente para tranferencia no valor de {valor}");
                return false;
            }
            
            _saldo -= valor;
            contaDestino.Depositar(valor);

            return true;
        }

    }
}