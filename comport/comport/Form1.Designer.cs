
namespace comport
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
            this.Baudrate_box = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SAVE_btn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.connect_com_btn = new System.Windows.Forms.Button();
            this.Com_setting_box = new System.Windows.Forms.ComboBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.SuspendLayout();
            // 
            // Baudrate_box
            // 
            this.Baudrate_box.FormattingEnabled = true;
            this.Baudrate_box.Location = new System.Drawing.Point(95, 56);
            this.Baudrate_box.Name = "Baudrate_box";
            this.Baudrate_box.Size = new System.Drawing.Size(121, 21);
            this.Baudrate_box.TabIndex = 11;
            this.Baudrate_box.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "BAUDRATE";
            this.label1.Visible = false;
            // 
            // SAVE_btn
            // 
            this.SAVE_btn.Location = new System.Drawing.Point(12, 84);
            this.SAVE_btn.Name = "SAVE_btn";
            this.SAVE_btn.Size = new System.Drawing.Size(75, 23);
            this.SAVE_btn.TabIndex = 9;
            this.SAVE_btn.Text = "SAVE";
            this.SAVE_btn.UseVisualStyleBackColor = true;
            this.SAVE_btn.Visible = false;
            this.SAVE_btn.Click += new System.EventHandler(this.SAVE_btn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "COM PORT";
            this.label2.Visible = false;
            // 
            // connect_com_btn
            // 
            this.connect_com_btn.BackColor = System.Drawing.Color.Lime;
            this.connect_com_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.connect_com_btn.ForeColor = System.Drawing.Color.Black;
            this.connect_com_btn.Location = new System.Drawing.Point(62, 25);
            this.connect_com_btn.Name = "connect_com_btn";
            this.connect_com_btn.Size = new System.Drawing.Size(97, 53);
            this.connect_com_btn.TabIndex = 7;
            this.connect_com_btn.Text = "CONNECT CLIENT";
            this.connect_com_btn.UseVisualStyleBackColor = false;
            this.connect_com_btn.Click += new System.EventHandler(this.connect_com_btn_Click);
            // 
            // Com_setting_box
            // 
            this.Com_setting_box.FormattingEnabled = true;
            this.Com_setting_box.Location = new System.Drawing.Point(95, 21);
            this.Com_setting_box.Name = "Com_setting_box";
            this.Com_setting_box.Size = new System.Drawing.Size(121, 21);
            this.Com_setting_box.TabIndex = 6;
            this.Com_setting_box.Visible = false;
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(217, 112);
            this.Controls.Add(this.Baudrate_box);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SAVE_btn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.connect_com_btn);
            this.Controls.Add(this.Com_setting_box);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox Baudrate_box;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SAVE_btn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button connect_com_btn;
        private System.Windows.Forms.ComboBox Com_setting_box;
        private System.IO.Ports.SerialPort serialPort1;
    }
}

