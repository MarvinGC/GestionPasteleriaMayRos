using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btMaximizar.Visible = false;
            btRestaurar.Visible = true;
        }

        private void btMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btRestaurar.Visible = false;
            btMaximizar.Visible = true;
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SeandMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SeandMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btProductos_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new Productos());
        }

        private void Inicio_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new Inicio());
        }

        private void panelContenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            subMenuReportes.Visible = false;
        }

        private void Reportes_Click(object sender, EventArgs e)
        {
            subMenuReportes.Visible = !subMenuReportes.Visible;
        }

        private void AbrirFormHija(object formhija)
        {
            if (this.panelCont.Controls.Count > 0)
                this.panelCont.Controls.RemoveAt(0);
            Form fh = formhija as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelCont.Controls.Add(fh);
            this.panelCont.Tag = fh;
            fh.Show();


        }

        private void panelCont_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
