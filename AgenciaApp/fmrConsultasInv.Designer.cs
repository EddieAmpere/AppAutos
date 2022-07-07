
namespace AgenciaApp
{
    partial class fmrConsultasInv
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
            this.inventarioBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.aplicacioncarrosDataSet = new AgenciaApp.aplicacioncarrosDataSet();
            this.inventarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inventarioTableAdapter = new AgenciaApp.aplicacioncarrosDataSetTableAdapters.inventarioTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.aplicacioncarrosDataSet1 = new AgenciaApp.aplicacioncarrosDataSet1();
            this.vConsultaInventarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.v_ConsultaInventarioTableAdapter = new AgenciaApp.aplicacioncarrosDataSet1TableAdapters.V_ConsultaInventarioTableAdapter();
            this.aplicacioncarrosDataSet2 = new AgenciaApp.aplicacioncarrosDataSet2();
            this.vConsultaInventarioBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.v_ConsultaInventarioTableAdapter1 = new AgenciaApp.aplicacioncarrosDataSet2TableAdapters.V_ConsultaInventarioTableAdapter();
            this.marcaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modeloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.añoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kilometrajeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transmisiónDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventarioBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aplicacioncarrosDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aplicacioncarrosDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vConsultaInventarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aplicacioncarrosDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vConsultaInventarioBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.marcaDataGridViewTextBoxColumn,
            this.modeloDataGridViewTextBoxColumn,
            this.colorDataGridViewTextBoxColumn,
            this.añoDataGridViewTextBoxColumn,
            this.precioDataGridViewTextBoxColumn,
            this.kilometrajeDataGridViewTextBoxColumn,
            this.transmisiónDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.vConsultaInventarioBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(28, 82);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(955, 289);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // inventarioBindingSource1
            // 
            this.inventarioBindingSource1.DataMember = "inventario";
            this.inventarioBindingSource1.DataSource = this.aplicacioncarrosDataSet;
            // 
            // aplicacioncarrosDataSet
            // 
            this.aplicacioncarrosDataSet.DataSetName = "aplicacioncarrosDataSet";
            this.aplicacioncarrosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // inventarioBindingSource
            // 
            this.inventarioBindingSource.DataMember = "inventario";
            this.inventarioBindingSource.DataSource = this.aplicacioncarrosDataSet;
            // 
            // inventarioTableAdapter
            // 
            this.inventarioTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(28, 23);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 31);
            this.button1.TabIndex = 1;
            this.button1.Text = "Regresar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // aplicacioncarrosDataSet1
            // 
            this.aplicacioncarrosDataSet1.DataSetName = "aplicacioncarrosDataSet1";
            this.aplicacioncarrosDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vConsultaInventarioBindingSource
            // 
            this.vConsultaInventarioBindingSource.DataMember = "V_ConsultaInventario";
            this.vConsultaInventarioBindingSource.DataSource = this.aplicacioncarrosDataSet1;
            // 
            // v_ConsultaInventarioTableAdapter
            // 
            this.v_ConsultaInventarioTableAdapter.ClearBeforeFill = true;
            // 
            // aplicacioncarrosDataSet2
            // 
            this.aplicacioncarrosDataSet2.DataSetName = "aplicacioncarrosDataSet2";
            this.aplicacioncarrosDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vConsultaInventarioBindingSource1
            // 
            this.vConsultaInventarioBindingSource1.DataMember = "V_ConsultaInventario";
            this.vConsultaInventarioBindingSource1.DataSource = this.aplicacioncarrosDataSet2;
            // 
            // v_ConsultaInventarioTableAdapter1
            // 
            this.v_ConsultaInventarioTableAdapter1.ClearBeforeFill = true;
            // 
            // marcaDataGridViewTextBoxColumn
            // 
            this.marcaDataGridViewTextBoxColumn.DataPropertyName = "Marca";
            this.marcaDataGridViewTextBoxColumn.HeaderText = "Marca";
            this.marcaDataGridViewTextBoxColumn.Name = "marcaDataGridViewTextBoxColumn";
            // 
            // modeloDataGridViewTextBoxColumn
            // 
            this.modeloDataGridViewTextBoxColumn.DataPropertyName = "Modelo";
            this.modeloDataGridViewTextBoxColumn.HeaderText = "Modelo";
            this.modeloDataGridViewTextBoxColumn.Name = "modeloDataGridViewTextBoxColumn";
            // 
            // colorDataGridViewTextBoxColumn
            // 
            this.colorDataGridViewTextBoxColumn.DataPropertyName = "Color";
            this.colorDataGridViewTextBoxColumn.HeaderText = "Color";
            this.colorDataGridViewTextBoxColumn.Name = "colorDataGridViewTextBoxColumn";
            // 
            // añoDataGridViewTextBoxColumn
            // 
            this.añoDataGridViewTextBoxColumn.DataPropertyName = "Año";
            this.añoDataGridViewTextBoxColumn.HeaderText = "Año";
            this.añoDataGridViewTextBoxColumn.Name = "añoDataGridViewTextBoxColumn";
            // 
            // precioDataGridViewTextBoxColumn
            // 
            this.precioDataGridViewTextBoxColumn.DataPropertyName = "Precio";
            this.precioDataGridViewTextBoxColumn.HeaderText = "Precio";
            this.precioDataGridViewTextBoxColumn.Name = "precioDataGridViewTextBoxColumn";
            // 
            // kilometrajeDataGridViewTextBoxColumn
            // 
            this.kilometrajeDataGridViewTextBoxColumn.DataPropertyName = "Kilometraje";
            this.kilometrajeDataGridViewTextBoxColumn.HeaderText = "Kilometraje";
            this.kilometrajeDataGridViewTextBoxColumn.Name = "kilometrajeDataGridViewTextBoxColumn";
            // 
            // transmisiónDataGridViewTextBoxColumn
            // 
            this.transmisiónDataGridViewTextBoxColumn.DataPropertyName = "Transmisión";
            this.transmisiónDataGridViewTextBoxColumn.HeaderText = "Transmisión";
            this.transmisiónDataGridViewTextBoxColumn.Name = "transmisiónDataGridViewTextBoxColumn";
            // 
            // fmrConsultasInv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 442);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "fmrConsultasInv";
            this.Text = "fmrConsultasInv";
            this.Load += new System.EventHandler(this.fmrConsultasInv_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventarioBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aplicacioncarrosDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aplicacioncarrosDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vConsultaInventarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aplicacioncarrosDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vConsultaInventarioBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private aplicacioncarrosDataSet aplicacioncarrosDataSet;
        private System.Windows.Forms.BindingSource inventarioBindingSource;
        private aplicacioncarrosDataSetTableAdapters.inventarioTableAdapter inventarioTableAdapter;
        private System.Windows.Forms.BindingSource inventarioBindingSource1;
        private System.Windows.Forms.Button button1;
        private aplicacioncarrosDataSet1 aplicacioncarrosDataSet1;
        private System.Windows.Forms.BindingSource vConsultaInventarioBindingSource;
        private aplicacioncarrosDataSet1TableAdapters.V_ConsultaInventarioTableAdapter v_ConsultaInventarioTableAdapter;
        private aplicacioncarrosDataSet2 aplicacioncarrosDataSet2;
        private System.Windows.Forms.BindingSource vConsultaInventarioBindingSource1;
        private aplicacioncarrosDataSet2TableAdapters.V_ConsultaInventarioTableAdapter v_ConsultaInventarioTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn marcaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modeloDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn añoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kilometrajeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn transmisiónDataGridViewTextBoxColumn;
    }
}