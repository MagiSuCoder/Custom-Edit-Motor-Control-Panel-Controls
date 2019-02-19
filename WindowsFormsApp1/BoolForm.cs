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

    public delegate void boolTranslateEventHandler(Label value,SkinRadioButton valueY,SkinRadioButton valueN,int numState);  //bool代理
    public partial class BoolForm : CCSkinMain
    {
        private Font fontNew;
        private Color colorNew;
        public event boolTranslateEventHandler boolTranslate;

        public BoolForm()
        {
            InitializeComponent();
        }

        private void boolForm_Load(object sender, EventArgs e)
        {

        }

        private void skinLabel2_Click(object sender, EventArgs e)
        {

        }

        private void skinPushPanel1_ItemCaptionClick(object sender, CCWin.SkinControl.PushPanelItemCaptionClickEventArgs e)
        {

        }

        private void skinButton1_Click(object sender, EventArgs e)
        {
            int selectNum=0;  //判断选择的字段,0代表未选择
            if (selectBool.Text.Equals("转速字段"))
            {
                selectNum = 1;
            }
            else if(selectBool.Equals("地址字段"))
            {
                selectNum = 2;
            }
            else
            {
                selectNum = 3;
            }
            if(selectNum!=0)
            {
                boolSetting(selectNum);
            }
            this.Close();
        }
        private void boolSetting(int selectNum)
        {
            Label boolLabelName = new Label();
            boolLabelName.Text = labelName.Text;
            SkinRadioButton skinRadioButton1 = new SkinRadioButton();    skinRadioButton1.Text = "是";
            SkinRadioButton skinRadioButton2 = new SkinRadioButton();    skinRadioButton2.Text = "否";

            boolLabelName.Font = fontNew;   skinRadioButton1.Font = fontNew;  skinRadioButton2.Font = fontNew;
            boolLabelName.ForeColor = colorNew; skinRadioButton1.ForeColor = colorNew; skinRadioButton2.ForeColor = colorNew;

            boolLabelName.AutoSize = true;   skinRadioButton1.AutoSize = true; skinRadioButton2.AutoSize = true;
            boolTranslate(boolLabelName, skinRadioButton1, skinRadioButton2,selectNum);
        }

        //设置字体
        private void skinButton2_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                 fontNew = fontDialog1.Font;
            }
        }
        //设置颜色
        private void skinButton3_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog()== DialogResult.OK)
            {
                colorNew = colorDialog1.Color;
            }
        }

        private void skinWaterTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
