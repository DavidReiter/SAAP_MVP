using SAAP_MVP.Model;
using SAAP_MVP.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAAP_MVP.Presenter
{
    public class CalcPresenter
    {
        Calc calc = new Calc();

        private ICalc calcView;

        public CalcPresenter(ICalc view)
        {
            calcView = view;
        }

        public void Connect()
        {
            calc.input = Convert.ToDouble(calcView.txt_input);
        }

        public void CalcSin()
        {
            Connect();
            calcView.txt_output = calc.calcSin().ToString();
        }

        public void CalcCos()
        {
            Connect();
            calcView.txt_output = calc.calcCos().ToString();
        }

        public void CalcTan()
        {
            Connect();
            calcView.txt_output = calc.calcTan().ToString();
        }
    }

}
