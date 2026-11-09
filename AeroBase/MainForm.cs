using System;
using System.Windows.Forms;

namespace AeroBase
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            SetupDroneGrid();
        }

        private void SetupDroneGrid()
        {
            dgvDrones.Columns.Clear();
            dgvDrones.Columns.Add("colName", "Название");
            dgvDrones.Columns.Add("colNumber", "Номер");
            dgvDrones.Columns.Add("colType", "Тип");
            dgvDrones.Columns.Add("colStatus", "Состояние");

            dgvDrones.Rows.Clear();
            dgvDrones.Rows.Add("Учебный №1", "UAV-001", "Квадрокоптер", "Исправен");
            dgvDrones.Rows.Add("Учебный №2", "UAV-002", "Самолётный", "На ТО");
            dgvDrones.Rows.Add("Учебный №3", "UAV-003", "Квадрокоптер", "Исправен");
        }

        private void dgvDrones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}