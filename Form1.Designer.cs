
namespace use_timer_reset
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
            this.Create_Timer = new System.Windows.Forms.Button();
            this.Run_Timer = new System.Windows.Forms.Button();
            this.ReSet_Timer = new System.Windows.Forms.Button();
            this.Stop_Timer = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Create_Timer
            // 
            this.Create_Timer.Location = new System.Drawing.Point(12, 12);
            this.Create_Timer.Name = "Create_Timer";
            this.Create_Timer.Size = new System.Drawing.Size(135, 38);
            this.Create_Timer.TabIndex = 0;
            this.Create_Timer.Text = "Create_Timer";
            this.Create_Timer.UseVisualStyleBackColor = true;
            this.Create_Timer.Click += new System.EventHandler(this.Create_Timer_Click);
            // 
            // Run_Timer
            // 
            this.Run_Timer.Location = new System.Drawing.Point(170, 12);
            this.Run_Timer.Name = "Run_Timer";
            this.Run_Timer.Size = new System.Drawing.Size(135, 38);
            this.Run_Timer.TabIndex = 0;
            this.Run_Timer.Text = "Run_Timer";
            this.Run_Timer.UseVisualStyleBackColor = true;
            this.Run_Timer.Click += new System.EventHandler(this.Run_Timer_Click);
            // 
            // ReSet_Timer
            // 
            this.ReSet_Timer.Location = new System.Drawing.Point(330, 12);
            this.ReSet_Timer.Name = "ReSet_Timer";
            this.ReSet_Timer.Size = new System.Drawing.Size(135, 38);
            this.ReSet_Timer.TabIndex = 0;
            this.ReSet_Timer.Text = "ReSet_Timer";
            this.ReSet_Timer.UseVisualStyleBackColor = true;
            this.ReSet_Timer.Click += new System.EventHandler(this.ReSet_Timer_Click);
            // 
            // Stop_Timer
            // 
            this.Stop_Timer.Location = new System.Drawing.Point(490, 12);
            this.Stop_Timer.Name = "Stop_Timer";
            this.Stop_Timer.Size = new System.Drawing.Size(135, 38);
            this.Stop_Timer.TabIndex = 0;
            this.Stop_Timer.Text = "Stop_Timer";
            this.Stop_Timer.UseVisualStyleBackColor = true;
            this.Stop_Timer.Click += new System.EventHandler(this.Stop_Timer_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(283, 223);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 23);
            this.textBox1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(490, 255);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "label2";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(229, 266);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Stop_Timer);
            this.Controls.Add(this.ReSet_Timer);
            this.Controls.Add(this.Run_Timer);
            this.Controls.Add(this.Create_Timer);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Create_Timer;
        private System.Windows.Forms.Button Run_Timer;
        private System.Windows.Forms.Button ReSet_Timer;
        private System.Windows.Forms.Button Stop_Timer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}

