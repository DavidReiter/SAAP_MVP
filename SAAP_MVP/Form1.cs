using SAAP_MVP.Presenter;
using SAAP_MVP.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SAAP_MVP
{
    public partial class Form1 : Form, ICalc
    {
        public Form1()
        {
            InitializeComponent();
        }

        public string txt_input { get => txtbox_input.Text; set => txtbox_input.Text = value; }
        public string txt_output { get => txtbox_output.Text; set => txtbox_output.Text = value; }

        private CalcPresenter presenter;

        private void btn_sin_Click(object sender, EventArgs e)
        {
            presenter = new CalcPresenter(this);
            presenter.CalcSin();

        }

        private void btn_cos_Click(object sender, EventArgs e)
        {
            presenter = new CalcPresenter(this);
            presenter.CalcCos();
        }

        private void btn_tan_Click(object sender, EventArgs e)
        {
            presenter = new CalcPresenter(this);
            presenter.CalcTan();
        }

    }
}
