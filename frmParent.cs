using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BSP
{
    public partial class frmParent : Form
    {
        public frmParent()
        {
            InitializeComponent();
            // These lines eliminate flickering of the form or controls in the graphical interface (but not 100%)
            this.hideAll();
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            this.DoubleBuffered = true;
        }

        private void FrmParent_Load(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            
        }

        private Form activeForm = null;
        private void openChildFormInPanel(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
                
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnlMain.Controls.Add(childForm);
            pnlMain.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void Label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private int tolerance = 12;
        private const int WM_NCHITTEST = 132;
        private const int HTBOTTOMRIGHT = 17;
        private Rectangle sizeGripRectangle;
        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_NCHITTEST:
                    base.WndProc(ref m);
                    var hitPoint = this.PointToClient(new Point(m.LParam.ToInt32() & 0xffff, m.LParam.ToInt32() >> 16));
                    if (sizeGripRectangle.Contains(hitPoint))
                        m.Result = new IntPtr(HTBOTTOMRIGHT);
                    break;
                default:
                    base.WndProc(ref m);
                    break;
            }
        }
        // ---------------- DRAW RECTANGLE / EXCLUDE PANEL CORNER 
        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            var region = new Region(new Rectangle(0, 0, this.ClientRectangle.Width, this.ClientRectangle.Height));
            sizeGripRectangle = new Rectangle(this.ClientRectangle.Width - tolerance, this.ClientRectangle.Height - tolerance, tolerance, tolerance);
            region.Exclude(sizeGripRectangle);
            this.pnl.Region = region;
            this.Invalidate();
        }
        // ---------------- COLOUR AND LOWER RECTANGLE GRIP
        protected override void OnPaint(PaintEventArgs e)
        {
            SolidBrush blueBrush = new SolidBrush(Color.FromArgb(244, 244, 244));
            e.Graphics.FillRectangle(blueBrush, sizeGripRectangle);
            base.OnPaint(e);
            ControlPaint.DrawSizeGrip(e.Graphics, Color.Transparent, sizeGripRectangle);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnProjectStatus_Click(object sender, EventArgs e)
        {
            Form frm = new frmStatus();
            openChildFormInPanel(frm);
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            Form frm = new frmPackage();
            openChildFormInPanel(frm);
        }

        private void BtnBudgetManagement_Click(object sender, EventArgs e)
        {
            Form frm = new frmBudgetMaintenance();
            openChildFormInPanel(frm);
        }

        private void hideAll()
        {
            pnlProjManagement.Visible = false;
            pnlProjManagement.Enabled = false;

            pnlChangeManagement.Visible = false;
            pnlChangeManagement.Enabled = false;

            pnlBudgetManagement.Visible = false;
            pnlBudgetManagement.Enabled = false;

            pnlSettings.Visible = false;
            pnlSettings.Enabled = false;
        }
    }
}
