using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tic
{
    internal class Cell : Button
    {
        protected int index;
        public Cell(int index) : base()
        {
            ForeColor = Color.Blue;
            Font = new Font("Segoe UI", 70F);
            Text = index.ToString();
        }
    }
}
