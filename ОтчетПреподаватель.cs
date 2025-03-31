using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Расписание_занятий
{
    public partial class ОтчетПреподаватель : Form
    {
        public ОтчетПреподаватель()
        {
            InitializeComponent();
        }

        private void ОтчетПреподаватель_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "РасписаниеDataSet.Отчет_преподаватели". При необходимости она может быть перемещена или удалена.
            this.Отчет_преподавателиTableAdapter.Fill(this.РасписаниеDataSet.Отчет_преподаватели);

            this.reportViewer1.RefreshReport();
        }
    }
}
