namespace ourproject
{
    partial class Form_employee
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
            this.button_update = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button_LOOK = new System.Windows.Forms.Button();
            this.button_CREATE = new System.Windows.Forms.Button();
            this.button_delet = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_update
            // 
            this.button_update.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button_update.Location = new System.Drawing.Point(262, 190);
            this.button_update.Margin = new System.Windows.Forms.Padding(2);
            this.button_update.Name = "button_update";
            this.button_update.Size = new System.Drawing.Size(160, 60);
            this.button_update.TabIndex = 10;
            this.button_update.Text = "עדכון עובד קיים";
            this.button_update.UseVisualStyleBackColor = true;
            this.button_update.Click += new System.EventHandler(this.button_update_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.Location = new System.Drawing.Point(387, 74);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 29);
            this.label2.TabIndex = 9;
            this.label2.Text = "משאבי אנוש";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // button_LOOK
            // 
            this.button_LOOK.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button_LOOK.Location = new System.Drawing.Point(68, 190);
            this.button_LOOK.Margin = new System.Windows.Forms.Padding(2);
            this.button_LOOK.Name = "button_LOOK";
            this.button_LOOK.Size = new System.Drawing.Size(160, 60);
            this.button_LOOK.TabIndex = 7;
            this.button_LOOK.Text = "צפייה בעובד קיים";
            this.button_LOOK.UseVisualStyleBackColor = true;
            this.button_LOOK.Click += new System.EventHandler(this.button_LOOK_Click);
            // 
            // button_CREATE
            // 
            this.button_CREATE.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button_CREATE.Location = new System.Drawing.Point(644, 190);
            this.button_CREATE.Margin = new System.Windows.Forms.Padding(2);
            this.button_CREATE.Name = "button_CREATE";
            this.button_CREATE.Size = new System.Drawing.Size(160, 60);
            this.button_CREATE.TabIndex = 8;
            this.button_CREATE.Text = "יצירת עובד חדש";
            this.button_CREATE.UseVisualStyleBackColor = true;
            this.button_CREATE.Click += new System.EventHandler(this.button_CREATE_Click);
            // 
            // button_delet
            // 
            this.button_delet.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button_delet.Location = new System.Drawing.Point(458, 190);
            this.button_delet.Margin = new System.Windows.Forms.Padding(2);
            this.button_delet.Name = "button_delet";
            this.button_delet.Size = new System.Drawing.Size(160, 60);
            this.button_delet.TabIndex = 11;
            this.button_delet.Text = "מחיקת עובד קיים";
            this.button_delet.UseVisualStyleBackColor = true;
            this.button_delet.Click += new System.EventHandler(this.button_delet_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button1.Location = new System.Drawing.Point(34, 355);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 30);
            this.button1.TabIndex = 12;
            this.button1.Text = "חזרה למסך ראשי";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form_employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ourproject.Properties.Resources.WhatsApp_Image_2021_06_03_at_09_18_36;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button_delet);
            this.Controls.Add(this.button_update);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_LOOK);
            this.Controls.Add(this.button_CREATE);
            this.Name = "Form_employee";
            this.Text = "משאבי אנוש";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_update;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_LOOK;
        private System.Windows.Forms.Button button_CREATE;
        private System.Windows.Forms.Button button_delet;
        private System.Windows.Forms.Button button1;
    }
}