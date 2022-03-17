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
        private int interpolacion;


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
            valor0 = Convert.ToDouble(X0Box.Text);
            valor1 = Convert.ToDouble(X1Box.Text);
            valor2 = Convert.ToDouble(X2Box.Text);
            valor3 = Convert.ToDouble(XBox.Text);
            valor4 = Convert.ToDouble(FX0Box.Text);
            valor5 = Convert.ToDouble(FX1Box.Text);
            valor6 = Convert.ToDouble(FX2Box.Text);

            if(interpolacion == 1)
            {
                tbDisplay.Text = "Resultado de Interpolacion Cuadratica = " + ((((valor3-valor1) / (valor0-valor1))*((valor3-valor2) / (valor0-valor2))*(valor4)) + 
                                 (((valor3 - valor0) / (valor1 - valor0)) * ((valor3 - valor2) / (valor1 - valor2)) * (valor5)) + 
                                 (((valor3 - valor0) / (valor2 - valor0)) * ((valor3 - valor1) / (valor2 - valor1)) * (valor6))).ToString() + " Aprox.";
            } else if(interpolacion == 2) {
                tbDisplay.Text = "Resultado de Interpolacion Lineal = " + ((((valor3 - valor1) / (valor0 - valor1)) * valor4) + (((valor3 - valor0) / (valor1 - valor0)) * valor5)).ToString() + " Aprox";

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
        }

        private void decimalesButton_CheckedChanged(object sender, EventArgs e)
        {
            //Decimales
        }

        private void tresDecimalButton_CheckedChanged(object sender, EventArgs e)
        {
            //3Decimal
        }
    }
}