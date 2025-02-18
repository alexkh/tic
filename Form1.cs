using System.Reflection.Metadata.Ecma335;

namespace tic
{
    public partial class Form1 : Form
    {
        private int curo = 0; // 1 when it is O's move?
        private int board = 0; // board state
        // board state is a packed binary
        // 2 bits per cell from top left to bottom right
        // value 1 for X, 2 for O, 0 for empty cell
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
            int x = Int32.Parse(senderCell.Name);

            if (curo == 1)
            {
                // O's Turn: put O
                senderCell.Text = "O";
                curo = 0;
                label1.Text = "X's turn:";
                board |= 2 << (x * 2);
            } else
            {
                // X's Turn: put X
                senderCell.Text = "X";
                curo = 1;
                label1.Text = "O's Turn:";
                board |= 1 << (x * 2);
            }
        }
    }
}
