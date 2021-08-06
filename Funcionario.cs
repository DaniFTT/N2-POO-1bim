using System;

namespace N2_POO_1bim
{
    public class Funcionario
    {
        #region propriedades
        private string nome;
        private double salarioBase;
        private double descontos;

        public string Nome
        {
            get => nome;
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("O nome do funcionário é obrigatório");
                }
                nome = value;
            }
        }
        public double SalarioBase
        {
            get => salarioBase;
            set
            {
                if (value < 0)
                {
                    throw new Exception("O salario base não pode negativo");
                }
                salarioBase = value;
            }
        }
        public double Descontos
        {
            get => descontos;
            set
            {
                if (value < 0)
                {
                    throw new Exception("O desconto não pode negativo");
                }
                descontos = value;
            }
        }

        #endregion

        #region metodos

        public double CalcularSalario()
        {
            double salarioCalculado = SalarioBase - Descontos;

            return salarioCalculado;
        }

        public double CalcularSalario(double acrescismos)
        {
            if (!(acrescismos < 0))
            {
                double salarioCalculado = SalarioBase + (acrescismos - descontos);

                return salarioCalculado;
            }
            else
            {
                throw new Exception("Os acrescimentos não podem ser negativos");
            }
        }

        #endregion

        #region construtores
        public Funcionario(string nome)
        {
            Nome = nome;
            SalarioBase = 0;
            Descontos = 0;
        }
        #endregion

    }
}
