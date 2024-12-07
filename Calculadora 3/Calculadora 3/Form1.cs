namespace Calculadora_3
{
    public partial class Form : System.Windows.Forms.Form
    {
        private double valor1;
        private double valor2;

        private double resultado;

        private int operacion;
        public Form()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;

        }

        private void button9_Click(object sender, EventArgs e)
        {
            //suma

            operacion = 1;

            valor1 = Convert.ToDouble(txtResultado.Text);
            txtResultado.Text = "";


        }

        private void button17_Click(object sender, EventArgs e)
        {
            //limpiar

            txtResultado.Text   =  " ";
        }

        private void CalculadoraPromasa_Load(object sender, EventArgs e)
        {

        }

        private void btn0_Click(object sender, EventArgs e)
        {
            //numero 0
            txtResultado.Text = txtResultado.Text + "0";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            //numero 1
            txtResultado.Text = txtResultado.Text + "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            //numero 2
            txtResultado.Text = txtResultado.Text + "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            //numero 3
            txtResultado.Text = txtResultado.Text + "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            //numero 4
            txtResultado.Text = txtResultado.Text + "4";

        }

        private void btn5_Click(object sender, EventArgs e)
        {
            //numero 5
            txtResultado.Text = txtResultado.Text + "5";

        }

        private void btn6_Click(object sender, EventArgs e)
        {
            //numero 6
            txtResultado.Text = txtResultado.Text + "6";

        }

        private void btn7_Click(object sender, EventArgs e)
        {
            //numero 7
            txtResultado.Text = txtResultado.Text + "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            //numero 8
            txtResultado.Text =  txtResultado.Text + "8";

        }

        private void btn9_Click(object sender, EventArgs e)
        {
            //numero 9
            txtResultado.Text = txtResultado.Text + "9";
        }

        private void punto_Click(object sender, EventArgs e)
        {
            //punto
            txtResultado.Text  =  txtResultado.Text + ".";

        }

        private void igual_Click(object sender, EventArgs e)
        {
            //igual o resultado

            valor2 = Convert.ToDouble(txtResultado.Text);

            switch (operacion)
            {
                case 1:
                    resultado = valor1 + valor2;
                    break;

                case 2:
                    resultado = valor1 - valor2;
                    break;


                case 3:
                    resultado = valor1 * valor2;
                    break;

                case 4:
                    resultado = valor1 / valor2;
                    break;
            }


            txtResultado.Text = resultado.ToString();

        }

        private void resta_Click(object sender, EventArgs e)
        {
            //resta

            operacion = 2;
            
            valor1 = Convert.ToDouble(txtResultado.Text);
            txtResultado.Text = "";


        }

        private void multiplicacion_Click(object sender, EventArgs e)
        {
            //multiplicacion 

            operacion = 3;

            valor1 = Convert.ToDouble(txtResultado.Text);
            txtResultado.Text = "";
        }

        private void division_Click(object sender, EventArgs e)
        {
            //division

            operacion = 4;

            valor1 = Convert.ToDouble(txtResultado.Text);
            txtResultado.Text = "";

        }
    }
}
