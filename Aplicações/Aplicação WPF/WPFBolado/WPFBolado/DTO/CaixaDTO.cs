using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFBolado.DTO
{
    public class CaixaDTO
    {
        private static int statusCaixa = 0;
        private int id;
        private decimal saldoInicial;
        private DateTime dataAbertura;
        private DateTime dataFechamento;
        private DateTime horaAbertura;
        private DateTime horaFechamento;

        public static int StatusCaixa
        {
            get
            {
                return statusCaixa;
            }

            set
            {
                statusCaixa = value;
            }
        }

        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public decimal SaldoInicial
        {
            get
            {
                return saldoInicial;
            }

            set
            {
                saldoInicial = value;
            }
        }

        public DateTime DataAbertura
        {
            get
            {
                return dataAbertura;
            }

            set
            {
                dataAbertura = value;
            }
        }

        public DateTime DataFechamento
        {
            get
            {
                return dataFechamento;
            }

            set
            {
                dataFechamento = value;
            }
        }

        public DateTime HoraAbertura
        {
            get
            {
                return horaAbertura;
            }

            set
            {
                horaAbertura = value;
            }
        }

        public DateTime HoraFechamento
        {
            get
            {
                return horaFechamento;
            }

            set
            {
                horaFechamento = value;
            }
        }
    }
}
