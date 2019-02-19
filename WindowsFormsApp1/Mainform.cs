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
using WinControlLib;

namespace WindowsFormsApp1
{
    public partial class Mainform : CCSkinMain
    {
        private Label labelNew;
        private FormTool formTool;
        private SkinButton btnSkinButton;
        private int btnNum;


        public Mainform()
        {
            InitializeComponent();
            formTool = new FormTool();//给位置，不出现空值错误
            labelNew = new Label();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }





        //创建一个标签设置界面
        private void skinButton1_Click(object sender, EventArgs e)
        {
            //事件代管
            LabelForm labelform = new LabelForm();
            labelform.Translate += new TranslateEventHandler(label_Translate);
            labelform.ShowDialog();
            Label nlabel = new Label();
            nlabel = labelNew;
            skinSplitContainer1.Panel2.Controls.Add(nlabel);
            nlabel.Show();
            DragControlClass obj = new DragControlClass(nlabel);
        }
        void label_Translate(Label value)
        {
            labelNew= value;
        }

        void bool_Translate(Label label,SkinRadioButton valueY,SkinRadioButton valueN,int numValue)
        {
            formTool.RadioButtonY = valueY;
            formTool.RadioButtonN = valueN;
            formTool.Label = label;
            formTool.NumValue = numValue;
        }




        //add a equation setting form
        private void skinButton2_Click(object sender, EventArgs e)
        {
            equationForm equationform = new equationForm();
            equationform.labelTranlate += new labelTranslateEventHandler(text_Translate);
            equationform.ShowDialog();
            label1.Text = labelNew.Text;
            label1.Show();


        }
        void text_Translate(string value)
        {
            labelNew.Text = value;
        }

        //add a  bool setting form and limitation form
        private void skinButton3_Click(object sender, EventArgs e)
        {
            BoolForm boolForm = new BoolForm();
            boolForm.boolTranslate += new boolTranslateEventHandler(bool_Translate);
            boolForm.ShowDialog();

            //create the tool
            Label nlabel = new Label();
            SkinRadioButton radioButtonY = new SkinRadioButton();
            SkinRadioButton radioButtonN = new SkinRadioButton();

            nlabel = formTool.Label;   radioButtonN = formTool.RadioButtonN; radioButtonY = formTool.RadioButtonY;
            //add to the panel
            skinSplitContainer1.Panel2.Controls.Add(nlabel);
            skinSplitContainer1.Panel2.Controls.Add(radioButtonY);
            skinSplitContainer1.Panel2.Controls.Add(radioButtonN);
            nlabel.Show();   radioButtonN.Show();  radioButtonY.Show();
            //可移动设置
            DragControlClass obj = new DragControlClass(nlabel);
            DragControlClass obj1 = new DragControlClass(radioButtonY);
            DragControlClass obj2 = new DragControlClass(radioButtonN);
        }

        //add a btn setting form
        private void btn_newBtn_Click(object sender, EventArgs e)
        {
            BtnForm btnForm = new BtnForm();
            btnForm.btnTranlate += new btnTranslateEventHandler(btn_Translate); 
            btnForm.ShowDialog();
            SkinButton btnNew = btnSkinButton;
            skinSplitContainer1.Panel2.Controls.Add(btnNew);
            DragControlClass obj = new DragControlClass(btnNew);

        }
        private void btn_Translate(SkinButton skinButton,int num)
        {
            this.btnSkinButton = skinButton;
            this.btnNum = num;
  
        }





        private void label1_Click(object sender, EventArgs e)
        {
            //label1.Text = "" + Program.result; 读xml文件
            DataSet ds = new DataSet();
            ds.ReadXml("F:\\c#project\\Data.xml");
            label1.Text = ds.Tables["Company"].Rows[0][7].ToString();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            ds.ReadXml("F:\\c#project\\Data.xml");
            label1.Text = ds.Tables["Company"].Rows[0][7].ToString();
        }
    }
    
}

namespace WinControlLib
{
    public class DragControlClass
    {
        //待拖动的控件
        private Control m_Control;
        //鼠标按下时的x，y坐标
        private int m_X;
        private int m_Y;
        public DragControlClass(Control control)
        {
            m_Control = control;
            m_Control.MouseDown += new MouseEventHandler(control_MouseDown);
            m_Control.MouseMove += new MouseEventHandler(contro_MouseMove);
        }
        private void control_MouseDown(object sender, MouseEventArgs e)
        {
            m_X = e.X;
            m_Y = e.Y;
        }
        private void contro_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                int x = e.X - m_X;
                int y = e.Y - m_Y;
                this.m_Control.Left += x;
                this.m_Control.Top += y;

            }
        }
    }
}
