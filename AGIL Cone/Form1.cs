namespace AGIL_Cone
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

        private void txt_radius_TextChanged()
        {

        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_height.Text = String.Empty;
            txt_volume.Text = String.Empty;
            txt_radius.Text = String.Empty;
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_calculate_Click(object sender, EventArgs e)
        {
            if (txt_height.Text == String.Empty || txt_radius.Text == String.Empty) 
            {
                MessageBox.Show("Please, Enter the values","Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
               // return;
            }
            else
            {
                
                double h = Double.Parse(txt_height.Text);
                double r = Double.Parse(txt_radius.Text);

                double volume = (double)((int)(Math.Pow(r, 2) * h * Math.PI/3 * 100))/100;

                txt_volume.Text = volume.ToString();
            }
        }

    }
}