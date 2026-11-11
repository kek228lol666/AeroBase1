using AeroBase.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;

namespace AeroBase
{
    public partial class MainForm : Form
    {
        // 1. Коллекции объектов (вместо ручного добавления строк)
        private readonly List<Drone> drones = new();
        private readonly List<Part> parts = new();

        public MainForm()
        {
            InitializeComponent();
            LoadInitialData();
            RefreshDronesTable();
            RefreshPartsTable();
        }

        // 2. Заполнение списков вашими данными из документа
        private void LoadInitialData()
        {
            // 5 БПЛА (раздел 1.2)
            drones.Add(new Drone { Id = 1, Name = "Учебный №1", Type = "Квадрокоптер", Model = "Tello EDU", InventoryNumber = "UAV-001", Status = "Исправен" });
            drones.Add(new Drone { Id = 2, Name = "Учебный №2", Type = "Самолётного типа", Model = "Fixed-Wing Trainer FW-01", InventoryNumber = "UAV-002", Status = "На обслуживании" });
            drones.Add(new Drone { Id = 3, Name = "Учебный №3", Type = "Квадрокоптер", Model = "Geoscan Pioneer Mini", InventoryNumber = "UAV-003", Status = "Исправен" });
            drones.Add(new Drone { Id = 4, Name = "Учебный №4", Type = "Гексакоптер", Model = "HexaTrain H6", InventoryNumber = "UAV-004", Status = "Неисправен" });
            drones.Add(new Drone { Id = 5, Name = "Учебный №5", Type = "Квадрокоптер", Model = "Tello EDU", InventoryNumber = "UAV-005", Status = "Исправен" });

            // 10 комплектующих (раздел 1.3)
            parts.Add(new Part { Id = 1, Name = "Пропеллер 3\" (пара)", Category = "Винты", Quantity = 24, StorageLocation = "Шкаф A, полка 1", Compatibility = "Квадрокоптер / Tello EDU" });
            parts.Add(new Part { Id = 2, Name = "Пропеллер 10\" (пара)", Category = "Винты", Quantity = 8, StorageLocation = "Шкаф A, полка 1", Compatibility = "Гексакоптер / HexaTrain H6" });
            parts.Add(new Part { Id = 3, Name = "Аккумулятор LiPo 1S 1100 mAh", Category = "Питание", Quantity = 12, StorageLocation = "Шкаф B, полка 2 (огнеупорный бокс)", Compatibility = "Квадрокоптер" });
            parts.Add(new Part { Id = 4, Name = "Аккумулятор LiPo 4S 5000 mAh", Category = "Питание", Quantity = 4, StorageLocation = "Шкаф B, полка 2 (огнеупорный бокс)", Compatibility = "Гексакоптер" });
            parts.Add(new Part { Id = 5, Name = "Зарядное устройство USB-C", Category = "Питание", Quantity = 6, StorageLocation = "Шкаф B, полка 3", Compatibility = "Квадрокоптер" });
            parts.Add(new Part { Id = 6, Name = "Кабель micro-USB", Category = "Кабели", Quantity = 15, StorageLocation = "Шкаф C, полка 1", Compatibility = "Универсально" });
            parts.Add(new Part { Id = 7, Name = "Мотор бесколлекторный 2205", Category = "Двигатели", Quantity = 6, StorageLocation = "Шкаф A, полка 2", Compatibility = "Квадрокоптер" });
            parts.Add(new Part { Id = 8, Name = "ESC 30A", Category = "Электроника", Quantity = 5, StorageLocation = "Шкаф A, полка 2", Compatibility = "Гексакоптер" });
            parts.Add(new Part { Id = 9, Name = "Плата полётного контроллера", Category = "Электроника", Quantity = 3, StorageLocation = "Шкаф C, полка 2", Compatibility = "Квадрокоптер / Гексакоптер" });
            parts.Add(new Part { Id = 10, Name = "Серводвигатель SG90", Category = "Двигатели", Quantity = 10, StorageLocation = "Шкаф A, полка 3", Compatibility = "Самолётного типа" });
        }

        // 3. Привязка списка БПЛА к таблице dgvDrones
        private void RefreshDronesTable()
        {
            dgvDrones.Columns.Clear();
            dgvDrones.DataSource = null;
            dgvDrones.DataSource = drones;
        }

        // 4. Привязка списка деталей к таблице комплектующих (проверьте имя dgvParts!)
        private void RefreshPartsTable()
        {
            dgvParts.Columns.Clear();
            dgvParts.DataSource = null;
            dgvParts.DataSource = parts;
        }


        private void UpdateStatistics()
        {
            // Подставьте имена ваших Label
            lblTotalDrones.Text = drones.Count.ToString();
            // lblActiveDrones.Text = drones.Count(d => d.Status == "Исправен").ToString();
            // lblMaintenanceDrones.Text = drones.Count(d => d.Status == "На обслуживании" || d.Status == "Неисправен").ToString();
        }

        // Код для кнопки «Добавить» (вставьте внутрь вашего метода Click)
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text) || string.IsNullOrWhiteSpace(txtInvNumber.Text))
            {
                MessageBox.Show("Заполните название и инвентарный номер!");
                return;
            }

            drones.Add(new Drone
            {
                Id = drones.Count > 0 ? drones.Max(d => d.Id) + 1 : 1,
                Name = txtName.Text.Trim(),
                Type = txtType.Text.Trim(),
                Model = txtModel.Text.Trim(),
                InventoryNumber = txtInvNumber.Text.Trim(),
                Status = txtStatus.Text.Trim()
            });

            RefreshDronesTable();
            txtName.Clear();
            txtType.Clear();
            txtModel.Clear();
            txtInvNumber.Clear();
        }

        // Код для кнопки «Удалить» (вставьте внутрь вашего метода Click)
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvDrones.CurrentRow?.DataBoundItem is not Drone selectedDrone)
            {
                MessageBox.Show("Выберите БПЛА в таблице!");
                return;
            }

            if (MessageBox.Show($"Удалить {selectedDrone.Name}?", "Подтверждение", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                drones.Remove(selectedDrone);
                RefreshDronesTable();
            }
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string query = textBox1.Text.Trim();

            // Если поле поиска пустое — показываем весь исходный список БПЛА
            if (string.IsNullOrEmpty(query))
            {
                RefreshDronesTable();
                return;
            }

            // Фильтруем по названию или инвентарному номеру без учёта регистра
            var filtered = drones.Where(d =>
                d.Name.Contains(query, StringComparison.OrdinalIgnoreCase) ||
                d.InventoryNumber.Contains(query, StringComparison.OrdinalIgnoreCase))
                .ToList();

            dgvDrones.Columns.Clear();
            dgvDrones.DataSource = null;
            dgvDrones.DataSource = filtered;
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}