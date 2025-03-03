namespace tpmodul3_103022300148
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
            submit = new Button();
            input = new TextBox();
            output = new Label();
            SuspendLayout();
            // 
            // submit
            // 
            submit.Font = new Font("Segoe UI", 18F);
            submit.Location = new Point(526, 161);
            submit.Name = "submit";
            submit.Size = new Size(138, 55);
            submit.TabIndex = 0;
            submit.Text = "SUBMIT";
            submit.UseVisualStyleBackColor = true;
            submit.Click += button1_Click;
            // 
            // input
            // 
            input.Font = new Font("Segoe UI", 18F);
            input.Location = new Point(82, 161);
            input.Multiline = true;
            input.Name = "input";
            input.Size = new Size(438, 55);
            input.TabIndex = 1;
            // 
            // output
            // 
            output.AutoSize = true;
            output.Font = new Font("Segoe UI", 22F);
            output.Location = new Point(82, 238);
            output.Name = "output";
            output.Size = new Size(159, 50);
            output.TabIndex = 2;
            output.Text = "OUTPUT";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(output);
            Controls.Add(input);
            Controls.Add(submit);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button submit;
        private TextBox input;
        private Label output;
    }
}
