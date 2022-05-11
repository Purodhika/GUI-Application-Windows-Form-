using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Purodhika_GuiPremier
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
            this.pic = new System.Windows.Forms.PictureBox();
            this.labelName = new System.Windows.Forms.Label();
            this.labelLife = new System.Windows.Forms.Label();
            this.labelRule = new System.Windows.Forms.Label();
            this.lst = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).BeginInit();
            this.SuspendLayout();
            // 
            // pic
            // 
            this.pic.Location = new System.Drawing.Point(27, 55);
            this.pic.Name = "pic";
            this.pic.Size = new System.Drawing.Size(339, 263);
            this.pic.TabIndex = 0;
            this.pic.TabStop = false;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(23, 18);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(51, 20);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "label1";
            // 
            // labelLife
            // 
            this.labelLife.AutoSize = true;
            this.labelLife.Location = new System.Drawing.Point(23, 340);
            this.labelLife.Name = "labelLife";
            this.labelLife.Size = new System.Drawing.Size(51, 20);
            this.labelLife.TabIndex = 2;
            this.labelLife.Text = "label2";
            // 
            // labelRule
            // 
            this.labelRule.AutoSize = true;
            this.labelRule.Location = new System.Drawing.Point(23, 380);
            this.labelRule.Name = "labelRule";
            this.labelRule.Size = new System.Drawing.Size(51, 20);
            this.labelRule.TabIndex = 3;
            this.labelRule.Text = "label3";
            // 
            // lst
            // 
            this.lst.FormattingEnabled = true;
            this.lst.ItemHeight = 20;
            this.lst.Location = new System.Drawing.Point(550, 55);
            this.lst.Name = "lst";
            this.lst.Size = new System.Drawing.Size(178, 324);
            this.lst.TabIndex = 4;
            this.lst.SelectedIndexChanged += new System.EventHandler(this.lst_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lst);
            this.Controls.Add(this.labelRule);
            this.Controls.Add(this.labelLife);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.pic);
            this.Name = "Form1";
            this.Text = "Premier Form";
            //this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pic;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelLife;
        private System.Windows.Forms.Label labelRule;
        private System.Windows.Forms.ListBox lst;
    }
}

