using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using OpenTK;

using OpenTK.Graphics.OpenGL;

namespace HydraCAM
{
    public partial class BedViewer : UserControl
    {
        
        
        //Varibles for controlling Bed State
        
        //GL Control Variables
        private bool GL_Loaded;

        public BedViewer()
        {
            InitializeComponent();
        }

        private void BedViewer_Load(object sender, EventArgs e)
        {
            if(DesignMode)
                return;
            
            GL_Loaded = true;

            glControl1.MakeCurrent();
            GL.ClearColor(Color.SkyBlue);
        }

        private void drawGrid()
        { }

        private void drawCursor()
        {

        }

        private void drawZ()
        {

        }
        
        private void BedViewer_Paint(object sender, PaintEventArgs e)
        {
            if (DesignMode)
                return;

            if(!GL_Loaded)
                return;

            glControl1.MakeCurrent();
            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);
            glControl1.SwapBuffers();


        }

        private void glControl1_Load(object sender, EventArgs e)
        {

        }

  
    }
}
