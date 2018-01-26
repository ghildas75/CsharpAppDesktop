namespace tpCargaison
{
    partial class CargaisonForm
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
            this.textBoxDistance = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.listBoxCargaison = new System.Windows.Forms.ListBox();
            this.btnAddCargaison = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxPoids = new System.Windows.Forms.TextBox();
            this.textBoxVolume = new System.Windows.Forms.TextBox();
            this.btnAddMarchandise = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Poids = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Volume = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxCout = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "distance";
            // 
            // textBoxDistance
            // 
            this.textBoxDistance.Location = new System.Drawing.Point(94, 24);
            this.textBoxDistance.Name = "textBoxDistance";
            this.textBoxDistance.Size = new System.Drawing.Size(100, 20);
            this.textBoxDistance.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "type";
            // 
            // comboBoxType
            // 
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Items.AddRange(new object[] {
            "Routiere",
            "Aerienne"});
            this.comboBoxType.Location = new System.Drawing.Point(94, 66);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(100, 21);
            this.comboBoxType.TabIndex = 4;
            // 
            // listBoxCargaison
            // 
            this.listBoxCargaison.FormattingEnabled = true;
            this.listBoxCargaison.Location = new System.Drawing.Point(5, 101);
            this.listBoxCargaison.Name = "listBoxCargaison";
            this.listBoxCargaison.Size = new System.Drawing.Size(236, 147);
            this.listBoxCargaison.TabIndex = 5;
            this.listBoxCargaison.SelectedIndexChanged += new System.EventHandler(this.listBoxCargaison_SelectedIndexChanged);
            // 
            // btnAddCargaison
            // 
            this.btnAddCargaison.Location = new System.Drawing.Point(200, 64);
            this.btnAddCargaison.Name = "btnAddCargaison";
            this.btnAddCargaison.Size = new System.Drawing.Size(75, 23);
            this.btnAddCargaison.TabIndex = 6;
            this.btnAddCargaison.Text = "Add";
            this.btnAddCargaison.UseVisualStyleBackColor = true;
            this.btnAddCargaison.Click += new System.EventHandler(this.btnAddCargaison_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(425, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Volime";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(339, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Poids";
            // 
            // textBoxPoids
            // 
            this.textBoxPoids.Location = new System.Drawing.Point(319, 47);
            this.textBoxPoids.Name = "textBoxPoids";
            this.textBoxPoids.Size = new System.Drawing.Size(100, 20);
            this.textBoxPoids.TabIndex = 9;
            // 
            // textBoxVolume
            // 
            this.textBoxVolume.Location = new System.Drawing.Point(428, 47);
            this.textBoxVolume.Name = "textBoxVolume";
            this.textBoxVolume.Size = new System.Drawing.Size(100, 20);
            this.textBoxVolume.TabIndex = 10;
            // 
            // btnAddMarchandise
            // 
            this.btnAddMarchandise.Location = new System.Drawing.Point(562, 47);
            this.btnAddMarchandise.Name = "btnAddMarchandise";
            this.btnAddMarchandise.Size = new System.Drawing.Size(75, 23);
            this.btnAddMarchandise.TabIndex = 11;
            this.btnAddMarchandise.Text = "Add";
            this.btnAddMarchandise.UseVisualStyleBackColor = true;
            this.btnAddMarchandise.Click += new System.EventHandler(this.btnAddMarchandise_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Numero,
            this.Poids,
            this.Volume});
            this.dataGridView1.Location = new System.Drawing.Point(329, 101);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(308, 150);
            this.dataGridView1.TabIndex = 12;
            // 
            // Numero
            // 
            this.Numero.HeaderText = "Numero";
            this.Numero.Name = "Numero";
            // 
            // Poids
            // 
            this.Poids.HeaderText = "Poids";
            this.Poids.Name = "Poids";
            // 
            // Volume
            // 
            this.Volume.HeaderText = "Volume";
            this.Volume.Name = "Volume";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(91, 266);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "coutTotal";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // textBoxCout
            // 
            this.textBoxCout.Enabled = false;
            this.textBoxCout.Location = new System.Drawing.Point(166, 258);
            this.textBoxCout.Name = "textBoxCout";
            this.textBoxCout.Size = new System.Drawing.Size(100, 20);
            this.textBoxCout.TabIndex = 14;
            // 
            // CargaisonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 288);
            this.Controls.Add(this.textBoxCout);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnAddMarchandise);
            this.Controls.Add(this.textBoxVolume);
            this.Controls.Add(this.textBoxPoids);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnAddCargaison);
            this.Controls.Add(this.listBoxCargaison);
            this.Controls.Add(this.comboBoxType);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxDistance);
            this.Controls.Add(this.label1);
            this.Name = "CargaisonForm";
            this.Text = "CargaisonForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxDistance;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.ListBox listBoxCargaison;
        private System.Windows.Forms.Button btnAddCargaison;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxPoids;
        private System.Windows.Forms.TextBox textBoxVolume;
        private System.Windows.Forms.Button btnAddMarchandise;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn Poids;
        private System.Windows.Forms.DataGridViewTextBoxColumn Volume;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxCout;
    }
}