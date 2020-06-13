namespace FinalProject
{
    partial class Comments
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Comments));
            this.label1 = new System.Windows.Forms.Label();
            this.comTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.finalprojectDataSet = new FinalProject.finalprojectDataSet();
            this.comTableTableAdapter = new FinalProject.finalprojectDataSetTableAdapters.ComTableTableAdapter();
            this.comTableBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.finalprojectDataSet1 = new FinalProject.finalprojectDataSet1();
            this.comTableBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.comTableTableAdapter1 = new FinalProject.finalprojectDataSet1TableAdapters.ComTableTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.comTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.finalprojectDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comTableBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.finalprojectDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comTableBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(21, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(669, 38);
            this.label1.TabIndex = 3;
            this.label1.Text = "Here you can view users and their posted comments";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // comTableBindingSource
            // 
            this.comTableBindingSource.DataMember = "ComTable";
            this.comTableBindingSource.DataSource = this.finalprojectDataSet;
            // 
            // finalprojectDataSet
            // 
            this.finalprojectDataSet.DataSetName = "finalprojectDataSet";
            this.finalprojectDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comTableTableAdapter
            // 
            this.comTableTableAdapter.ClearBeforeFill = true;
            // 
            // comTableBindingSource1
            // 
            this.comTableBindingSource1.DataMember = "ComTable";
            this.comTableBindingSource1.DataSource = this.finalprojectDataSet;
            // 
            // finalprojectDataSet1
            // 
            this.finalprojectDataSet1.DataSetName = "finalprojectDataSet1";
            this.finalprojectDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comTableBindingSource2
            // 
            this.comTableBindingSource2.DataMember = "ComTable";
            this.comTableBindingSource2.DataSource = this.finalprojectDataSet1;
            // 
            // comTableTableAdapter1
            // 
            this.comTableTableAdapter1.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.DeepSkyBlue;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 92);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(404, 399);
            this.dataGridView1.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::FinalProject.Properties.Resources.avatar;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Location = new System.Drawing.Point(425, 92);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(265, 249);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = global::FinalProject.Properties.Resources.Clear;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Location = new System.Drawing.Point(578, 389);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 93);
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click_1);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BackgroundImage = global::FinalProject.Properties.Resources.comments;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Location = new System.Drawing.Point(451, 389);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(100, 93);
            this.pictureBox3.TabIndex = 7;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // Comments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FinalProject.Properties.Resources.bg;
            this.ClientSize = new System.Drawing.Size(690, 503);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Comments";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Comments";
            this.Load += new System.EventHandler(this.Comments_Load);
            ((System.ComponentModel.ISupportInitialize)(this.comTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.finalprojectDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comTableBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.finalprojectDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comTableBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private finalprojectDataSet finalprojectDataSet;
        private System.Windows.Forms.BindingSource comTableBindingSource;
        private finalprojectDataSetTableAdapters.ComTableTableAdapter comTableTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource comTableBindingSource1;
        private finalprojectDataSet1 finalprojectDataSet1;
        private System.Windows.Forms.BindingSource comTableBindingSource2;
        private finalprojectDataSet1TableAdapters.ComTableTableAdapter comTableTableAdapter1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;

    }
}