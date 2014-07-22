using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tetris
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_DrawField_Click(object sender, EventArgs e)
        {
            DrawField(this.panel_playField.Height, 
                this.panel_playField.Width, 
                this.panel_playField.CreateGraphics());
            DrawField(this.pictureBox_Field.Height,
                this.pictureBox_Field.Width, 
                this.pictureBox_Field.CreateGraphics());

        }

        private void DrawField(int height, int width, Graphics graphics)
        {
            int blockSize = 25;

            System.Drawing.Pen pen_fieldGrid;
            pen_fieldGrid = new System.Drawing.Pen(System.Drawing.Color.DarkGray);
            System.Drawing.Graphics formGraphics = graphics;

            int rowCount = height / blockSize;
            int colCount = width / blockSize;

            int row_StartPoint = height % blockSize;//лишнее оставляем сверху (та часть поля, которая не кратна blockSize)
            for (int i = 0; i < rowCount; i++)
            {
                formGraphics.DrawLine(pen_fieldGrid, 0, row_StartPoint + blockSize * i, width, row_StartPoint + blockSize * i);
            }
            //тут лишнее останется справа (в идеале - найти способ убрать лишнее)
            for (int i = 0; i < colCount; i++)
            {
                formGraphics.DrawLine(pen_fieldGrid, blockSize * (i + 1), 0, blockSize * (i + 1), height);
            }

            pen_fieldGrid.Dispose();
            formGraphics.Dispose();
        }

    }
}
