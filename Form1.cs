using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace N2_POO_1bim
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();

            List<Funcionario> listaDeFuncionarios = new List<Funcionario>();
            string[] nomes = { "Ana", "Maria", "Silvia", "Pedrita", "Carla", "Elisabeth", "Jéssica" };

            foreach (string item in nomes)
            {
                listaDeFuncionarios.Add(new Funcionario(item));
            }

            int v1 = -1;
            int v2 = 0;

            try
            {
                if (Convert.ToInt32(v1) + Convert.ToInt32(v2) < 0)
                {
                    throw new Exception("O resultado da soma não pode ser negativo.");
                }
            }
            catch
            {
                Console.WriteLine("Corrija os valores.");
            }




        }



    }
}
