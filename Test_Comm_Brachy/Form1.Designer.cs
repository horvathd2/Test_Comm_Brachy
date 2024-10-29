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
            this.panel5 = new System.Windows.Forms.Panel();
            this.comPortList = new System.Windows.Forms.ComboBox();
            this.baudRateList = new System.Windows.Forms.ComboBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.labelDebug = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.labelErrors = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonConnect
            // 
            this.buttonConnect.BackColor = System.Drawing.Color.Transparent;
            this.buttonConnect.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonConnect.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.buttonConnect.FlatAppearance.BorderSize = 0;
            this.buttonConnect.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.buttonConnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonConnect.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConnect.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonConnect.Location = new System.Drawing.Point(0, 95);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(200, 40);
            this.buttonConnect.TabIndex = 0;
            this.buttonConnect.Text = "CONNECT";
            this.buttonConnect.UseVisualStyleBackColor = false;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // buttonSend
            // 
            this.buttonSend.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.buttonSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSend.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSend.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonSend.Location = new System.Drawing.Point(257, 58);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(125, 33);
            this.buttonSend.TabIndex = 1;
            this.buttonSend.Text = "MOVE POSITION";
            this.buttonSend.UseVisualStyleBackColor = true;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // buttonHomingGripper
            // 
            this.buttonHomingGripper.BackColor = System.Drawing.Color.Transparent;
            this.buttonHomingGripper.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonHomingGripper.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.buttonHomingGripper.FlatAppearance.BorderSize = 0;
            this.buttonHomingGripper.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.buttonHomingGripper.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHomingGripper.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHomingGripper.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonHomingGripper.Location = new System.Drawing.Point(0, 135);
            this.buttonHomingGripper.Name = "buttonHomingGripper";
            this.buttonHomingGripper.Size = new System.Drawing.Size(200, 50);
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
            this.textBoxTargetSpeed.Size = new System.Drawing.Size(47, 22);
            this.textBoxTargetSpeed.TabIndex = 3;
            this.textBoxTargetSpeed.Text = "80";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(27, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "INSERTION SPEED";
            // 
            // buttonOpenFunnel
            // 
            this.buttonOpenFunnel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.buttonOpenFunnel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOpenFunnel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOpenFunnel.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonOpenFunnel.Location = new System.Drawing.Point(566, 323);
            this.buttonOpenFunnel.Name = "buttonOpenFunnel";
            this.buttonOpenFunnel.Size = new System.Drawing.Size(113, 33);
            this.buttonOpenFunnel.TabIndex = 5;
            this.buttonOpenFunnel.Text = "OPEN FUNNEL";
            this.buttonOpenFunnel.UseVisualStyleBackColor = true;
            this.buttonOpenFunnel.Click += new System.EventHandler(this.buttonOpenFunnel_Click);
            // 
            // buttonCloseFunnel
            // 
            this.buttonCloseFunnel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.buttonCloseFunnel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCloseFunnel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCloseFunnel.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonCloseFunnel.Location = new System.Drawing.Point(566, 362);
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
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(27, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "INSERTION DEPTH";
            // 
            // textBoxTargetPos
            // 
            this.textBoxTargetPos.Location = new System.Drawing.Point(150, 75);
            this.textBoxTargetPos.MaxLength = 100;
            this.textBoxTargetPos.Name = "textBoxTargetPos";
            this.textBoxTargetPos.Size = new System.Drawing.Size(47, 22);
            this.textBoxTargetPos.TabIndex = 8;
            this.textBoxTargetPos.Text = "8000";
            // 
            // buttonCloseGripper
            // 
            this.buttonCloseGripper.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.buttonCloseGripper.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCloseGripper.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCloseGripper.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonCloseGripper.Location = new System.Drawing.Point(738, 362);
            this.buttonCloseGripper.Name = "buttonCloseGripper";
            this.buttonCloseGripper.Size = new System.Drawing.Size(113, 33);
            this.buttonCloseGripper.TabIndex = 11;
            this.buttonCloseGripper.Text = "CLOSE GRIPPER";
            this.buttonCloseGripper.UseVisualStyleBackColor = true;
            this.buttonCloseGripper.Click += new System.EventHandler(this.buttonCloseGripper_Click);
            // 
            // buttonOpenGripper
            // 
            this.buttonOpenGripper.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.buttonOpenGripper.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOpenGripper.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOpenGripper.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonOpenGripper.Location = new System.Drawing.Point(738, 323);
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
            this.label3.ForeColor = System.Drawing.Color.Gainsboro;
            this.label3.Location = new System.Drawing.Point(203, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "%";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Gainsboro;
            this.label4.Location = new System.Drawing.Point(203, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "mm";
            // 
            // buttonNextNeedle
            // 
            this.buttonNextNeedle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.buttonNextNeedle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNextNeedle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNextNeedle.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonNextNeedle.Location = new System.Drawing.Point(297, 508);
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
            this.buttonStop.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonStop.FlatAppearance.BorderSize = 0;
            this.buttonStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStop.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStop.Location = new System.Drawing.Point(0, 449);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(200, 50);
            this.buttonStop.TabIndex = 15;
            this.buttonStop.Text = "STOP";
            this.buttonStop.UseVisualStyleBackColor = false;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // buttonBackstep
            // 
            this.buttonBackstep.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.buttonBackstep.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBackstep.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBackstep.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonBackstep.Location = new System.Drawing.Point(60, 508);
            this.buttonBackstep.Name = "buttonBackstep";
            this.buttonBackstep.Size = new System.Drawing.Size(157, 43);
            this.buttonBackstep.TabIndex = 16;
            this.buttonBackstep.Text = "BACKSTEP MAGAZINE";
            this.buttonBackstep.UseVisualStyleBackColor = true;
            this.buttonBackstep.Click += new System.EventHandler(this.buttonBackstep_Click);
            // 
            // buttonRunCycle
            // 
            this.buttonRunCycle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.buttonRunCycle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRunCycle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRunCycle.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonRunCycle.Location = new System.Drawing.Point(604, 499);
            this.buttonRunCycle.Name = "buttonRunCycle";
            this.buttonRunCycle.Size = new System.Drawing.Size(223, 52);
            this.buttonRunCycle.TabIndex = 17;
            this.buttonRunCycle.Text = "RUN PROCEDURE CYCLE";
            this.buttonRunCycle.UseVisualStyleBackColor = true;
            this.buttonRunCycle.Click += new System.EventHandler(this.buttonRunCycle_Click);
            // 
            // buttonOpenAll
            // 
            this.buttonOpenAll.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.buttonOpenAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOpenAll.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOpenAll.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonOpenAll.Location = new System.Drawing.Point(652, 430);
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
            this.labelFeedback.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelFeedback.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFeedback.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelFeedback.Location = new System.Drawing.Point(0, 20);
            this.labelFeedback.Name = "labelFeedback";
            this.labelFeedback.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.labelFeedback.Size = new System.Drawing.Size(106, 13);
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
            this.buttonExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonExit.FlatAppearance.BorderSize = 0;
            this.buttonExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonExit.Location = new System.Drawing.Point(1064, 0);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(43, 28);
            this.buttonExit.TabIndex = 20;
            this.buttonExit.Text = "X";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            this.buttonExit.MouseEnter += new System.EventHandler(this.buttonExit_MouseEnter);
            this.buttonExit.MouseLeave += new System.EventHandler(this.buttonExit_MouseLeave);
            // 
            // buttonHomingRepo
            // 
            this.buttonHomingRepo.BackColor = System.Drawing.Color.Transparent;
            this.buttonHomingRepo.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonHomingRepo.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.buttonHomingRepo.FlatAppearance.BorderSize = 0;
            this.buttonHomingRepo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.buttonHomingRepo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHomingRepo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHomingRepo.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonHomingRepo.Location = new System.Drawing.Point(0, 185);
            this.buttonHomingRepo.Name = "buttonHomingRepo";
            this.buttonHomingRepo.Size = new System.Drawing.Size(200, 50);
            this.buttonHomingRepo.TabIndex = 22;
            this.buttonHomingRepo.Text = "HOME NEEDLE REPOSITORY";
            this.buttonHomingRepo.UseVisualStyleBackColor = false;
            this.buttonHomingRepo.Click += new System.EventHandler(this.buttonHomingRepo_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.buttonHomingRepo);
            this.panel1.Controls.Add(this.buttonHomingGripper);
            this.panel1.Controls.Add(this.buttonConnect);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.buttonStop);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(1, 31);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(0, 70, 0, 20);
            this.panel1.Size = new System.Drawing.Size(202, 600);
            this.panel1.TabIndex = 23;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Transparent;
            this.panel5.Controls.Add(this.comPortList);
            this.panel5.Controls.Add(this.baudRateList);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 70);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(200, 25);
            this.panel5.TabIndex = 29;
            // 
            // comPortList
            // 
            this.comPortList.Dock = System.Windows.Forms.DockStyle.Left;
            this.comPortList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comPortList.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comPortList.FormattingEnabled = true;
            this.comPortList.Location = new System.Drawing.Point(0, 0);
            this.comPortList.Name = "comPortList";
            this.comPortList.Size = new System.Drawing.Size(81, 25);
            this.comPortList.TabIndex = 26;
            this.comPortList.MouseDown += new System.Windows.Forms.MouseEventHandler(this.comPortList_MouseDown);
            // 
            // baudRateList
            // 
            this.baudRateList.Dock = System.Windows.Forms.DockStyle.Right;
            this.baudRateList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.baudRateList.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.baudRateList.FormattingEnabled = true;
            this.baudRateList.Items.AddRange(new object[] {
            "9600",
            "14400",
            "19200",
            "38400",
            "57600",
            "115200"});
            this.baudRateList.Location = new System.Drawing.Point(86, 0);
            this.baudRateList.Name = "baudRateList";
            this.baudRateList.Size = new System.Drawing.Size(114, 25);
            this.baudRateList.TabIndex = 27;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.Controls.Add(this.labelDebug);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.labelFeedback);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 499);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.panel4.Size = new System.Drawing.Size(200, 79);
            this.panel4.TabIndex = 28;
            // 
            // labelDebug
            // 
            this.labelDebug.AutoSize = true;
            this.labelDebug.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelDebug.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDebug.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelDebug.Location = new System.Drawing.Point(0, 46);
            this.labelDebug.Name = "labelDebug";
            this.labelDebug.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.labelDebug.Size = new System.Drawing.Size(94, 13);
            this.labelDebug.TabIndex = 28;
            this.labelDebug.Text = "DEBUG";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Top;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Gainsboro;
            this.label5.Location = new System.Drawing.Point(0, 33);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.label5.Size = new System.Drawing.Size(151, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "DEVICE FEEDBACK";
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
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Gainsboro;
            this.groupBox1.Location = new System.Drawing.Point(60, 312);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(400, 131);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "INSERTION PARAMETERS";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Controls.Add(this.buttonExit);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Location = new System.Drawing.Point(1, 1);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.panel2.Size = new System.Drawing.Size(1109, 30);
            this.panel2.TabIndex = 26;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox3.Image = global::Test_Comm_Brachy.Properties.Resources.output_onlinepngtools_1_;
            this.pictureBox3.Location = new System.Drawing.Point(10, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(29, 28);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 25;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Test_Comm_Brachy.Properties.Resources.output_onlinepngtools;
            this.pictureBox2.Location = new System.Drawing.Point(53, 17);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(774, 221);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 25;
            this.pictureBox2.TabStop = false;
            // 
            // labelErrors
            // 
            this.labelErrors.AutoSize = true;
            this.labelErrors.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelErrors.ForeColor = System.Drawing.Color.Red;
            this.labelErrors.Location = new System.Drawing.Point(58, 451);
            this.labelErrors.Name = "labelErrors";
            this.labelErrors.Size = new System.Drawing.Size(62, 13);
            this.labelErrors.TabIndex = 27;
            this.labelErrors.Text = "labelErrors";
            this.labelErrors.Visible = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.buttonRunCycle);
            this.panel3.Controls.Add(this.labelErrors);
            this.panel3.Controls.Add(this.buttonOpenFunnel);
            this.panel3.Controls.Add(this.buttonCloseFunnel);
            this.panel3.Controls.Add(this.buttonOpenGripper);
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Controls.Add(this.buttonCloseGripper);
            this.panel3.Controls.Add(this.groupBox1);
            this.panel3.Controls.Add(this.buttonNextNeedle);
            this.panel3.Controls.Add(this.buttonOpenAll);
            this.panel3.Controls.Add(this.buttonBackstep);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(203, 31);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(907, 600);
            this.panel3.TabIndex = 28;
            this.panel3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseDown);
            this.panel3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseMove);
            this.panel3.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.ClientSize = new System.Drawing.Size(1111, 632);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(1);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Brachytherapy Instrument Control Panel";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
    }
}

