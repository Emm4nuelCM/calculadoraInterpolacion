namespace calculadoraInterpolacion
{
    public partial class Form1 : Form
    {
        private double valor0;
        private double valor1;
        private double valor2;
        private double valor3;
        private double valor4;
        private double valor5;
        private double valor6;
        private double valor7;
        private double valor8;
        private int interpolacion;
        private int tipo;
        private string fraseInCua = "Resultado de Interpolacion Cuadratica = ";
        private string fraseInLin = "Resultado de Interpolacion Lineal = ";
        private string fraseFin = " Aprox.";
        private double operacion;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttLimpiar_Click(object sender, EventArgs e)
        {
            //Limpiar
            tbDisplay.Text = "";
        }

        private void buttCalcular_Click(object sender, EventArgs e)
        {
            //Calcular
            valor0 = Convert.ToDouble(X0Box.Text + 0);
            valor1 = Convert.ToDouble(X1Box.Text + 0);
            valor2 = Convert.ToDouble(X2Box.Text + 0);
            valor3 = Convert.ToDouble(XBox.Text + 0);
            valor4 = Convert.ToDouble(FX0Box.Text + 0);
            valor5 = Convert.ToDouble(FX1Box.Text + 0);
            valor6 = Convert.ToDouble(FX2Box.Text + 0);
            
            if(errorRelativoCheck.Checked == true)
            {
                valor7 = Convert.ToDouble(errorRelativoBox.Text + 0);
                valor8 = Convert.ToDouble(operacion);
                tbDisplay2.Text = (((valor7 - valor8) / valor7) * 100).ToString() + "%";
            } else
            {
                tbDisplay2.Text = "";
            }



            if (interpolacion == 1 && tipo == 0)
            {
                operacion = ((((valor3 - valor1) / (valor0 - valor1)) * ((valor3 - valor2) / (valor0 - valor2)) * (valor4)) +
                                 (((valor3 - valor0) / (valor1 - valor0)) * ((valor3 - valor2) / (valor1 - valor2)) * (valor5)) +
                                 (((valor3 - valor0) / (valor2 - valor0)) * ((valor3 - valor1) / (valor2 - valor1)) * (valor6)));
                tbDisplay.Text = fraseInCua + operacion.ToString() + fraseFin;
            }
            else if (interpolacion == 2 && tipo == 0)
            {
                operacion = ((((valor3 - valor1) / (valor0 - valor1)) * valor4) + (((valor3 - valor0) / (valor1 - valor0)) * valor5));
                tbDisplay.Text = fraseInLin + operacion.ToString() + fraseFin;
            }
            else if (interpolacion == 1 && tipo == 1)
            {
                operacion = Math.Round(((((valor3 - valor1) / (valor0 - valor1)) * ((valor3 - valor2) / (valor0 - valor2)) * (valor4)) +
                                 (((valor3 - valor0) / (valor1 - valor0)) * ((valor3 - valor2) / (valor1 - valor2)) * (valor5)) +
                                 (((valor3 - valor0) / (valor2 - valor0)) * ((valor3 - valor1) / (valor2 - valor1)) * (valor6))));
                tbDisplay.Text = fraseInCua + operacion.ToString() + fraseFin;
            } 
            else if(interpolacion == 2 && tipo ==1)
            {
                operacion =Math.Round(((((valor3 - valor1) / (valor0 - valor1)) * valor4) + (((valor3 - valor0) / (valor1 - valor0)) * valor5)));
                tbDisplay.Text = fraseInLin + operacion.ToString() + fraseFin;
            }
            else if (interpolacion == 1 && tipo == 2)
            {
                operacion = ((((valor3 - valor1) / (valor0 - valor1)) * ((valor3 - valor2) / (valor0 - valor2)) * (valor4)) +
                                 (((valor3 - valor0) / (valor1 - valor0)) * ((valor3 - valor2) / (valor1 - valor2)) * (valor5)) +
                                 (((valor3 - valor0) / (valor2 - valor0)) * ((valor3 - valor1) / (valor2 - valor1)) * (valor6)));
                tbDisplay.Text = fraseInCua + operacion.ToString() + fraseFin;
            }
            else if (interpolacion == 2 && tipo == 2)
            {
                operacion = ((((valor3 - valor1) / (valor0 - valor1)) * valor4) + (((valor3 - valor0) / (valor1 - valor0)) * valor5));
                tbDisplay.Text = fraseInLin + operacion.ToString() + fraseFin;
            }
        }


        private void cuadraticaButton_CheckedChanged(object sender, EventArgs e)
        {
            //Cuadratica
            if (cuadraticaButton.Checked == true)
            {
                interpolacion = 1;
            }
        }

        private void linealButton_CheckedChanged(object sender, EventArgs e)
        {
            //Lineal
            if (linealButton.Checked == true)
            {
                interpolacion = 2;
            }
        }

        private void naturalButton_CheckedChanged(object sender, EventArgs e)
        {
            //Naturales
            if (naturalButton.Checked == true)
            {
                tipo = 0;
            }
        }

        private void decimalesButton_CheckedChanged(object sender, EventArgs e)
        {
            //Decimales
            if (decimalesButton.Checked == true)
            {
                tipo = 1;
            }
        }

        private void tresDecimalButton_CheckedChanged(object sender, EventArgs e)
        {
            //3Decimal
            if (tresDecimalButton.Checked == true)
            {
                tipo = 2;
            }
        }

        private void errorRelativoCheck_CheckedChanged(object sender, EventArgs e)
        {
            //Error Relativo

        }
    }
}