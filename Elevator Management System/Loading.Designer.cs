namespace Elevator_Management_System
{
    partial class Loading
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
            components = new System.ComponentModel.Container();
            progressBar1 = new ProgressBar();
            loadingBar = new System.Windows.Forms.Timer(components);
            percentage = new Label();
            text = new Label();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // progressBar1
            // 
            progressBar1.BackColor = SystemColors.GradientActiveCaption;
            progressBar1.ForeColor = Color.Ivory;
            progressBar1.Location = new Point(72, 427);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(650, 12);
            progressBar1.TabIndex = 0;
            progressBar1.Click += progressBar1_Click;
            // 
            // loadingBar
            // 
            loadingBar.Tick += loadingBar_Tick;
            // 
            // percentage
            // 
            percentage.AutoSize = true;
            percentage.BackColor = SystemColors.ActiveCaptionText;
            percentage.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            percentage.ForeColor = SystemColors.ButtonFace;
            percentage.Location = new Point(152, 392);
            percentage.Name = "percentage";
            percentage.Size = new Size(35, 23);
            percentage.TabIndex = 1;
            percentage.Text = "0%";
            percentage.Click += percentage_Click;
            // 
            // text
            // 
            text.AutoSize = true;
            text.BackColor = SystemColors.ControlText;
            text.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            text.ForeColor = SystemColors.ButtonHighlight;
            text.Location = new Point(23, 72);
            text.Name = "text";
            text.Size = new Size(299, 31);
            text.TabIndex = 2;
            text.Text = "ELEVATOR MANAGEMENT ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaptionText;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(23, 113);
            label1.Name = "label1";
            label1.Size = new Size(101, 31);
            label1.TabIndex = 3;
            label1.Text = "SYSTEM";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ActiveCaptionText;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(72, 390);
            label2.Name = "label2";
            label2.Size = new Size(80, 25);
            label2.TabIndex = 4;
            label2.Text = "Loading";
            // 
            // Loading
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Door;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(text);
            Controls.Add(percentage);
            Controls.Add(progressBar1);
            Name = "Loading";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Loading";
            Load += Loading_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ProgressBar progressBar1;
        private System.Windows.Forms.Timer loadingBar;
        private Label percentage;
        private Label text;
        private Label label1;
        private Label label2;
    }
}