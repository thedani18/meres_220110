﻿
namespace meres_220110
{
    partial class FrmNew
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
            this.label1 = new System.Windows.Forms.Label();
            this.tb_id = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_Akeret = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_Ckeret = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_new = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 67);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            // 
            // tb_id
            // 
            this.tb_id.Location = new System.Drawing.Point(71, 64);
            this.tb_id.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tb_id.Name = "tb_id";
            this.tb_id.ReadOnly = true;
            this.tb_id.Size = new System.Drawing.Size(72, 29);
            this.tb_id.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(219, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "\"A\" kategóriás értékkeret:";
            // 
            // tb_Akeret
            // 
            this.tb_Akeret.Location = new System.Drawing.Point(31, 159);
            this.tb_Akeret.Name = "tb_Akeret";
            this.tb_Akeret.Size = new System.Drawing.Size(219, 29);
            this.tb_Akeret.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(256, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "HUF";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(256, 244);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 24);
            this.label4.TabIndex = 7;
            this.label4.Text = "HUF";
            // 
            // tb_Ckeret
            // 
            this.tb_Ckeret.Location = new System.Drawing.Point(31, 241);
            this.tb_Ckeret.Name = "tb_Ckeret";
            this.tb_Ckeret.Size = new System.Drawing.Size(219, 29);
            this.tb_Ckeret.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 213);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(219, 24);
            this.label5.TabIndex = 5;
            this.label5.Text = "\"C\" kategóriás értékkeret:";
            // 
            // btn_new
            // 
            this.btn_new.Location = new System.Drawing.Point(13, 303);
            this.btn_new.Name = "btn_new";
            this.btn_new.Size = new System.Drawing.Size(323, 81);
            this.btn_new.TabIndex = 8;
            this.btn_new.Text = "új pályázat hírdetése";
            this.btn_new.UseVisualStyleBackColor = true;
            this.btn_new.Click += new System.EventHandler(this.btn_new_Click);
            // 
            // FrmNew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 415);
            this.Controls.Add(this.btn_new);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_Ckeret);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_Akeret);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_id);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "FrmNew";
            this.Text = "FrmNew";
            this.Load += new System.EventHandler(this.FrmNew_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_id;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_Akeret;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_Ckeret;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_new;
    }
}