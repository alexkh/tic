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
        // cells are: 0 1 2
        //            3 4 5
        //            6 7 8
        public Form1()
        {
            InitializeComponent();
        }

        // cval extracts cell value from board at pos position
        private int cval(int b, int pos)
        {
            return (b >> (pos * 2)) & 3;
        }

        // eval_win takes a board stat as argument
        // and returns 0 if game is not over,
        // 1 if X won, 2 if O won, 3 if draw
        private int eval_win(int b)
        {
            // check if central cell is not empty and there is
            // a three-in-a-row
            int c = cval(b, 4);
            if (c != 0 &&
                ((cval(b, 0) == c && cval(b, 8) == c) ||
                 (cval(b, 1) == c && cval(b, 7) == c) ||
                 (cval(b, 2) == c && cval(b, 6) == c) ||
                 (cval(b, 3) == c && cval(b, 5) == c))
                )
            {
                return c;
            }

            // check top and left sides:
            c = cval(b, 0);
            if (c != 0 &&
                ((cval(b, 1) == c && cval(b, 2) == c) ||
                 (cval(b, 3) == c && cval(b, 6) == c))
               ) {
                return c;
            }

            // check right and bottom sides:
            c = cval(b, 8);
            if(c != 0 &&
                ((cval(b, 2) == c && cval(b, 5) == c) ||
                 (cval(b, 6) == c && cval(b, 7) == c))
                 )
            {
                return c;
            }

            // if there is no empty cells, it's a draw - return 3
            if(cval(b, 0) != 0 && cval(b, 1) != 0 && cval(b, 2) != 0 &&
               cval(b, 3) != 0 && cval(b, 4) != 0 && cval(b, 5) != 0 &&
               cval(b, 6) != 0 && cval(b, 7) != 0 && cval(b, 8) != 0) {
                return 3;
            }

            return 0;
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

            int win = eval_win(board);
            switch (win)
            {
                case 1:
                    // X won the game
                    label1.Text = "Game over. X won!";
                    break;
                case 2:
                    // O won the game
                    label1.Text = "Game over. O won!";
                    break;
                case 3:
                    // draw
                    label1.Text = "Game over. It's a draw!";
                    break;
            }
        }
    }
}
