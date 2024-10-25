namespace Test_Comm_Brachy
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.buttonConnect = new System.Windows.Forms.Button();
            this.buttonSend = new System.Windows.Forms.Button();
            this.buttonHomingGripper = new System.Windows.Forms.Button();
            this.textBoxTargetSpeed = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonOpenFunnel = new System.Windows.Forms.Button();
            this.buttonCloseFunnel = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxTargetPos = new System.Windows.Forms.TextBox();
            this.buttonCloseGripper = new System.Windows.Forms.Button();
            this.buttonOpenGripper = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonNextNeedle = new System.Windows.Forms.Button();
            this.buttonStop = new System.Windows.Forms.Button();
            this.buttonBackstep = new System.Windows.Forms.Button();
            this.buttonRunCycle = new System.Windows.Forms.Button();
            this.buttonOpenAll = new System.Windows.Forms.Button();
            this.labelFeedback = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonHomingRepo = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.baudRateList = new System.Windows.Forms.ComboBox();
            this.comPortList = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.labelErrors = new System.Windows.Forms.Label();
            this.labelDebug = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonConnect
            // 
            this.buttonConnect.BackColor = System.Drawing.Color.Azure;
            this.buttonConnect.FlatAppearance.BorderSize = 0;
            this.buttonConnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConnect.Location = new System.Drawing.Point(34, 197);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(146, 30);
            this.buttonConnect.TabIndex = 0;
            this.buttonConnect.Text = "Connect";
            this.buttonConnect.UseVisualStyleBackColor = false;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // buttonSend
            // 
            this.buttonSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSend.Location = new System.Drawing.Point(257, 58);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(113, 33);
            this.buttonSend.TabIndex = 1;
            this.buttonSend.Text = "MOVE POSITION";
            this.buttonSend.UseVisualStyleBackColor = true;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // buttonHomingGripper
            // 
            this.buttonHomingGripper.BackColor = System.Drawing.Color.LightGray;
            this.buttonHomingGripper.FlatAppearance.BorderSize = 0;
            this.buttonHomingGripper.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHomingGripper.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHomingGripper.Location = new System.Drawing.Point(34, 454);
            this.buttonHomingGripper.Name = "buttonHomingGripper";
            this.buttonHomingGripper.Size = new System.Drawing.Size(146, 47);
            this.buttonHomingGripper.TabIndex = 2;
            this.buttonHomingGripper.Text = "HOME INSERTION AXIS";
            this.buttonHomingGripper.UseVisualStyleBackColor = false;
            this.buttonHomingGripper.Click += new System.EventHandler(this.buttonHoming_Click);
            // 
            // textBoxTargetSpeed
            // 
            this.textBoxTargetSpeed.Location = new System.Drawing.Point(150, 49);
            this.textBoxTargetSpeed.MaxLength = 100;
            this.textBoxTargetSpeed.Name = "textBoxTargetSpeed";
            this.textBoxTargetSpeed.Size = new System.Drawing.Size(47, 20);
            this.textBoxTargetSpeed.TabIndex = 3;
            this.textBoxTargetSpeed.Text = "80";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "INSERTION SPEED";
            // 
            // buttonOpenFunnel
            // 
            this.buttonOpenFunnel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOpenFunnel.Location = new System.Drawing.Point(761, 381);
            this.buttonOpenFunnel.Name = "buttonOpenFunnel";
            this.buttonOpenFunnel.Size = new System.Drawing.Size(113, 33);
            this.buttonOpenFunnel.TabIndex = 5;
            this.buttonOpenFunnel.Text = "OPEN FUNNEL";
            this.buttonOpenFunnel.UseVisualStyleBackColor = true;
            this.buttonOpenFunnel.Click += new System.EventHandler(this.buttonOpenFunnel_Click);
            // 
            // buttonCloseFunnel
            // 
            this.buttonCloseFunnel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCloseFunnel.Location = new System.Drawing.Point(761, 420);
            this.buttonCloseFunnel.Name = "buttonCloseFunnel";
            this.buttonCloseFunnel.Size = new System.Drawing.Size(113, 33);
            this.buttonCloseFunnel.TabIndex = 6;
            this.buttonCloseFunnel.Text = "CLOSE FUNNEL";
            this.buttonCloseFunnel.UseVisualStyleBackColor = true;
            this.buttonCloseFunnel.Click += new System.EventHandler(this.buttonCloseFunnel_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "INSERTION DEPTH";
            // 
            // textBoxTargetPos
            // 
            this.textBoxTargetPos.Location = new System.Drawing.Point(150, 75);
            this.textBoxTargetPos.MaxLength = 100;
            this.textBoxTargetPos.Name = "textBoxTargetPos";
            this.textBoxTargetPos.Size = new System.Drawing.Size(47, 20);
            this.textBoxTargetPos.TabIndex = 8;
            this.textBoxTargetPos.Text = "8000";
            // 
            // buttonCloseGripper
            // 
            this.buttonCloseGripper.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCloseGripper.Location = new System.Drawing.Point(933, 420);
            this.buttonCloseGripper.Name = "buttonCloseGripper";
            this.buttonCloseGripper.Size = new System.Drawing.Size(113, 33);
            this.buttonCloseGripper.TabIndex = 11;
            this.buttonCloseGripper.Text = "CLOSE GRIPPER";
            this.buttonCloseGripper.UseVisualStyleBackColor = true;
            this.buttonCloseGripper.Click += new System.EventHandler(this.buttonCloseGripper_Click);
            // 
            // buttonOpenGripper
            // 
            this.buttonOpenGripper.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOpenGripper.Location = new System.Drawing.Point(933, 381);
            this.buttonOpenGripper.Name = "buttonOpenGripper";
            this.buttonOpenGripper.Size = new System.Drawing.Size(113, 33);
            this.buttonOpenGripper.TabIndex = 10;
            this.buttonOpenGripper.Text = "OPEN GRIPPER";
            this.buttonOpenGripper.UseVisualStyleBackColor = true;
            this.buttonOpenGripper.Click += new System.EventHandler(this.buttonOpenGripper_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(203, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "%";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(203, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "mm";
            // 
            // buttonNextNeedle
            // 
            this.buttonNextNeedle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNextNeedle.Location = new System.Drawing.Point(492, 566);
            this.buttonNextNeedle.Name = "buttonNextNeedle";
            this.buttonNextNeedle.Size = new System.Drawing.Size(156, 43);
            this.buttonNextNeedle.TabIndex = 14;
            this.buttonNextNeedle.Text = "NEXT NEEDLE";
            this.buttonNextNeedle.UseVisualStyleBackColor = true;
            this.buttonNextNeedle.Click += new System.EventHandler(this.buttonNextNeedle_Click);
            // 
            // buttonStop
            // 
            this.buttonStop.BackColor = System.Drawing.Color.Red;
            this.buttonStop.FlatAppearance.BorderSize = 0;
            this.buttonStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStop.Location = new System.Drawing.Point(34, 278);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(146, 35);
            this.buttonStop.TabIndex = 15;
            this.buttonStop.Text = "STOP";
            this.buttonStop.UseVisualStyleBackColor = false;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // buttonBackstep
            // 
            this.buttonBackstep.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBackstep.Location = new System.Drawing.Point(255, 566);
            this.buttonBackstep.Name = "buttonBackstep";
            this.buttonBackstep.Size = new System.Drawing.Size(157, 43);
            this.buttonBackstep.TabIndex = 16;
            this.buttonBackstep.Text = "BACKSTEP MAGAZINE";
            this.buttonBackstep.UseVisualStyleBackColor = true;
            this.buttonBackstep.Click += new System.EventHandler(this.buttonBackstep_Click);
            // 
            // buttonRunCycle
            // 
            this.buttonRunCycle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRunCycle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRunCycle.Location = new System.Drawing.Point(799, 557);
            this.buttonRunCycle.Name = "buttonRunCycle";
            this.buttonRunCycle.Size = new System.Drawing.Size(223, 52);
            this.buttonRunCycle.TabIndex = 17;
            this.buttonRunCycle.Text = "RUN PROCEDURE CYCLE";
            this.buttonRunCycle.UseVisualStyleBackColor = true;
            this.buttonRunCycle.Click += new System.EventHandler(this.buttonRunCycle_Click);
            // 
            // buttonOpenAll
            // 
            this.buttonOpenAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOpenAll.Location = new System.Drawing.Point(847, 488);
            this.buttonOpenAll.Name = "buttonOpenAll";
            this.buttonOpenAll.Size = new System.Drawing.Size(113, 33);
            this.buttonOpenAll.TabIndex = 18;
            this.buttonOpenAll.Text = "OPEN ALL";
            this.buttonOpenAll.UseVisualStyleBackColor = true;
            this.buttonOpenAll.Click += new System.EventHandler(this.buttonOpenAll_Click);
            // 
            // labelFeedback
            // 
            this.labelFeedback.AutoSize = true;
            this.labelFeedback.Location = new System.Drawing.Point(80, 562);
            this.labelFeedback.Name = "labelFeedback";
            this.labelFeedback.Size = new System.Drawing.Size(55, 13);
            this.labelFeedback.TabIndex = 19;
            this.labelFeedback.Text = "Feedback";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.Transparent;
            this.buttonExit.FlatAppearance.BorderSize = 0;
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonExit.Location = new System.Drawing.Point(1078, 8);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(43, 38);
            this.buttonExit.TabIndex = 20;
            this.buttonExit.Text = "X";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            this.buttonExit.MouseEnter += new System.EventHandler(this.buttonExit_MouseEnter);
            this.buttonExit.MouseLeave += new System.EventHandler(this.buttonExit_MouseLeave);
            // 
            // buttonHomingRepo
            // 
            this.buttonHomingRepo.BackColor = System.Drawing.Color.LightGray;
            this.buttonHomingRepo.FlatAppearance.BorderSize = 0;
            this.buttonHomingRepo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHomingRepo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHomingRepo.Location = new System.Drawing.Point(34, 398);
            this.buttonHomingRepo.Name = "buttonHomingRepo";
            this.buttonHomingRepo.Size = new System.Drawing.Size(146, 47);
            this.buttonHomingRepo.TabIndex = 22;
            this.buttonHomingRepo.Text = "HOME NEEDLE REPOSITORY";
            this.buttonHomingRepo.UseVisualStyleBackColor = false;
            this.buttonHomingRepo.Click += new System.EventHandler(this.buttonHomingRepo_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.labelDebug);
            this.panel1.Controls.Add(this.baudRateList);
            this.panel1.Controls.Add(this.comPortList);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.buttonConnect);
            this.panel1.Controls.Add(this.buttonHomingGripper);
            this.panel1.Controls.Add(this.labelFeedback);
            this.panel1.Controls.Add(this.buttonHomingRepo);
            this.panel1.Controls.Add(this.buttonStop);
            this.panel1.Location = new System.Drawing.Point(-13, 34);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(203, 633);
            this.panel1.TabIndex = 23;
            // 
            // baudRateList
            // 
            this.baudRateList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.baudRateList.FormattingEnabled = true;
            this.baudRateList.Items.AddRange(new object[] {
            "9600",
            "14400",
            "19200",
            "38400",
            "57600",
            "115200"});
            this.baudRateList.Location = new System.Drawing.Point(107, 164);
            this.baudRateList.Name = "baudRateList";
            this.baudRateList.Size = new System.Drawing.Size(73, 21);
            this.baudRateList.TabIndex = 27;
            // 
            // comPortList
            // 
            this.comPortList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comPortList.FormattingEnabled = true;
            this.comPortList.Location = new System.Drawing.Point(34, 164);
            this.comPortList.Name = "comPortList";
            this.comPortList.Size = new System.Drawing.Size(67, 21);
            this.comPortList.TabIndex = 26;
            this.comPortList.MouseDown += new System.Windows.Forms.MouseEventHandler(this.comPortList_MouseDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(57, 543);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "DEVICE FEEDBACK";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Test_Comm_Brachy.Properties.Resources.output_onlinepngtools_1_;
            this.pictureBox1.Location = new System.Drawing.Point(16, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(181, 123);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBoxTargetSpeed);
            this.groupBox1.Controls.Add(this.textBoxTargetPos);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.buttonSend);
            this.groupBox1.Location = new System.Drawing.Point(255, 370);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(400, 131);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "INSERTION PARAMETERS";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gray;
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Controls.Add(this.buttonExit);
            this.panel2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Location = new System.Drawing.Point(-10, -10);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1138, 46);
            this.panel2.TabIndex = 26;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Test_Comm_Brachy.Properties.Resources.output_onlinepngtools_1_;
            this.pictureBox3.Location = new System.Drawing.Point(22, 13);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(27, 30);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 25;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Test_Comm_Brachy.Properties.Resources.output_onlinepngtools;
            this.pictureBox2.Location = new System.Drawing.Point(255, 42);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(767, 305);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 25;
            this.pictureBox2.TabStop = false;
            // 
            // labelErrors
            // 
            this.labelErrors.AutoSize = true;
            this.labelErrors.ForeColor = System.Drawing.Color.Red;
            this.labelErrors.Location = new System.Drawing.Point(252, 508);
            this.labelErrors.Name = "labelErrors";
            this.labelErrors.Size = new System.Drawing.Size(56, 13);
            this.labelErrors.TabIndex = 27;
            this.labelErrors.Text = "labelErrors";
            this.labelErrors.Visible = false;
            // 
            // labelDebug
            // 
            this.labelDebug.AutoSize = true;
            this.labelDebug.Location = new System.Drawing.Point(80, 523);
            this.labelDebug.Name = "labelDebug";
            this.labelDebug.Size = new System.Drawing.Size(45, 13);
            this.labelDebug.TabIndex = 28;
            this.labelDebug.Text = "DEBUG";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1111, 632);
            this.Controls.Add(this.labelErrors);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonOpenAll);
            this.Controls.Add(this.buttonRunCycle);
            this.Controls.Add(this.buttonBackstep);
            this.Controls.Add(this.buttonNextNeedle);
            this.Controls.Add(this.buttonCloseGripper);
            this.Controls.Add(this.buttonOpenGripper);
            this.Controls.Add(this.buttonCloseFunnel);
            this.Controls.Add(this.buttonOpenFunnel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Brachytherapy Instrument Control Panel";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.Button buttonHomingGripper;
        private System.Windows.Forms.TextBox textBoxTargetSpeed;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonOpenFunnel;
        private System.Windows.Forms.Button buttonCloseFunnel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxTargetPos;
        private System.Windows.Forms.Button buttonCloseGripper;
        private System.Windows.Forms.Button buttonOpenGripper;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonNextNeedle;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.Button buttonBackstep;
        private System.Windows.Forms.Button buttonRunCycle;
        private System.Windows.Forms.Button buttonOpenAll;
        private System.Windows.Forms.Label labelFeedback;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonHomingRepo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox comPortList;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Label labelErrors;
        private System.Windows.Forms.ComboBox baudRateList;
        private System.Windows.Forms.Label labelDebug;
    }
}

