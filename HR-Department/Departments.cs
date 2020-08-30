using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HR_Department
{
    public partial class Departments : Form
    {
        public string Title { get; set; }
        public string Action { get; set; }
        public string DepName { get; set; }

        public Departments()
        {
            InitializeComponent();
        }

        private void ExecuteButton_Click(object sender, EventArgs e)
        {
            DepName = DepartmentField.Text;
            if (String.IsNullOrEmpty(DepName))
            {
                MessageBox.Show("Вы не указали название департамента!", "Ошибка ввода",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                this.DialogResult = DialogResult.OK;
            }
        }

        private void Departments_Load(object sender, EventArgs e)
        {
            TitleLabel.Text = Title;
            ExecuteButton.Text = Action;
            DepartmentField.Text = DepName;
        }
    }
}
