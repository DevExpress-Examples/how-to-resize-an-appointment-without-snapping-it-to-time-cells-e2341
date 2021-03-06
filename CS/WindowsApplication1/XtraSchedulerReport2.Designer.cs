﻿// Developer Express Code Central Example:
// How to resize an appointment without snapping it to time cells
// 
// This example illustrates how to resize an appointment without snapping it to
// timecells.
// 
// You can find sample updates and versions for different programming languages here:
// http://www.devexpress.com/example=E2341

namespace WindowsApplication1 {
    partial class XtraSchedulerReport2 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            components = new System.ComponentModel.Container();
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] { this.Detail });
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
        }

        #endregion

        private DevExpress.XtraReports.UI.DetailBand Detail;
    }
}
