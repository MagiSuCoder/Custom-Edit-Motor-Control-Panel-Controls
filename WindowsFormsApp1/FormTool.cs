using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CCWin.SkinControl;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    class FormTool
    {
        private Label label;
        private SkinRadioButton radioButtonY;
        private SkinRadioButton radioButtonN;
        private int numValue;

        public Label Label { get => label; set => label = value; }
        public SkinRadioButton RadioButtonY { get => radioButtonY; set => radioButtonY = value; }
        public SkinRadioButton RadioButtonN { get => radioButtonN; set => radioButtonN = value; }
        public int NumValue { get => numValue; set => numValue = value; }
    }
}
