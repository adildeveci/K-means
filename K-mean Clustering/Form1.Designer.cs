namespace K_mean_Clustering
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
            this.btnInitializeCluster = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txKumeSayisi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFindTheResult = new System.Windows.Forms.Button();
            this.btnInitializeClusterWithImproving = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColumnX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.txX = new System.Windows.Forms.TextBox();
            this.txY = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnEkle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnInitializeCluster
            // 
            this.btnInitializeCluster.Location = new System.Drawing.Point(849, 82);
            this.btnInitializeCluster.Name = "btnInitializeCluster";
            this.btnInitializeCluster.Size = new System.Drawing.Size(182, 23);
            this.btnInitializeCluster.TabIndex = 1;
            this.btnInitializeCluster.Text = "Başlangıç Kümesi Seç (Rasgele)";
            this.btnInitializeCluster.UseVisualStyleBackColor = true;
            this.btnInitializeCluster.Click += new System.EventHandler(this.btnInitializeCluster_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(233, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(611, 400);
            this.panel1.TabIndex = 2;
            this.panel1.Click += new System.EventHandler(this.panel1_Click);
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // txKumeSayisi
            // 
            this.txKumeSayisi.Location = new System.Drawing.Point(976, 13);
            this.txKumeSayisi.Name = "txKumeSayisi";
            this.txKumeSayisi.Size = new System.Drawing.Size(39, 20);
            this.txKumeSayisi.TabIndex = 8;
            this.txKumeSayisi.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txKumeSayisi.TextChanged += new System.EventHandler(this.txKumeSayisi_TextChanged);
            this.txKumeSayisi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txKumeSayisi_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(849, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Küme Sayısı";
            // 
            // btnFindTheResult
            // 
            this.btnFindTheResult.Location = new System.Drawing.Point(849, 363);
            this.btnFindTheResult.Name = "btnFindTheResult";
            this.btnFindTheResult.Size = new System.Drawing.Size(183, 23);
            this.btnFindTheResult.TabIndex = 10;
            this.btnFindTheResult.Text = "Küme Merkezlerini Bul";
            this.btnFindTheResult.UseVisualStyleBackColor = true;
            this.btnFindTheResult.Click += new System.EventHandler(this.btnFindTheResult_Click);
            // 
            // btnInitializeClusterWithImproving
            // 
            this.btnInitializeClusterWithImproving.Location = new System.Drawing.Point(850, 53);
            this.btnInitializeClusterWithImproving.Name = "btnInitializeClusterWithImproving";
            this.btnInitializeClusterWithImproving.Size = new System.Drawing.Size(182, 23);
            this.btnInitializeClusterWithImproving.TabIndex = 13;
            this.btnInitializeClusterWithImproving.Text = "Başlangıç Kümesi Seç";
            this.btnInitializeClusterWithImproving.UseVisualStyleBackColor = true;
            this.btnInitializeClusterWithImproving.Click += new System.EventHandler(this.btnInitializeClusterWithImproving_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowDrop = true;
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnX,
            this.ColumnY});
            this.dataGridView1.Location = new System.Drawing.Point(13, 53);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(214, 360);
            this.dataGridView1.TabIndex = 14;
            // 
            // ColumnX
            // 
            this.ColumnX.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnX.HeaderText = "X";
            this.ColumnX.Name = "ColumnX";
            this.ColumnX.ReadOnly = true;
            // 
            // ColumnY
            // 
            this.ColumnY.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnY.HeaderText = "Y";
            this.ColumnY.Name = "ColumnY";
            this.ColumnY.ReadOnly = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(849, 392);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(177, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "Restart";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txX
            // 
            this.txX.Location = new System.Drawing.Point(55, 27);
            this.txX.Name = "txX";
            this.txX.Size = new System.Drawing.Size(85, 20);
            this.txX.TabIndex = 16;
            this.txX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txX_KeyPress);
            // 
            // txY
            // 
            this.txY.Location = new System.Drawing.Point(146, 27);
            this.txY.Name = "txY";
            this.txY.Size = new System.Drawing.Size(81, 20);
            this.txY.TabIndex = 17;
            this.txY.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txY_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "X";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(143, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Y";
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(13, 24);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(36, 23);
            this.btnEkle.TabIndex = 20;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1052, 427);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txY);
            this.Controls.Add(this.txX);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnInitializeClusterWithImproving);
            this.Controls.Add(this.btnFindTheResult);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txKumeSayisi);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnInitializeCluster);
            this.Name = "Form1";
            this.Text = "K-Means";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInitializeCluster;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txKumeSayisi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFindTheResult;
        private System.Windows.Forms.Button btnInitializeClusterWithImproving;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnX;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnY;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txX;
        private System.Windows.Forms.TextBox txY;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnEkle;
    }
}

