namespace DACK.GUI
{
    partial class frmDoimatkhau
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
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.txtmkcu = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.txtmatkhaumoi = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.txtconfigmk = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem3 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem4 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.btnluu = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.btndong = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtmkcu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtmatkhaumoi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtconfigmk.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.btndong);
            this.layoutControl1.Controls.Add(this.btnluu);
            this.layoutControl1.Controls.Add(this.txtconfigmk);
            this.layoutControl1.Controls.Add(this.txtmatkhaumoi);
            this.layoutControl1.Controls.Add(this.txtmkcu);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(623, 18, 650, 400);
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(457, 139);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.emptySpaceItem1,
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.emptySpaceItem2,
            this.emptySpaceItem3,
            this.emptySpaceItem4,
            this.layoutControlItem4,
            this.layoutControlItem5});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(440, 148);
            this.Root.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 102);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(210, 26);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // txtmkcu
            // 
            this.txtmkcu.Location = new System.Drawing.Point(137, 3);
            this.txtmkcu.Name = "txtmkcu";
            this.txtmkcu.Size = new System.Drawing.Size(291, 20);
            this.txtmkcu.StyleController = this.layoutControl1;
            this.txtmkcu.TabIndex = 4;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.txtmkcu;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(420, 24);
            this.layoutControlItem1.Text = "Mật khẩu cũ";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(113, 13);
            // 
            // txtmatkhaumoi
            // 
            this.txtmatkhaumoi.Location = new System.Drawing.Point(137, 37);
            this.txtmatkhaumoi.Name = "txtmatkhaumoi";
            this.txtmatkhaumoi.Size = new System.Drawing.Size(291, 20);
            this.txtmatkhaumoi.StyleController = this.layoutControl1;
            this.txtmatkhaumoi.TabIndex = 5;
            this.txtmatkhaumoi.EditValueChanged += new System.EventHandler(this.Txtmatkhaumoi_EditValueChanged);
            this.txtmatkhaumoi.Click += new System.EventHandler(this.Txtmatkhaumoi_Click);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.txtmatkhaumoi;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 34);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(420, 24);
            this.layoutControlItem2.Text = "mật khẩu mới";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(113, 13);
            // 
            // txtconfigmk
            // 
            this.txtconfigmk.Location = new System.Drawing.Point(137, 71);
            this.txtconfigmk.Name = "txtconfigmk";
            this.txtconfigmk.Size = new System.Drawing.Size(291, 20);
            this.txtconfigmk.StyleController = this.layoutControl1;
            this.txtconfigmk.TabIndex = 6;
            this.txtconfigmk.EditValueChanged += new System.EventHandler(this.Txtconfigmk_EditValueChanged);
            this.txtconfigmk.Click += new System.EventHandler(this.Txtconfigmk_Click);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.txtconfigmk;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 68);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(420, 24);
            this.layoutControlItem3.Text = "Xác nhận mật khẩu mới ";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(113, 13);
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(0, 24);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(420, 10);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem3
            // 
            this.emptySpaceItem3.AllowHotTrack = false;
            this.emptySpaceItem3.Location = new System.Drawing.Point(0, 58);
            this.emptySpaceItem3.Name = "emptySpaceItem3";
            this.emptySpaceItem3.Size = new System.Drawing.Size(420, 10);
            this.emptySpaceItem3.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem4
            // 
            this.emptySpaceItem4.AllowHotTrack = false;
            this.emptySpaceItem4.Location = new System.Drawing.Point(0, 92);
            this.emptySpaceItem4.Name = "emptySpaceItem4";
            this.emptySpaceItem4.Size = new System.Drawing.Size(420, 10);
            this.emptySpaceItem4.TextSize = new System.Drawing.Size(0, 0);
            // 
            // btnluu
            // 
            this.btnluu.Location = new System.Drawing.Point(222, 105);
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(101, 22);
            this.btnluu.StyleController = this.layoutControl1;
            this.btnluu.TabIndex = 7;
            this.btnluu.Text = "Xác nhận";
            this.btnluu.Click += new System.EventHandler(this.Btnluu_Click);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.btnluu;
            this.layoutControlItem4.Location = new System.Drawing.Point(210, 102);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(105, 26);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // btndong
            // 
            this.btndong.Location = new System.Drawing.Point(327, 105);
            this.btndong.Name = "btndong";
            this.btndong.Size = new System.Drawing.Size(101, 22);
            this.btndong.StyleController = this.layoutControl1;
            this.btndong.TabIndex = 8;
            this.btndong.Text = "Đóng";
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.btndong;
            this.layoutControlItem5.Location = new System.Drawing.Point(315, 102);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(105, 26);
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // frmDoimatkhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 139);
            this.Controls.Add(this.layoutControl1);
            this.Name = "frmDoimatkhau";
            this.Text = "frmDoimatkhau";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtmkcu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtmatkhaumoi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtconfigmk.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraEditors.SimpleButton btndong;
        private DevExpress.XtraEditors.SimpleButton btnluu;
        private DevExpress.XtraEditors.TextEdit txtconfigmk;
        private DevExpress.XtraEditors.TextEdit txtmatkhaumoi;
        private DevExpress.XtraEditors.TextEdit txtmkcu;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem3;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
    }
}