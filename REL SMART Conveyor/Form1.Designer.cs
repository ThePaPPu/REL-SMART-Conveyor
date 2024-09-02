namespace REL_SMART_Conveyor
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
            label2 = new Label();
            plc_input_timer = new System.Windows.Forms.Timer(components);
            label3 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(88, 165);
            label2.Name = "label2";
            label2.Size = new Size(135, 25);
            label2.TabIndex = 3;
            label2.Text = "Running Event: ";
            // 
            // plc_input_timer
            // 
            plc_input_timer.Tick += timer1_Tick;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(88, 227);
            label3.Name = "label3";
            label3.Size = new Size(152, 25);
            label3.TabIndex = 5;
            label3.Text = "Upcoming Event: ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(88, 40);
            label1.Name = "label1";
            label1.Size = new Size(164, 25);
            label1.TabIndex = 6;
            label1.Text = "Connection Status: ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(487, 450);
            Controls.Add(label1);
            Controls.Add(label3);
            Controls.Add(label2);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private System.Windows.Forms.Timer plc_input_timer;
        private Label label3;
        private Label label1;
    }
}
