using System.Diagnostics.Tracing;
using System.Runtime.CompilerServices;
using System.Globalization;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2_lab
{
    public partial class Form1 : Form
    {
        private int x = 500;
        private int y = 700;
        private int flag = 0,
        private  int q = 0;

        private Pen _pen = new  Pen(Color.Yellow, 5);
        private Graphics _graph;

        public Form1()
        {
            _graph = CreateGraphics();
            InitializeComponent();
            
        }
        
        private async void Animate()
        {
            while(true)
            {
                if(y <= 220)
                {
                    g.DrawLine(pen, x, y, x, y - 20);
                    y -= 22;
                }
                for (var i = 0; i < 2; i++)
                {
                    await Explose();
                    await Task.Delay(100);
                    await PhaseOne();
                    await Task.Delay(100);
                    await PhaseTwo();
                    await Task.Delay(100);
                }

            }
        }

        private async Task Explose()
        {
            _graph.Clear(BackColor);
            _graph.DrawEllipse(pen, 499, 337, 2, 2);
        }

        private async Task PhaseOne()
        {
            _graph.DrawLine(pen, 500, 330, 500, 300);
            await Task.Delay(2);
            _graph.DrawLine(pen, 490, 330, 450, 300);
            await Task.Delay(2);
            _graph.DrawLine(pen, 510, 330, 550, 300);
            await Task.Delay(2);
            _graph.DrawLine(pen, 490, 345, 450, 370);
            await Task.Delay(2);
            _graph.DrawLine(pen, 510, 345, 550, 370);
            await Task.Delay(2);
        }
        private async Task PhaseTwo()
        {
            _graph.DrawLine(pen, 500, 295, 500, 255);
            await Task.Delay(2);
            _graph.DrawLine(pen, 440, 295, 400, 265);
            await Task.Delay(2);
            _graph.DrawLine(pen, 560, 295, 600, 265);
            await Task.Delay(2);
            _graph.DrawLine(pen, 440, 375, 400, 400);
            await Task.Delay(2);
            _graph.DrawLine(pen, 560, 375, 600, 400);
            await Task.Delay(2);
        }

        private async Task SycleEnd()
        {
            g.Clear(BackColor);
            y = 700;
        }
    }
}
