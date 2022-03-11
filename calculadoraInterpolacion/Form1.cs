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
        private int resultado;


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
                //tbDisplay.Text = valor0.ToString() + "+" + valor1.ToString() + "+" + valor2.ToString() + "+" + valor3.ToString() + "+" + valor4.ToString() + "+" + valor5.ToString() + "+" + valor6.ToString();
                tbDisplay.Text = ((((valor3-valor1) / (valor0-valor1))*((valor3-valor2) / (valor0-valor2))*(valor4)) + 
                                 (((valor3 - valor0) / (valor1 - valor0)) * ((valor3 - valor2) / (valor1 - valor2)) * (valor5)) + 
                                 (((valor3 - valor0) / (valor2 - valor0)) * ((valor3 - valor1) / (valor2 - valor1)) * (valor6))).ToString();
            } else if(interpolacion == 2) {
                tbDisplay.Text = ((((valor3 - valor1) / (valor0 - valor1)) * valor4) + (((valor3 - valor0) / (valor1 - valor0)) * valor5)).ToString();
            } else
            {
                tbDisplay.Text = "Error, selecciona una sola casilla de interpolacion";
            }
        }

        private void cuadraticaCheck_CheckedChanged(object sender, EventArgs e)
        {
            //Cuadratica
            if (cuadraticaCheck.Checked == true)
            {
                interpolacion = interpolacion + 1;
            } else
            {
                interpolacion = 0;
            }
        }

        private void linealCheck_CheckedChanged(object sender, EventArgs e)
        {
            //Lineal
            if (linealCheck.Checked == true)
            {
                interpolacion = interpolacion + 2;
            } else
            {
                interpolacion = 0;
            }
        }
    }
}