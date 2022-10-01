namespace Stacionar
{
    partial class Stacionar
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
            this.mainWindowTabs = new System.Windows.Forms.TabControl();
            this.headDoctor = new System.Windows.Forms.TabPage();
            this.pattientsTable = new System.Windows.Forms.DataGridView();
            this.refreshPattientsButton = new System.Windows.Forms.Button();
            this.setTetramentButton = new System.Windows.Forms.Button();
            this.nurse = new System.Windows.Forms.TabPage();
            this.showPattients = new System.Windows.Forms.Button();
            this.addPattient = new System.Windows.Forms.Button();
            this.showTreatmentsButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.mainWindowTabs.SuspendLayout();
            this.headDoctor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pattientsTable)).BeginInit();
            this.nurse.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // mainWindowTabs
            // 
            this.mainWindowTabs.Controls.Add(this.headDoctor);
            this.mainWindowTabs.Controls.Add(this.nurse);
            this.mainWindowTabs.Location = new System.Drawing.Point(0, -24);
            this.mainWindowTabs.Name = "mainWindowTabs";
            this.mainWindowTabs.SelectedIndex = 0;
            this.mainWindowTabs.Size = new System.Drawing.Size(1266, 579);
            this.mainWindowTabs.TabIndex = 0;
            // 
            // headDoctor
            // 
            this.headDoctor.Controls.Add(this.label2);
            this.headDoctor.Controls.Add(this.label1);
            this.headDoctor.Controls.Add(this.pattientsTable);
            this.headDoctor.Controls.Add(this.refreshPattientsButton);
            this.headDoctor.Controls.Add(this.setTetramentButton);
            this.headDoctor.Location = new System.Drawing.Point(4, 22);
            this.headDoctor.Name = "headDoctor";
            this.headDoctor.Padding = new System.Windows.Forms.Padding(3);
            this.headDoctor.Size = new System.Drawing.Size(1258, 553);
            this.headDoctor.TabIndex = 0;
            this.headDoctor.Text = "Глав. врач";
            this.headDoctor.UseVisualStyleBackColor = true;
            // 
            // pattientsTable
            // 
            this.pattientsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pattientsTable.Location = new System.Drawing.Point(940, 14);
            this.pattientsTable.Name = "pattientsTable";
            this.pattientsTable.Size = new System.Drawing.Size(312, 531);
            this.pattientsTable.TabIndex = 2;
            // 
            // refreshPattientsButton
            // 
            this.refreshPattientsButton.Location = new System.Drawing.Point(498, 297);
            this.refreshPattientsButton.Name = "refreshPattientsButton";
            this.refreshPattientsButton.Size = new System.Drawing.Size(242, 45);
            this.refreshPattientsButton.TabIndex = 1;
            this.refreshPattientsButton.Text = "Длинношерстная";
            this.refreshPattientsButton.UseVisualStyleBackColor = true;
            this.refreshPattientsButton.Click += new System.EventHandler(this.refreshPattientsButton_Click);
            // 
            // setTetramentButton
            // 
            this.setTetramentButton.Location = new System.Drawing.Point(217, 297);
            this.setTetramentButton.Name = "setTetramentButton";
            this.setTetramentButton.Size = new System.Drawing.Size(235, 41);
            this.setTetramentButton.TabIndex = 0;
            this.setTetramentButton.Text = "Короткошерстная";
            this.setTetramentButton.UseVisualStyleBackColor = true;
            this.setTetramentButton.Click += new System.EventHandler(this.setTetramentButton_Click);
            // 
            // nurse
            // 
            this.nurse.Controls.Add(this.showPattients);
            this.nurse.Controls.Add(this.addPattient);
            this.nurse.Controls.Add(this.showTreatmentsButton);
            this.nurse.Controls.Add(this.dataGridView1);
            this.nurse.Location = new System.Drawing.Point(4, 22);
            this.nurse.Name = "nurse";
            this.nurse.Padding = new System.Windows.Forms.Padding(3);
            this.nurse.Size = new System.Drawing.Size(1046, 529);
            this.nurse.TabIndex = 1;
            this.nurse.Text = "Мед.Сестра";
            this.nurse.UseVisualStyleBackColor = true;
            // 
            // showPattients
            // 
            this.showPattients.Location = new System.Drawing.Point(4, 308);
            this.showPattients.Name = "showPattients";
            this.showPattients.Size = new System.Drawing.Size(180, 144);
            this.showPattients.TabIndex = 6;
            this.showPattients.Text = "Просмотр пациентов";
            this.showPattients.UseVisualStyleBackColor = true;
            this.showPattients.Click += new System.EventHandler(this.showPattients_Click);
            // 
            // addPattient
            // 
            this.addPattient.Location = new System.Drawing.Point(4, 158);
            this.addPattient.Name = "addPattient";
            this.addPattient.Size = new System.Drawing.Size(180, 144);
            this.addPattient.TabIndex = 5;
            this.addPattient.Text = "Добавить пациентов";
            this.addPattient.UseVisualStyleBackColor = true;
            this.addPattient.Click += new System.EventHandler(this.addPattient_Click);
            // 
            // showTreatmentsButton
            // 
            this.showTreatmentsButton.Location = new System.Drawing.Point(4, 8);
            this.showTreatmentsButton.Name = "showTreatmentsButton";
            this.showTreatmentsButton.Size = new System.Drawing.Size(180, 144);
            this.showTreatmentsButton.TabIndex = 4;
            this.showTreatmentsButton.Text = "Показать информацию, о назначенных процедурах";
            this.showTreatmentsButton.UseVisualStyleBackColor = true;
            this.showTreatmentsButton.Click += new System.EventHandler(this.showTreatmentsButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(190, 8);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(853, 515);
            this.dataGridView1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(175, 188);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(659, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Вас интересует короткошерстная или длинношерстная порода собаки?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DarkGray;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(1020, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ваши ответы";
            // 
            // Stacionar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSalmon;
            this.ClientSize = new System.Drawing.Size(1265, 555);
            this.Controls.Add(this.mainWindowTabs);
            this.Name = "Stacionar";
            this.Text = "Stacionar";
            this.Load += new System.EventHandler(this.Stacionar_Load);
            this.mainWindowTabs.ResumeLayout(false);
            this.headDoctor.ResumeLayout(false);
            this.headDoctor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pattientsTable)).EndInit();
            this.nurse.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl mainWindowTabs;
        private System.Windows.Forms.TabPage headDoctor;
        private System.Windows.Forms.DataGridView pattientsTable;
        private System.Windows.Forms.Button refreshPattientsButton;
        private System.Windows.Forms.Button setTetramentButton;
        private System.Windows.Forms.TabPage nurse;
        private System.Windows.Forms.Button showPattients;
        private System.Windows.Forms.Button addPattient;
        private System.Windows.Forms.Button showTreatmentsButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

