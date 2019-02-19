namespace WindowsFormsApp1
{
    partial class BoolForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.skinLabel1 = new CCWin.SkinControl.SkinLabel();
            this.selectBool = new CCWin.SkinControl.SkinComboBox();
            this.skinButton1 = new CCWin.SkinControl.SkinButton();
            this.skinLabel6 = new CCWin.SkinControl.SkinLabel();
            this.skinWaterTextBox1 = new CCWin.SkinControl.SkinWaterTextBox();
            this.skinLabel7 = new CCWin.SkinControl.SkinLabel();
            this.skinWaterTextBox2 = new CCWin.SkinControl.SkinWaterTextBox();
            this.skinLabel2 = new CCWin.SkinControl.SkinLabel();
            this.labelName = new CCWin.SkinControl.SkinWaterTextBox();
            this.skinButton2 = new CCWin.SkinControl.SkinButton();
            this.skinLine1 = new CCWin.SkinControl.SkinLine();
            this.skinButton3 = new CCWin.SkinControl.SkinButton();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.SuspendLayout();
            // 
            // skinLabel1
            // 
            this.skinLabel1.AutoSize = true;
            this.skinLabel1.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel1.BorderColor = System.Drawing.Color.White;
            this.skinLabel1.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel1.Location = new System.Drawing.Point(21, 42);
            this.skinLabel1.Name = "skinLabel1";
            this.skinLabel1.Size = new System.Drawing.Size(50, 26);
            this.skinLabel1.TabIndex = 0;
            this.skinLabel1.Text = "字段";
            // 
            // selectBool
            // 
            this.selectBool.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.selectBool.FormattingEnabled = true;
            this.selectBool.Items.AddRange(new object[] {
            "转速字段",
            "地址字段",
            "电流字段"});
            this.selectBool.Location = new System.Drawing.Point(90, 46);
            this.selectBool.Name = "selectBool";
            this.selectBool.Size = new System.Drawing.Size(167, 22);
            this.selectBool.TabIndex = 3;
            this.selectBool.WaterText = "";
            // 
            // skinButton1
            // 
            this.skinButton1.BackColor = System.Drawing.Color.Transparent;
            this.skinButton1.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinButton1.DownBack = null;
            this.skinButton1.Location = new System.Drawing.Point(90, 257);
            this.skinButton1.MouseBack = null;
            this.skinButton1.Name = "skinButton1";
            this.skinButton1.NormlBack = null;
            this.skinButton1.Size = new System.Drawing.Size(100, 23);
            this.skinButton1.TabIndex = 4;
            this.skinButton1.Text = "确定";
            this.skinButton1.UseVisualStyleBackColor = false;
            this.skinButton1.Click += new System.EventHandler(this.skinButton1_Click);
            // 
            // skinLabel6
            // 
            this.skinLabel6.AutoSize = true;
            this.skinLabel6.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel6.BorderColor = System.Drawing.Color.White;
            this.skinLabel6.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel6.Location = new System.Drawing.Point(23, 184);
            this.skinLabel6.Name = "skinLabel6";
            this.skinLabel6.Size = new System.Drawing.Size(32, 17);
            this.skinLabel6.TabIndex = 9;
            this.skinLabel6.Text = "上限";
            // 
            // skinWaterTextBox1
            // 
            this.skinWaterTextBox1.Location = new System.Drawing.Point(90, 180);
            this.skinWaterTextBox1.Name = "skinWaterTextBox1";
            this.skinWaterTextBox1.Size = new System.Drawing.Size(100, 21);
            this.skinWaterTextBox1.TabIndex = 10;
            this.skinWaterTextBox1.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.skinWaterTextBox1.WaterText = "";
            this.skinWaterTextBox1.TextChanged += new System.EventHandler(this.skinWaterTextBox1_TextChanged);
            // 
            // skinLabel7
            // 
            this.skinLabel7.AutoSize = true;
            this.skinLabel7.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel7.BorderColor = System.Drawing.Color.White;
            this.skinLabel7.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel7.Location = new System.Drawing.Point(23, 210);
            this.skinLabel7.Name = "skinLabel7";
            this.skinLabel7.Size = new System.Drawing.Size(32, 17);
            this.skinLabel7.TabIndex = 11;
            this.skinLabel7.Text = "下限";
            // 
            // skinWaterTextBox2
            // 
            this.skinWaterTextBox2.Location = new System.Drawing.Point(90, 210);
            this.skinWaterTextBox2.Name = "skinWaterTextBox2";
            this.skinWaterTextBox2.Size = new System.Drawing.Size(100, 21);
            this.skinWaterTextBox2.TabIndex = 12;
            this.skinWaterTextBox2.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.skinWaterTextBox2.WaterText = "";
            // 
            // skinLabel2
            // 
            this.skinLabel2.AutoSize = true;
            this.skinLabel2.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel2.BorderColor = System.Drawing.Color.White;
            this.skinLabel2.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel2.Location = new System.Drawing.Point(21, 77);
            this.skinLabel2.Name = "skinLabel2";
            this.skinLabel2.Size = new System.Drawing.Size(50, 26);
            this.skinLabel2.TabIndex = 13;
            this.skinLabel2.Text = "命名";
            // 
            // labelName
            // 
            this.labelName.Location = new System.Drawing.Point(90, 77);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(100, 21);
            this.labelName.TabIndex = 14;
            this.labelName.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.labelName.WaterText = "";
            // 
            // skinButton2
            // 
            this.skinButton2.BackColor = System.Drawing.Color.Transparent;
            this.skinButton2.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinButton2.DownBack = null;
            this.skinButton2.Location = new System.Drawing.Point(26, 118);
            this.skinButton2.MouseBack = null;
            this.skinButton2.Name = "skinButton2";
            this.skinButton2.NormlBack = null;
            this.skinButton2.Size = new System.Drawing.Size(75, 23);
            this.skinButton2.TabIndex = 15;
            this.skinButton2.Text = "字体设置";
            this.skinButton2.UseVisualStyleBackColor = false;
            this.skinButton2.Click += new System.EventHandler(this.skinButton2_Click);
            // 
            // skinLine1
            // 
            this.skinLine1.BackColor = System.Drawing.Color.Transparent;
            this.skinLine1.LineColor = System.Drawing.Color.Black;
            this.skinLine1.LineHeight = 1;
            this.skinLine1.Location = new System.Drawing.Point(-3, 147);
            this.skinLine1.Name = "skinLine1";
            this.skinLine1.Size = new System.Drawing.Size(289, 10);
            this.skinLine1.TabIndex = 16;
            this.skinLine1.Text = "skinLine1";
            // 
            // skinButton3
            // 
            this.skinButton3.BackColor = System.Drawing.Color.Transparent;
            this.skinButton3.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinButton3.DownBack = null;
            this.skinButton3.Location = new System.Drawing.Point(138, 117);
            this.skinButton3.MouseBack = null;
            this.skinButton3.Name = "skinButton3";
            this.skinButton3.NormlBack = null;
            this.skinButton3.Size = new System.Drawing.Size(75, 23);
            this.skinButton3.TabIndex = 17;
            this.skinButton3.Text = "字体颜色";
            this.skinButton3.UseVisualStyleBackColor = false;
            this.skinButton3.Click += new System.EventHandler(this.skinButton3_Click);
            // 
            // BoolForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(276, 311);
            this.Controls.Add(this.skinButton3);
            this.Controls.Add(this.skinLine1);
            this.Controls.Add(this.skinButton2);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.skinLabel2);
            this.Controls.Add(this.skinWaterTextBox2);
            this.Controls.Add(this.skinLabel7);
            this.Controls.Add(this.skinWaterTextBox1);
            this.Controls.Add(this.skinLabel6);
            this.Controls.Add(this.skinButton1);
            this.Controls.Add(this.selectBool);
            this.Controls.Add(this.skinLabel1);
            this.Name = "BoolForm";
            this.Text = " ";
            this.Load += new System.EventHandler(this.boolForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CCWin.SkinControl.SkinLabel skinLabel1;
        private CCWin.SkinControl.SkinComboBox selectBool;
        private CCWin.SkinControl.SkinButton skinButton1;
        private CCWin.SkinControl.SkinLabel skinLabel6;
        private CCWin.SkinControl.SkinWaterTextBox skinWaterTextBox1;
        private CCWin.SkinControl.SkinLabel skinLabel7;
        private CCWin.SkinControl.SkinWaterTextBox skinWaterTextBox2;
        private CCWin.SkinControl.SkinLabel skinLabel2;
        private CCWin.SkinControl.SkinWaterTextBox labelName;
        private CCWin.SkinControl.SkinButton skinButton2;
        private CCWin.SkinControl.SkinLine skinLine1;
        private CCWin.SkinControl.SkinButton skinButton3;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.FontDialog fontDialog1;
    }
}