﻿using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace PolicyPlus
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class OpenSection : Form
    {

        // Form overrides dispose to clean up the component list.
        [DebuggerNonUserCode()]
        protected override void Dispose(bool disposing)
        {
            try
            {
                if (disposing && components is object)
                {
                    components.Dispose();
                }
            }
            finally
            {
                base.Dispose(disposing);
            }
        }

        // Required by the Windows Form Designer
        private System.ComponentModel.IContainer components;

        // NOTE: The following procedure is required by the Windows Form Designer
        // It can be modified using the Windows Form Designer.  
        // Do not modify it using the code editor.
        [DebuggerStepThrough()]
        private void InitializeComponent()
        {
            this.OptUser = new System.Windows.Forms.RadioButton();
            this.OptComputer = new System.Windows.Forms.RadioButton();
            this.ButtonOK = new System.Windows.Forms.Button();
            this.ButtonCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // OptUser
            // 
            this.OptUser.AutoSize = true;
            this.OptUser.Checked = true;
            this.OptUser.Location = new System.Drawing.Point(16, 14);
            this.OptUser.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.OptUser.Name = "OptUser";
            this.OptUser.Size = new System.Drawing.Size(58, 19);
            this.OptUser.TabIndex = 0;
            this.OptUser.TabStop = true;
            this.OptUser.Text = "User";
            this.OptUser.UseVisualStyleBackColor = true;
            // 
            // OptComputer
            // 
            this.OptComputer.AutoSize = true;
            this.OptComputer.Location = new System.Drawing.Point(16, 40);
            this.OptComputer.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.OptComputer.Name = "OptComputer";
            this.OptComputer.Size = new System.Drawing.Size(90, 19);
            this.OptComputer.TabIndex = 1;
            this.OptComputer.Text = "Computer";
            this.OptComputer.UseVisualStyleBackColor = true;
            // 
            // ButtonOK
            // 
            this.ButtonOK.Location = new System.Drawing.Point(96, 67);
            this.ButtonOK.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ButtonOK.Name = "ButtonOK";
            this.ButtonOK.Size = new System.Drawing.Size(104, 27);
            this.ButtonOK.TabIndex = 2;
            this.ButtonOK.Text = "OK";
            this.ButtonOK.UseVisualStyleBackColor = true;
            this.ButtonOK.Click += new System.EventHandler(this.ButtonOK_Click);
            // 
            // ButtonCancel
            // 
            this.ButtonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ButtonCancel.Location = new System.Drawing.Point(16, 67);
            this.ButtonCancel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.Size = new System.Drawing.Size(72, 27);
            this.ButtonCancel.TabIndex = 3;
            this.ButtonCancel.Text = "Cancel";
            this.ButtonCancel.UseVisualStyleBackColor = true;
            // 
            // OpenSection
            // 
            this.AcceptButton = this.ButtonOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.ButtonCancel;
            this.ClientSize = new System.Drawing.Size(216, 105);
            this.Controls.Add(this.ButtonCancel);
            this.Controls.Add(this.ButtonOK);
            this.Controls.Add(this.OptComputer);
            this.Controls.Add(this.OptUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OpenSection";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Select Section";
            this.Shown += new System.EventHandler(this.OpenSection_Shown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OpenSection_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        internal RadioButton OptUser;
        internal RadioButton OptComputer;
        internal Button ButtonOK;
        internal Button ButtonCancel;
    }
}