﻿
namespace LibraryManagement.PresentationLayer
{
    partial class FRM_AREYOUSURE
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_AREYOUSURE));
            BunifuAnimatorNS.Animation animation4 = new BunifuAnimatorNS.Animation();
            this.lblAreYouWant = new System.Windows.Forms.Label();
            this.lblAreYouSure = new System.Windows.Forms.Label();
            this.btnNo = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnYes = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuTransition1 = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.SuspendLayout();
            // 
            // lblAreYouWant
            // 
            this.lblAreYouWant.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAreYouWant.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.lblAreYouWant, BunifuAnimatorNS.DecorationType.None);
            this.lblAreYouWant.Font = new System.Drawing.Font("LBC", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAreYouWant.ForeColor = System.Drawing.Color.Indigo;
            this.lblAreYouWant.Location = new System.Drawing.Point(444, 255);
            this.lblAreYouWant.Name = "lblAreYouWant";
            this.lblAreYouWant.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblAreYouWant.Size = new System.Drawing.Size(294, 47);
            this.lblAreYouWant.TabIndex = 12;
            this.lblAreYouWant.Text = "هل تود الاستمرار..";
            this.lblAreYouWant.Visible = false;
            // 
            // lblAreYouSure
            // 
            this.lblAreYouSure.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAreYouSure.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.lblAreYouSure, BunifuAnimatorNS.DecorationType.None);
            this.lblAreYouSure.Font = new System.Drawing.Font("LBC", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAreYouSure.ForeColor = System.Drawing.Color.MediumOrchid;
            this.lblAreYouSure.Location = new System.Drawing.Point(302, 188);
            this.lblAreYouSure.Name = "lblAreYouSure";
            this.lblAreYouSure.Size = new System.Drawing.Size(439, 47);
            this.lblAreYouSure.TabIndex = 13;
            this.lblAreYouSure.Text = "انت على وشك مسح الصنف";
            this.lblAreYouSure.Visible = false;
            // 
            // btnNo
            // 
            this.btnNo.ActiveBorderThickness = 1;
            this.btnNo.ActiveCornerRadius = 20;
            this.btnNo.ActiveFillColor = System.Drawing.Color.Purple;
            this.btnNo.ActiveForecolor = System.Drawing.Color.White;
            this.btnNo.ActiveLineColor = System.Drawing.Color.Purple;
            this.btnNo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnNo.BackColor = System.Drawing.Color.Black;
            this.btnNo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNo.BackgroundImage")));
            this.btnNo.ButtonText = "لا";
            this.btnNo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.btnNo, BunifuAnimatorNS.DecorationType.None);
            this.btnNo.Font = new System.Drawing.Font("LBC", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNo.ForeColor = System.Drawing.Color.Silver;
            this.btnNo.IdleBorderThickness = 1;
            this.btnNo.IdleCornerRadius = 20;
            this.btnNo.IdleFillColor = System.Drawing.Color.Indigo;
            this.btnNo.IdleForecolor = System.Drawing.Color.WhiteSmoke;
            this.btnNo.IdleLineColor = System.Drawing.Color.Transparent;
            this.btnNo.Location = new System.Drawing.Point(389, 404);
            this.btnNo.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.btnNo.Name = "btnNo";
            this.btnNo.Size = new System.Drawing.Size(157, 50);
            this.btnNo.TabIndex = 14;
            this.btnNo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnNo.Visible = false;
            this.btnNo.Click += new System.EventHandler(this.btnNo_Click);
            // 
            // btnYes
            // 
            this.btnYes.ActiveBorderThickness = 1;
            this.btnYes.ActiveCornerRadius = 20;
            this.btnYes.ActiveFillColor = System.Drawing.Color.Purple;
            this.btnYes.ActiveForecolor = System.Drawing.Color.White;
            this.btnYes.ActiveLineColor = System.Drawing.Color.Purple;
            this.btnYes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnYes.BackColor = System.Drawing.Color.Black;
            this.btnYes.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnYes.BackgroundImage")));
            this.btnYes.ButtonText = "نعم";
            this.btnYes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.btnYes, BunifuAnimatorNS.DecorationType.None);
            this.btnYes.Font = new System.Drawing.Font("LBC", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnYes.ForeColor = System.Drawing.Color.Silver;
            this.btnYes.IdleBorderThickness = 1;
            this.btnYes.IdleCornerRadius = 20;
            this.btnYes.IdleFillColor = System.Drawing.Color.MediumOrchid;
            this.btnYes.IdleForecolor = System.Drawing.Color.WhiteSmoke;
            this.btnYes.IdleLineColor = System.Drawing.Color.Transparent;
            this.btnYes.Location = new System.Drawing.Point(562, 404);
            this.btnYes.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.btnYes.Name = "btnYes";
            this.btnYes.Size = new System.Drawing.Size(157, 50);
            this.btnYes.TabIndex = 15;
            this.btnYes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnYes.Visible = false;
            this.btnYes.Click += new System.EventHandler(this.btnYes_Click);
            // 
            // bunifuTransition1
            // 
            this.bunifuTransition1.AnimationType = BunifuAnimatorNS.AnimationType.Leaf;
            this.bunifuTransition1.Cursor = null;
            animation4.AnimateOnlyDifferences = true;
            animation4.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.BlindCoeff")));
            animation4.LeafCoeff = 1F;
            animation4.MaxTime = 1F;
            animation4.MinTime = 0F;
            animation4.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.MosaicCoeff")));
            animation4.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation4.MosaicShift")));
            animation4.MosaicSize = 0;
            animation4.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            animation4.RotateCoeff = 0F;
            animation4.RotateLimit = 0F;
            animation4.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.ScaleCoeff")));
            animation4.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.SlideCoeff")));
            animation4.TimeCoeff = 0F;
            animation4.TransparencyCoeff = 0F;
            this.bunifuTransition1.DefaultAnimation = animation4;
            // 
            // FRM_AREYOUSURE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1022, 642);
            this.Controls.Add(this.btnNo);
            this.Controls.Add(this.btnYes);
            this.Controls.Add(this.lblAreYouWant);
            this.Controls.Add(this.lblAreYouSure);
            this.bunifuTransition1.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.Font = new System.Drawing.Font("LBC", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "FRM_AREYOUSURE";
            this.Opacity = 0.85D;
            this.Text = "FRM_AREYOUSURE";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FRM_AREYOUSURE_Load);
            this.Click += new System.EventHandler(this.FRM_AREYOUSURE_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuThinButton2 btnNo;
        private Bunifu.Framework.UI.BunifuThinButton2 btnYes;
        private System.Windows.Forms.Label lblAreYouWant;
        private BunifuAnimatorNS.BunifuTransition bunifuTransition1;
        public System.Windows.Forms.Label lblAreYouSure;
    }
}