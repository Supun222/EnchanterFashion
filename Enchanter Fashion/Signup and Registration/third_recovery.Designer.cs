
namespace Enchanter_Fashion.Signup_and_Registration
{
    partial class third_recovery
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
            this.label4 = new System.Windows.Forms.Label();
            this.confirm_pswd = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label3 = new System.Windows.Forms.Label();
            this.new_pswd = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.submit_btn = new MaterialSkin.Controls.MaterialFlatButton();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(46, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 15);
            this.label4.TabIndex = 103;
            this.label4.Text = "Confirm password";
            // 
            // confirm_pswd
            // 
            this.confirm_pswd.Depth = 0;
            this.confirm_pswd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(179)))), ((int)(((byte)(132)))));
            this.confirm_pswd.Hint = "";
            this.confirm_pswd.Location = new System.Drawing.Point(61, 168);
            this.confirm_pswd.MaxLength = 32767;
            this.confirm_pswd.MouseState = MaterialSkin.MouseState.HOVER;
            this.confirm_pswd.Name = "confirm_pswd";
            this.confirm_pswd.PasswordChar = '\0';
            this.confirm_pswd.SelectedText = "";
            this.confirm_pswd.SelectionLength = 0;
            this.confirm_pswd.SelectionStart = 0;
            this.confirm_pswd.Size = new System.Drawing.Size(213, 23);
            this.confirm_pswd.TabIndex = 102;
            this.confirm_pswd.TabStop = false;
            this.confirm_pswd.UseSystemPasswordChar = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(46, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 15);
            this.label3.TabIndex = 101;
            this.label3.Text = "New password";
            // 
            // new_pswd
            // 
            this.new_pswd.Depth = 0;
            this.new_pswd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(179)))), ((int)(((byte)(132)))));
            this.new_pswd.Hint = "";
            this.new_pswd.Location = new System.Drawing.Point(61, 97);
            this.new_pswd.MaxLength = 32767;
            this.new_pswd.MouseState = MaterialSkin.MouseState.HOVER;
            this.new_pswd.Name = "new_pswd";
            this.new_pswd.PasswordChar = '\0';
            this.new_pswd.SelectedText = "";
            this.new_pswd.SelectionLength = 0;
            this.new_pswd.SelectionStart = 0;
            this.new_pswd.Size = new System.Drawing.Size(213, 23);
            this.new_pswd.TabIndex = 100;
            this.new_pswd.TabStop = false;
            this.new_pswd.UseSystemPasswordChar = false;
            // 
            // submit_btn
            // 
            this.submit_btn.AutoSize = true;
            this.submit_btn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.submit_btn.BackColor = System.Drawing.Color.White;
            this.submit_btn.Depth = 0;
            this.submit_btn.DialogResult = System.Windows.Forms.DialogResult.Ignore;
            this.submit_btn.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.submit_btn.Icon = null;
            this.submit_btn.Location = new System.Drawing.Point(129, 213);
            this.submit_btn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.submit_btn.MouseState = MaterialSkin.MouseState.HOVER;
            this.submit_btn.Name = "submit_btn";
            this.submit_btn.Primary = false;
            this.submit_btn.Size = new System.Drawing.Size(71, 36);
            this.submit_btn.TabIndex = 104;
            this.submit_btn.Text = "Submit";
            this.submit_btn.UseVisualStyleBackColor = false;
            this.submit_btn.Click += new System.EventHandler(this.submit_btn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(108, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 23);
            this.label2.TabIndex = 106;
            this.label2.Text = "Recovery";
            // 
            // third_recovery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.submit_btn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.confirm_pswd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.new_pswd);
            this.Name = "third_recovery";
            this.Size = new System.Drawing.Size(326, 273);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        public MaterialSkin.Controls.MaterialSingleLineTextField confirm_pswd;
        private System.Windows.Forms.Label label3;
        public MaterialSkin.Controls.MaterialSingleLineTextField new_pswd;
        public MaterialSkin.Controls.MaterialFlatButton submit_btn;
        private System.Windows.Forms.Label label2;
    }
}
