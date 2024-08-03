namespace trampo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void lbtotal_Click(object sender, EventArgs e)
        {

        }



        private void btnsoma_Click(object sender, EventArgs e)
        {
            int var1, var2, total;
            var1 = int.Parse(txvalor1.Text);
            var2 = int.Parse(txvalor2.Text);

            total = var1 + var2;
            lbresultado.Text = total.ToString();


        }

        private void btnmultiplicacao_Click(object sender, EventArgs e)
        {
            int var1, var2, total;
            var1 = int.Parse(txvalor1.Text);
            var2 = int.Parse(txvalor2.Text);

            total = var1 * var2;
            lbresultado.Text = total.ToString();

        }

        private void btnsub_Click(object sender, EventArgs e)
        {
            int var1, var2, total;
            var1 = int.Parse(txvalor1.Text);
            var2 = int.Parse (txvalor2.Text);

            total = (var1 - var2);
            lbresultado.Text = total.ToString();
        }
    }
}
