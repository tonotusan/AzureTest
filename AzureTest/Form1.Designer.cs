namespace AzureTest
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.oo_AtClippingDataSet = new AzureTest.oo_AtClippingDataSet();
            this.torderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.t_orderTableAdapter = new AzureTest.oo_AtClippingDataSetTableAdapters.t_orderTableAdapter();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.oo_AtClippingDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.torderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 21;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1180, 300);
            this.dataGridView1.TabIndex = 0;
            // 
            // splitter1
            // 
            this.splitter1.BackColor = System.Drawing.Color.LightPink;
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter1.Location = new System.Drawing.Point(0, 300);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(1180, 5);
            this.splitter1.TabIndex = 44;
            this.splitter1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.button7);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 605);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1180, 89);
            this.panel1.TabIndex = 48;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label5.ForeColor = System.Drawing.Color.Brown;
            this.label5.Location = new System.Drawing.Point(961, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(188, 15);
            this.label5.TabIndex = 13;
            this.label5.Text = "label5";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(880, 35);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 12;
            this.button6.Text = "azure out";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.ForeColor = System.Drawing.Color.Brown;
            this.label4.Location = new System.Drawing.Point(961, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(188, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "label4";
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(880, 6);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 10;
            this.button7.Text = "azure in";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.ForeColor = System.Drawing.Color.Brown;
            this.label3.Location = new System.Drawing.Point(656, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(188, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "label3";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(575, 35);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 8;
            this.button5.Text = "local out";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.ForeColor = System.Drawing.Color.Brown;
            this.label2.Location = new System.Drawing.Point(656, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "label2";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(575, 6);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 6;
            this.button4.Text = "local in";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.ForeColor = System.Drawing.Color.Brown;
            this.label1.Location = new System.Drawing.Point(347, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "label1";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(210, 6);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(124, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "Table Insert";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(108, 6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // oo_AtClippingDataSet
            // 
            this.oo_AtClippingDataSet.DataSetName = "oo_AtClippingDataSet";
            this.oo_AtClippingDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // torderBindingSource
            // 
            this.torderBindingSource.DataMember = "t_order";
            this.torderBindingSource.DataSource = this.oo_AtClippingDataSet;
            // 
            // t_orderTableAdapter
            // 
            this.t_orderTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(0, 305);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 21;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(1180, 300);
            this.dataGridView2.TabIndex = 49;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1180, 694);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.oo_AtClippingDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.torderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private oo_AtClippingDataSet oo_AtClippingDataSet;
        private System.Windows.Forms.BindingSource torderBindingSource;
        private oo_AtClippingDataSetTableAdapters.t_orderTableAdapter t_orderTableAdapter;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button7;
    }
}

