﻿namespace ShareX.HistoryLib
{
    partial class HistoryItemInfoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HistoryItemInfoForm));
            this.olvMain = new ShareX.HelpersLib.ObjectListView();
            this.SuspendLayout();
            // 
            // olvMain
            // 
            this.olvMain.AutoFillColumn = true;
            this.olvMain.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.olvMain, "olvMain");
            this.olvMain.FullRowSelect = true;
            this.olvMain.GridLines = true;
            this.olvMain.HideSelection = false;
            this.olvMain.MultiSelect = false;
            this.olvMain.Name = "olvMain";
            this.olvMain.SelectedObject = null;
            this.olvMain.UseCompatibleStateImageBehavior = false;
            this.olvMain.View = System.Windows.Forms.View.Details;
            // 
            // HistoryItemInfoForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.olvMain);
            this.Name = "HistoryItemInfoForm";
            this.ResumeLayout(false);

        }

        #endregion Windows Form Designer generated code

        private ShareX.HelpersLib.ObjectListView olvMain;
    }
}