using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tic
{
    internal class Cell : Button
    {
        public Cell() : base()
        {
            ForeColor = Color.Blue;
            Font = new Font("Segoe UI", 70F);
        }
    }
}
