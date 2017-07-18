namespace ArduBoard_Plus
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
            this.arduino = new System.IO.Ports.SerialPort(this.components);
            this.mechanism = new System.ComponentModel.BackgroundWorker();
            this.timer = new System.Windows.Forms.Label();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.date = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.settings = new System.Windows.Forms.PictureBox();
            this.closeApp = new System.Windows.Forms.PictureBox();
            this.set_com_port = new System.Windows.Forms.Button();
            this.comport = new System.Windows.Forms.TextBox();
            this.mark = new System.Windows.Forms.Label();
            this.settings_panel = new System.Windows.Forms.Panel();
            this.temperature_indicator = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.settings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeApp)).BeginInit();
            this.settings_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // arduino
            // 
            this.arduino.PortName = "COM20";
            // 
            // mechanism
            // 
            this.mechanism.WorkerReportsProgress = true;
            this.mechanism.WorkerSupportsCancellation = true;
            this.mechanism.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.mechanism.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.mechanism.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // timer
            // 
            this.timer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.timer.BackColor = System.Drawing.Color.White;
            this.timer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.timer.Font = new System.Drawing.Font("Segoe UI", 83.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.timer.ForeColor = System.Drawing.Color.DimGray;
            this.timer.Location = new System.Drawing.Point(276, 174);
            this.timer.Name = "timer";
            this.timer.Size = new System.Drawing.Size(553, 147);
            this.timer.TabIndex = 2;
            this.timer.Text = "09:31 PM";
            this.timer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.timer.Click += new System.EventHandler(this.label3_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon1.Visible = true;
            // 
            // date
            // 
            this.date.BackColor = System.Drawing.Color.White;
            this.date.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.date.Font = new System.Drawing.Font("Segoe UI", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.date.ForeColor = System.Drawing.Color.DimGray;
            this.date.Location = new System.Drawing.Point(279, 287);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(547, 128);
            this.date.TabIndex = 5;
            this.date.Text = "07.18.2017";
            this.date.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ArduBoard_Plus.Properties.Resources.velocity;
            this.pictureBox2.Location = new System.Drawing.Point(3, 10);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(27, 29);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // settings
            // 
            this.settings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.settings.Image = global::ArduBoard_Plus.Properties.Resources._1495237886_gear;
            this.settings.Location = new System.Drawing.Point(1033, 607);
            this.settings.Name = "settings";
            this.settings.Size = new System.Drawing.Size(59, 50);
            this.settings.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.settings.TabIndex = 7;
            this.settings.TabStop = false;
            this.settings.Click += new System.EventHandler(this.settings_Click);
            // 
            // closeApp
            // 
            this.closeApp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeApp.Image = global::ArduBoard_Plus.Properties.Resources.cancel;
            this.closeApp.Location = new System.Drawing.Point(1043, 4);
            this.closeApp.Name = "closeApp";
            this.closeApp.Size = new System.Drawing.Size(59, 50);
            this.closeApp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.closeApp.TabIndex = 3;
            this.closeApp.TabStop = false;
            this.closeApp.Click += new System.EventHandler(this.closeApp_Click);
            // 
            // set_com_port
            // 
            this.set_com_port.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.set_com_port.Location = new System.Drawing.Point(197, 16);
            this.set_com_port.Name = "set_com_port";
            this.set_com_port.Size = new System.Drawing.Size(75, 23);
            this.set_com_port.TabIndex = 8;
            this.set_com_port.Text = "Okay";
            this.set_com_port.UseVisualStyleBackColor = true;
            this.set_com_port.Click += new System.EventHandler(this.set_com_port_Click);
            // 
            // comport
            // 
            this.comport.Location = new System.Drawing.Point(108, 18);
            this.comport.Name = "comport";
            this.comport.Size = new System.Drawing.Size(83, 20);
            this.comport.TabIndex = 9;
            this.comport.Text = "COM12";
            this.comport.TextChanged += new System.EventHandler(this.comport_TextChanged);
            // 
            // mark
            // 
            this.mark.AutoSize = true;
            this.mark.Location = new System.Drawing.Point(7, 21);
            this.mark.Name = "mark";
            this.mark.Size = new System.Drawing.Size(95, 13);
            this.mark.TabIndex = 10;
            this.mark.Text = "Arduino COM Port:";
            // 
            // settings_panel
            // 
            this.settings_panel.Controls.Add(this.set_com_port);
            this.settings_panel.Controls.Add(this.mark);
            this.settings_panel.Controls.Add(this.comport);
            this.settings_panel.Location = new System.Drawing.Point(743, 603);
            this.settings_panel.Name = "settings_panel";
            this.settings_panel.Size = new System.Drawing.Size(284, 54);
            this.settings_panel.TabIndex = 11;
            this.settings_panel.Visible = false;
            // 
            // temperature_indicator
            // 
            this.temperature_indicator.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.temperature_indicator.AutoSize = true;
            this.temperature_indicator.BackColor = System.Drawing.Color.White;
            this.temperature_indicator.Font = new System.Drawing.Font("Segoe UI", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.temperature_indicator.ForeColor = System.Drawing.Color.DimGray;
            this.temperature_indicator.Location = new System.Drawing.Point(40, 546);
            this.temperature_indicator.Name = "temperature_indicator";
            this.temperature_indicator.Size = new System.Drawing.Size(285, 128);
            this.temperature_indicator.TabIndex = 0;
            this.temperature_indicator.Text = "{^_^}";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pictureBox1.Image = global::ArduBoard_Plus.Properties.Resources.thermometer;
            this.pictureBox1.Location = new System.Drawing.Point(-1, 571);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(68, 93);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(29, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(230, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "ArduTemp by GeoSn0w";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1104, 669);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.temperature_indicator);
            this.Controls.Add(this.settings_panel);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.settings);
            this.Controls.Add(this.timer);
            this.Controls.Add(this.date);
            this.Controls.Add(this.closeApp);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.settings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeApp)).EndInit();
            this.settings_panel.ResumeLayout(false);
            this.settings_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort arduino;
        private System.ComponentModel.BackgroundWorker mechanism;
        private System.Windows.Forms.Label timer;
        private System.Windows.Forms.PictureBox closeApp;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Label date;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox settings;
        private System.Windows.Forms.Panel settings_panel;
        private System.Windows.Forms.Button set_com_port;
        private System.Windows.Forms.Label mark;
        private System.Windows.Forms.TextBox comport;
        private System.Windows.Forms.Label temperature_indicator;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
    }
}

