namespace WindowsFormsApp1
{
    partial class LabelForm
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
            this.labelText = new CCWin.SkinControl.SkinWaterTextBox();
            this.labelColorBtn = new CCWin.SkinControl.SkinButton();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.btnShow = new System.Windows.Forms.Button();
            this.fontSettingBtn = new CCWin.SkinControl.SkinButton();
            this.testLabel = new CCWin.SkinControl.SkinLabel();
            this.skinLabel3 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel4 = new CCWin.SkinControl.SkinLabel();
            this.labelSureBtn = new CCWin.SkinControl.SkinButton();
            this.skinGroupBox1 = new CCWin.SkinControl.SkinGroupBox();
            this.skinGroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // skinLabel1
            // 
            this.skinLabel1.AutoSize = true;
            this.skinLabel1.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel1.BorderColor = System.Drawing.Color.White;
            this.skinLabel1.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel1.Location = new System.Drawing.Point(27, 88);
            this.skinLabel1.Name = "skinLabel1";
            this.skinLabel1.Size = new System.Drawing.Size(50, 26);
            this.skinLabel1.TabIndex = 1;
            this.skinLabel1.Text = "颜色";
            // 
            // labelText
            // 
            this.labelText.Location = new System.Drawing.Point(79, 45);
            this.labelText.Name = "labelText";
            this.labelText.Size = new System.Drawing.Size(157, 21);
            this.labelText.TabIndex = 2;
            this.labelText.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.labelText.WaterText = "";
            // 
            // labelColorBtn
            // 
            this.labelColorBtn.BackColor = System.Drawing.Color.Transparent;
            this.labelColorBtn.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.labelColorBtn.DownBack = null;
            this.labelColorBtn.Location = new System.Drawing.Point(161, 90);
            this.labelColorBtn.MouseBack = null;
            this.labelColorBtn.Name = "labelColorBtn";
            this.labelColorBtn.NormlBack = null;
            this.labelColorBtn.Size = new System.Drawing.Size(75, 23);
            this.labelColorBtn.TabIndex = 4;
            this.labelColorBtn.Text = "确定";
            this.labelColorBtn.UseVisualStyleBackColor = false;
            this.labelColorBtn.Click += new System.EventHandler(this.labelColorBtn_Click);
            // 
            // btnShow
            // 
            this.btnShow.BackColor = System.Drawing.Color.Aquamarine;
            this.btnShow.Location = new System.Drawing.Point(79, 90);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(75, 23);
            this.btnShow.TabIndex = 5;
            this.btnShow.UseVisualStyleBackColor = false;
            // 
            // fontSettingBtn
            // 
            this.fontSettingBtn.BackColor = System.Drawing.Color.Transparent;
            this.fontSettingBtn.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.fontSettingBtn.DownBack = null;
            this.fontSettingBtn.Location = new System.Drawing.Point(104, 135);
            this.fontSettingBtn.MouseBack = null;
            this.fontSettingBtn.Name = "fontSettingBtn";
            this.fontSettingBtn.NormlBack = null;
            this.fontSettingBtn.Size = new System.Drawing.Size(84, 26);
            this.fontSettingBtn.TabIndex = 7;
            this.fontSettingBtn.Text = "设置";
            this.fontSettingBtn.UseVisualStyleBackColor = false;
            this.fontSettingBtn.Click += new System.EventHandler(this.fontSettingBtn_Click);
            // 
            // testLabel
            // 
            this.testLabel.AutoSize = true;
            this.testLabel.BackColor = System.Drawing.Color.Transparent;
            this.testLabel.BorderColor = System.Drawing.Color.White;
            this.testLabel.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.testLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.testLabel.Location = new System.Drawing.Point(53, 42);
            this.testLabel.Name = "testLabel";
            this.testLabel.Size = new System.Drawing.Size(80, 17);
            this.testLabel.TabIndex = 8;
            this.testLabel.Text = "测试字体样式";
            // 
            // skinLabel3
            // 
            this.skinLabel3.AutoSize = true;
            this.skinLabel3.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel3.BorderColor = System.Drawing.Color.White;
            this.skinLabel3.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel3.Location = new System.Drawing.Point(27, 45);
            this.skinLabel3.Name = "skinLabel3";
            this.skinLabel3.Size = new System.Drawing.Size(50, 26);
            this.skinLabel3.TabIndex = 9;
            this.skinLabel3.Text = "命名";
            // 
            // skinLabel4
            // 
            this.skinLabel4.AutoSize = true;
            this.skinLabel4.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel4.BorderColor = System.Drawing.Color.White;
            this.skinLabel4.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel4.Location = new System.Drawing.Point(27, 135);
            this.skinLabel4.Name = "skinLabel4";
            this.skinLabel4.Size = new System.Drawing.Size(50, 26);
            this.skinLabel4.TabIndex = 10;
            this.skinLabel4.Text = "字体";
            // 
            // labelSureBtn
            // 
            this.labelSureBtn.BackColor = System.Drawing.Color.Transparent;
            this.labelSureBtn.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.labelSureBtn.DownBack = null;
            this.labelSureBtn.Location = new System.Drawing.Point(79, 296);
            this.labelSureBtn.MouseBack = null;
            this.labelSureBtn.Name = "labelSureBtn";
            this.labelSureBtn.NormlBack = null;
            this.labelSureBtn.Size = new System.Drawing.Size(101, 48);
            this.labelSureBtn.TabIndex = 11;
            this.labelSureBtn.Text = "确定";
            this.labelSureBtn.UseVisualStyleBackColor = false;
            this.labelSureBtn.Click += new System.EventHandler(this.labelSureBtn_Click);
            // 
            // skinGroupBox1
            // 
            this.skinGroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.skinGroupBox1.BorderColor = System.Drawing.Color.Red;
            this.skinGroupBox1.Controls.Add(this.testLabel);
            this.skinGroupBox1.ForeColor = System.Drawing.Color.Blue;
            this.skinGroupBox1.Location = new System.Drawing.Point(32, 177);
            this.skinGroupBox1.Name = "skinGroupBox1";
            this.skinGroupBox1.RectBackColor = System.Drawing.Color.White;
            this.skinGroupBox1.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.skinGroupBox1.Size = new System.Drawing.Size(204, 100);
            this.skinGroupBox1.TabIndex = 12;
            this.skinGroupBox1.TabStop = false;
            this.skinGroupBox1.TitleBorderColor = System.Drawing.Color.Red;
            this.skinGroupBox1.TitleRectBackColor = System.Drawing.Color.White;
            this.skinGroupBox1.TitleRoundStyle = CCWin.SkinClass.RoundStyle.All;
            // 
            // LabelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 383);
            this.Controls.Add(this.skinGroupBox1);
            this.Controls.Add(this.labelSureBtn);
            this.Controls.Add(this.skinLabel4);
            this.Controls.Add(this.skinLabel3);
            this.Controls.Add(this.fontSettingBtn);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.labelColorBtn);
            this.Controls.Add(this.labelText);
            this.Controls.Add(this.skinLabel1);
            this.Name = "LabelForm";
            this.Text = "标签设置";
            this.Load += new System.EventHandler(this.labelForm_Load);
            this.skinGroupBox1.ResumeLayout(false);
            this.skinGroupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private CCWin.SkinControl.SkinLabel skinLabel1;
        private CCWin.SkinControl.SkinWaterTextBox labelText;
        private CCWin.SkinControl.SkinButton labelColorBtn;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button btnShow;
        private CCWin.SkinControl.SkinButton fontSettingBtn;
        private CCWin.SkinControl.SkinLabel testLabel;
        private CCWin.SkinControl.SkinLabel skinLabel3;
        private CCWin.SkinControl.SkinLabel skinLabel4;
        private CCWin.SkinControl.SkinButton labelSureBtn;
        private CCWin.SkinControl.SkinGroupBox skinGroupBox1;
    }
}