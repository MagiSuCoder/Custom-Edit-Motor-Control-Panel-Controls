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
using CCWin.SkinControl;


namespace WindowsFormsApp1
{
    public delegate void btnTranslateEventHandler(SkinButton value,int num);
    public partial class BtnForm : CCSkinMain
    {
        private Font fontNew;
        private Color colorNew;
        public event btnTranslateEventHandler btnTranlate;
        public BtnForm()
        {
            InitializeComponent();
        }

        private void btnForm_Load(object sender, EventArgs e)
        {

        }

        private void skinButton1_Click(object sender, EventArgs e)
        {
            if (!btnComboBox1.Text.Equals(""))
            {
                skinButton();
            }
        }
        //新建设置两个
        private void skinButton()
        {
            string btnKind = btnComboBox1.Text;
            int num = 1;
            switch (btnKind)
            {
                case "确定": num = 1; break;
                case "取消": num = 2; break;
                case "转速设置": num = 3; break;
                case "开关电机": num = 4; break;
                case "解除堵转": num = 5; break;
            }
            SkinButton skinButton = new SkinButton();
            skinButton.Text = btnName.Text;
            skinButton.Font = fontNew;
            skinButton.ForeColor = colorNew;
            skinButton.AutoSize = true;
            btnTranlate(skinButton,num);
            this.Close();
        }
        //setting font
        private void btnFont_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                fontNew = fontDialog1.Font;
            }
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                colorNew = colorDialog1.Color;
            }
        }
    }
}
