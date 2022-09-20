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
            this.SaveBtn = new DevExpress.XtraEditors.SimpleButton();
            this.textData = new DevExpress.XtraEditors.TextEdit();
            this.clearBtn = new DevExpress.XtraEditors.SimpleButton();
            this.btnCode128 = new DevExpress.XtraEditors.SimpleButton();
            this.btnQr = new DevExpress.XtraEditors.SimpleButton();
            this.labelCode = new DevExpress.XtraEditors.LabelControl();
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
            // SaveBtn
            // 
            this.SaveBtn.Location = new System.Drawing.Point(248, 342);
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
            // clearBtn
            // 
            this.clearBtn.Location = new System.Drawing.Point(366, 342);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(112, 34);
            this.clearBtn.TabIndex = 4;
            this.clearBtn.Text = "Clear";
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // btnCode128
            // 
            this.btnCode128.Location = new System.Drawing.Point(12, 342);
            this.btnCode128.Name = "btnCode128";
            this.btnCode128.Size = new System.Drawing.Size(112, 34);
            this.btnCode128.TabIndex = 7;
            this.btnCode128.Text = "BarCode_128";
            this.btnCode128.Click += new System.EventHandler(this.btnCode128_Click);
            // 
            // btnQr
            // 
            this.btnQr.Location = new System.Drawing.Point(130, 342);
            this.btnQr.Name = "btnQr";
            this.btnQr.Size = new System.Drawing.Size(112, 34);
            this.btnQr.TabIndex = 8;
            this.btnQr.Text = "QR_Code";
            this.btnQr.Click += new System.EventHandler(this.btnQr_Click);
            // 
            // labelCode
            // 
            this.labelCode.Appearance.BackColor = System.Drawing.Color.White;
            this.labelCode.Appearance.Font = new System.Drawing.Font("맑은 고딕", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCode.Appearance.Options.UseBackColor = true;
            this.labelCode.Appearance.Options.UseFont = true;
            this.labelCode.Location = new System.Drawing.Point(588, 12);
            this.labelCode.Name = "labelCode";
            this.labelCode.Size = new System.Drawing.Size(313, 41);
            this.labelCode.TabIndex = 9;
            this.labelCode.Text = "Code에 관해서 입니다.";
            this.labelCode.Click += new System.EventHandler(this.labelCode_Click);
            // 
            // QR_Code
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(987, 378);
            this.Controls.Add(this.labelCode);
            this.Controls.Add(this.btnQr);
            this.Controls.Add(this.btnCode128);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.textData);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.image1);
            this.Controls.Add(this.labelControl1);
            this.Name = "QR_Code";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QR_Code";
            this.Load += new System.EventHandler(this.QR_Code_Load);
            ((System.ComponentModel.ISupportInitialize)(this.image1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textData.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.PictureEdit image1;
        private DevExpress.XtraEditors.SimpleButton SaveBtn;
        private DevExpress.XtraEditors.TextEdit textData;
        private DevExpress.XtraEditors.SimpleButton clearBtn;
        private DevExpress.XtraEditors.SimpleButton btnCode128;
        private DevExpress.XtraEditors.SimpleButton btnQr;
        private DevExpress.XtraEditors.LabelControl labelCode;
    }
      
}

