using System.Reflection.Metadata.Ecma335;

namespace tic
{
    public partial class Form1 : Form
    {
        private int curo = 0; // 1 when it is O's move?
        public Form1()
        {
            InitializeComponent();
        }

        private void cell_Click(object sender, EventArgs e)
        {
            Cell senderCell = (Cell)sender;
            if(senderCell.Text != "")
            {
                return;
            }
            senderCell.Text = curo == 1? "O": "X";
            curo = (curo + 1) % 2;
            label1.Text = curo == 1 ? "O's turn:" : "X's turn:";
        }
    }
}
