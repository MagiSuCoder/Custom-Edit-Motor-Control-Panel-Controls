namespace WindowsFormsApp1
{
    partial class BtnForm
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
            this.btnComboBox1 = new CCWin.SkinControl.SkinComboBox();
            this.skinButton1 = new CCWin.SkinControl.SkinButton();
            this.btnName = new CCWin.SkinControl.SkinWaterTextBox();
            this.skinLabel2 = new CCWin.SkinControl.SkinLabel();
            this.btnFont = new CCWin.SkinControl.SkinButton();
            this.btnColor = new CCWin.SkinControl.SkinButton();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.SuspendLayout();
            // 
            // skinLabel1
            // 
            this.skinLabel1.AutoSize = true;
            this.skinLabel1.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel1.BorderColor = System.Drawing.Color.White;
            this.skinLabel1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel1.Location = new System.Drawing.Point(19, 57);
            this.skinLabel1.Name = "skinLabel1";
            this.skinLabel1.Size = new System.Drawing.Size(56, 17);
            this.skinLabel1.TabIndex = 0;
            this.skinLabel1.Text = "按键类型";
            // 
            // btnComboBox1
            // 
            this.btnComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.btnComboBox1.FormattingEnabled = true;
            this.btnComboBox1.Items.AddRange(new object[] {
            "确认",
            "取消",
            "转速设置",
            "开关电机",
            "解除堵转"});
            this.btnComboBox1.Location = new System.Drawing.Point(91, 52);
            this.btnComboBox1.Name = "btnComboBox1";
            this.btnComboBox1.Size = new System.Drawing.Size(121, 22);
            this.btnComboBox1.TabIndex = 1;
            this.btnComboBox1.WaterText = "";
            // 
            // skinButton1
            // 
            this.skinButton1.BackColor = System.Drawing.Color.Transparent;
            this.skinButton1.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinButton1.DownBack = null;
            this.skinButton1.Location = new System.Drawing.Point(91, 209);
            this.skinButton1.MouseBack = null;
            this.skinButton1.Name = "skinButton1";
            this.skinButton1.NormlBack = null;
            this.skinButton1.Size = new System.Drawing.Size(75, 23);
            this.skinButton1.TabIndex = 2;
            this.skinButton1.Text = "确定";
            this.skinButton1.UseVisualStyleBackColor = false;
            this.skinButton1.Click += new System.EventHandler(this.skinButton1_Click);
            // 
            // btnName
            // 
            this.btnName.Location = new System.Drawing.Point(91, 101);
            this.btnName.Name = "btnName";
            this.btnName.Size = new System.Drawing.Size(121, 21);
            this.btnName.TabIndex = 3;
            this.btnName.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.btnName.WaterText = "";
            // 
            // skinLabel2
            // 
            this.skinLabel2.AutoSize = true;
            this.skinLabel2.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel2.BorderColor = System.Drawing.Color.White;
            this.skinLabel2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel2.Location = new System.Drawing.Point(19, 101);
            this.skinLabel2.Name = "skinLabel2";
            this.skinLabel2.Size = new System.Drawing.Size(32, 17);
            this.skinLabel2.TabIndex = 4;
            this.skinLabel2.Text = "命名";
            // 
            // btnFont
            // 
            this.btnFont.BackColor = System.Drawing.Color.Transparent;
            this.btnFont.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnFont.DownBack = null;
            this.btnFont.Location = new System.Drawing.Point(22, 150);
            this.btnFont.MouseBack = null;
            this.btnFont.Name = "btnFont";
            this.btnFont.NormlBack = null;
            this.btnFont.Size = new System.Drawing.Size(75, 23);
            this.btnFont.TabIndex = 5;
            this.btnFont.Text = "字体设置";
            this.btnFont.UseVisualStyleBackColor = false;
            this.btnFont.Click += new System.EventHandler(this.btnFont_Click);
            // 
            // btnColor
            // 
            this.btnColor.BackColor = System.Drawing.Color.Transparent;
            this.btnColor.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnColor.DownBack = null;
            this.btnColor.Location = new System.Drawing.Point(159, 150);
            this.btnColor.MouseBack = null;
            this.btnColor.Name = "btnColor";
            this.btnColor.NormlBack = null;
            this.btnColor.Size = new System.Drawing.Size(75, 23);
            this.btnColor.TabIndex = 6;
            this.btnColor.Text = "颜色设置";
            this.btnColor.UseVisualStyleBackColor = false;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // BtnForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(257, 281);
            this.Controls.Add(this.btnColor);
            this.Controls.Add(this.btnFont);
            this.Controls.Add(this.skinLabel2);
            this.Controls.Add(this.btnName);
            this.Controls.Add(this.skinButton1);
            this.Controls.Add(this.btnComboBox1);
            this.Controls.Add(this.skinLabel1);
            this.Name = "BtnForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.btnForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CCWin.SkinControl.SkinLabel skinLabel1;
        private CCWin.SkinControl.SkinComboBox btnComboBox1;
        private CCWin.SkinControl.SkinButton skinButton1;
        private CCWin.SkinControl.SkinWaterTextBox btnName;
        private CCWin.SkinControl.SkinLabel skinLabel2;
        private CCWin.SkinControl.SkinButton btnFont;
        private CCWin.SkinControl.SkinButton btnColor;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}