
namespace Paige_Mark_1
{
    partial class Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form));
            this.LSTCommands = new System.Windows.Forms.ListBox();
            this.TmrSpeaking = new System.Windows.Forms.Timer(this.components);
            this.test = new System.Windows.Forms.Panel();
            this.wakeUpButton = new System.Windows.Forms.Button();
            this.listening = new System.Windows.Forms.Label();
            this.Taskmanager = new System.Windows.Forms.Button();
            this.Stop = new System.Windows.Forms.Button();
            this.Start = new System.Windows.Forms.Button();
            this.RamTitle = new System.Windows.Forms.Label();
            this.RAM = new System.Windows.Forms.Label();
            this.CpuTitle = new System.Windows.Forms.Label();
            this.CPU = new System.Windows.Forms.Label();
            this.Unmute = new System.Windows.Forms.Button();
            this.Mute = new System.Windows.Forms.Button();
            this.Weather = new System.Windows.Forms.Button();
            this.OpenYoutube = new System.Windows.Forms.Button();
            this.OpenGoogle = new System.Windows.Forms.Button();
            this.commandsText = new System.Windows.Forms.Label();
            this.paigebox = new System.Windows.Forms.Label();
            this.speechbox = new System.Windows.Forms.Label();
            this.paigeTitle = new System.Windows.Forms.Label();
            this.dhruv = new System.Windows.Forms.Label();
            this.time = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.Label();
            this.dateTitle = new System.Windows.Forms.Label();
            this.timeTitle = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TimeClock = new System.Windows.Forms.Timer(this.components);
            this.DateClock = new System.Windows.Forms.Timer(this.components);
            this.CpuClock = new System.Windows.Forms.Timer(this.components);
            this.RamClock = new System.Windows.Forms.Timer(this.components);
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.test.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LSTCommands
            // 
            this.LSTCommands.BackColor = System.Drawing.Color.Black;
            this.LSTCommands.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LSTCommands.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LSTCommands.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LSTCommands.FormattingEnabled = true;
            this.LSTCommands.ItemHeight = 25;
            this.LSTCommands.Location = new System.Drawing.Point(31, 53);
            this.LSTCommands.Margin = new System.Windows.Forms.Padding(4);
            this.LSTCommands.Name = "LSTCommands";
            this.LSTCommands.Size = new System.Drawing.Size(345, 625);
            this.LSTCommands.TabIndex = 0;
            this.LSTCommands.Visible = false;
            this.LSTCommands.SelectedIndexChanged += new System.EventHandler(this.LSTCommands_SelectedIndexChanged);
            // 
            // TmrSpeaking
            // 
            this.TmrSpeaking.Enabled = true;
            this.TmrSpeaking.Interval = 1000;
            this.TmrSpeaking.Tick += new System.EventHandler(this.TmrSpeaking_Tick);
            // 
            // test
            // 
            this.test.AutoSize = true;
            this.test.BackColor = System.Drawing.Color.Black;
            this.test.Controls.Add(this.wakeUpButton);
            this.test.Controls.Add(this.listening);
            this.test.Controls.Add(this.Taskmanager);
            this.test.Controls.Add(this.Stop);
            this.test.Controls.Add(this.Start);
            this.test.Controls.Add(this.RamTitle);
            this.test.Controls.Add(this.RAM);
            this.test.Controls.Add(this.CpuTitle);
            this.test.Controls.Add(this.CPU);
            this.test.Controls.Add(this.Unmute);
            this.test.Controls.Add(this.Mute);
            this.test.Controls.Add(this.Weather);
            this.test.Controls.Add(this.OpenYoutube);
            this.test.Controls.Add(this.OpenGoogle);
            this.test.Controls.Add(this.commandsText);
            this.test.Controls.Add(this.paigebox);
            this.test.Controls.Add(this.speechbox);
            this.test.Controls.Add(this.paigeTitle);
            this.test.Controls.Add(this.dhruv);
            this.test.Controls.Add(this.time);
            this.test.Controls.Add(this.date);
            this.test.Controls.Add(this.dateTitle);
            this.test.Controls.Add(this.timeTitle);
            this.test.Controls.Add(this.pictureBox1);
            this.test.Controls.Add(this.LSTCommands);
            this.test.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.test.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.test.Location = new System.Drawing.Point(-3, -2);
            this.test.Margin = new System.Windows.Forms.Padding(4);
            this.test.Name = "test";
            this.test.Size = new System.Drawing.Size(1479, 767);
            this.test.TabIndex = 1;
            // 
            // wakeUpButton
            // 
            this.wakeUpButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.wakeUpButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.wakeUpButton.FlatAppearance.BorderSize = 2;
            this.wakeUpButton.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wakeUpButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.wakeUpButton.Location = new System.Drawing.Point(660, 362);
            this.wakeUpButton.Name = "wakeUpButton";
            this.wakeUpButton.Size = new System.Drawing.Size(159, 44);
            this.wakeUpButton.TabIndex = 31;
            this.wakeUpButton.Text = "Wake Up";
            this.wakeUpButton.UseVisualStyleBackColor = false;
            this.wakeUpButton.Visible = false;
            this.wakeUpButton.Click += new System.EventHandler(this.wakeUpButton_Click);
            // 
            // listening
            // 
            this.listening.AutoSize = true;
            this.listening.Font = new System.Drawing.Font("Georgia", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listening.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.listening.Location = new System.Drawing.Point(667, 9);
            this.listening.Name = "listening";
            this.listening.Size = new System.Drawing.Size(148, 31);
            this.listening.TabIndex = 30;
            this.listening.Text = "Listening...";
            this.listening.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.listening.Visible = false;
            // 
            // Taskmanager
            // 
            this.Taskmanager.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Taskmanager.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Taskmanager.FlatAppearance.BorderSize = 2;
            this.Taskmanager.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Taskmanager.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Taskmanager.Location = new System.Drawing.Point(1207, 212);
            this.Taskmanager.Name = "Taskmanager";
            this.Taskmanager.Size = new System.Drawing.Size(159, 44);
            this.Taskmanager.TabIndex = 29;
            this.Taskmanager.Text = "Task manager";
            this.Taskmanager.UseVisualStyleBackColor = false;
            this.Taskmanager.Click += new System.EventHandler(this.Taskmanager_Click);
            // 
            // Stop
            // 
            this.Stop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Stop.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Stop.FlatAppearance.BorderSize = 2;
            this.Stop.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Stop.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Stop.Location = new System.Drawing.Point(1039, 362);
            this.Stop.Name = "Stop";
            this.Stop.Size = new System.Drawing.Size(159, 44);
            this.Stop.TabIndex = 28;
            this.Stop.Text = "Stop Listening";
            this.Stop.UseVisualStyleBackColor = false;
            this.Stop.Click += new System.EventHandler(this.Stop_Click);
            // 
            // Start
            // 
            this.Start.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Start.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Start.FlatAppearance.BorderSize = 2;
            this.Start.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Start.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Start.Location = new System.Drawing.Point(1039, 312);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(159, 44);
            this.Start.TabIndex = 27;
            this.Start.Text = "Start Listening";
            this.Start.UseVisualStyleBackColor = false;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // RamTitle
            // 
            this.RamTitle.AutoSize = true;
            this.RamTitle.Font = new System.Drawing.Font("Georgia", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RamTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.RamTitle.Location = new System.Drawing.Point(1014, 636);
            this.RamTitle.Name = "RamTitle";
            this.RamTitle.Size = new System.Drawing.Size(114, 38);
            this.RamTitle.TabIndex = 26;
            this.RamTitle.Text = "RAM:";
            this.RamTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RAM
            // 
            this.RAM.AutoSize = true;
            this.RAM.Font = new System.Drawing.Font("Georgia", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RAM.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.RAM.Location = new System.Drawing.Point(1135, 642);
            this.RAM.Name = "RAM";
            this.RAM.Size = new System.Drawing.Size(65, 31);
            this.RAM.TabIndex = 25;
            this.RAM.Text = "ram";
            this.RAM.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CpuTitle
            // 
            this.CpuTitle.AutoSize = true;
            this.CpuTitle.Font = new System.Drawing.Font("Georgia", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CpuTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.CpuTitle.Location = new System.Drawing.Point(1024, 526);
            this.CpuTitle.Name = "CpuTitle";
            this.CpuTitle.Size = new System.Drawing.Size(104, 38);
            this.CpuTitle.TabIndex = 24;
            this.CpuTitle.Text = "CPU:";
            this.CpuTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CPU
            // 
            this.CPU.AutoSize = true;
            this.CPU.Font = new System.Drawing.Font("Georgia", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CPU.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.CPU.Location = new System.Drawing.Point(1135, 532);
            this.CPU.Name = "CPU";
            this.CPU.Size = new System.Drawing.Size(58, 31);
            this.CPU.TabIndex = 23;
            this.CPU.Text = "cpu";
            this.CPU.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Unmute
            // 
            this.Unmute.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Unmute.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Unmute.FlatAppearance.BorderSize = 2;
            this.Unmute.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Unmute.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Unmute.Location = new System.Drawing.Point(1207, 462);
            this.Unmute.Name = "Unmute";
            this.Unmute.Size = new System.Drawing.Size(159, 44);
            this.Unmute.TabIndex = 22;
            this.Unmute.Text = "Unmute";
            this.Unmute.UseVisualStyleBackColor = false;
            this.Unmute.Click += new System.EventHandler(this.Unmute_Click);
            // 
            // Mute
            // 
            this.Mute.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Mute.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Mute.FlatAppearance.BorderSize = 2;
            this.Mute.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mute.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Mute.Location = new System.Drawing.Point(1207, 412);
            this.Mute.Name = "Mute";
            this.Mute.Size = new System.Drawing.Size(159, 44);
            this.Mute.TabIndex = 21;
            this.Mute.Text = "Mute";
            this.Mute.UseVisualStyleBackColor = false;
            this.Mute.Click += new System.EventHandler(this.Mute_Click);
            // 
            // Weather
            // 
            this.Weather.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Weather.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Weather.FlatAppearance.BorderSize = 2;
            this.Weather.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Weather.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Weather.Location = new System.Drawing.Point(1207, 362);
            this.Weather.Name = "Weather";
            this.Weather.Size = new System.Drawing.Size(159, 44);
            this.Weather.TabIndex = 20;
            this.Weather.Text = "Weather";
            this.Weather.UseVisualStyleBackColor = false;
            this.Weather.Click += new System.EventHandler(this.Weather_Click);
            // 
            // OpenYoutube
            // 
            this.OpenYoutube.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.OpenYoutube.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.OpenYoutube.FlatAppearance.BorderSize = 2;
            this.OpenYoutube.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpenYoutube.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.OpenYoutube.Location = new System.Drawing.Point(1207, 312);
            this.OpenYoutube.Name = "OpenYoutube";
            this.OpenYoutube.Size = new System.Drawing.Size(159, 44);
            this.OpenYoutube.TabIndex = 19;
            this.OpenYoutube.Text = "Youtube";
            this.OpenYoutube.UseVisualStyleBackColor = false;
            this.OpenYoutube.Click += new System.EventHandler(this.OpenYoutube_Click);
            // 
            // OpenGoogle
            // 
            this.OpenGoogle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.OpenGoogle.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.OpenGoogle.FlatAppearance.BorderSize = 2;
            this.OpenGoogle.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpenGoogle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.OpenGoogle.Location = new System.Drawing.Point(1207, 262);
            this.OpenGoogle.Name = "OpenGoogle";
            this.OpenGoogle.Size = new System.Drawing.Size(159, 44);
            this.OpenGoogle.TabIndex = 18;
            this.OpenGoogle.Text = "Google";
            this.OpenGoogle.UseVisualStyleBackColor = false;
            this.OpenGoogle.Click += new System.EventHandler(this.OpenGoogle_Click);
            // 
            // commandsText
            // 
            this.commandsText.AutoSize = true;
            this.commandsText.BackColor = System.Drawing.Color.Black;
            this.commandsText.Font = new System.Drawing.Font("Georgia", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.commandsText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.commandsText.Location = new System.Drawing.Point(8, 11);
            this.commandsText.Name = "commandsText";
            this.commandsText.Size = new System.Drawing.Size(224, 38);
            this.commandsText.TabIndex = 17;
            this.commandsText.Text = "Commands:";
            this.commandsText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // paigebox
            // 
            this.paigebox.AutoSize = true;
            this.paigebox.Font = new System.Drawing.Font("Georgia", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paigebox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.paigebox.Location = new System.Drawing.Point(414, 583);
            this.paigebox.Name = "paigebox";
            this.paigebox.Size = new System.Drawing.Size(125, 31);
            this.paigebox.TabIndex = 16;
            this.paigebox.Text = "Paigebox";
            this.paigebox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // speechbox
            // 
            this.speechbox.AutoSize = true;
            this.speechbox.Font = new System.Drawing.Font("Georgia", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.speechbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.speechbox.Location = new System.Drawing.Point(414, 67);
            this.speechbox.Name = "speechbox";
            this.speechbox.Size = new System.Drawing.Size(143, 31);
            this.speechbox.TabIndex = 15;
            this.speechbox.Text = "Speechbox";
            this.speechbox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // paigeTitle
            // 
            this.paigeTitle.AutoSize = true;
            this.paigeTitle.Font = new System.Drawing.Font("Georgia", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paigeTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.paigeTitle.Location = new System.Drawing.Point(397, 545);
            this.paigeTitle.Name = "paigeTitle";
            this.paigeTitle.Size = new System.Drawing.Size(122, 38);
            this.paigeTitle.TabIndex = 13;
            this.paigeTitle.Text = "Paige:";
            this.paigeTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dhruv
            // 
            this.dhruv.AutoSize = true;
            this.dhruv.Font = new System.Drawing.Font("Georgia", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dhruv.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dhruv.Location = new System.Drawing.Point(397, 29);
            this.dhruv.Name = "dhruv";
            this.dhruv.Size = new System.Drawing.Size(137, 38);
            this.dhruv.TabIndex = 11;
            this.dhruv.Text = "Dhruv:";
            this.dhruv.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // time
            // 
            this.time.AutoSize = true;
            this.time.Font = new System.Drawing.Font("Georgia", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.time.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.time.Location = new System.Drawing.Point(1135, 35);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(68, 31);
            this.time.TabIndex = 9;
            this.time.Text = "time";
            this.time.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // date
            // 
            this.date.AutoSize = true;
            this.date.Font = new System.Drawing.Font("Georgia", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.date.Location = new System.Drawing.Point(1135, 136);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(67, 31);
            this.date.TabIndex = 8;
            this.date.Text = "date";
            this.date.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dateTitle
            // 
            this.dateTitle.AutoSize = true;
            this.dateTitle.Font = new System.Drawing.Font("Georgia", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dateTitle.Location = new System.Drawing.Point(1019, 130);
            this.dateTitle.Name = "dateTitle";
            this.dateTitle.Size = new System.Drawing.Size(109, 38);
            this.dateTitle.TabIndex = 7;
            this.dateTitle.Text = "Date:";
            this.dateTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timeTitle
            // 
            this.timeTitle.AutoSize = true;
            this.timeTitle.Font = new System.Drawing.Font("Georgia", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.timeTitle.Location = new System.Drawing.Point(1011, 29);
            this.timeTitle.Name = "timeTitle";
            this.timeTitle.Size = new System.Drawing.Size(117, 38);
            this.timeTitle.TabIndex = 6;
            this.timeTitle.Text = "Time:";
            this.timeTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(417, 53);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(653, 654);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // TimeClock
            // 
            this.TimeClock.Enabled = true;
            this.TimeClock.Interval = 1000;
            this.TimeClock.Tick += new System.EventHandler(this.TimeClock_Tick);
            // 
            // DateClock
            // 
            this.DateClock.Enabled = true;
            this.DateClock.Interval = 1000;
            this.DateClock.Tick += new System.EventHandler(this.DateClock_Tick);
            // 
            // CpuClock
            // 
            this.CpuClock.Enabled = true;
            this.CpuClock.Interval = 1000;
            this.CpuClock.Tick += new System.EventHandler(this.CpuClock_Tick);
            // 
            // RamClock
            // 
            this.RamClock.Enabled = true;
            this.RamClock.Interval = 1000;
            this.RamClock.Tick += new System.EventHandler(this.RamClock_Tick);
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1474, 757);
            this.Controls.Add(this.test);
            this.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Paige Mark 1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.test.ResumeLayout(false);
            this.test.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox LSTCommands;
        private System.Windows.Forms.Timer TmrSpeaking;
        private System.Windows.Forms.Panel test;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label timeTitle;
        private System.Windows.Forms.Label date;
        private System.Windows.Forms.Label dateTitle;
        private System.Windows.Forms.Label time;
        private System.Windows.Forms.Label dhruv;
        private System.Windows.Forms.Label paigeTitle;
        private System.Windows.Forms.Label speechbox;
        private System.Windows.Forms.Label paigebox;
        private System.Windows.Forms.Label commandsText;
        private System.Windows.Forms.Button OpenGoogle;
        private System.Windows.Forms.Button Unmute;
        private System.Windows.Forms.Button Mute;
        private System.Windows.Forms.Button Weather;
        private System.Windows.Forms.Button OpenYoutube;
        private System.Windows.Forms.Label CPU;
        private System.Windows.Forms.Label RamTitle;
        private System.Windows.Forms.Label RAM;
        private System.Windows.Forms.Label CpuTitle;
        private System.Windows.Forms.Timer TimeClock;
        private System.Windows.Forms.Timer DateClock;
        private System.Windows.Forms.Timer CpuClock;
        private System.Windows.Forms.Timer RamClock;
        private System.Windows.Forms.Button Stop;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Button Taskmanager;
        private System.Windows.Forms.Label listening;
        private System.Windows.Forms.Button wakeUpButton;
        private System.Windows.Forms.Timer Timer;
    }
}

