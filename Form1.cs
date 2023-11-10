namespace Práctica_8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int número = int.Parse(textBox1.Text); //Se declara que lo que se escriba en la caja 1 sea el valor de la variable número.
            int factorial = 1;                   //Que el factorial se relaciona con "i" mediante la igualdad "1".
            for (int i = 1; i <= número; i++)      //Se declara que la variable "i" en el ciclo "for" haga que cuente desde 1 hasta el número introducido.
            {


                listBox1.Items.Add(i); //Se declara que cada vez que ocurra el ciclo se  muestre en la list box el resultado de i.
                factorial *= i;       //Se declara que el factorial será la multiplicaión  "i" por el valor en el ciclo.

            }
            textBox2.Text = número.ToString();           //La caja 2 y la 3 presenttará el valor del número y de su factorial respectivamente.
            textBox3.Text = factorial.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}