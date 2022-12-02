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
            _presenter.IsRadioButtonChecked(this);
            _presenter.Show(this);
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
            lblMaxX.Visible =
            txtMaxX.Visible =
            lblMaxY.Visible =
            txtMaxY.Visible = rbtMax.Checked;

            lblMinX.Visible =
            txtMinX.Visible =
            lblMinY.Visible =
            txtMinY.Visible = rbtMin.Checked;
        }

        private void IntervalParameters_BoxLeave(object sender, EventArgs e)
        {
            TextBox box = (TextBox)sender;
            if (box.Text == "")
            {
                ShowDefaultTextBox();
                _presenter.ShowDefaultParamsMessage();
            }
        }
    }
}
