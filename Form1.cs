namespace tic
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cell_Click(object sender, EventArgs e)
        {
            Cell senderCell = (Cell)sender;
            senderCell.Text = "X";
        }
    }
}
