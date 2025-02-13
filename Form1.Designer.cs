namespace tic
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            cell0 = new Cell();
            cell1 = new Cell();
            cell2 = new Cell();
            cell3 = new Cell();
            cell4 = new Cell();
            cell5 = new Cell();
            cell6 = new Cell();
            cell7 = new Cell();
            cell8 = new Cell();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 10);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 1;
            label1.Text = "X's turn:";
            // 
            // cell0
            // 
            cell0.Location = new Point(18, 44);
            cell0.Name = "0";
            cell0.Size = new Size(132, 136);
            cell0.TabIndex = 3;
            cell0.UseVisualStyleBackColor = true;
            cell0.Click += cell_Click;
            // 
            // cell1
            // 
            cell1.Location = new Point(156, 44);
            cell1.Name = "1";
            cell1.Size = new Size(119, 136);
            cell1.TabIndex = 4;
            cell1.Click += cell_Click;
            // 
            // cell2
            // 
            cell2.Location = new Point(281, 44);
            cell2.Name = "2";
            cell2.Size = new Size(124, 136);
            cell2.TabIndex = 5;
            cell2.Click += cell_Click;
            // 
            // cell3
            // 
            cell3.Location = new Point(18, 186);
            cell3.Name = "3";
            cell3.Size = new Size(132, 139);
            cell3.TabIndex = 6;
            cell3.Click += cell_Click;
            // 
            // cell4
            // 
            cell4.Location = new Point(156, 186);
            cell4.Name = "4";
            cell4.Size = new Size(119, 139);
            cell4.TabIndex = 7;
            cell4.Click += cell_Click;
            // 
            // cell5
            // 
            cell5.Location = new Point(281, 186);
            cell5.Name = "5";
            cell5.Size = new Size(124, 139);
            cell5.TabIndex = 8;
            cell5.Click += cell_Click;
            // 
            // cell6
            // 
            cell6.Location = new Point(18, 331);
            cell6.Name = "6";
            cell6.Size = new Size(132, 133);
            cell6.TabIndex = 9;
            cell6.Click += cell_Click;
            // 
            // cell7
            //
            cell7.Location = new Point(156, 331);
            cell7.Name = "7";
            cell7.Size = new Size(119, 133);
            cell7.TabIndex = 10;
            cell7.Click += cell_Click;
            // 
            // cell8
            //
            cell8.Location = new Point(281, 331);
            cell8.Name = "8";
            cell8.Size = new Size(124, 133);
            cell8.TabIndex = 11;
            cell8.Click += cell_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(427, 492);
            Controls.Add(label1);
            Controls.Add(cell0);
            Controls.Add(cell1);
            Controls.Add(cell2);
            Controls.Add(cell3);
            Controls.Add(cell4);
            Controls.Add(cell5);
            Controls.Add(cell6);
            Controls.Add(cell7);
            Controls.Add(cell8);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Cell cell0, cell1, cell2,
            cell3, cell4, cell5,
            cell6, cell7, cell8;
    }
}
