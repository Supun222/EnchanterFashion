
namespace Enchanter_Fashion.Signup_and_Registration
{
    partial class first_recovery
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.recovery1_next = new MaterialSkin.Controls.MaterialFlatButton();
            this.label3 = new System.Windows.Forms.Label();
            this.email_or_username = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // recovery1_next
            // 
            this.recovery1_next.AutoSize = true;
            this.recovery1_next.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.recovery1_next.BackColor = System.Drawing.Color.White;
            this.recovery1_next.Depth = 0;
            this.recovery1_next.DialogResult = System.Windows.Forms.DialogResult.Ignore;
            this.recovery1_next.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.recovery1_next.Icon = null;
            this.recovery1_next.Location = new System.Drawing.Point(134, 214);
            this.recovery1_next.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.recovery1_next.MouseState = MaterialSkin.MouseState.HOVER;
            this.recovery1_next.Name = "recovery1_next";
            this.recovery1_next.Primary = false;
            this.recovery1_next.Size = new System.Drawing.Size(55, 36);
            this.recovery1_next.TabIndex = 95;
            this.recovery1_next.Text = "Next";
            this.recovery1_next.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(39, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(233, 15);
            this.label3.TabIndex = 100;
            this.label3.Text = "Enter the username or email address";
            // 
            // email_or_username
            // 
            this.email_or_username.Depth = 0;
            this.email_or_username.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(179)))), ((int)(((byte)(132)))));
            this.email_or_username.Hint = "";
            this.email_or_username.Location = new System.Drawing.Point(42, 141);
            this.email_or_username.MaxLength = 32767;
            this.email_or_username.MouseState = MaterialSkin.MouseState.HOVER;
            this.email_or_username.Name = "email_or_username";
            this.email_or_username.PasswordChar = '\0';
            this.email_or_username.SelectedText = "";
            this.email_or_username.SelectionLength = 0;
            this.email_or_username.SelectionStart = 0;
            this.email_or_username.Size = new System.Drawing.Size(230, 23);
            this.email_or_username.TabIndex = 99;
            this.email_or_username.TabStop = false;
            this.email_or_username.UseSystemPasswordChar = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Schoolbook", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(101, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 25);
            this.label2.TabIndex = 98;
            this.label2.Text = "Welcome ";
            // 
            // first_recovery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.email_or_username);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.recovery1_next);
            this.Name = "first_recovery";
            this.Size = new System.Drawing.Size(326, 273);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public MaterialSkin.Controls.MaterialFlatButton recovery1_next;
        private System.Windows.Forms.Label label3;
        public MaterialSkin.Controls.MaterialSingleLineTextField email_or_username;
        private System.Windows.Forms.Label label2;
    }
}
