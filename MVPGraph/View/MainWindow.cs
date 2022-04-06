using MVPGraph.Presenter;
using MVPGraph.View;
using System;
using System.Windows.Forms;

namespace MVPGraph
{
    public partial class MainWindow : Form, IExtremum
    {
        private ExtremumPresenter _presenter;

        public MainWindow()
        {
            InitializeComponent();
            ShowDefaultTextBox();
            rbtSin.Checked = true;
            rbtMax.Checked = true;
        }

        public string TxtA { get => txtA.Text; set => txtA.Text = value; }
        public string TxtB { get => txtB.Text; set => txtB.Text = value; }
        public string TxtH { get => txtH.Text; set => txtH.Text = value; }
        public string TxtEpsilon { get => txtEpsilon.Text; set => txtEpsilon.Text = value; }
        public string TxtFX { get => txtFX.Text; set => txtFX.Text = value; }
        public string TxtMaxY { get => txtMaxY.Text; set => txtMaxY.Text = value; }
        public string TxtMinY { get => txtMinY.Text; set => txtMinY.Text = value; }
        public string TxtMaxX { get => txtMaxX.Text; set => txtMaxX.Text = value; }
        public string TxtMinX { get => txtMinX.Text; set => txtMinX.Text = value; }

        private void BtnDraw_Click(object sender, EventArgs e)
        {
            _presenter = new ExtremumPresenter(this);
            chrtGraph.Series[0].Points.Clear();
            _presenter.Calculate(this);
            ShowMinOrMaxTextBox();
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            _presenter = new ExtremumPresenter(this);
            chrtGraph.Series[0].Points.Clear();
            _presenter.AnyTextBoxEmpty();
        }

        private void TxtA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (
                !Char.IsDigit(e.KeyChar)
                && e.KeyChar != 8   // ASCII Backspace
                && e.KeyChar != 44  // ASCII Comma ","
                && e.KeyChar != 45  // ASCII Minus "-"
                && e.KeyChar != 46  // ASCII Dot "."
                )
                e.Handled = true;
        }

        private void TxtB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (
                !Char.IsDigit(e.KeyChar)
                && e.KeyChar != 8   // ASCII Backspace
                && e.KeyChar != 44  // ASCII Comma ","
                && e.KeyChar != 45  // ASCII Minus "-"
                && e.KeyChar != 46  // ASCII Dot "."
                )
                e.Handled = true;
        }

        private void TxtH_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (
                !Char.IsDigit(e.KeyChar)
                && e.KeyChar != 8   // ASCII Backspace
                && e.KeyChar != 44  // ASCII Comma ","
                && e.KeyChar != 46  // ASCII Dot "."
                )
                e.Handled = true;
        }

        private void TxtEpsilon_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (
                !Char.IsDigit(e.KeyChar)
                && e.KeyChar != 8   // ASCII Backspace
                && e.KeyChar != 44  // ASCII Comma ","
                && e.KeyChar != 46  // ASCII Dot "."
                )
                e.Handled = true;
        }

        private void ShowDefaultTextBox()
        {
            txtA.Text = (string)txtA.Tag;
            txtB.Text = (string)txtB.Tag;
            txtH.Text = (string)txtH.Tag;
            txtEpsilon.Text = (string)txtEpsilon.Tag;
        }

        private void ShowMinOrMaxTextBox()
        {
            if (rbtMax.Checked)
            {
                lblMaxX.Visible = true;
                txtMaxX.Visible = true;
                lblMaxY.Visible = true;
                txtMaxY.Visible = true;
                lblMinX.Visible = false;
                txtMinX.Visible = false;
                lblMinY.Visible = false;
                txtMinY.Visible = false;
            }

            if (rbtMin.Checked)
            {
                lblMaxX.Visible = false;
                txtMaxX.Visible = false;
                lblMaxY.Visible = false;
                txtMaxY.Visible = false;
                lblMinX.Visible = true;
                txtMinX.Visible = true;
                lblMinY.Visible = true;
                txtMinY.Visible = true;
            }
        }
    }
}
