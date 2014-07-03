namespace S1_WieleDoWielu_
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
            this.components = new System.ComponentModel.Container();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.ksiazkiDataSet = new S1_WieleDoWielu_.KsiazkiDataSet();
            this.autorzyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.autorzyTableAdapter = new S1_WieleDoWielu_.KsiazkiDataSetTableAdapters.AutorzyTableAdapter();
            this.ksiazkaAutorTableAdapter1 = new S1_WieleDoWielu_.KsiazkiDataSetTableAdapters.KsiazkaAutorTableAdapter();
            this.ksiazkiTableAdapter1 = new S1_WieleDoWielu_.KsiazkiDataSetTableAdapters.KsiazkiTableAdapter();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ksiazkiDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.autorzyBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox1.DataSource = this.autorzyBindingSource;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(25, 25);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(470, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.comboBox1.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.comboBox1_Format);
            // 
            // listBox1
            // 
            this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(25, 78);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(470, 303);
            this.listBox1.TabIndex = 1;
            // 
            // ksiazkiDataSet
            // 
            this.ksiazkiDataSet.DataSetName = "KsiazkiDataSet";
            this.ksiazkiDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // autorzyBindingSource
            // 
            this.autorzyBindingSource.DataMember = "Autorzy";
            this.autorzyBindingSource.DataSource = this.ksiazkiDataSet;
            // 
            // autorzyTableAdapter
            // 
            this.autorzyTableAdapter.ClearBeforeFill = true;
            // 
            // ksiazkaAutorTableAdapter1
            // 
            this.ksiazkaAutorTableAdapter1.ClearBeforeFill = true;
            // 
            // ksiazkiTableAdapter1
            // 
            this.ksiazkiTableAdapter1.ClearBeforeFill = true;
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.autorzyBindingSource, "Imie", true));
            this.textBox1.Location = new System.Drawing.Point(273, 52);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.autorzyBindingSource, "Nazwisko", true));
            this.textBox2.Location = new System.Drawing.Point(395, 52);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 403);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.comboBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ksiazkiDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.autorzyBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ListBox listBox1;
        private KsiazkiDataSet ksiazkiDataSet;
        private System.Windows.Forms.BindingSource autorzyBindingSource;
        private KsiazkiDataSetTableAdapters.AutorzyTableAdapter autorzyTableAdapter;
        private KsiazkiDataSetTableAdapters.KsiazkaAutorTableAdapter ksiazkaAutorTableAdapter1;
        private KsiazkiDataSetTableAdapters.KsiazkiTableAdapter ksiazkiTableAdapter1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
    }
}

