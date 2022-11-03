namespace SAAP_MVP
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
            this.txtbox_input = new System.Windows.Forms.TextBox();
            this.btn_sin = new System.Windows.Forms.Button();
            this.btn_cos = new System.Windows.Forms.Button();
            this.btn_tan = new System.Windows.Forms.Button();
            this.txtbox_output = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtbox_input
            // 
            this.txtbox_input.Location = new System.Drawing.Point(13, 13);
            this.txtbox_input.Name = "txtbox_input";
            this.txtbox_input.Size = new System.Drawing.Size(100, 20);
            this.txtbox_input.TabIndex = 0;
            // 
            // btn_sin
            // 
            this.btn_sin.Location = new System.Drawing.Point(13, 40);
            this.btn_sin.Name = "btn_sin";
            this.btn_sin.Size = new System.Drawing.Size(100, 23);
            this.btn_sin.TabIndex = 1;
            this.btn_sin.Text = "sin";
            this.btn_sin.UseVisualStyleBackColor = true;
            this.btn_sin.Click += new System.EventHandler(this.btn_sin_Click);
            // 
            // btn_cos
            // 
            this.btn_cos.Location = new System.Drawing.Point(13, 70);
            this.btn_cos.Name = "btn_cos";
            this.btn_cos.Size = new System.Drawing.Size(100, 23);
            this.btn_cos.TabIndex = 2;
            this.btn_cos.Text = "cos";
            this.btn_cos.UseVisualStyleBackColor = true;
            this.btn_cos.Click += new System.EventHandler(this.btn_cos_Click);
            // 
            // btn_tan
            // 
            this.btn_tan.Location = new System.Drawing.Point(13, 100);
            this.btn_tan.Name = "btn_tan";
            this.btn_tan.Size = new System.Drawing.Size(100, 23);
            this.btn_tan.TabIndex = 3;
            this.btn_tan.Text = "tan";
            this.btn_tan.UseVisualStyleBackColor = true;
            this.btn_tan.Click += new System.EventHandler(this.btn_tan_Click);
            // 
            // txtbox_output
            // 
            this.txtbox_output.Location = new System.Drawing.Point(168, 12);
            this.txtbox_output.Name = "txtbox_output";
            this.txtbox_output.Size = new System.Drawing.Size(187, 20);
            this.txtbox_output.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 137);
            this.Controls.Add(this.txtbox_output);
            this.Controls.Add(this.btn_tan);
            this.Controls.Add(this.btn_cos);
            this.Controls.Add(this.btn_sin);
            this.Controls.Add(this.txtbox_input);
            this.Name = "Form1";
            this.Text = "MVP";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbox_input;
        private System.Windows.Forms.Button btn_sin;
        private System.Windows.Forms.Button btn_cos;
        private System.Windows.Forms.Button btn_tan;
        private System.Windows.Forms.TextBox txtbox_output;
    }
}

