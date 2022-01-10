
namespace meres_220110
{
    partial class FrmMain
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
            this.dgv = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.keretosszeg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.szamlakszama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.szamlakosszege = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.btn_New = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.AllowUserToResizeColumns = false;
            this.dgv.AllowUserToResizeRows = false;
            this.dgv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.keretosszeg,
            this.szamlakszama,
            this.szamlakosszege});
            this.dgv.Location = new System.Drawing.Point(89, 37);
            this.dgv.MultiSelect = false;
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersVisible = false;
            this.dgv.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(608, 280);
            this.dgv.TabIndex = 0;
            // 
            // ID
            // 
            this.ID.FillWeight = 10F;
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // keretosszeg
            // 
            this.keretosszeg.FillWeight = 30F;
            this.keretosszeg.HeaderText = "keretösszeg";
            this.keretosszeg.Name = "keretosszeg";
            this.keretosszeg.ReadOnly = true;
            // 
            // szamlakszama
            // 
            this.szamlakszama.FillWeight = 30F;
            this.szamlakszama.HeaderText = "Számlák száma";
            this.szamlakszama.Name = "szamlakszama";
            this.szamlakszama.ReadOnly = true;
            // 
            // szamlakosszege
            // 
            this.szamlakosszege.FillWeight = 30F;
            this.szamlakosszege.HeaderText = "számlák összege";
            this.szamlakosszege.Name = "szamlakosszege";
            this.szamlakosszege.ReadOnly = true;
            // 
            // btn_Exit
            // 
            this.btn_Exit.Location = new System.Drawing.Point(424, 347);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(273, 78);
            this.btn_Exit.TabIndex = 2;
            this.btn_Exit.Text = "Kilépés";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // btn_New
            // 
            this.btn_New.Location = new System.Drawing.Point(89, 347);
            this.btn_New.Name = "btn_New";
            this.btn_New.Size = new System.Drawing.Size(273, 78);
            this.btn_New.TabIndex = 3;
            this.btn_New.Text = "új pályázat";
            this.btn_New.UseVisualStyleBackColor = true;
            this.btn_New.Click += new System.EventHandler(this.btn_New_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_New);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.dgv);
            this.Name = "Form1";
            this.Text = "Pályázatok állapota";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Button btn_New;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn keretosszeg;
        private System.Windows.Forms.DataGridViewTextBoxColumn szamlakszama;
        private System.Windows.Forms.DataGridViewTextBoxColumn szamlakosszege;
    }
}

