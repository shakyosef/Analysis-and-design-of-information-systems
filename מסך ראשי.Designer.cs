namespace ourproject
{
    partial class Form2
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
            this.button_EMPLOYEE = new System.Windows.Forms.Button();
            this.button_opertion = new System.Windows.Forms.Button();
            this.button_serviceC = new System.Windows.Forms.Button();
            this.button_EXIT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_EMPLOYEE
            // 
            this.button_EMPLOYEE.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_EMPLOYEE.Location = new System.Drawing.Point(134, 186);
            this.button_EMPLOYEE.Margin = new System.Windows.Forms.Padding(2);
            this.button_EMPLOYEE.Name = "button_EMPLOYEE";
            this.button_EMPLOYEE.Size = new System.Drawing.Size(150, 80);
            this.button_EMPLOYEE.TabIndex = 4;
            this.button_EMPLOYEE.Text = "משאבי אנוש";
            this.button_EMPLOYEE.UseVisualStyleBackColor = true;
            this.button_EMPLOYEE.Click += new System.EventHandler(this.button_EMPLOYEE_Click);
            // 
            // button_opertion
            // 
            this.button_opertion.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_opertion.Location = new System.Drawing.Point(368, 186);
            this.button_opertion.Margin = new System.Windows.Forms.Padding(2);
            this.button_opertion.Name = "button_opertion";
            this.button_opertion.Size = new System.Drawing.Size(150, 80);
            this.button_opertion.TabIndex = 8;
            this.button_opertion.Text = "תפעול";
            this.button_opertion.UseVisualStyleBackColor = true;
            this.button_opertion.Click += new System.EventHandler(this.button_opertion_Click);
            // 
            // button_serviceC
            // 
            this.button_serviceC.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_serviceC.Location = new System.Drawing.Point(598, 186);
            this.button_serviceC.Margin = new System.Windows.Forms.Padding(2);
            this.button_serviceC.Name = "button_serviceC";
            this.button_serviceC.Size = new System.Drawing.Size(150, 80);
            this.button_serviceC.TabIndex = 3;
            this.button_serviceC.Text = " מנהל שירות לקוחות";
            this.button_serviceC.UseVisualStyleBackColor = true;
            this.button_serviceC.Click += new System.EventHandler(this.button_serviceC_Click);
            // 
            // button_EXIT
            // 
            this.button_EXIT.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button_EXIT.Location = new System.Drawing.Point(24, 360);
            this.button_EXIT.Margin = new System.Windows.Forms.Padding(2);
            this.button_EXIT.Name = "button_EXIT";
            this.button_EXIT.Size = new System.Drawing.Size(118, 30);
            this.button_EXIT.TabIndex = 13;
            this.button_EXIT.Text = "יציאה מהמערכת";
            this.button_EXIT.UseVisualStyleBackColor = true;
            this.button_EXIT.Click += new System.EventHandler(this.button_EXIT_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ourproject.Properties.Resources.WhatsApp_Image_2021_06_03_at_09_18_36;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.button_EXIT);
            this.Controls.Add(this.button_EMPLOYEE);
            this.Controls.Add(this.button_opertion);
            this.Controls.Add(this.button_serviceC);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form2";
            this.Text = "דף ראשי";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button_EMPLOYEE;
        private System.Windows.Forms.Button button_opertion;
        private System.Windows.Forms.Button button_serviceC;
        private System.Windows.Forms.Button button_EXIT;
    }
}

