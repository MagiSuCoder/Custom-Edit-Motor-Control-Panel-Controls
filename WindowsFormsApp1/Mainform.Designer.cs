namespace WindowsFormsApp1
{
    partial class Mainform
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.skinSplitContainer1 = new CCWin.SkinControl.SkinSplitContainer();
            this.btn_newBtn = new CCWin.SkinControl.SkinButton();
            this.skinButton3 = new CCWin.SkinControl.SkinButton();
            this.skinButton2 = new CCWin.SkinControl.SkinButton();
            this.skinButton1 = new CCWin.SkinControl.SkinButton();
            this.label1 = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.skinSplitContainer1)).BeginInit();
            this.skinSplitContainer1.Panel1.SuspendLayout();
            this.skinSplitContainer1.Panel2.SuspendLayout();
            this.skinSplitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(7, 31);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(786, 412);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Aquamarine;
            this.tabPage1.ImeMode = System.Windows.Forms.ImeMode.Close;
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(778, 386);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "显示";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.skinSplitContainer1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(778, 386);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "设置界面";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // skinSplitContainer1
            // 
            this.skinSplitContainer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.skinSplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinSplitContainer1.Location = new System.Drawing.Point(3, 3);
            this.skinSplitContainer1.Name = "skinSplitContainer1";
            // 
            // skinSplitContainer1.Panel1
            // 
            this.skinSplitContainer1.Panel1.BackColor = System.Drawing.Color.SpringGreen;
            this.skinSplitContainer1.Panel1.Controls.Add(this.btn_newBtn);
            this.skinSplitContainer1.Panel1.Controls.Add(this.skinButton3);
            this.skinSplitContainer1.Panel1.Controls.Add(this.skinButton2);
            this.skinSplitContainer1.Panel1.Controls.Add(this.skinButton1);
            // 
            // skinSplitContainer1.Panel2
            // 
            this.skinSplitContainer1.Panel2.BackColor = System.Drawing.Color.Aquamarine;
            this.skinSplitContainer1.Panel2.Controls.Add(this.label1);
            this.skinSplitContainer1.Size = new System.Drawing.Size(772, 380);
            this.skinSplitContainer1.SplitterDistance = 143;
            this.skinSplitContainer1.TabIndex = 0;
            // 
            // btn_newBtn
            // 
            this.btn_newBtn.BackColor = System.Drawing.Color.Transparent;
            this.btn_newBtn.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btn_newBtn.DownBack = null;
            this.btn_newBtn.Location = new System.Drawing.Point(3, 182);
            this.btn_newBtn.MouseBack = null;
            this.btn_newBtn.Name = "btn_newBtn";
            this.btn_newBtn.NormlBack = null;
            this.btn_newBtn.Size = new System.Drawing.Size(137, 28);
            this.btn_newBtn.TabIndex = 3;
            this.btn_newBtn.Text = "按键";
            this.btn_newBtn.UseVisualStyleBackColor = false;
            this.btn_newBtn.Click += new System.EventHandler(this.btn_newBtn_Click);
            // 
            // skinButton3
            // 
            this.skinButton3.BackColor = System.Drawing.Color.Transparent;
            this.skinButton3.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinButton3.DownBack = null;
            this.skinButton3.Location = new System.Drawing.Point(3, 134);
            this.skinButton3.MouseBack = null;
            this.skinButton3.Name = "skinButton3";
            this.skinButton3.NormlBack = null;
            this.skinButton3.Size = new System.Drawing.Size(137, 29);
            this.skinButton3.TabIndex = 2;
            this.skinButton3.Text = "布尔显示";
            this.skinButton3.UseVisualStyleBackColor = false;
            this.skinButton3.Click += new System.EventHandler(this.skinButton3_Click);
            // 
            // skinButton2
            // 
            this.skinButton2.BackColor = System.Drawing.Color.Transparent;
            this.skinButton2.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinButton2.DownBack = null;
            this.skinButton2.Location = new System.Drawing.Point(3, 76);
            this.skinButton2.MouseBack = null;
            this.skinButton2.Name = "skinButton2";
            this.skinButton2.NormlBack = null;
            this.skinButton2.Size = new System.Drawing.Size(137, 33);
            this.skinButton2.TabIndex = 1;
            this.skinButton2.Text = "数值显示";
            this.skinButton2.UseVisualStyleBackColor = false;
            this.skinButton2.Click += new System.EventHandler(this.skinButton2_Click);
            // 
            // skinButton1
            // 
            this.skinButton1.BackColor = System.Drawing.Color.Transparent;
            this.skinButton1.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinButton1.DownBack = null;
            this.skinButton1.Location = new System.Drawing.Point(3, 28);
            this.skinButton1.MouseBack = null;
            this.skinButton1.Name = "skinButton1";
            this.skinButton1.NormlBack = null;
            this.skinButton1.Size = new System.Drawing.Size(137, 28);
            this.skinButton1.TabIndex = 0;
            this.skinButton1.Text = "标签";
            this.skinButton1.UseVisualStyleBackColor = false;
            this.skinButton1.Click += new System.EventHandler(this.skinButton1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(136, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "计算结果为：";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // Mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aquamarine;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Mainform";
            this.Text = "";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.skinSplitContainer1.Panel1.ResumeLayout(false);
            this.skinSplitContainer1.Panel2.ResumeLayout(false);
            this.skinSplitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.skinSplitContainer1)).EndInit();
            this.skinSplitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private CCWin.SkinControl.SkinSplitContainer skinSplitContainer1;
        private CCWin.SkinControl.SkinButton skinButton1;
        private CCWin.SkinControl.SkinButton skinButton2;
        private CCWin.SkinControl.SkinButton btn_newBtn;
        private CCWin.SkinControl.SkinButton skinButton3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource bindingSource1;
    }
}

