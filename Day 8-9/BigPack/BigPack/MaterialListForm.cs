using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BigPack
{
    public partial class MaterialListForm : Form
    {
        public MaterialListForm()
        {
            InitializeComponent();
        }

        private void MaterialListForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "materialTypes_24ip192DataSet.Material". При необходимости она может быть перемещена или удалена.
            this.materialTableAdapter1.Fill(this.materialTypes_24ip192DataSet.Material);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_24ip192DataSet.Material". При необходимости она может быть перемещена или удалена.
            this.materialTableAdapter.Fill(this._24ip192DataSet.Material);

            // Создаем столбец для изображений
            DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
            imageColumn.Name = "Img";
            imageColumn.HeaderText = "Изображение";
            imageColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
            this.MaterialListDataGridView.Columns.Insert(0, imageColumn);

            // Проходим по всем строкам таблицы и добавляем изображение
            foreach (DataRow row in this._24ip192DataSet.Material.Rows)
            {
                // Получаем путь к изображению из таблицы
                string imagePath;
                if (row["Image"].ToString().Length == 0) 
                {
                    imagePath = ".\\materials\\default.png";
                }
                else 
                {
                    imagePath = (string)row["Image"];
                }

                // Загружаем изображение в объект Image
                Image image = Image.FromFile(imagePath);

                // Добавляем изображение в ячейку соответствующего столбца
                int rowIndex = this._24ip192DataSet.Material.Rows.IndexOf(row);
                this.MaterialListDataGridView.Rows[rowIndex].Cells["Img"].Value = image;
            }

        }

        private void AddMaterialButton_Click(object sender, EventArgs e)
        {
            AddMaterialForm addMaterialForm = new AddMaterialForm();
            addMaterialForm.ShowDialog();
        }

        private void EditMaterialButton_Click(object sender, EventArgs e)
        {
            EditMaterialForm editMaterialForm = new EditMaterialForm();
            editMaterialForm.ShowDialog();
        }
    }
}
