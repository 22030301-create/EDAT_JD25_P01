using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace UI.NumerosAleatorios
{
    public partial class Form1 : Form
    {
        Random rnd = new Random();
        String[] nombres = { "Marco", "Valentina", "Stelle", "Billy", "Cerydra", "Bronya", "Wallace", "Richard" };
        char[] grupos = {'A', 'B', 'C', 'D'};
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            Class1 emp = new Class1
            {
                Numero = rnd.Next(1000, 9999),
                Nombre = nombres[rnd.Next(nombres.Length)],
                FechaNacimiento = RandomDate(new DateTime(1970, 1, 1), DateTime.Today),
                Sexo = (rnd.Next(2) == 0) ? "Masculino" : "Femenino",
                Grupo = grupos[rnd.Next(grupos.Length)],
                Sueldo = Math.Round(rnd.NextDouble() * 20000 + 5000, 2),
                SeguroMedico = rnd.Next(2) == 0 ? false : true
            };

            txtNumero.Text = emp.Numero.ToString();
            txtNombre.Text = emp.Nombre;
            dtpFechaNacimiento.Value = emp.FechaNacimiento;
            if (emp.Sexo == "Masculino")
                rbtnMasculino.Checked = true;
            else
                rbtnFemenino.Checked = true;
            cboGrupo.Text = emp.Grupo.ToString();
            txtSueldo.Text = emp.Sueldo.ToString("F2");
            chkSeguroMedico.Checked = emp.SeguroMedico;

            MessageBox.Show(emp.ToString(), "Empleado Generado");
        }

        private DateTime RandomDate(DateTime start, DateTime end)
        {
            int range = (end - start).Days;
            return start.AddDays(rnd.Next(range));
        }
    }
}
