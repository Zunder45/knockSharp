namespace knockSharp
{
    partial class test
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(test));
            this.button_add = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textBox_ports = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_deskript = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button_send_knock = new System.Windows.Forms.Button();
            this.textBox_ip = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripMenuItem_Seve = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_DelItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_ClearList = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripButton_OpenFilderSetting = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_add
            // 
            this.button_add.Location = new System.Drawing.Point(176, 209);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(141, 23);
            this.button_add.TabIndex = 4;
            this.button_add.Text = "Добвать";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 215);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "IP адрес";
            // 
            // listView1
            // 
            this.listView1.BackgroundImageTiled = true;
            this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(0, 28);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(329, 171);
            this.listView1.TabIndex = 3;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "IP";
            this.columnHeader1.Width = 92;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Порт";
            this.columnHeader2.Width = 75;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Описание";
            this.columnHeader3.Width = 103;
            // 
            // textBox_ports
            // 
            this.textBox_ports.Location = new System.Drawing.Point(72, 238);
            this.textBox_ports.Name = "textBox_ports";
            this.textBox_ports.Size = new System.Drawing.Size(245, 20);
            this.textBox_ports.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 241);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Порт";
            // 
            // textBox_deskript
            // 
            this.textBox_deskript.Location = new System.Drawing.Point(72, 264);
            this.textBox_deskript.Name = "textBox_deskript";
            this.textBox_deskript.Size = new System.Drawing.Size(245, 20);
            this.textBox_deskript.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 267);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Описание";
            // 
            // button_send_knock
            // 
            this.button_send_knock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_send_knock.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_send_knock.Location = new System.Drawing.Point(12, 290);
            this.button_send_knock.Name = "button_send_knock";
            this.button_send_knock.Size = new System.Drawing.Size(305, 47);
            this.button_send_knock.TabIndex = 9;
            this.button_send_knock.Text = "Отправить";
            this.button_send_knock.UseVisualStyleBackColor = true;
            this.button_send_knock.Click += new System.EventHandler(this.button_send_knock_Click);
            // 
            // textBox_ip
            // 
            this.textBox_ip.Location = new System.Drawing.Point(72, 211);
            this.textBox_ip.Name = "textBox_ip";
            this.textBox_ip.Size = new System.Drawing.Size(100, 20);
            this.textBox_ip.TabIndex = 1;
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1,
            this.toolStripButton_OpenFilderSetting});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(329, 25);
            this.toolStrip1.TabIndex = 15;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem_Seve,
            this.toolStripMenuItem_DelItem,
            this.toolStripMenuItem_ClearList});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(61, 22);
            this.toolStripDropDownButton1.Text = "Список";
            // 
            // toolStripMenuItem_Seve
            // 
            this.toolStripMenuItem_Seve.Name = "toolStripMenuItem_Seve";
            this.toolStripMenuItem_Seve.Size = new System.Drawing.Size(220, 22);
            this.toolStripMenuItem_Seve.Text = "Сохранить";
            this.toolStripMenuItem_Seve.Click += new System.EventHandler(this.toolStripMenuItem_Seve_Click);
            // 
            // toolStripMenuItem_DelItem
            // 
            this.toolStripMenuItem_DelItem.Name = "toolStripMenuItem_DelItem";
            this.toolStripMenuItem_DelItem.Size = new System.Drawing.Size(220, 22);
            this.toolStripMenuItem_DelItem.Text = "Удалить выбранный адрес";
            this.toolStripMenuItem_DelItem.Click += new System.EventHandler(this.toolStripMenuItem_DelItem_Click);
            // 
            // toolStripMenuItem_ClearList
            // 
            this.toolStripMenuItem_ClearList.Name = "toolStripMenuItem_ClearList";
            this.toolStripMenuItem_ClearList.Size = new System.Drawing.Size(220, 22);
            this.toolStripMenuItem_ClearList.Text = "Очистить список";
            this.toolStripMenuItem_ClearList.Click += new System.EventHandler(this.toolStripMenuItem_ClearList_Click);
            // 
            // toolStripButton_OpenFilderSetting
            // 
            this.toolStripButton_OpenFilderSetting.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton_OpenFilderSetting.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_OpenFilderSetting.Image")));
            this.toolStripButton_OpenFilderSetting.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_OpenFilderSetting.Name = "toolStripButton_OpenFilderSetting";
            this.toolStripButton_OpenFilderSetting.Size = new System.Drawing.Size(124, 22);
            this.toolStripButton_OpenFilderSetting.Text = "Открыть папку Local";
            this.toolStripButton_OpenFilderSetting.ToolTipText = "Открыть папку настроек";
            this.toolStripButton_OpenFilderSetting.Click += new System.EventHandler(this.toolStripButton_OpenFilderSetting_Click);
            // 
            // test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(329, 341);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.textBox_ip);
            this.Controls.Add(this.button_send_knock);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_deskript);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_ports);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_add);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(345, 380);
            this.MinimumSize = new System.Drawing.Size(345, 380);
            this.Name = "test";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "knock#";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.test_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.TextBox textBox_ports;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.TextBox textBox_deskript;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_send_knock;
        private System.Windows.Forms.TextBox textBox_ip;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_Seve;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_DelItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_ClearList;
        private System.Windows.Forms.ToolStripButton toolStripButton_OpenFilderSetting;
    }
}

