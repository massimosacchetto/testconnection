
namespace testconn
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
            this.IP1 = new System.Windows.Forms.TextBox();
            this.IP2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.stop_ping = new System.Windows.Forms.Button();
            this.output_a = new System.Windows.Forms.ListBox();
            this.output_b = new System.Windows.Forms.ListBox();
            this.timerPing = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // IP1
            // 
            this.IP1.Location = new System.Drawing.Point(38, 21);
            this.IP1.Name = "IP1";
            this.IP1.Size = new System.Drawing.Size(158, 22);
            this.IP1.TabIndex = 0;
            // 
            // IP2
            // 
            this.IP2.Location = new System.Drawing.Point(202, 21);
            this.IP2.Name = "IP2";
            this.IP2.Size = new System.Drawing.Size(158, 22);
            this.IP2.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(366, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 50);
            this.button1.TabIndex = 2;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // stop_ping
            // 
            this.stop_ping.Location = new System.Drawing.Point(366, 77);
            this.stop_ping.Name = "stop_ping";
            this.stop_ping.Size = new System.Drawing.Size(75, 50);
            this.stop_ping.TabIndex = 3;
            this.stop_ping.Text = "Stop";
            this.stop_ping.UseVisualStyleBackColor = true;
            this.stop_ping.Click += new System.EventHandler(this.start_ping_Click);
            // 
            // output_a
            // 
            this.output_a.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.output_a.FormattingEnabled = true;
            this.output_a.ItemHeight = 16;
            this.output_a.Location = new System.Drawing.Point(38, 49);
            this.output_a.Name = "output_a";
            this.output_a.Size = new System.Drawing.Size(158, 338);
            this.output_a.TabIndex = 4;
            // 
            // output_b
            // 
            this.output_b.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.output_b.FormattingEnabled = true;
            this.output_b.ItemHeight = 16;
            this.output_b.Location = new System.Drawing.Point(202, 49);
            this.output_b.Name = "output_b";
            this.output_b.Size = new System.Drawing.Size(158, 338);
            this.output_b.TabIndex = 5;
            // 
            // timerPing
            // 
            this.timerPing.Interval = 1000;
            this.timerPing.Tick += new System.EventHandler(this.timerPing_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.output_b);
            this.Controls.Add(this.output_a);
            this.Controls.Add(this.stop_ping);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.IP2);
            this.Controls.Add(this.IP1);
            this.Name = "Form1";
            this.Text = "testconnection";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox IP1;
        private System.Windows.Forms.TextBox IP2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button stop_ping;
        private System.Windows.Forms.ListBox output_a;
        private System.Windows.Forms.ListBox output_b;
        private System.Windows.Forms.Timer timerPing;
    }
}

