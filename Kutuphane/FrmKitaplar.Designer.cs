
namespace Kutuphane
{
    partial class FrmKitaplar
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ıDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kITAPADDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kITAPYAZARDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tURUDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sAYFADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tBLKITAPLARBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kutuphaneDataSet = new Kutuphane.KutuphaneDataSet();
            this.tBL_KITAPLARTableAdapter = new Kutuphane.KutuphaneDataSetTableAdapters.TBL_KITAPLARTableAdapter();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLKITAPLARBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kutuphaneDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ıDDataGridViewTextBoxColumn,
            this.kITAPADDataGridViewTextBoxColumn,
            this.kITAPYAZARDataGridViewTextBoxColumn,
            this.tURUDataGridViewTextBoxColumn,
            this.sAYFADataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tBLKITAPLARBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 95);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(874, 343);
            this.dataGridView1.TabIndex = 0;
            // 
            // ıDDataGridViewTextBoxColumn
            // 
            this.ıDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.ıDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.ıDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ıDDataGridViewTextBoxColumn.Name = "ıDDataGridViewTextBoxColumn";
            this.ıDDataGridViewTextBoxColumn.Width = 125;
            // 
            // kITAPADDataGridViewTextBoxColumn
            // 
            this.kITAPADDataGridViewTextBoxColumn.DataPropertyName = "KITAPAD";
            this.kITAPADDataGridViewTextBoxColumn.HeaderText = "KITAPAD";
            this.kITAPADDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kITAPADDataGridViewTextBoxColumn.Name = "kITAPADDataGridViewTextBoxColumn";
            this.kITAPADDataGridViewTextBoxColumn.Width = 125;
            // 
            // kITAPYAZARDataGridViewTextBoxColumn
            // 
            this.kITAPYAZARDataGridViewTextBoxColumn.DataPropertyName = "KITAPYAZAR";
            this.kITAPYAZARDataGridViewTextBoxColumn.HeaderText = "KITAPYAZAR";
            this.kITAPYAZARDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kITAPYAZARDataGridViewTextBoxColumn.Name = "kITAPYAZARDataGridViewTextBoxColumn";
            this.kITAPYAZARDataGridViewTextBoxColumn.Width = 125;
            // 
            // tURUDataGridViewTextBoxColumn
            // 
            this.tURUDataGridViewTextBoxColumn.DataPropertyName = "TURU";
            this.tURUDataGridViewTextBoxColumn.HeaderText = "TURU";
            this.tURUDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tURUDataGridViewTextBoxColumn.Name = "tURUDataGridViewTextBoxColumn";
            this.tURUDataGridViewTextBoxColumn.Width = 125;
            // 
            // sAYFADataGridViewTextBoxColumn
            // 
            this.sAYFADataGridViewTextBoxColumn.DataPropertyName = "SAYFA";
            this.sAYFADataGridViewTextBoxColumn.HeaderText = "SAYFA";
            this.sAYFADataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sAYFADataGridViewTextBoxColumn.Name = "sAYFADataGridViewTextBoxColumn";
            this.sAYFADataGridViewTextBoxColumn.Width = 125;
            // 
            // tBLKITAPLARBindingSource
            // 
            this.tBLKITAPLARBindingSource.DataMember = "TBL_KITAPLAR";
            this.tBLKITAPLARBindingSource.DataSource = this.kutuphaneDataSet;
            // 
            // kutuphaneDataSet
            // 
            this.kutuphaneDataSet.DataSetName = "KutuphaneDataSet";
            this.kutuphaneDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tBL_KITAPLARTableAdapter
            // 
            this.tBL_KITAPLARTableAdapter.ClearBeforeFill = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(12, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 37);
            this.label6.TabIndex = 16;
            this.label6.Text = "Kitaplar";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Kutuphane.Properties.Resources.book;
            this.pictureBox1.Location = new System.Drawing.Point(145, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(117, 58);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // FrmKitaplar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dataGridView1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmKitaplar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmKitaplar";
            this.Load += new System.EventHandler(this.FrmKitaplar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLKITAPLARBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kutuphaneDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private KutuphaneDataSet kutuphaneDataSet;
        private System.Windows.Forms.BindingSource tBLKITAPLARBindingSource;
        private KutuphaneDataSetTableAdapters.TBL_KITAPLARTableAdapter tBL_KITAPLARTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kITAPADDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kITAPYAZARDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tURUDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sAYFADataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}