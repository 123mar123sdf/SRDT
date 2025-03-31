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
    public partial class ОтчетКабинеты : Form
    {
        public ОтчетКабинеты()
        {
            InitializeComponent();
        }

        private void ОтчетКабинеты_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "РасписаниеDataSet.Отчет_группы". При необходимости она может быть перемещена или удалена.
            this.Отчет_группыTableAdapter.Fill(this.РасписаниеDataSet.Отчет_группы);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "РасписаниеDataSet.Отчет_кабинеты". При необходимости она может быть перемещена или удалена.
            this.Отчет_кабинетыTableAdapter.Fill(this.РасписаниеDataSet.Отчет_кабинеты);

            this.reportViewer1.RefreshReport();
        }
    }
}
