namespace AeroBase
{
    partial class MainForm
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
            panel1 = new Panel();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            label1 = new Label();
            panel2 = new Panel();
            panel7 = new Panel();
            label14 = new Label();
            label13 = new Label();
            btnAdd = new Button();
            label12 = new Label();
            label9 = new Label();
            label7 = new Label();
            label5 = new Label();
            txtName = new TextBox();
            txtInvNumber = new TextBox();
            txtType = new TextBox();
            txtStatus = new TextBox();
            txtModel = new TextBox();
            dgvParts = new DataGridView();
            dgvDrones = new DataGridView();
            btnDelete = new Button();
            button7 = new Button();
            panel9 = new Panel();
            label11 = new Label();
            panel8 = new Panel();
            button6 = new Button();
            label10 = new Label();
            textBox1 = new TextBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel4 = new Panel();
            lblTotalDrones = new Label();
            label4 = new Label();
            panel5 = new Panel();
            label6 = new Label();
            panel6 = new Panel();
            lblMaintenanceDrones = new Label();
            label8 = new Label();
            panel3 = new Panel();
            label3 = new Label();
            label2 = new Label();
            saveFileDialog1 = new SaveFileDialog();
            saveFileDialog2 = new SaveFileDialog();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvParts).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvDrones).BeginInit();
            panel9.SuspendLayout();
            panel8.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(30, 41, 59);
            panel1.Controls.Add(button5);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(165, 711);
            panel1.TabIndex = 0;
            // 
            // button5
            // 
            button5.Dock = DockStyle.Top;
            button5.FlatStyle = FlatStyle.Flat;
            button5.ForeColor = SystemColors.ButtonFace;
            button5.Location = new Point(0, 205);
            button5.Name = "button5";
            button5.Padding = new Padding(20, 0, 0, 0);
            button5.Size = new Size(165, 45);
            button5.TabIndex = 5;
            button5.Text = "Правила";
            button5.TextAlign = ContentAlignment.MiddleLeft;
            button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Dock = DockStyle.Top;
            button4.FlatStyle = FlatStyle.Flat;
            button4.ForeColor = SystemColors.ButtonFace;
            button4.Location = new Point(0, 160);
            button4.Name = "button4";
            button4.Padding = new Padding(20, 0, 0, 0);
            button4.Size = new Size(165, 45);
            button4.TabIndex = 4;
            button4.Text = "Обслуживание";
            button4.TextAlign = ContentAlignment.MiddleLeft;
            button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Dock = DockStyle.Top;
            button3.FlatStyle = FlatStyle.Flat;
            button3.ForeColor = SystemColors.ButtonFace;
            button3.Location = new Point(0, 115);
            button3.Name = "button3";
            button3.Padding = new Padding(20, 0, 0, 0);
            button3.Size = new Size(165, 45);
            button3.TabIndex = 3;
            button3.Text = "Комплектующие";
            button3.TextAlign = ContentAlignment.MiddleLeft;
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Dock = DockStyle.Top;
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = SystemColors.ButtonFace;
            button2.Location = new Point(0, 70);
            button2.Name = "button2";
            button2.Padding = new Padding(20, 0, 0, 0);
            button2.Size = new Size(165, 45);
            button2.TabIndex = 2;
            button2.Text = "Реестр БПЛА";
            button2.TextAlign = ContentAlignment.MiddleLeft;
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Dock = DockStyle.Top;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.White;
            button1.Location = new Point(0, 25);
            button1.Name = "button1";
            button1.Padding = new Padding(20, 0, 0, 0);
            button1.Size = new Size(165, 45);
            button1.TabIndex = 1;
            button1.Text = "Обзор";
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.ForeColor = Color.White;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Padding = new Padding(15, 0, 0, 0);
            label1.Size = new Size(137, 25);
            label1.TabIndex = 0;
            label1.Text = "✈ AeroBase";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            panel2.BackColor = Color.WhiteSmoke;
            panel2.Controls.Add(panel7);
            panel2.Controls.Add(tableLayoutPanel1);
            panel2.Controls.Add(panel3);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(165, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1019, 711);
            panel2.TabIndex = 1;
            // 
            // panel7
            // 
            panel7.Controls.Add(label14);
            panel7.Controls.Add(label13);
            panel7.Controls.Add(btnAdd);
            panel7.Controls.Add(label12);
            panel7.Controls.Add(label9);
            panel7.Controls.Add(label7);
            panel7.Controls.Add(label5);
            panel7.Controls.Add(txtName);
            panel7.Controls.Add(txtInvNumber);
            panel7.Controls.Add(txtType);
            panel7.Controls.Add(txtStatus);
            panel7.Controls.Add(txtModel);
            panel7.Controls.Add(dgvParts);
            panel7.Controls.Add(dgvDrones);
            panel7.Controls.Add(btnDelete);
            panel7.Controls.Add(button7);
            panel7.Controls.Add(panel9);
            panel7.Controls.Add(panel8);
            panel7.Dock = DockStyle.Fill;
            panel7.Location = new Point(0, 200);
            panel7.Name = "panel7";
            panel7.Size = new Size(1019, 511);
            panel7.TabIndex = 2;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 12F);
            label14.Location = new Point(29, 186);
            label14.Name = "label14";
            label14.Size = new Size(184, 21);
            label14.TabIndex = 19;
            label14.Text = "Список комплектующих";
            label14.Click += label14_Click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(535, 414);
            label13.Name = "label13";
            label13.Size = new Size(66, 15);
            label13.TabIndex = 18;
            label13.Text = "Состояниe";
            // 
            // btnAdd
            // 
            btnAdd.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAdd.BackColor = Color.FromArgb(37, 99, 235);
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.ForeColor = SystemColors.ButtonFace;
            btnAdd.Location = new Point(823, 389);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(143, 40);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "+ Добавить БПЛА";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(535, 369);
            label12.Name = "label12";
            label12.Size = new Size(122, 15);
            label12.TabIndex = 17;
            label12.Text = "Инвентарный номер";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(675, 369);
            label9.Name = "label9";
            label9.Size = new Size(65, 15);
            label9.TabIndex = 16;
            label9.Text = "Тип БПЛА ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(410, 414);
            label7.Name = "label7";
            label7.Size = new Size(50, 15);
            label7.TabIndex = 15;
            label7.Text = "Модель";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(410, 369);
            label5.Name = "label5";
            label5.Size = new Size(62, 15);
            label5.TabIndex = 14;
            label5.Text = "Название ";
            // 
            // txtName
            // 
            txtName.Location = new Point(535, 387);
            txtName.Name = "txtName";
            txtName.Size = new Size(100, 23);
            txtName.TabIndex = 13;
            // 
            // txtInvNumber
            // 
            txtInvNumber.Location = new Point(675, 387);
            txtInvNumber.Name = "txtInvNumber";
            txtInvNumber.Size = new Size(100, 23);
            txtInvNumber.TabIndex = 12;
            // 
            // txtType
            // 
            txtType.Location = new Point(410, 430);
            txtType.Name = "txtType";
            txtType.Size = new Size(100, 23);
            txtType.TabIndex = 11;
            // 
            // txtStatus
            // 
            txtStatus.Location = new Point(535, 430);
            txtStatus.Name = "txtStatus";
            txtStatus.Size = new Size(100, 23);
            txtStatus.TabIndex = 10;
            // 
            // txtModel
            // 
            txtModel.Location = new Point(410, 387);
            txtModel.Name = "txtModel";
            txtModel.Size = new Size(100, 23);
            txtModel.TabIndex = 9;
            // 
            // dgvParts
            // 
            dgvParts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvParts.Location = new Point(-3, 236);
            dgvParts.Name = "dgvParts";
            dgvParts.Size = new Size(1019, 95);
            dgvParts.TabIndex = 8;
            // 
            // dgvDrones
            // 
            dgvDrones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDrones.Location = new Point(0, 75);
            dgvDrones.Name = "dgvDrones";
            dgvDrones.Size = new Size(1019, 95);
            dgvDrones.TabIndex = 7;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(254, 226, 226);
            btnDelete.Location = new Point(197, 446);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 35);
            btnDelete.TabIndex = 6;
            btnDelete.Text = "Удалить";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // button7
            // 
            button7.BackColor = Color.FromArgb(219, 234, 254);
            button7.Location = new Point(39, 446);
            button7.Name = "button7";
            button7.Size = new Size(92, 35);
            button7.TabIndex = 5;
            button7.Text = "Изменить";
            button7.UseVisualStyleBackColor = false;
            // 
            // panel9
            // 
            panel9.Controls.Add(label11);
            panel9.Location = new Point(20, 387);
            panel9.Name = "panel9";
            panel9.Size = new Size(353, 42);
            panel9.TabIndex = 4;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(3, 12);
            label11.Name = "label11";
            label11.Size = new Size(338, 15);
            label11.TabIndex = 0;
            label11.Text = "Выберите строку, чтобы редактировать или удалить запись.";
            // 
            // panel8
            // 
            panel8.Controls.Add(button6);
            panel8.Controls.Add(label10);
            panel8.Controls.Add(textBox1);
            panel8.Location = new Point(1, 0);
            panel8.Name = "panel8";
            panel8.Size = new Size(1019, 69);
            panel8.TabIndex = 3;
            // 
            // button6
            // 
            button6.Location = new Point(646, 26);
            button6.Name = "button6";
            button6.Size = new Size(75, 23);
            button6.TabIndex = 2;
            button6.Text = "Найти";
            button6.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F);
            label10.Location = new Point(28, 19);
            label10.Name = "label10";
            label10.Size = new Size(141, 21);
            label10.TabIndex = 1;
            label10.Text = "Список аппаратов";
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBox1.Location = new Point(747, 27);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(250, 23);
            textBox1.TabIndex = 0;
            textBox1.Text = "Поиск по названию...";
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Controls.Add(panel4, 0, 0);
            tableLayoutPanel1.Controls.Add(panel5, 1, 0);
            tableLayoutPanel1.Controls.Add(panel6, 2, 0);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(0, 80);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(20, 10, 20, 10);
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1019, 120);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // panel4
            // 
            panel4.Controls.Add(lblTotalDrones);
            panel4.Controls.Add(label4);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(23, 13);
            panel4.Name = "panel4";
            panel4.Size = new Size(320, 94);
            panel4.TabIndex = 0;
            // 
            // lblTotalDrones
            // 
            lblTotalDrones.AutoSize = true;
            lblTotalDrones.Font = new Font("Segoe UI", 24F);
            lblTotalDrones.Location = new Point(10, 40);
            lblTotalDrones.Name = "lblTotalDrones";
            lblTotalDrones.Size = new Size(37, 45);
            lblTotalDrones.TabIndex = 1;
            lblTotalDrones.Text = "5";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.ControlDarkDark;
            label4.Location = new Point(10, 10);
            label4.Name = "label4";
            label4.Size = new Size(73, 15);
            label4.TabIndex = 0;
            label4.Text = "Всего БПЛА";
            // 
            // panel5
            // 
            panel5.Controls.Add(label6);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(349, 13);
            panel5.Name = "panel5";
            panel5.Size = new Size(320, 94);
            panel5.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = SystemColors.ControlDarkDark;
            label6.Location = new Point(10, 10);
            label6.Name = "label6";
            label6.Size = new Size(70, 15);
            label6.TabIndex = 0;
            label6.Text = "Исправные";
            // 
            // panel6
            // 
            panel6.Controls.Add(lblMaintenanceDrones);
            panel6.Controls.Add(label8);
            panel6.Dock = DockStyle.Fill;
            panel6.Location = new Point(675, 13);
            panel6.Name = "panel6";
            panel6.Size = new Size(321, 94);
            panel6.TabIndex = 2;
            // 
            // lblMaintenanceDrones
            // 
            lblMaintenanceDrones.AutoSize = true;
            lblMaintenanceDrones.Font = new Font("Segoe UI", 24F);
            lblMaintenanceDrones.ForeColor = SystemColors.ActiveCaptionText;
            lblMaintenanceDrones.Location = new Point(10, 40);
            lblMaintenanceDrones.Name = "lblMaintenanceDrones";
            lblMaintenanceDrones.Size = new Size(37, 45);
            lblMaintenanceDrones.TabIndex = 1;
            lblMaintenanceDrones.Text = "2";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = SystemColors.ControlDarkDark;
            label8.Location = new Point(10, 10);
            label8.Name = "label8";
            label8.Size = new Size(107, 15);
            label8.TabIndex = 0;
            label8.Text = "На обслуживании";
            // 
            // panel3
            // 
            panel3.Controls.Add(label3);
            panel3.Controls.Add(label2);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(1019, 80);
            panel3.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.AppWorkspace;
            label3.Location = new Point(20, 52);
            label3.Name = "label3";
            label3.Size = new Size(214, 15);
            label3.TabIndex = 1;
            label3.Text = "Оборудование учебной лаборатории";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20F);
            label2.Location = new Point(20, 20);
            label2.Name = "label2";
            label2.Size = new Size(175, 37);
            label2.TabIndex = 0;
            label2.Text = "Реестр БПЛА";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1184, 711);
            Controls.Add(panel2);
            Controls.Add(panel1);
            MinimumSize = new Size(1000, 650);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AeroBase — учёт БПЛА";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvParts).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvDrones).EndInit();
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private Panel panel2;
        private Panel panel3;
        private Label label2;
        private Label label3;
        private Button btnAdd;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel4;
        private Panel panel5;
        private Panel panel6;
        private Label label4;
        private Label label6;
        private Label lblMaintenanceDrones;
        private Label label8;
        private SaveFileDialog saveFileDialog1;
        private SaveFileDialog saveFileDialog2;
        private Panel panel7;
        private DataGridView dgvDrones;
        private Label label10;
        private TextBox textBox1;
        private Panel panel8;
        private Panel panel9;
        private Label label11;
        private Button btnDelete;
        private Button button7;
        private DataGridView dgvParts;
        private Label label12;
        private Label label9;
        private Label label7;
        private Label label5;
        private TextBox txtName;
        private TextBox txtInvNumber;
        private TextBox txtType;
        private TextBox txtStatus;
        private TextBox txtModel;
        private Label lblTotalDrones;
        private Label label13;
        private Label label14;
        private Button button6;
    }
}