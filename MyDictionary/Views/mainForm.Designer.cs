namespace MyDictionary.Views
{
    partial class mainForm
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panelTopMenu = new System.Windows.Forms.Panel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.lbLogo = new System.Windows.Forms.Label();
            this.lbTopMenuTool = new System.Windows.Forms.Label();
            this.lbSearch = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.btnChucNang4 = new System.Windows.Forms.Button();
            this.btnChucNang3 = new System.Windows.Forms.Button();
            this.btnChucNang2 = new System.Windows.Forms.Button();
            this.btnChucNang1 = new System.Windows.Forms.Button();
            this.panelMain = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panelTopMenu.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panelTopMenu, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1342, 639);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.tableLayoutPanel2.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.panelMain, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 66);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1336, 570);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // panelTopMenu
            // 
            this.panelTopMenu.Controls.Add(this.tableLayoutPanel3);
            this.panelTopMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTopMenu.Location = new System.Drawing.Point(3, 3);
            this.panelTopMenu.Name = "panelTopMenu";
            this.panelTopMenu.Size = new System.Drawing.Size(1336, 57);
            this.panelTopMenu.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.27273F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 63.63636F));
            this.tableLayoutPanel3.Controls.Add(this.lbLogo, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.lbTopMenuTool, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.lbSearch, 2, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1336, 57);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // lbLogo
            // 
            this.lbLogo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbLogo.AutoSize = true;
            this.lbLogo.Location = new System.Drawing.Point(3, 0);
            this.lbLogo.Name = "lbLogo";
            this.lbLogo.Size = new System.Drawing.Size(115, 57);
            this.lbLogo.TabIndex = 0;
            this.lbLogo.Text = "LogoHere";
            this.lbLogo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbLogo.Click += new System.EventHandler(this.lbLogo_Click);
            // 
            // lbTopMenuTool
            // 
            this.lbTopMenuTool.AutoSize = true;
            this.lbTopMenuTool.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbTopMenuTool.Location = new System.Drawing.Point(124, 0);
            this.lbTopMenuTool.Name = "lbTopMenuTool";
            this.lbTopMenuTool.Size = new System.Drawing.Size(358, 57);
            this.lbTopMenuTool.TabIndex = 1;
            this.lbTopMenuTool.Text = "TopMenuTool";
            this.lbTopMenuTool.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbSearch
            // 
            this.lbSearch.AutoSize = true;
            this.lbSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbSearch.Location = new System.Drawing.Point(488, 0);
            this.lbSearch.Name = "lbSearch";
            this.lbSearch.Size = new System.Drawing.Size(845, 57);
            this.lbSearch.TabIndex = 2;
            this.lbSearch.Text = "lbSearch";
            this.lbSearch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.tableLayoutPanel4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(194, 564);
            this.panel1.TabIndex = 0;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.btnChucNang4, 0, 3);
            this.tableLayoutPanel4.Controls.Add(this.btnChucNang3, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this.btnChucNang2, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.btnChucNang1, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 4;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(192, 169);
            this.tableLayoutPanel4.TabIndex = 2;
            // 
            // btnChucNang4
            // 
            this.btnChucNang4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnChucNang4.Location = new System.Drawing.Point(3, 129);
            this.btnChucNang4.Name = "btnChucNang4";
            this.btnChucNang4.Size = new System.Drawing.Size(186, 37);
            this.btnChucNang4.TabIndex = 3;
            this.btnChucNang4.Text = "Chức năng 4";
            this.btnChucNang4.UseVisualStyleBackColor = true;
            // 
            // btnChucNang3
            // 
            this.btnChucNang3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnChucNang3.Location = new System.Drawing.Point(3, 87);
            this.btnChucNang3.Name = "btnChucNang3";
            this.btnChucNang3.Size = new System.Drawing.Size(186, 36);
            this.btnChucNang3.TabIndex = 2;
            this.btnChucNang3.Text = "Chức năng 3";
            this.btnChucNang3.UseVisualStyleBackColor = true;
            // 
            // btnChucNang2
            // 
            this.btnChucNang2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnChucNang2.Location = new System.Drawing.Point(3, 45);
            this.btnChucNang2.Name = "btnChucNang2";
            this.btnChucNang2.Size = new System.Drawing.Size(186, 36);
            this.btnChucNang2.TabIndex = 1;
            this.btnChucNang2.Text = "Chức năng 2";
            this.btnChucNang2.UseVisualStyleBackColor = true;
            this.btnChucNang2.Click += new System.EventHandler(this.btnChucNang2_Click);
            // 
            // btnChucNang1
            // 
            this.btnChucNang1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnChucNang1.Location = new System.Drawing.Point(3, 3);
            this.btnChucNang1.Name = "btnChucNang1";
            this.btnChucNang1.Size = new System.Drawing.Size(186, 36);
            this.btnChucNang1.TabIndex = 0;
            this.btnChucNang1.Text = "Chức năng 1";
            this.btnChucNang1.UseVisualStyleBackColor = true;
            this.btnChucNang1.Click += new System.EventHandler(this.btnChucNang1_Click);
            // 
            // panelMain
            // 
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(203, 3);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1130, 564);
            this.panelMain.TabIndex = 1;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1342, 639);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "mainForm";
            this.Text = "mainForm";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panelTopMenu.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panelTopMenu;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label lbLogo;
        private System.Windows.Forms.Label lbTopMenuTool;
        private System.Windows.Forms.Label lbSearch;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button btnChucNang4;
        private System.Windows.Forms.Button btnChucNang3;
        private System.Windows.Forms.Button btnChucNang2;
        private System.Windows.Forms.Button btnChucNang1;
        private System.Windows.Forms.Panel panelMain;
    }
}