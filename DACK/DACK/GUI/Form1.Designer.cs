namespace DACK
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
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnLogin = new DevExpress.XtraEditors.SimpleButton();
            this.linkdk = new DevExpress.XtraEditors.HyperlinkLabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.button1 = new System.Windows.Forms.Button();
            this.txtPasswork = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtUser = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPasswork.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUser.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Appearance.BackColor = System.Drawing.Color.Orange;
            this.groupControl1.Appearance.Options.UseBackColor = true;
            this.groupControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.groupControl1.Controls.Add(this.btnLogin);
            this.groupControl1.Controls.Add(this.linkdk);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.button1);
            this.groupControl1.Controls.Add(this.txtPasswork);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.txtUser);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(70, 57);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(465, 187);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Thông tin đăng nhập";
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(179, 120);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(85, 25);
            this.btnLogin.TabIndex = 7;
            this.btnLogin.Text = "Đăng nhập";
            this.btnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // linkdk
            // 
            this.linkdk.Location = new System.Drawing.Point(291, 151);
            this.linkdk.Name = "linkdk";
            this.linkdk.Size = new System.Drawing.Size(40, 13);
            this.linkdk.TabIndex = 6;
            this.linkdk.Text = "Đăng ký";
            this.linkdk.Click += new System.EventHandler(this.Linkdk_Click);
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(146, 153);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(111, 13);
            this.labelControl3.TabIndex = 5;
            this.labelControl3.Text = "Bạn chưa có tài khoản?";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(291, 92);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(8, 8);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // txtPasswork
            // 
            this.txtPasswork.Location = new System.Drawing.Point(146, 79);
            this.txtPasswork.Name = "txtPasswork";
            this.txtPasswork.Size = new System.Drawing.Size(193, 20);
            this.txtPasswork.TabIndex = 3;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(24, 82);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(52, 16);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Mật khẩu";
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(146, 42);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(193, 20);
            this.txtUser.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(24, 45);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(89, 16);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Tên Đăng Nhập";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(588, 314);
            this.Controls.Add(this.groupControl1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập hệ thống";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPasswork.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUser.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.TextEdit txtUser;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.HyperlinkLabelControl linkdk;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private System.Windows.Forms.Button button1;
        private DevExpress.XtraEditors.TextEdit txtPasswork;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton btnLogin;
    }
}

