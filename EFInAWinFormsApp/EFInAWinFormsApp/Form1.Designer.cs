
namespace EFInAWinFormsApp
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
            this.GetEmployees = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // GetEmployees
            // 
            this.GetEmployees.Location = new System.Drawing.Point(369, 149);
            this.GetEmployees.Name = "GetEmployees";
            this.GetEmployees.Size = new System.Drawing.Size(138, 56);
            this.GetEmployees.TabIndex = 0;
            this.GetEmployees.Text = "Get Employees";
            this.GetEmployees.UseVisualStyleBackColor = true;
            this.GetEmployees.Click += new System.EventHandler(this.GetEmployees_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GetEmployees);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button GetEmployees;
    }
}

