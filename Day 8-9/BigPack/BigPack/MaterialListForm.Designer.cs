
namespace BigPack
{
    partial class MaterialListForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MaterialListForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.LogoPictureBox = new System.Windows.Forms.PictureBox();
            this.SortComboBox = new System.Windows.Forms.ComboBox();
            this.FilterComboBox = new System.Windows.Forms.ComboBox();
            this.MaterialTypesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.materialTypes_24ip192DataSet = new BigPack.MaterialTypes_24ip192DataSet();
            this._24ip192DataSet = new BigPack._24ip192DataSet();
            this.SearchLabel = new System.Windows.Forms.Label();
            this.SortLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.MaterialListDataGridView = new System.Windows.Forms.DataGridView();
            this.ip192DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.materialTableAdapter = new BigPack._24ip192DataSetTableAdapters.MaterialTableAdapter();
            this.materialTableAdapter1 = new BigPack.MaterialTypes_24ip192DataSetTableAdapters.MaterialTableAdapter();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.AddMaterialButton = new System.Windows.Forms.Button();
            this.EditMaterialButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaterialTypesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialTypes_24ip192DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._24ip192DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaterialListDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ip192DataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchTextBox.Enabled = false;
            this.SearchTextBox.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SearchTextBox.Location = new System.Drawing.Point(266, 13);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(261, 21);
            this.SearchTextBox.TabIndex = 0;
            // 
            // LogoPictureBox
            // 
            this.LogoPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("LogoPictureBox.Image")));
            this.LogoPictureBox.Location = new System.Drawing.Point(12, 12);
            this.LogoPictureBox.Name = "LogoPictureBox";
            this.LogoPictureBox.Size = new System.Drawing.Size(200, 200);
            this.LogoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LogoPictureBox.TabIndex = 1;
            this.LogoPictureBox.TabStop = false;
            // 
            // SortComboBox
            // 
            this.SortComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SortComboBox.Enabled = false;
            this.SortComboBox.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.SortComboBox.FormattingEnabled = true;
            this.SortComboBox.Location = new System.Drawing.Point(616, 13);
            this.SortComboBox.Name = "SortComboBox";
            this.SortComboBox.Size = new System.Drawing.Size(120, 21);
            this.SortComboBox.TabIndex = 2;
            // 
            // FilterComboBox
            // 
            this.FilterComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.FilterComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(193)))));
            this.FilterComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.MaterialTypesBindingSource, "Type", true));
            this.FilterComboBox.DataSource = this.MaterialTypesBindingSource;
            this.FilterComboBox.DisplayMember = "Type";
            this.FilterComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FilterComboBox.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.FilterComboBox.ForeColor = System.Drawing.SystemColors.MenuText;
            this.FilterComboBox.FormattingEnabled = true;
            this.FilterComboBox.Location = new System.Drawing.Point(826, 13);
            this.FilterComboBox.Name = "FilterComboBox";
            this.FilterComboBox.Size = new System.Drawing.Size(120, 21);
            this.FilterComboBox.TabIndex = 3;
            this.FilterComboBox.ValueMember = "Type";
            // 
            // MaterialTypesBindingSource
            // 
            this.MaterialTypesBindingSource.DataMember = "Material";
            this.MaterialTypesBindingSource.DataSource = this.materialTypes_24ip192DataSet;
            // 
            // materialTypes_24ip192DataSet
            // 
            this.materialTypes_24ip192DataSet.DataSetName = "MaterialTypes_24ip192DataSet";
            this.materialTypes_24ip192DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // _24ip192DataSet
            // 
            this._24ip192DataSet.DataSetName = "_24ip192DataSet";
            this._24ip192DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // SearchLabel
            // 
            this.SearchLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchLabel.AutoSize = true;
            this.SearchLabel.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.SearchLabel.Location = new System.Drawing.Point(218, 17);
            this.SearchLabel.Name = "SearchLabel";
            this.SearchLabel.Size = new System.Drawing.Size(42, 13);
            this.SearchLabel.TabIndex = 4;
            this.SearchLabel.Text = "Поиск";
            // 
            // SortLabel
            // 
            this.SortLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SortLabel.AutoSize = true;
            this.SortLabel.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.SortLabel.Location = new System.Drawing.Point(533, 16);
            this.SortLabel.Name = "SortLabel";
            this.SortLabel.Size = new System.Drawing.Size(77, 13);
            this.SortLabel.TabIndex = 5;
            this.SortLabel.Text = "Сортировка";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.label1.Location = new System.Drawing.Point(742, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Фильтрация";
            // 
            // MaterialListDataGridView
            // 
            this.MaterialListDataGridView.AllowUserToAddRows = false;
            this.MaterialListDataGridView.AllowUserToDeleteRows = false;
            this.MaterialListDataGridView.AllowUserToResizeRows = false;
            this.MaterialListDataGridView.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.MaterialListDataGridView.AutoGenerateColumns = false;
            this.MaterialListDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.MaterialListDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.MaterialListDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(193)))));
            this.MaterialListDataGridView.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.MaterialListDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MaterialListDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.typeDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.MaterialListDataGridView.DataSource = this.ip192DataSetBindingSource;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 8.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(43)))), ((int)(((byte)(57)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.MaterialListDataGridView.DefaultCellStyle = dataGridViewCellStyle1;
            this.MaterialListDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(193)))));
            this.MaterialListDataGridView.Location = new System.Drawing.Point(221, 41);
            this.MaterialListDataGridView.Name = "MaterialListDataGridView";
            this.MaterialListDataGridView.ReadOnly = true;
            this.MaterialListDataGridView.RowHeadersVisible = false;
            this.MaterialListDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.MaterialListDataGridView.Size = new System.Drawing.Size(725, 368);
            this.MaterialListDataGridView.TabIndex = 4;
            // 
            // ip192DataSetBindingSource
            // 
            this.ip192DataSetBindingSource.DataMember = "Material";
            this.ip192DataSetBindingSource.DataSource = this._24ip192DataSet;
            // 
            // materialTableAdapter
            // 
            this.materialTableAdapter.ClearBeforeFill = true;
            // 
            // materialTableAdapter1
            // 
            this.materialTableAdapter1.ClearBeforeFill = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn3.HeaderText = "Name";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "Type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "Type";
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            this.typeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Image";
            this.dataGridViewTextBoxColumn7.HeaderText = "Image";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Visible = false;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "StorageAmount";
            this.dataGridViewTextBoxColumn4.HeaderText = "StorageAmount";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "MinimumAmount";
            this.dataGridViewTextBoxColumn5.HeaderText = "MinimumAmount";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "SupplierNames";
            this.dataGridViewTextBoxColumn6.HeaderText = "SupplierNames";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(193)))));
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(221, 415);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(224, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Изменить минимальное количество на...";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // AddMaterialButton
            // 
            this.AddMaterialButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.AddMaterialButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(193)))));
            this.AddMaterialButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.AddMaterialButton.Location = new System.Drawing.Point(829, 415);
            this.AddMaterialButton.Name = "AddMaterialButton";
            this.AddMaterialButton.Size = new System.Drawing.Size(117, 23);
            this.AddMaterialButton.TabIndex = 8;
            this.AddMaterialButton.Text = "Добавить материал";
            this.AddMaterialButton.UseVisualStyleBackColor = false;
            this.AddMaterialButton.Click += new System.EventHandler(this.AddMaterialButton_Click);
            // 
            // EditMaterialButton
            // 
            this.EditMaterialButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.EditMaterialButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(193)))));
            this.EditMaterialButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.EditMaterialButton.Location = new System.Drawing.Point(679, 415);
            this.EditMaterialButton.Name = "EditMaterialButton";
            this.EditMaterialButton.Size = new System.Drawing.Size(144, 23);
            this.EditMaterialButton.TabIndex = 9;
            this.EditMaterialButton.Text = "Редактировать материал";
            this.EditMaterialButton.UseVisualStyleBackColor = false;
            this.EditMaterialButton.Click += new System.EventHandler(this.EditMaterialButton_Click);
            // 
            // MaterialListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 450);
            this.Controls.Add(this.EditMaterialButton);
            this.Controls.Add(this.AddMaterialButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.MaterialListDataGridView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SortLabel);
            this.Controls.Add(this.SearchLabel);
            this.Controls.Add(this.FilterComboBox);
            this.Controls.Add(this.SortComboBox);
            this.Controls.Add(this.LogoPictureBox);
            this.Controls.Add(this.SearchTextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(974, 489);
            this.Name = "MaterialListForm";
            this.Text = "Список материалов";
            this.Load += new System.EventHandler(this.MaterialListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaterialTypesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialTypes_24ip192DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._24ip192DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaterialListDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ip192DataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.PictureBox LogoPictureBox;
        private System.Windows.Forms.ComboBox SortComboBox;
        private System.Windows.Forms.ComboBox FilterComboBox;
        private System.Windows.Forms.Label SearchLabel;
        private System.Windows.Forms.Label SortLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView MaterialListDataGridView;
        private System.Windows.Forms.BindingSource ip192DataSetBindingSource;
        private _24ip192DataSet _24ip192DataSet;
        private _24ip192DataSetTableAdapters.MaterialTableAdapter materialTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplierNamesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn наименованиеМатериалаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn типМатериалаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn изображениеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn остатокDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn минимальноеКоличествоDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn поставщикиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn column1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn storageAmountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn minimumAmountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.BindingSource MaterialTypesBindingSource;
        private MaterialTypes_24ip192DataSet materialTypes_24ip192DataSet;
        private MaterialTypes_24ip192DataSetTableAdapters.MaterialTableAdapter materialTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button AddMaterialButton;
        private System.Windows.Forms.Button EditMaterialButton;
    }
}

