using System;

namespace WindowsFormsApp1
{
    partial class QR_Code
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.image1 = new DevExpress.XtraEditors.PictureEdit();
            this.CreateBtn = new DevExpress.XtraEditors.SimpleButton();
            this.SaveBtn = new DevExpress.XtraEditors.SimpleButton();
            this.textData = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.image1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textData.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.Transparent;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelControl1.Location = new System.Drawing.Point(0, 0);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(0, 22);
            this.labelControl1.TabIndex = 0;
            // 
            // image1
            // 
            this.image1.Location = new System.Drawing.Point(12, 12);
            this.image1.Name = "image1";
            this.image1.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.image1.Properties.Appearance.Options.UseBackColor = true;
            this.image1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.image1.Size = new System.Drawing.Size(570, 289);
            this.image1.TabIndex = 1;
            this.image1.EditValueChanged += new System.EventHandler(this.image1_EditValueChanged);
            // 
            // CreateBtn
            // 
            this.CreateBtn.Location = new System.Drawing.Point(12, 350);
            this.CreateBtn.Name = "CreateBtn";
            this.CreateBtn.Size = new System.Drawing.Size(112, 34);
            this.CreateBtn.TabIndex = 2;
            this.CreateBtn.Text = "Create";
            this.CreateBtn.Click += new System.EventHandler(this.CreateBtn_Click);
            // 
            // SaveBtn
            // 
            this.SaveBtn.Location = new System.Drawing.Point(180, 350);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(112, 34);
            this.SaveBtn.TabIndex = 2;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // textData
            // 
            this.textData.Location = new System.Drawing.Point(13, 308);
            this.textData.Name = "textData";
            this.textData.Size = new System.Drawing.Size(569, 28);
            this.textData.TabIndex = 3;
            // 
            // QR_Code
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textData);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.CreateBtn);
            this.Controls.Add(this.image1);
            this.Controls.Add(this.labelControl1);
            this.Name = "QR_Code";
            this.Text = "QR_Code";
            ((System.ComponentModel.ISupportInitialize)(this.image1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textData.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.PictureEdit image1;
        private DevExpress.XtraEditors.SimpleButton CreateBtn;
        private DevExpress.XtraEditors.SimpleButton SaveBtn;
        private DevExpress.XtraEditors.TextEdit textData;

    }
      
}

