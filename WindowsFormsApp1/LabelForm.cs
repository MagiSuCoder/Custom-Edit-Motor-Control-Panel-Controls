using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CCWin;

namespace WindowsFormsApp1
{
    public delegate void TranslateEventHandler(Label value);
    public partial class LabelForm : CCSkinMain
    {
        public LabelForm()
        {
            InitializeComponent();
        }
        //委托事件
        public event TranslateEventHandler Translate;

        private void labelForm_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        //设置颜色
        private void labelColorBtn_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                btnShow.BackColor = colorDialog1.Color;
            }
        }

        //设置字体
        private void fontSettingBtn_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
        //新建标签ogResult.OK)
            {
                testLabel.Font = fontDialog1.Font;
            }          
        }

        private void labelSureBtn_Click(object sender, EventArgs e)
        {
            Label label = new Label();
            label.Text = labelText.Text;
            label.BackColor = Color.Transparent;
            label.ForeColor = btnShow.BackColor;
            label.Font  = testLabel.Font;
            label.AutoSize = true;
            Translate(label);
            this.Close();
        }
    }
}
