using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Stacionar
{
    public partial class Stacionar : Form
    {
        public Stacionar()
        {
            InitializeComponent();
        }
        private void toggleLoginForm() {
            
            Thread loginThread = new Thread(() => {
                Form loginForm = new Login();
                loginForm.ShowDialog();
            });
            loginThread.Start();
            loginThread.Join();

            if (dbController.logged == null) Close();

            if (dbController.logged.position == "Гл.Врач")
            {
                if (!mainWindowTabs.TabPages.Contains(headDoctor))
                    toggleOnHeadDoctorFunctiuons();
                toggelOffNurseFunctions();
                loadPattientsOnGridView(dbController.getPattientsList(), pattientsTable);
            }
            else
            {
                if(!mainWindowTabs.TabPages.Contains(nurse))
                    toggelOnNurseFunctions();
                toggleOffHeadDoctorFunctiuons();
                loadPattientsOnGridView(dbController.getPattientsList(), dataGridView1);
            }
            
        }
        private void Stacionar_Load(object sender, EventArgs e)
        {
            toggleLoginForm();
        }

        private void toggelOffNurseFunctions() =>
            this.mainWindowTabs.TabPages.Remove(nurse);
        private void toggelOnNurseFunctions() =>
            this.mainWindowTabs.TabPages.Add(nurse);
        private void toggleOffHeadDoctorFunctiuons() =>
            this.mainWindowTabs.TabPages.Remove(headDoctor);

        private void toggleOnHeadDoctorFunctiuons() =>
            this.mainWindowTabs.TabPages.Add(headDoctor);

        private void loadPattientsOnGridView(LinkedList<PattientInfo> target , DataGridView table)
        {
            table.DataSource = null;
            table.Rows.Clear();
            table.Refresh();
            if (table.Columns.Count == 0)
            {
                table.Columns.Add("pattientName", "ФИО");
                table.Columns.Add("roomNumder", "Палата");
                table.Columns.Add("birthday", "Дата рождения");
                table.Columns.Add("receipt", "Дата поступления");
                table.Columns.Add("start", "Дата начала");
                table.Columns.Add("end", "Дата окончания");
                table.Columns.Add("result", "Лечение");
            }
            foreach (PattientInfo p in target)
            {
                table.Rows.Add(p.namePatient,p.roomNumber, p.birthday, p.dateReceipt, p.startTreatment, p.endTreatment, p.resultTreatment);
            }
        }

        private void refreshPattientsButton_Click(object sender, EventArgs e)
        {
            loadPattientsOnGridView(dbController.getPattientsList(), pattientsTable);
        }

        private void setTetramentButton_Click(object sender, EventArgs e)
        {
            Thread addTreatmentThread = new Thread(() =>
            {
                new addTreatment().ShowDialog();
            });
            addTreatmentThread.Start();
            addTreatmentThread.Join();
        }

        private void logutButton_Click(object sender, EventArgs e)
        {
            Hide();
            dbController.logged = null;
            toggleLoginForm();
            Show();
        }

        private void showPattients_Click(object sender, EventArgs e)
        {
            loadPattientsOnGridView(dbController.getPattientsList(), dataGridView1);
        }

        private void showTreatmentsButton_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            dataGridView1.Refresh();
            dataGridView1.DataSource = dbController.getProcedureInfo();
            //if (dataGridView1.Columns.Count == 0)
            //{
            //    dataGridView1.Columns.Add("staffName", "ФИО Врача");
            //    dataGridView1.Columns.Add("start", "Дата начала");
            //    dataGridView1.Columns.Add("end", "Дата окончания");
            //    dataGridView1.Columns.Add("result", "Лечение");
            //    dataGridView1.Columns.Add("cab", "Номер процедурного кабинета");
            //    dataGridView1.Columns.Add("man", "Производитель");
            //    dataGridView1.Columns.Add("dosage", "Доза");
             
            //}
            //foreach (ShowProcedurs p in dbController.getProcedureInfo())
            //{
            //    dataGridView1.Rows.Add(p.staffName, p.start, p.end, p.result, p.cabinetNumber, p.manufacturer, p.dosage);
            //}
        }

        private void addPattient_Click(object sender, EventArgs e)
        {
            Thread addTreatmentThread = new Thread(() =>
            {
                new addPattient().ShowDialog();
            });
            addTreatmentThread.Start();
            addTreatmentThread.Join();
        }
    }
}
