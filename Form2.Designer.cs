namespace ourproject
{
    partial class MAIN_FORM
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
            this.SuspendLayout();
            // 
            // button_update
            // 
            this.button_update.Location = new System.Drawing.Point(136, 164);
            this.button_update.Margin = new System.Windows.Forms.Padding(2);
            this.button_update.Name = "button_update";
            this.button_update.Size = new System.Drawing.Size(90, 32);
            this.button_update.TabIndex = 6;
            this.button_update.Text = "עדכון עובד קיים";
            this.button_update.UseVisualStyleBackColor = true;
            this.button_update.Click += new System.EventHandler(this.button_update_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(154, 57);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "מערכת עובדים";
            // 
            // button_LOOK
            // 
            this.button_LOOK.Location = new System.Drawing.Point(48, 113);
            this.button_LOOK.Margin = new System.Windows.Forms.Padding(2);
            this.button_LOOK.Name = "button_LOOK";
            this.button_LOOK.Size = new System.Drawing.Size(111, 30);
            this.button_LOOK.TabIndex = 3;
            this.button_LOOK.Text = "צפייה בעובד קיים";
            this.button_LOOK.UseVisualStyleBackColor = true;
            this.button_LOOK.Click += new System.EventHandler(this.button_LOOK_Click);
            // 
            // button_CREATE
            // 
            this.button_CREATE.Location = new System.Drawing.Point(222, 113);
            this.button_CREATE.Margin = new System.Windows.Forms.Padding(2);
            this.button_CREATE.Name = "button_CREATE";
            this.button_CREATE.Size = new System.Drawing.Size(111, 30);
            this.button_CREATE.TabIndex = 4;
            this.button_CREATE.Text = "יצירת עובד חדש";
            this.button_CREATE.UseVisualStyleBackColor = true;
            this.button_CREATE.Click += new System.EventHandler(this.button_CREATE_Click);
            // 
            // MAIN_FORM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 285);
            this.Controls.Add(this.button_update);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_LOOK);
            this.Controls.Add(this.button_CREATE);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MAIN_FORM";
            this.Text = "משאבי אנוש";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button_update;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_LOOK;
        private System.Windows.Forms.Button button_CREATE;
    }
}