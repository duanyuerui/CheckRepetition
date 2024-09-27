namespace CR.App
{
    partial class FrmMain
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
            panel1 = new Panel();
            panel3 = new Panel();
            panel5 = new Panel();
            txtLog = new TextBox();
            panel4 = new Panel();
            txtRepetitionContext = new TextBox();
            panel6 = new Panel();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            btnClearLog = new Button();
            btnGenerate = new Button();
            btnCompare = new Button();
            btnUpload = new Button();
            btnChoose = new Button();
            txtFilePath = new TextBox();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel6.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(961, 550);
            panel1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(panel5);
            panel3.Controls.Add(panel4);
            panel3.Controls.Add(panel6);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 71);
            panel3.Name = "panel3";
            panel3.Size = new Size(961, 479);
            panel3.TabIndex = 1;
            // 
            // panel5
            // 
            panel5.Controls.Add(txtLog);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(494, 30);
            panel5.Name = "panel5";
            panel5.Size = new Size(467, 449);
            panel5.TabIndex = 5;
            // 
            // txtLog
            // 
            txtLog.Dock = DockStyle.Fill;
            txtLog.ForeColor = SystemColors.ActiveBorder;
            txtLog.Location = new Point(0, 0);
            txtLog.Multiline = true;
            txtLog.Name = "txtLog";
            txtLog.Size = new Size(467, 449);
            txtLog.TabIndex = 4;
            // 
            // panel4
            // 
            panel4.Controls.Add(txtRepetitionContext);
            panel4.Dock = DockStyle.Left;
            panel4.Location = new Point(0, 30);
            panel4.Name = "panel4";
            panel4.Size = new Size(494, 449);
            panel4.TabIndex = 4;
            // 
            // txtRepetitionContext
            // 
            txtRepetitionContext.Dock = DockStyle.Fill;
            txtRepetitionContext.Location = new Point(0, 0);
            txtRepetitionContext.Multiline = true;
            txtRepetitionContext.Name = "txtRepetitionContext";
            txtRepetitionContext.Size = new Size(494, 449);
            txtRepetitionContext.TabIndex = 3;
            // 
            // panel6
            // 
            panel6.Controls.Add(label2);
            panel6.Controls.Add(label1);
            panel6.Dock = DockStyle.Top;
            panel6.Location = new Point(0, 0);
            panel6.Name = "panel6";
            panel6.Size = new Size(961, 30);
            panel6.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.YellowGreen;
            label2.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 134);
            label2.Location = new Point(697, 4);
            label2.Name = "label2";
            label2.Size = new Size(74, 22);
            label2.TabIndex = 1;
            label2.Text = "行为日志";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.LightCoral;
            label1.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 134);
            label1.Location = new Point(165, 4);
            label1.Name = "label1";
            label1.Size = new Size(74, 22);
            label1.TabIndex = 0;
            label1.Text = "比较结果";
            // 
            // panel2
            // 
            panel2.Controls.Add(btnClearLog);
            panel2.Controls.Add(btnGenerate);
            panel2.Controls.Add(btnCompare);
            panel2.Controls.Add(btnUpload);
            panel2.Controls.Add(btnChoose);
            panel2.Controls.Add(txtFilePath);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(961, 71);
            panel2.TabIndex = 0;
            // 
            // btnClearLog
            // 
            btnClearLog.Location = new Point(874, 36);
            btnClearLog.Name = "btnClearLog";
            btnClearLog.Size = new Size(75, 23);
            btnClearLog.TabIndex = 6;
            btnClearLog.Text = "清空日志";
            btnClearLog.UseVisualStyleBackColor = true;
            // 
            // btnGenerate
            // 
            btnGenerate.Location = new Point(793, 36);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(75, 23);
            btnGenerate.TabIndex = 5;
            btnGenerate.Text = "模板数据";
            btnGenerate.UseVisualStyleBackColor = true;
            // 
            // btnCompare
            // 
            btnCompare.Location = new Point(183, 36);
            btnCompare.Name = "btnCompare";
            btnCompare.Size = new Size(75, 23);
            btnCompare.TabIndex = 4;
            btnCompare.Text = "③ 比较";
            btnCompare.UseVisualStyleBackColor = true;
            // 
            // btnUpload
            // 
            btnUpload.Location = new Point(102, 36);
            btnUpload.Name = "btnUpload";
            btnUpload.Size = new Size(75, 23);
            btnUpload.TabIndex = 3;
            btnUpload.Text = "② 上传";
            btnUpload.UseVisualStyleBackColor = true;
            // 
            // btnChoose
            // 
            btnChoose.Location = new Point(12, 36);
            btnChoose.Name = "btnChoose";
            btnChoose.Size = new Size(84, 23);
            btnChoose.TabIndex = 2;
            btnChoose.Text = "① 选择文件";
            btnChoose.UseVisualStyleBackColor = true;
            // 
            // txtFilePath
            // 
            txtFilePath.Location = new Point(12, 6);
            txtFilePath.Name = "txtFilePath";
            txtFilePath.Size = new Size(937, 23);
            txtFilePath.TabIndex = 1;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(961, 550);
            Controls.Add(panel1);
            Name = "FrmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmMain";
            Load += FrmMain_Load;
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel3;
        private TextBox txtRepetitionContext;
        private Panel panel2;
        private Button btnCompare;
        private Button btnUpload;
        private Button btnChoose;
        private TextBox txtFilePath;
        private Button btnGenerate;
        private Panel panel5;
        private TextBox txtLog;
        private Panel panel4;
        private Panel panel6;
        private Label label2;
        private Label label1;
        private Button btnClearLog;
    }
}