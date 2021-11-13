
namespace Materials
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtNameBuilding = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCostumer = new System.Windows.Forms.TextBox();
            this.txtPrefix = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.listBoxBuilding = new System.Windows.Forms.ListBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.txtPartNumber = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.listBoxCostumers = new System.Windows.Forms.ListBox();
            this.btnAgregarPart = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.checkBoxAvailable = new System.Windows.Forms.CheckBox();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 322);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(250, 269);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // txtNameBuilding
            // 
            this.txtNameBuilding.Location = new System.Drawing.Point(12, 81);
            this.txtNameBuilding.Name = "txtNameBuilding";
            this.txtNameBuilding.Size = new System.Drawing.Size(250, 25);
            this.txtNameBuilding.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Building name:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(498, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 41);
            this.label2.TabIndex = 3;
            this.label2.Text = "Buildings";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(101, 148);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 26);
            this.btnAgregar.TabIndex = 4;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(301, 322);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 25;
            this.dataGridView2.Size = new System.Drawing.Size(452, 269);
            this.dataGridView2.TabIndex = 5;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(301, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "Prefix:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(301, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 19);
            this.label4.TabIndex = 7;
            this.label4.Text = "Costumer name:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtCostumer
            // 
            this.txtCostumer.Location = new System.Drawing.Point(301, 81);
            this.txtCostumer.Name = "txtCostumer";
            this.txtCostumer.Size = new System.Drawing.Size(452, 25);
            this.txtCostumer.TabIndex = 8;
            // 
            // txtPrefix
            // 
            this.txtPrefix.Location = new System.Drawing.Point(301, 131);
            this.txtPrefix.Name = "txtPrefix";
            this.txtPrefix.Size = new System.Drawing.Size(452, 25);
            this.txtPrefix.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(301, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 19);
            this.label5.TabIndex = 10;
            this.label5.Text = "Building:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(498, 259);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 27);
            this.button2.TabIndex = 12;
            this.button2.Text = "Agregar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // listBoxBuilding
            // 
            this.listBoxBuilding.FormattingEnabled = true;
            this.listBoxBuilding.ItemHeight = 17;
            this.listBoxBuilding.Location = new System.Drawing.Point(301, 181);
            this.listBoxBuilding.Name = "listBoxBuilding";
            this.listBoxBuilding.Size = new System.Drawing.Size(452, 72);
            this.listBoxBuilding.TabIndex = 13;
            this.listBoxBuilding.SelectedIndexChanged += new System.EventHandler(this.listBoxBuilding_SelectedIndexChanged);
            // 
            // txtPartNumber
            // 
            this.txtPartNumber.Location = new System.Drawing.Point(797, 81);
            this.txtPartNumber.Name = "txtPartNumber";
            this.txtPartNumber.Size = new System.Drawing.Size(370, 25);
            this.txtPartNumber.TabIndex = 14;
            this.txtPartNumber.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(797, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 19);
            this.label6.TabIndex = 15;
            this.label6.Text = "Part number:";
            // 
            // listBoxCostumers
            // 
            this.listBoxCostumers.FormattingEnabled = true;
            this.listBoxCostumers.ItemHeight = 17;
            this.listBoxCostumers.Location = new System.Drawing.Point(797, 181);
            this.listBoxCostumers.Name = "listBoxCostumers";
            this.listBoxCostumers.Size = new System.Drawing.Size(370, 72);
            this.listBoxCostumers.TabIndex = 16;
            this.listBoxCostumers.SelectedIndexChanged += new System.EventHandler(this.listBoxPartNumber_SelectedIndexChanged);
            // 
            // btnAgregarPart
            // 
            this.btnAgregarPart.Location = new System.Drawing.Point(968, 259);
            this.btnAgregarPart.Name = "btnAgregarPart";
            this.btnAgregarPart.Size = new System.Drawing.Size(75, 33);
            this.btnAgregarPart.TabIndex = 17;
            this.btnAgregarPart.Text = "Agregar";
            this.btnAgregarPart.UseVisualStyleBackColor = true;
            this.btnAgregarPart.Click += new System.EventHandler(this.btnAgregarPart_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(797, 159);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 19);
            this.label8.TabIndex = 19;
            this.label8.Text = "Customer:";
            // 
            // checkBoxAvailable
            // 
            this.checkBoxAvailable.AutoSize = true;
            this.checkBoxAvailable.Location = new System.Drawing.Point(797, 131);
            this.checkBoxAvailable.Name = "checkBoxAvailable";
            this.checkBoxAvailable.Size = new System.Drawing.Size(82, 23);
            this.checkBoxAvailable.TabIndex = 20;
            this.checkBoxAvailable.Text = "Available";
            this.checkBoxAvailable.UseVisualStyleBackColor = true;
            this.checkBoxAvailable.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(797, 322);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowTemplate.Height = 25;
            this.dataGridView3.Size = new System.Drawing.Size(370, 269);
            this.dataGridView3.TabIndex = 22;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1179, 604);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.checkBoxAvailable);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnAgregarPart);
            this.Controls.Add(this.listBoxCostumers);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtPartNumber);
            this.Controls.Add(this.listBoxBuilding);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPrefix);
            this.Controls.Add(this.txtCostumer);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNameBuilding);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtNameBuilding;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCostumer;
        private System.Windows.Forms.TextBox txtPrefix;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox listBoxBuilding;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.TextBox txtPartNumber;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox listBoxCostumers;
        private System.Windows.Forms.Button btnAgregarPart;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox checkBoxAvailable;
        private System.Windows.Forms.DataGridView dataGridView3;
    }
}

