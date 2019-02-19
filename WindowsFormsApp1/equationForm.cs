using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using CCWin.SkinControl;
using CCWin;

namespace WindowsFormsApp1
{
    public delegate void labelTranslateEventHandler(string value);//委托器
    public partial class equationForm : CCSkinMain
    {
        public event labelTranslateEventHandler labelTranlate;//事件函数
        private Label labelNew;
        private FormTool formTool;
        public equationForm()

        {
            InitializeComponent();

        }
        
        int b = 0;
        int c = 0;
        int d = 0;
        int result = 0;
        private void equation_Load(object sender, EventArgs e)
        {

        }

        private void skinButton2_Click(object sender, EventArgs e)
        {

        }
        //计算存储公式数据  读取label的数值-字符串公式计算-存储在xml文件中
        private void skinButton1_Click(object sender, EventArgs e)
        {
    
            //全部不为空
            if (comboBox1!=null&& comboBox2 != null &&skinWaterTextBox2!=null&& skinWaterTextBox3 != null && skinWaterTextBox4 != null && skinWaterTextBox5 != null)
            {
                int a = int.Parse(this.skinWaterTextBox2.Text);
                int x = int.Parse(this.comboBox1.Text);
                int y = int.Parse(this.comboBox2.Text);
                int b = int.Parse(this.skinWaterTextBox3.Text);
                int c = int.Parse(this.skinWaterTextBox4.Text);
                int d = int.Parse(this.skinWaterTextBox5.Text);
                result = a * x * y + b * x + c * y + d;
                Program.result = result;

                DataSet ds = new DataSet();
                DataTable dt = new DataTable();
                dt.TableName = "Company";
                dt.Columns.Add("Title");
                dt.Columns.Add("x");
                dt.Columns.Add("y");
                dt.Columns.Add("a");
                dt.Columns.Add("b");
                dt.Columns.Add("c");
                dt.Columns.Add("d");
                dt.Columns.Add("result");
                ds.Tables.Add(dt);

               

                DataRow row = ds.Tables["Company"].NewRow();
                row["Title"] = comboBox3.Text;
                row["x"] = comboBox1.Text;
                row["y"] = comboBox2.Text;
                row["a"] = skinWaterTextBox2.Text;
                row["b"] = skinWaterTextBox3.Text;
                row["c"] = skinWaterTextBox4.Text;
                row["d"] = skinWaterTextBox5.Text;
                row["result"] = Program.result;
                ds.Tables["Company"].Rows.Add(row);
                //foreach(DataGridViewRow )
                ds.WriteXml("F:\\c#project\\Data.xml");
                label1.Text = "结果为：" + Program.result;

                //加载计算结果到主面板

                Label labeltest = new Label();  labeltest = label1;
                labelTranlate(label1.Text);
                this.Close();

            }
        }
        //显示公式计算结果 读取xml文件
        private void label1_Click(object sender, EventArgs e)
        {
            
        }
        //a值存储
        private void skinWaterTextBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
