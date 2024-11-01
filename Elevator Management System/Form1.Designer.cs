namespace Lift
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            lblFloor1Status = new Label();
            lblFloor2Status = new Label();
            lblCurrentFloor = new Label();
            pictureBox1 = new PictureBox();
            doorTimer = new System.Windows.Forms.Timer(components);
            doorAnimationTimer = new System.Windows.Forms.Timer(components);
            btnOpenDoor = new Button();
            btnCloseDoor = new Button();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            panel4 = new Panel();
            pictureBox5 = new PictureBox();
            panel5 = new Panel();
            callDown = new Button();
            panel1 = new Panel();
            pictureBox4 = new PictureBox();
            panel7 = new Panel();
            btnRequestFloor1 = new Button();
            btnRequestFloor0 = new Button();
            Emergency = new Button();
            animation = new PictureBox();
            panel2 = new Panel();
            panel3 = new Panel();
            panel6 = new Panel();
            callUp = new Button();
            pictureBox6 = new PictureBox();
            pictureBox7 = new PictureBox();
            pictureBox8 = new PictureBox();
            pictureBox9 = new PictureBox();
            lblCurrentFloor0 = new Label();
            panel8 = new Panel();
            pictureBox10 = new PictureBox();
            dataGridView = new DataGridView();
            leftdoor2 = new PictureBox();
            rightdoor2 = new PictureBox();
            leftdoor1 = new PictureBox();
            rightdoor1 = new PictureBox();
            elevatorTimers = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            panel5.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)animation).BeginInit();
            panel2.SuspendLayout();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)leftdoor2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)rightdoor2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)leftdoor1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)rightdoor1).BeginInit();
            SuspendLayout();
            // 
            // lblFloor1Status
            // 
            lblFloor1Status.AutoSize = true;
            lblFloor1Status.Location = new Point(465, 243);
            lblFloor1Status.Name = "lblFloor1Status";
            lblFloor1Status.Size = new Size(0, 20);
            lblFloor1Status.TabIndex = 4;
            // 
            // lblFloor2Status
            // 
            lblFloor2Status.AutoSize = true;
            lblFloor2Status.Location = new Point(465, 273);
            lblFloor2Status.Name = "lblFloor2Status";
            lblFloor2Status.Size = new Size(0, 20);
            lblFloor2Status.TabIndex = 5;
            // 
            // lblCurrentFloor
            // 
            lblCurrentFloor.AutoSize = true;
            lblCurrentFloor.BackColor = SystemColors.ControlLight;
            lblCurrentFloor.BorderStyle = BorderStyle.Fixed3D;
            lblCurrentFloor.Font = new Font("Calisto MT", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCurrentFloor.Location = new Point(1029, 12);
            lblCurrentFloor.Name = "lblCurrentFloor";
            lblCurrentFloor.Size = new Size(101, 22);
            lblCurrentFloor.TabIndex = 7;
            lblCurrentFloor.Text = ".... Curr ....";
            lblCurrentFloor.Click += lblCurrentFloor_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.HotTrack;
            pictureBox1.BackgroundImage = Elevator_Management_System.Properties.Resources._438648_PEONVH_790__2_;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Location = new Point(982, 353);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(146, 171);
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // doorTimer
            // 
            doorTimer.Tick += doorTimer_Tick;
            // 
            // doorAnimationTimer
            // 
            doorAnimationTimer.Interval = 1000;
            doorAnimationTimer.Tick += doorAnimationTimer_Tick;
            // 
            // btnOpenDoor
            // 
            btnOpenDoor.BackColor = SystemColors.ControlLight;
            btnOpenDoor.BackgroundImage = Elevator_Management_System.Properties.Resources.icons8_elevator_91__4_;
            btnOpenDoor.BackgroundImageLayout = ImageLayout.Stretch;
            btnOpenDoor.Location = new Point(40, 156);
            btnOpenDoor.Name = "btnOpenDoor";
            btnOpenDoor.Size = new Size(40, 41);
            btnOpenDoor.TabIndex = 17;
            btnOpenDoor.UseVisualStyleBackColor = false;
            btnOpenDoor.Click += btnOpenDoor_Click;
            // 
            // btnCloseDoor
            // 
            btnCloseDoor.BackColor = SystemColors.ControlLight;
            btnCloseDoor.BackgroundImage = Elevator_Management_System.Properties.Resources.icons8_close_arrows_91;
            btnCloseDoor.BackgroundImageLayout = ImageLayout.Stretch;
            btnCloseDoor.Location = new Point(80, 156);
            btnCloseDoor.Name = "btnCloseDoor";
            btnCloseDoor.Size = new Size(40, 41);
            btnCloseDoor.TabIndex = 18;
            btnCloseDoor.UseVisualStyleBackColor = false;
            btnCloseDoor.Click += btnCloseDoor_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = Elevator_Management_System.Properties.Resources._438648_PEONVH_790_Photoroom;
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Location = new Point(947, 262);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(420, 355);
            pictureBox2.TabIndex = 19;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImage = Elevator_Management_System.Properties.Resources._438648_PEONVH_790_Photoroom;
            pictureBox3.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox3.Location = new Point(947, -37);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(420, 355);
            pictureBox3.TabIndex = 20;
            pictureBox3.TabStop = false;
            // 
            // panel4
            // 
            panel4.BackgroundImage = Elevator_Management_System.Properties.Resources.G;
            panel4.BackgroundImageLayout = ImageLayout.Stretch;
            panel4.Controls.Add(pictureBox5);
            panel4.Location = new Point(780, 262);
            panel4.Name = "panel4";
            panel4.Size = new Size(193, 354);
            panel4.TabIndex = 22;
            // 
            // pictureBox5
            // 
            pictureBox5.BackgroundImage = Elevator_Management_System.Properties.Resources.Untitled__1_;
            pictureBox5.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox5.BorderStyle = BorderStyle.Fixed3D;
            pictureBox5.Location = new Point(12, 49);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(60, 59);
            pictureBox5.TabIndex = 1;
            pictureBox5.TabStop = false;
            // 
            // panel5
            // 
            panel5.BackgroundImage = Elevator_Management_System.Properties.Resources._438648_PEONVH_790__3__Photoroom__2_;
            panel5.BackgroundImageLayout = ImageLayout.Stretch;
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Controls.Add(callDown);
            panel5.Location = new Point(0, 85);
            panel5.Name = "panel5";
            panel5.Size = new Size(76, 152);
            panel5.TabIndex = 25;
            // 
            // callDown
            // 
            callDown.BackgroundImage = Elevator_Management_System.Properties.Resources.icons8_slide_up_801;
            callDown.BackgroundImageLayout = ImageLayout.Stretch;
            callDown.Location = new Point(20, 73);
            callDown.Name = "callDown";
            callDown.Size = new Size(30, 33);
            callDown.TabIndex = 1;
            callDown.UseVisualStyleBackColor = true;
            callDown.Click += callDown_Click;
            // 
            // panel1
            // 
            panel1.BackgroundImage = Elevator_Management_System.Properties.Resources.G;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(pictureBox4);
            panel1.Location = new Point(780, -37);
            panel1.Name = "panel1";
            panel1.Size = new Size(193, 354);
            panel1.TabIndex = 23;
            // 
            // pictureBox4
            // 
            pictureBox4.BackgroundImage = Elevator_Management_System.Properties.Resources.Untitled__3_;
            pictureBox4.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox4.BorderStyle = BorderStyle.Fixed3D;
            pictureBox4.Location = new Point(12, 49);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(60, 59);
            pictureBox4.TabIndex = 0;
            pictureBox4.TabStop = false;
            // 
            // panel7
            // 
            panel7.BackgroundImage = Elevator_Management_System.Properties.Resources.snapedit_1730108276254__1_;
            panel7.BackgroundImageLayout = ImageLayout.Stretch;
            panel7.BorderStyle = BorderStyle.FixedSingle;
            panel7.Controls.Add(btnRequestFloor1);
            panel7.Controls.Add(btnRequestFloor0);
            panel7.Controls.Add(Emergency);
            panel7.Controls.Add(animation);
            panel7.Controls.Add(btnOpenDoor);
            panel7.Controls.Add(btnCloseDoor);
            panel7.Location = new Point(619, 3);
            panel7.Name = "panel7";
            panel7.Size = new Size(161, 278);
            panel7.TabIndex = 27;
            // 
            // btnRequestFloor1
            // 
            btnRequestFloor1.BackgroundImage = Elevator_Management_System.Properties.Resources.icons8_1_32;
            btnRequestFloor1.BackgroundImageLayout = ImageLayout.Stretch;
            btnRequestFloor1.Location = new Point(80, 107);
            btnRequestFloor1.Name = "btnRequestFloor1";
            btnRequestFloor1.Size = new Size(40, 41);
            btnRequestFloor1.TabIndex = 24;
            btnRequestFloor1.UseVisualStyleBackColor = true;
            btnRequestFloor1.Click += btnRequestFloor1_Click_1;
            // 
            // btnRequestFloor0
            // 
            btnRequestFloor0.BackColor = SystemColors.ControlLight;
            btnRequestFloor0.BackgroundImage = Elevator_Management_System.Properties.Resources.icons8_1_32__3_;
            btnRequestFloor0.BackgroundImageLayout = ImageLayout.Stretch;
            btnRequestFloor0.Location = new Point(40, 107);
            btnRequestFloor0.Name = "btnRequestFloor0";
            btnRequestFloor0.Size = new Size(40, 41);
            btnRequestFloor0.TabIndex = 23;
            btnRequestFloor0.UseVisualStyleBackColor = false;
            btnRequestFloor0.Click += btnRequestFloor0_Click;
            // 
            // Emergency
            // 
            Emergency.BackgroundImage = Elevator_Management_System.Properties.Resources.alarm;
            Emergency.BackgroundImageLayout = ImageLayout.Stretch;
            Emergency.Location = new Point(60, 203);
            Emergency.Name = "Emergency";
            Emergency.Size = new Size(40, 38);
            Emergency.TabIndex = 20;
            Emergency.UseVisualStyleBackColor = true;
            Emergency.Click += Emergency_Click;
            // 
            // animation
            // 
            animation.BackColor = SystemColors.ActiveCaptionText;
            animation.BackgroundImageLayout = ImageLayout.Stretch;
            animation.BorderStyle = BorderStyle.Fixed3D;
            animation.Location = new Point(58, 40);
            animation.Name = "animation";
            animation.Size = new Size(46, 54);
            animation.TabIndex = 19;
            animation.TabStop = false;
            animation.Click += animation_Click;
            // 
            // panel2
            // 
            panel2.BackgroundImage = Elevator_Management_System.Properties.Resources.G;
            panel2.BackgroundImageLayout = ImageLayout.Stretch;
            panel2.Controls.Add(panel5);
            panel2.Location = new Point(1137, 262);
            panel2.Name = "panel2";
            panel2.Size = new Size(193, 354);
            panel2.TabIndex = 23;
            // 
            // panel3
            // 
            panel3.BackgroundImage = Elevator_Management_System.Properties.Resources.G;
            panel3.BackgroundImageLayout = ImageLayout.Stretch;
            panel3.Location = new Point(1137, -36);
            panel3.Name = "panel3";
            panel3.Size = new Size(193, 354);
            panel3.TabIndex = 24;
            // 
            // panel6
            // 
            panel6.BackgroundImage = Elevator_Management_System.Properties.Resources._438648_PEONVH_790__3__Photoroom__2_;
            panel6.BackgroundImageLayout = ImageLayout.Stretch;
            panel6.BorderStyle = BorderStyle.FixedSingle;
            panel6.Controls.Add(callUp);
            panel6.Location = new Point(1136, 49);
            panel6.Name = "panel6";
            panel6.Size = new Size(76, 152);
            panel6.TabIndex = 26;
            // 
            // callUp
            // 
            callUp.BackgroundImage = Elevator_Management_System.Properties.Resources.icons8_slide_up_80;
            callUp.BackgroundImageLayout = ImageLayout.Stretch;
            callUp.Location = new Point(21, 67);
            callUp.Name = "callUp";
            callUp.Size = new Size(30, 33);
            callUp.TabIndex = 0;
            callUp.UseVisualStyleBackColor = true;
            callUp.Click += callUp_Click;
            // 
            // pictureBox6
            // 
            pictureBox6.BackgroundImage = Elevator_Management_System.Properties.Resources._438648_PEONVH_790__3__Photoroom__1_;
            pictureBox6.Location = new Point(973, 335);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(10, 192);
            pictureBox6.TabIndex = 19;
            pictureBox6.TabStop = false;
            // 
            // pictureBox7
            // 
            pictureBox7.BackgroundImage = Elevator_Management_System.Properties.Resources._438648_PEONVH_790__3__Photoroom__1_;
            pictureBox7.Location = new Point(1128, 335);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(10, 192);
            pictureBox7.TabIndex = 29;
            pictureBox7.TabStop = false;
            // 
            // pictureBox8
            // 
            pictureBox8.BackgroundImage = Elevator_Management_System.Properties.Resources._438648_PEONVH_790__3__Photoroom__1_;
            pictureBox8.Location = new Point(973, 36);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(10, 194);
            pictureBox8.TabIndex = 30;
            pictureBox8.TabStop = false;
            // 
            // pictureBox9
            // 
            pictureBox9.BackgroundImage = Elevator_Management_System.Properties.Resources._438648_PEONVH_790__3__Photoroom__1_;
            pictureBox9.Location = new Point(1128, 36);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(10, 194);
            pictureBox9.TabIndex = 31;
            pictureBox9.TabStop = false;
            // 
            // lblCurrentFloor0
            // 
            lblCurrentFloor0.AutoSize = true;
            lblCurrentFloor0.BackColor = SystemColors.ControlLight;
            lblCurrentFloor0.BorderStyle = BorderStyle.Fixed3D;
            lblCurrentFloor0.Font = new Font("Calisto MT", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCurrentFloor0.Location = new Point(1029, 311);
            lblCurrentFloor0.Name = "lblCurrentFloor0";
            lblCurrentFloor0.Size = new Size(101, 22);
            lblCurrentFloor0.TabIndex = 32;
            lblCurrentFloor0.Text = ".... Curr ....";
            lblCurrentFloor0.Click += lblCurrentFloor0_Click;
            // 
            // panel8
            // 
            panel8.BackColor = SystemColors.AppWorkspace;
            panel8.Location = new Point(619, 273);
            panel8.Name = "panel8";
            panel8.Size = new Size(161, 20);
            panel8.TabIndex = 28;
            // 
            // pictureBox10
            // 
            pictureBox10.BackgroundImage = Elevator_Management_System.Properties.Resources.snapedit_1730108276254__1_1;
            pictureBox10.Location = new Point(619, 300);
            pictureBox10.Name = "pictureBox10";
            pictureBox10.Size = new Size(161, 317);
            pictureBox10.TabIndex = 33;
            pictureBox10.TabStop = false;
            // 
            // dataGridView
            // 
            dataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView.BackgroundColor = SystemColors.ControlLight;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.GridColor = Color.FromArgb(0, 64, 64);
            dataGridView.Location = new Point(5, -1);
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersWidth = 51;
            dataGridView.ScrollBars = ScrollBars.Vertical;
            dataGridView.Size = new Size(534, 589);
            dataGridView.TabIndex = 34;
            dataGridView.CellContentClick += dataGridView_CellContentClick;
            // 
            // leftdoor2
            // 
            leftdoor2.BackgroundImage = Elevator_Management_System.Properties.Resources._438648_PEONVH_790__1_;
            leftdoor2.BackgroundImageLayout = ImageLayout.Stretch;
            leftdoor2.Location = new Point(982, 58);
            leftdoor2.Name = "leftdoor2";
            leftdoor2.Size = new Size(77, 172);
            leftdoor2.TabIndex = 35;
            leftdoor2.TabStop = false;
            leftdoor2.Click += leftdoor2_Click;
            // 
            // rightdoor2
            // 
            rightdoor2.BackgroundImage = Elevator_Management_System.Properties.Resources.H;
            rightdoor2.BackgroundImageLayout = ImageLayout.Stretch;
            rightdoor2.Location = new Point(1058, 58);
            rightdoor2.Name = "rightdoor2";
            rightdoor2.Size = new Size(71, 172);
            rightdoor2.TabIndex = 36;
            rightdoor2.TabStop = false;
            rightdoor2.Click += rightdoor2_Click;
            // 
            // leftdoor1
            // 
            leftdoor1.BackgroundImage = Elevator_Management_System.Properties.Resources._438648_PEONVH_790__1_;
            leftdoor1.BackgroundImageLayout = ImageLayout.Stretch;
            leftdoor1.Location = new Point(982, 353);
            leftdoor1.Name = "leftdoor1";
            leftdoor1.Size = new Size(77, 172);
            leftdoor1.TabIndex = 37;
            leftdoor1.TabStop = false;
            leftdoor1.Click += leftdoor1_Click;
            // 
            // rightdoor1
            // 
            rightdoor1.BackgroundImage = Elevator_Management_System.Properties.Resources.H;
            rightdoor1.BackgroundImageLayout = ImageLayout.Stretch;
            rightdoor1.Location = new Point(1056, 353);
            rightdoor1.Name = "rightdoor1";
            rightdoor1.Size = new Size(73, 172);
            rightdoor1.TabIndex = 38;
            rightdoor1.TabStop = false;
            rightdoor1.Click += rightdoor1_Click;
            // 
            // elevatorTimers
            // 
            elevatorTimers.Tick += elevatorTimers_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(1292, 592);
            Controls.Add(panel8);
            Controls.Add(panel7);
            Controls.Add(panel4);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Controls.Add(panel6);
            Controls.Add(panel3);
            Controls.Add(rightdoor1);
            Controls.Add(leftdoor1);
            Controls.Add(rightdoor2);
            Controls.Add(leftdoor2);
            Controls.Add(dataGridView);
            Controls.Add(pictureBox10);
            Controls.Add(lblCurrentFloor0);
            Controls.Add(pictureBox9);
            Controls.Add(pictureBox8);
            Controls.Add(pictureBox7);
            Controls.Add(pictureBox6);
            Controls.Add(pictureBox1);
            Controls.Add(lblCurrentFloor);
            Controls.Add(lblFloor2Status);
            Controls.Add(lblFloor1Status);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox3);
            KeyPreview = true;
            Name = "Form1";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            TopMost = true;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            panel5.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)animation).EndInit();
            panel2.ResumeLayout(false);
            panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)leftdoor2).EndInit();
            ((System.ComponentModel.ISupportInitialize)rightdoor2).EndInit();
            ((System.ComponentModel.ISupportInitialize)leftdoor1).EndInit();
            ((System.ComponentModel.ISupportInitialize)rightdoor1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button callUp;
        private Label lblFloor1Status;
        private Label lblFloor2Status;
        private Label lblCurrentFloor;
        private PictureBox pictureBox1;
        private PictureBox leftDoor;
        private PictureBox rightDoor;

        private System.Windows.Forms.Timer doorTimer;
        private PictureBox leftDoor1;
        private PictureBox rightDoor1;
        private Button btnOpenDoor;
        private Button btnCloseDoor;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Panel panel4;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private PictureBox pictureBox5;
        private PictureBox pictureBox4;
        private Panel panel5;
        private Panel panel6;
        private Panel panel7;
        private PictureBox pictureBox6;
        private PictureBox pictureBox7;
        private PictureBox pictureBox8;
        private PictureBox pictureBox9;
        private PictureBox animation;
        private Label lblCurrentFloor0;
        private Panel panel8;
        private PictureBox pictureBox10;
        private Button Emergency;
        private DataGridView dataGridView;
        private Button btnRequestFloor0;
        private PictureBox leftdoor2;
        private PictureBox rightdoor2;
        private PictureBox leftdoor1;
        private PictureBox rightdoor1;
        private System.Windows.Forms.Timer elevatorTimers;
        private Button btnRequestFloor1;
        private Button callDown;
        private System.Windows.Forms.Timer autoCloseTimer;
        // Ensure you handle null cases later.

    }
}
