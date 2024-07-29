namespace CSharp_BangCuuChuong
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            int so = Convert.ToInt32(txtso.Text);
            for (int i = 1; i <= 10; i++)
            {
                iblketqua.Text += Environment.NewLine + so.ToString() + " x " + i.ToString() + " = " + (so * i).ToString();
            }
        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {

        }
    }
}
