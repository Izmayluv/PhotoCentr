namespace PhotoCentr
{
    partial class Main
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
            this.buttonConnect = new System.Windows.Forms.Button();
            this.comboBoxServices = new System.Windows.Forms.ComboBox();
            this.buttonCloseconnect = new System.Windows.Forms.Button();
            this.buttonOrder = new System.Windows.Forms.Button();
            this.dataGridViewPC = new System.Windows.Forms.DataGridView();
            this.textBoxO = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxQ = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id_request = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patronymic = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPC)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonConnect
            // 
            this.buttonConnect.Location = new System.Drawing.Point(832, 12);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(182, 57);
            this.buttonConnect.TabIndex = 0;
            this.buttonConnect.Text = "Open connection";
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // comboBoxServices
            // 
            this.comboBoxServices.FormattingEnabled = true;
            this.comboBoxServices.Items.AddRange(new object[] {
            "Ввести запрос вручную",
            "Все заказы",
            "Отчёт по должникам",
            "См инф-ию по ном заказа"});
            this.comboBoxServices.Location = new System.Drawing.Point(12, 25);
            this.comboBoxServices.Name = "comboBoxServices";
            this.comboBoxServices.Size = new System.Drawing.Size(360, 32);
            this.comboBoxServices.Sorted = true;
            this.comboBoxServices.TabIndex = 2;
            this.comboBoxServices.Text = "Выбрать запрос";
            this.comboBoxServices.SelectedIndexChanged += new System.EventHandler(this.comboBoxServices_SelectedIndexChanged);
            // 
            // buttonCloseconnect
            // 
            this.buttonCloseconnect.Location = new System.Drawing.Point(1020, 12);
            this.buttonCloseconnect.Name = "buttonCloseconnect";
            this.buttonCloseconnect.Size = new System.Drawing.Size(182, 57);
            this.buttonCloseconnect.TabIndex = 3;
            this.buttonCloseconnect.Text = "Close connection";
            this.buttonCloseconnect.UseVisualStyleBackColor = true;
            this.buttonCloseconnect.Click += new System.EventHandler(this.buttonCloseconnect_Click);
            // 
            // buttonOrder
            // 
            this.buttonOrder.Location = new System.Drawing.Point(378, 3);
            this.buttonOrder.Name = "buttonOrder";
            this.buttonOrder.Size = new System.Drawing.Size(167, 66);
            this.buttonOrder.TabIndex = 4;
            this.buttonOrder.Text = "Выполнить запрос";
            this.buttonOrder.UseVisualStyleBackColor = true;
            this.buttonOrder.Click += new System.EventHandler(this.buttonOrder_Click);
            // 
            // dataGridViewPC
            // 
            this.dataGridViewPC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewPC.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewPC.Name = "dataGridViewPC";
            this.dataGridViewPC.RowHeadersWidth = 72;
            this.dataGridViewPC.RowTemplate.Height = 31;
            this.dataGridViewPC.Size = new System.Drawing.Size(1210, 534);
            this.dataGridViewPC.TabIndex = 5;
            // 
            // textBoxO
            // 
            this.textBoxO.Location = new System.Drawing.Point(561, 36);
            this.textBoxO.Name = "textBoxO";
            this.textBoxO.Size = new System.Drawing.Size(246, 29);
            this.textBoxO.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(567, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Сумма:";
            // 
            // textBoxQ
            // 
            this.textBoxQ.Location = new System.Drawing.Point(560, 35);
            this.textBoxQ.Name = "textBoxQ";
            this.textBoxQ.Size = new System.Drawing.Size(246, 29);
            this.textBoxQ.TabIndex = 8;
            this.textBoxQ.TextChanged += new System.EventHandler(this.textBoxQ_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(567, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(230, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "Введите номер заказа:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(0, 570);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(1210, 29);
            this.textBox1.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(555, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 25);
            this.label3.TabIndex = 11;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.dataGridViewPC);
            this.panel1.Location = new System.Drawing.Point(0, 71);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1210, 534);
            this.panel1.TabIndex = 12;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_request,
            this.lastname,
            this.name,
            this.patronymic,
            this.title,
            this.genre});
            this.dataGridView1.Location = new System.Drawing.Point(12, 18);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 72;
            this.dataGridView1.RowTemplate.Height = 31;
            this.dataGridView1.Size = new System.Drawing.Size(1160, 475);
            this.dataGridView1.TabIndex = 6;
            // 
            // id_request
            // 
            this.id_request.HeaderText = "id_request";
            this.id_request.MinimumWidth = 9;
            this.id_request.Name = "id_request";
            this.id_request.Width = 175;
            // 
            // lastname
            // 
            this.lastname.HeaderText = "lastname";
            this.lastname.MinimumWidth = 9;
            this.lastname.Name = "lastname";
            this.lastname.Width = 175;
            // 
            // name
            // 
            this.name.HeaderText = "name";
            this.name.MinimumWidth = 9;
            this.name.Name = "name";
            this.name.Width = 175;
            // 
            // patronymic
            // 
            this.patronymic.HeaderText = "patronymic";
            this.patronymic.MinimumWidth = 9;
            this.patronymic.Name = "patronymic";
            this.patronymic.Width = 175;
            // 
            // title
            // 
            this.title.HeaderText = "title";
            this.title.MinimumWidth = 9;
            this.title.Name = "title";
            this.title.Width = 175;
            // 
            // genre
            // 
            this.genre.HeaderText = "genre";
            this.genre.MinimumWidth = 9;
            this.genre.Name = "genre";
            this.genre.Width = 175;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1210, 604);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBoxQ);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxO);
            this.Controls.Add(this.buttonOrder);
            this.Controls.Add(this.buttonCloseconnect);
            this.Controls.Add(this.comboBoxServices);
            this.Controls.Add(this.buttonConnect);
            this.Controls.Add(this.label2);
            this.Name = "Main";
            this.Text = "Окно администратора";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPC)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.ComboBox comboBoxServices;
        private System.Windows.Forms.Button buttonCloseconnect;
        private System.Windows.Forms.Button buttonOrder;
        public System.Windows.Forms.DataGridView dataGridViewPC;
        private System.Windows.Forms.TextBox textBoxO;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxQ;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_request;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastname;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn patronymic;
        private System.Windows.Forms.DataGridViewTextBoxColumn title;
        private System.Windows.Forms.DataGridViewTextBoxColumn genre;
    }
}

