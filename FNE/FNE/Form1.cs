using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FNE
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            validarCampos(out decimal inversion, out int plazo, out decimal tasa, out decimal inflacion, out decimal vs, out decimal egresos, out decimal ingreso);

            if (plazo <= 0)
                return;
            DataTable dt = new DataTable();
            dt.Columns.Add(" ");
            for (int i = 0; i <= plazo;  i++)
            {
                dt.Columns.Add(""+i);
            }

            decimal[] fne = new decimal[plazo + 1];
            fne[0] = inversion;

            //Cargo la fila de inversion
            DataRow filaInversion = dt.NewRow();
            filaInversion[" "] = "Inversion";
            filaInversion["0"] = inversion;
            for (int i = 1; i <= plazo; i++)
            {
                filaInversion["" + i] = 0;
            }
            
            dt.Rows.Add(filaInversion);

            //Cargo la fila de ingresos
            DataRow filaIngresos = dt.NewRow();
            filaIngresos[" "] = "Ingresos";
            filaIngresos["1"] = ingreso;
            fne[1] = ingreso;
            decimal[] ingresosXAnio = new decimal[plazo];
            ingresosXAnio[0] = ingreso;
            for (int i = 2; i <= plazo; i++)
            {
                filaIngresos["" + i] = ingreso * (decimal) (Math.Pow(1 + (double)inflacion/100, i - 1));
                fne[i] = ingreso * (decimal)(Math.Pow(1 + (double)inflacion / 100, i - 1));
                ingresosXAnio[i - 1] = ingreso * (decimal)(Math.Pow(1 + (double)inflacion / 100, i - 1));
            }

            dt.Rows.Add(filaIngresos);

            //Cargo la fila egresos
            DataRow filaEgresos = dt.NewRow();
            filaEgresos[" "] = "Egresos";
            filaEgresos["1"] = egresos;
            fne[1] -= egresos;
            
            for (int i = 2; i <= plazo; i++)
            {
                filaEgresos["" + i] = egresos * (decimal)(Math.Pow(1 + (double)inflacion / 100, i - 1));
                fne[i] -= egresos * (decimal)(Math.Pow(1 + (double)inflacion / 100, i - 1));
            }

            dt.Rows.Add(filaEgresos);

            DataRow filaDeprecicion = dt.NewRow();
            filaDeprecicion[" "] = "Depreciacion (Linea recta)";
            decimal gastoXDep = (inversion - vs) / plazo;
            for (int i = 1; i <= plazo; i++)
            {
                filaDeprecicion["" + i] = gastoXDep;
                fne[i] -= gastoXDep;
            }

            dt.Rows.Add(filaDeprecicion);

            DataRow filaVS = dt.NewRow();
            filaVS[" "] = "VS";

            for (int i = 1; i <= plazo; i++)
            {
                if(i == plazo)
                {
                    filaVS["" + i] = vs;
                    fne[i] += vs;
                }
                else
                    filaVS["" + i] = "-";
            }
            dt.Rows.Add(filaVS);

            DataRow filaUAI = dt.NewRow();
            filaUAI[" "] = "UAI";
            dt.Rows.Add(filaUAI);
            filaUAI["0"] = "-";
            for (int i = 1; i < plazo + 1; i++)
            {
                filaUAI["" + i] = fne[i];
            }

            DataRow filaIR = dt.NewRow();
            filaIR[" "] = "IR";
            double[] ir = new double[plazo];
            for (int i = 1; i < plazo + 1; i++)
            {
                if (fne[i] > 0)
                {
                    filaIR["" + i] = (double)fne[i] * 0.3;
                    ir[i - 1] = (double)fne[i] * 0.3;
                }
                else
                {
                    filaIR["" + i] = 0;
                    ir[i - 1] = 0;
                }
            }
            dt.Rows.Add(filaIR);

            DataRow filaUDI = dt.NewRow();
            filaUDI[" "] = "UDI";
            for (int i = 1; i < plazo + 1; i++)
            {
                filaUDI["" + i] = fne[i] - (decimal) ir[i-1];
                fne[i] -= (decimal)ir[i - 1];
            }
            dt.Rows.Add(filaUDI);

            DataRow filaDeprePositivo = dt.NewRow();
            filaDeprePositivo[" "] = "Depreciacion";

            for (int i = 1; i <= plazo; i++)
            {
                filaDeprePositivo["" + i] = gastoXDep;
                fne[i] += gastoXDep;
            }
            dt.Rows.Add(filaDeprePositivo);

            //Cargo fila FNE
            DataRow row10 = dt.NewRow();
            row10[" "] = "FNE";
            row10["0"] = inversion;
            for (int i = 1; i < plazo + 1; i++)
            {
                row10["" + i] = fne[i];
            }
            dt.Rows.Add(row10);
            dgvFNE.DataSource = dt;

            double sumaIngresos = 0;

            for(int anio = 1; anio <= plazo; anio++)
            {
                decimal ing = fne[anio];
                Console.WriteLine(ing);
                sumaIngresos += (double)ing * Math.Pow( 1 + (double) tasa/100, -anio);
            }

            txtVPN.Text = (sumaIngresos - (double)inversion) + "";

        }

        private void validarCampos(out decimal inversion, out int plazo, out decimal tasa, out decimal inflacion, out decimal vs, out decimal egresos, out decimal ingreso)
        {
            if (!decimal.TryParse(txtInversion.Text, out decimal inv))
                throw new ArgumentException($"El valor {txtInversion.Text} es invalido");
            inversion = inv;

            if (!int.TryParse(txtPlazo.Text, out int plaz))
                throw new ArgumentException($"El valor {txtPlazo.Text} es invalido");
            plazo = plaz;

            if (!decimal.TryParse(txtTasa.Text, out decimal tas))
                throw new ArgumentException($"El valor {txtTasa.Text} es invalido");
            tasa = tas;

            if (!decimal.TryParse(txtInfacion.Text, out decimal inf))
                throw new ArgumentException($"El valor {txtInfacion.Text} es invalido");
            inflacion = inf;

            if (!decimal.TryParse(txtVS.Text, out decimal vr))
                throw new ArgumentException($"El valor {txtVS.Text} es invalido");
            vs = vr;

            if (!decimal.TryParse(txtEgresos.Text, out decimal eg))
                throw new ArgumentException($"El valor {txtEgresos.Text} es invalido");
            egresos = eg;
            if (!decimal.TryParse(txtIngreso.Text, out decimal ig))
                throw new ArgumentException($"El valor {txtIngreso.Text} es invalido");
            ingreso = ig;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
