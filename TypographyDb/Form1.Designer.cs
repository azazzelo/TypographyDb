namespace TypographyDb
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageSignIn = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSignIn = new System.Windows.Forms.Button();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxFIO = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.buttonOrder = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxQuantity = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.pageEmployees = new System.Windows.Forms.TabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.buttonBackEmployees = new System.Windows.Forms.Button();
            this.buttonSearchEmployees = new System.Windows.Forms.Button();
            this.buttonDeleteEmployees = new System.Windows.Forms.Button();
            this.buttonUpdateEmployees = new System.Windows.Forms.Button();
            this.buttonInsertEmployees = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label20 = new System.Windows.Forms.Label();
            this.textBoxEmployeePos = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxEmployeePassword = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.textBoxEmployeeRoleID = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.textBoxEmployeeFIO = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.textBoxEmployeeID = new System.Windows.Forms.TextBox();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fIODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roleIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.positionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.zueVTypographyDbDataSet = new TypographyDb.ZueVTypographyDbDataSet();
            this.pageOrders = new System.Windows.Forms.TabPage();
            this.groupBoxOrdersOperations = new System.Windows.Forms.GroupBox();
            this.buttonOrdersDelete = new System.Windows.Forms.Button();
            this.buttonOrdersUpdate = new System.Windows.Forms.Button();
            this.buttonOrdersInsert = new System.Windows.Forms.Button();
            this.groupBoxOrdesFields = new System.Windows.Forms.GroupBox();
            this.checkBoxStatus = new System.Windows.Forms.CheckBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBoxQuantityTable = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBoxIDProduct = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textBoxIDMaterial = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.textBoxIDOrder = new System.Windows.Forms.TextBox();
            this.groupBoxStatus = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxIDOrderManager = new System.Windows.Forms.TextBox();
            this.buttonUpdateStatus = new System.Windows.Forms.Button();
            this.checkBoxStatusManager = new System.Windows.Forms.CheckBox();
            this.dataGridViewOrders = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDoneDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ordersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pageProducts = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonDeleteProducts = new System.Windows.Forms.Button();
            this.buttonUpdateProducts = new System.Windows.Forms.Button();
            this.buttonInsertProducts = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxProductName = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxProductID = new System.Windows.Forms.TextBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pageMaterials = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.buttonDeleteMaterials = new System.Windows.Forms.Button();
            this.buttonUpdateMaterials = new System.Windows.Forms.Button();
            this.buttonInsertMaterials = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxMaterialCost = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.textBoxMaterialName = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.textBoxMaterialID = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitcostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rolesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ordersTableAdapter = new TypographyDb.ZueVTypographyDbDataSetTableAdapters.OrdersTableAdapter();
            this.productsTableAdapter = new TypographyDb.ZueVTypographyDbDataSetTableAdapters.ProductsTableAdapter();
            this.materialsTableAdapter = new TypographyDb.ZueVTypographyDbDataSetTableAdapters.MaterialsTableAdapter();
            this.employeesTableAdapter = new TypographyDb.ZueVTypographyDbDataSetTableAdapters.EmployeesTableAdapter();
            this.rolesTableAdapter = new TypographyDb.ZueVTypographyDbDataSetTableAdapters.RolesTableAdapter();
            this.buttonBackOrders = new System.Windows.Forms.Button();
            this.buttonSearchOrders = new System.Windows.Forms.Button();
            this.buttonBackProducts = new System.Windows.Forms.Button();
            this.buttonSearchProducts = new System.Windows.Forms.Button();
            this.buttonBackMaterials = new System.Windows.Forms.Button();
            this.buttonSearchMaterials = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.tabPageSignIn.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.pageEmployees.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zueVTypographyDbDataSet)).BeginInit();
            this.pageOrders.SuspendLayout();
            this.groupBoxOrdersOperations.SuspendLayout();
            this.groupBoxOrdesFields.SuspendLayout();
            this.groupBoxStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).BeginInit();
            this.pageProducts.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            this.pageMaterials.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rolesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPageSignIn);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Location = new System.Drawing.Point(12, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1139, 605);
            this.tabControl.TabIndex = 0;
            // 
            // tabPageSignIn
            // 
            this.tabPageSignIn.BackColor = System.Drawing.Color.Coral;
            this.tabPageSignIn.Controls.Add(this.label2);
            this.tabPageSignIn.Controls.Add(this.label1);
            this.tabPageSignIn.Controls.Add(this.buttonSignIn);
            this.tabPageSignIn.Controls.Add(this.textBoxPassword);
            this.tabPageSignIn.Controls.Add(this.textBoxFIO);
            this.tabPageSignIn.ForeColor = System.Drawing.SystemColors.Control;
            this.tabPageSignIn.Location = new System.Drawing.Point(4, 22);
            this.tabPageSignIn.Name = "tabPageSignIn";
            this.tabPageSignIn.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSignIn.Size = new System.Drawing.Size(1131, 579);
            this.tabPageSignIn.TabIndex = 0;
            this.tabPageSignIn.Text = "Вход";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(520, 248);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Пароль";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(530, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "ФИО";
            // 
            // buttonSignIn
            // 
            this.buttonSignIn.BackColor = System.Drawing.Color.Coral;
            this.buttonSignIn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSignIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSignIn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonSignIn.Location = new System.Drawing.Point(416, 393);
            this.buttonSignIn.Name = "buttonSignIn";
            this.buttonSignIn.Size = new System.Drawing.Size(277, 65);
            this.buttonSignIn.TabIndex = 2;
            this.buttonSignIn.Text = "Войти";
            this.buttonSignIn.UseVisualStyleBackColor = false;
            this.buttonSignIn.Click += new System.EventHandler(this.buttonSignIn_Click);
            this.buttonSignIn.MouseLeave += new System.EventHandler(this.buttonSignIn_MouseLeave);
            this.buttonSignIn.MouseMove += new System.Windows.Forms.MouseEventHandler(this.buttonSignIn_MouseMove);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPassword.Location = new System.Drawing.Point(416, 275);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(277, 38);
            this.textBoxPassword.TabIndex = 1;
            // 
            // textBoxFIO
            // 
            this.textBoxFIO.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxFIO.Location = new System.Drawing.Point(416, 198);
            this.textBoxFIO.Name = "textBoxFIO";
            this.textBoxFIO.Size = new System.Drawing.Size(277, 38);
            this.textBoxFIO.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Coral;
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.comboBox2);
            this.tabPage2.Controls.Add(this.comboBox1);
            this.tabPage2.Controls.Add(this.buttonOrder);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.textBoxQuantity);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1131, 579);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Заказ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(508, 266);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 24);
            this.label5.TabIndex = 10;
            this.label5.Text = "Тираж";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(495, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 24);
            this.label4.TabIndex = 9;
            this.label4.Text = "Материал";
            // 
            // comboBox2
            // 
            this.comboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Глянцевая бумага",
            "Туалетная бумага",
            "Обычная бумага",
            "Тонкий картон"});
            this.comboBox2.Location = new System.Drawing.Point(402, 215);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(277, 39);
            this.comboBox2.TabIndex = 8;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Газета",
            "Открытка",
            "Фотография",
            "Журнал"});
            this.comboBox1.Location = new System.Drawing.Point(402, 136);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(277, 39);
            this.comboBox1.TabIndex = 7;
            // 
            // buttonOrder
            // 
            this.buttonOrder.BackColor = System.Drawing.Color.Coral;
            this.buttonOrder.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOrder.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonOrder.Location = new System.Drawing.Point(402, 408);
            this.buttonOrder.Name = "buttonOrder";
            this.buttonOrder.Size = new System.Drawing.Size(277, 65);
            this.buttonOrder.TabIndex = 6;
            this.buttonOrder.Text = "Заказать";
            this.buttonOrder.UseVisualStyleBackColor = false;
            this.buttonOrder.Click += new System.EventHandler(this.buttonOrder_Click);
            this.buttonOrder.MouseLeave += new System.EventHandler(this.buttonOrder_MouseLeave);
            this.buttonOrder.MouseMove += new System.Windows.Forms.MouseEventHandler(this.buttonOrder_MouseMove);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(499, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "Продукт";
            // 
            // textBoxQuantity
            // 
            this.textBoxQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxQuantity.Location = new System.Drawing.Point(402, 293);
            this.textBoxQuantity.Name = "textBoxQuantity";
            this.textBoxQuantity.Size = new System.Drawing.Size(277, 38);
            this.textBoxQuantity.TabIndex = 4;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.pageOrders);
            this.tabControl1.Controls.Add(this.pageEmployees);
            this.tabControl1.Controls.Add(this.pageProducts);
            this.tabControl1.Controls.Add(this.pageMaterials);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1143, 601);
            this.tabControl1.TabIndex = 1;
            // 
            // pageEmployees
            // 
            this.pageEmployees.BackColor = System.Drawing.Color.Coral;
            this.pageEmployees.Controls.Add(this.groupBox5);
            this.pageEmployees.Controls.Add(this.groupBox6);
            this.pageEmployees.Controls.Add(this.dataGridView3);
            this.pageEmployees.Location = new System.Drawing.Point(4, 22);
            this.pageEmployees.Name = "pageEmployees";
            this.pageEmployees.Padding = new System.Windows.Forms.Padding(3);
            this.pageEmployees.Size = new System.Drawing.Size(1135, 575);
            this.pageEmployees.TabIndex = 3;
            this.pageEmployees.Text = "Сотрудники";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.buttonBackEmployees);
            this.groupBox5.Controls.Add(this.buttonSearchEmployees);
            this.groupBox5.Controls.Add(this.buttonDeleteEmployees);
            this.groupBox5.Controls.Add(this.buttonUpdateEmployees);
            this.groupBox5.Controls.Add(this.buttonInsertEmployees);
            this.groupBox5.Location = new System.Drawing.Point(570, 242);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(255, 156);
            this.groupBox5.TabIndex = 14;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Операции (admin only)";
            // 
            // buttonBackEmployees
            // 
            this.buttonBackEmployees.Location = new System.Drawing.Point(57, 127);
            this.buttonBackEmployees.Name = "buttonBackEmployees";
            this.buttonBackEmployees.Size = new System.Drawing.Size(140, 23);
            this.buttonBackEmployees.TabIndex = 14;
            this.buttonBackEmployees.Text = "Вернуть таблицу";
            this.buttonBackEmployees.UseVisualStyleBackColor = true;
            this.buttonBackEmployees.Click += new System.EventHandler(this.buttonBackEmployees_Click);
            // 
            // buttonSearchEmployees
            // 
            this.buttonSearchEmployees.Location = new System.Drawing.Point(57, 98);
            this.buttonSearchEmployees.Name = "buttonSearchEmployees";
            this.buttonSearchEmployees.Size = new System.Drawing.Size(140, 23);
            this.buttonSearchEmployees.TabIndex = 13;
            this.buttonSearchEmployees.Text = "Найти по ID";
            this.buttonSearchEmployees.UseVisualStyleBackColor = true;
            this.buttonSearchEmployees.Click += new System.EventHandler(this.buttonSearchEmployees_Click);
            // 
            // buttonDeleteEmployees
            // 
            this.buttonDeleteEmployees.Location = new System.Drawing.Point(57, 72);
            this.buttonDeleteEmployees.Name = "buttonDeleteEmployees";
            this.buttonDeleteEmployees.Size = new System.Drawing.Size(140, 23);
            this.buttonDeleteEmployees.TabIndex = 12;
            this.buttonDeleteEmployees.Text = "Удалить";
            this.buttonDeleteEmployees.UseVisualStyleBackColor = true;
            this.buttonDeleteEmployees.Click += new System.EventHandler(this.buttonDeleteEmployees_Click);
            // 
            // buttonUpdateEmployees
            // 
            this.buttonUpdateEmployees.Location = new System.Drawing.Point(57, 43);
            this.buttonUpdateEmployees.Name = "buttonUpdateEmployees";
            this.buttonUpdateEmployees.Size = new System.Drawing.Size(140, 23);
            this.buttonUpdateEmployees.TabIndex = 10;
            this.buttonUpdateEmployees.Text = "Изменить";
            this.buttonUpdateEmployees.UseVisualStyleBackColor = true;
            this.buttonUpdateEmployees.Click += new System.EventHandler(this.buttonUpdateEmployees_Click);
            // 
            // buttonInsertEmployees
            // 
            this.buttonInsertEmployees.Location = new System.Drawing.Point(57, 16);
            this.buttonInsertEmployees.Name = "buttonInsertEmployees";
            this.buttonInsertEmployees.Size = new System.Drawing.Size(140, 23);
            this.buttonInsertEmployees.TabIndex = 9;
            this.buttonInsertEmployees.Text = "Добавить";
            this.buttonInsertEmployees.UseVisualStyleBackColor = true;
            this.buttonInsertEmployees.Click += new System.EventHandler(this.buttonInsertEmployees_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.label20);
            this.groupBox6.Controls.Add(this.textBoxEmployeePos);
            this.groupBox6.Controls.Add(this.label7);
            this.groupBox6.Controls.Add(this.textBoxEmployeePassword);
            this.groupBox6.Controls.Add(this.label17);
            this.groupBox6.Controls.Add(this.textBoxEmployeeRoleID);
            this.groupBox6.Controls.Add(this.label18);
            this.groupBox6.Controls.Add(this.textBoxEmployeeFIO);
            this.groupBox6.Controls.Add(this.label19);
            this.groupBox6.Controls.Add(this.textBoxEmployeeID);
            this.groupBox6.Location = new System.Drawing.Point(282, 242);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(282, 156);
            this.groupBox6.TabIndex = 13;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Поля данных";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(104, 129);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(65, 13);
            this.label20.TabIndex = 26;
            this.label20.Text = "Должность";
            // 
            // textBoxEmployeePos
            // 
            this.textBoxEmployeePos.Location = new System.Drawing.Point(15, 126);
            this.textBoxEmployeePos.Name = "textBoxEmployeePos";
            this.textBoxEmployeePos.Size = new System.Drawing.Size(83, 20);
            this.textBoxEmployeePos.TabIndex = 25;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(104, 103);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "Пароль";
            // 
            // textBoxEmployeePassword
            // 
            this.textBoxEmployeePassword.Location = new System.Drawing.Point(15, 100);
            this.textBoxEmployeePassword.Name = "textBoxEmployeePassword";
            this.textBoxEmployeePassword.Size = new System.Drawing.Size(83, 20);
            this.textBoxEmployeePassword.TabIndex = 24;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(59, 77);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(46, 13);
            this.label17.TabIndex = 21;
            this.label17.Text = "ID Роли";
            // 
            // textBoxEmployeeRoleID
            // 
            this.textBoxEmployeeRoleID.Location = new System.Drawing.Point(15, 74);
            this.textBoxEmployeeRoleID.Name = "textBoxEmployeeRoleID";
            this.textBoxEmployeeRoleID.Size = new System.Drawing.Size(38, 20);
            this.textBoxEmployeeRoleID.TabIndex = 22;
            this.textBoxEmployeeRoleID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxEmployeeRoleID_KeyPress);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(191, 48);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(34, 13);
            this.label18.TabIndex = 19;
            this.label18.Text = "ФИО";
            // 
            // textBoxEmployeeFIO
            // 
            this.textBoxEmployeeFIO.Location = new System.Drawing.Point(15, 48);
            this.textBoxEmployeeFIO.Name = "textBoxEmployeeFIO";
            this.textBoxEmployeeFIO.Size = new System.Drawing.Size(170, 20);
            this.textBoxEmployeeFIO.TabIndex = 20;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(59, 25);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(79, 13);
            this.label19.TabIndex = 17;
            this.label19.Text = "ID сотрудника";
            // 
            // textBoxEmployeeID
            // 
            this.textBoxEmployeeID.Location = new System.Drawing.Point(15, 22);
            this.textBoxEmployeeID.Name = "textBoxEmployeeID";
            this.textBoxEmployeeID.Size = new System.Drawing.Size(38, 20);
            this.textBoxEmployeeID.TabIndex = 18;
            this.textBoxEmployeeID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxEmployeeID_KeyPress);
            // 
            // dataGridView3
            // 
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn3,
            this.fIODataGridViewTextBoxColumn,
            this.roleIDDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn,
            this.positionDataGridViewTextBoxColumn});
            this.dataGridView3.DataSource = this.employeesBindingSource;
            this.dataGridView3.Location = new System.Drawing.Point(282, 78);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(543, 150);
            this.dataGridView3.TabIndex = 0;
            // 
            // iDDataGridViewTextBoxColumn3
            // 
            this.iDDataGridViewTextBoxColumn3.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn3.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn3.Name = "iDDataGridViewTextBoxColumn3";
            this.iDDataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // fIODataGridViewTextBoxColumn
            // 
            this.fIODataGridViewTextBoxColumn.DataPropertyName = "FIO";
            this.fIODataGridViewTextBoxColumn.HeaderText = "FIO";
            this.fIODataGridViewTextBoxColumn.Name = "fIODataGridViewTextBoxColumn";
            // 
            // roleIDDataGridViewTextBoxColumn
            // 
            this.roleIDDataGridViewTextBoxColumn.DataPropertyName = "Role_ID";
            this.roleIDDataGridViewTextBoxColumn.HeaderText = "Role_ID";
            this.roleIDDataGridViewTextBoxColumn.Name = "roleIDDataGridViewTextBoxColumn";
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "Password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "Password";
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            // 
            // positionDataGridViewTextBoxColumn
            // 
            this.positionDataGridViewTextBoxColumn.DataPropertyName = "Position";
            this.positionDataGridViewTextBoxColumn.HeaderText = "Position";
            this.positionDataGridViewTextBoxColumn.Name = "positionDataGridViewTextBoxColumn";
            // 
            // employeesBindingSource
            // 
            this.employeesBindingSource.DataMember = "Employees";
            this.employeesBindingSource.DataSource = this.zueVTypographyDbDataSet;
            // 
            // zueVTypographyDbDataSet
            // 
            this.zueVTypographyDbDataSet.DataSetName = "ZueVTypographyDbDataSet";
            this.zueVTypographyDbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pageOrders
            // 
            this.pageOrders.BackColor = System.Drawing.Color.Coral;
            this.pageOrders.Controls.Add(this.groupBoxOrdersOperations);
            this.pageOrders.Controls.Add(this.groupBoxOrdesFields);
            this.pageOrders.Controls.Add(this.groupBoxStatus);
            this.pageOrders.Controls.Add(this.dataGridViewOrders);
            this.pageOrders.Location = new System.Drawing.Point(4, 22);
            this.pageOrders.Name = "pageOrders";
            this.pageOrders.Padding = new System.Windows.Forms.Padding(3);
            this.pageOrders.Size = new System.Drawing.Size(1135, 575);
            this.pageOrders.TabIndex = 1;
            this.pageOrders.Text = "Заказы";
            // 
            // groupBoxOrdersOperations
            // 
            this.groupBoxOrdersOperations.Controls.Add(this.buttonBackOrders);
            this.groupBoxOrdersOperations.Controls.Add(this.buttonSearchOrders);
            this.groupBoxOrdersOperations.Controls.Add(this.buttonOrdersDelete);
            this.groupBoxOrdersOperations.Controls.Add(this.buttonOrdersUpdate);
            this.groupBoxOrdersOperations.Controls.Add(this.buttonOrdersInsert);
            this.groupBoxOrdersOperations.Location = new System.Drawing.Point(650, 227);
            this.groupBoxOrdersOperations.Name = "groupBoxOrdersOperations";
            this.groupBoxOrdersOperations.Size = new System.Drawing.Size(195, 176);
            this.groupBoxOrdersOperations.TabIndex = 12;
            this.groupBoxOrdersOperations.TabStop = false;
            this.groupBoxOrdersOperations.Text = "Операции (admin only)";
            // 
            // buttonOrdersDelete
            // 
            this.buttonOrdersDelete.Location = new System.Drawing.Point(30, 73);
            this.buttonOrdersDelete.Name = "buttonOrdersDelete";
            this.buttonOrdersDelete.Size = new System.Drawing.Size(140, 23);
            this.buttonOrdersDelete.TabIndex = 12;
            this.buttonOrdersDelete.Text = "Удалить";
            this.buttonOrdersDelete.UseVisualStyleBackColor = true;
            this.buttonOrdersDelete.Click += new System.EventHandler(this.buttonOrdersDelete_Click);
            // 
            // buttonOrdersUpdate
            // 
            this.buttonOrdersUpdate.Location = new System.Drawing.Point(30, 44);
            this.buttonOrdersUpdate.Name = "buttonOrdersUpdate";
            this.buttonOrdersUpdate.Size = new System.Drawing.Size(140, 23);
            this.buttonOrdersUpdate.TabIndex = 10;
            this.buttonOrdersUpdate.Text = "Изменить";
            this.buttonOrdersUpdate.UseVisualStyleBackColor = true;
            this.buttonOrdersUpdate.Click += new System.EventHandler(this.buttonOrdersUpdate_Click);
            // 
            // buttonOrdersInsert
            // 
            this.buttonOrdersInsert.Location = new System.Drawing.Point(30, 17);
            this.buttonOrdersInsert.Name = "buttonOrdersInsert";
            this.buttonOrdersInsert.Size = new System.Drawing.Size(140, 23);
            this.buttonOrdersInsert.TabIndex = 9;
            this.buttonOrdersInsert.Text = "Добавить";
            this.buttonOrdersInsert.UseVisualStyleBackColor = true;
            this.buttonOrdersInsert.Click += new System.EventHandler(this.buttonOrdersInsert_Click);
            // 
            // groupBoxOrdesFields
            // 
            this.groupBoxOrdesFields.Controls.Add(this.checkBoxStatus);
            this.groupBoxOrdesFields.Controls.Add(this.label11);
            this.groupBoxOrdesFields.Controls.Add(this.textBoxQuantityTable);
            this.groupBoxOrdesFields.Controls.Add(this.label12);
            this.groupBoxOrdesFields.Controls.Add(this.textBoxIDProduct);
            this.groupBoxOrdesFields.Controls.Add(this.label13);
            this.groupBoxOrdesFields.Controls.Add(this.textBoxIDMaterial);
            this.groupBoxOrdesFields.Controls.Add(this.label14);
            this.groupBoxOrdesFields.Controls.Add(this.textBoxIDOrder);
            this.groupBoxOrdesFields.Location = new System.Drawing.Point(476, 227);
            this.groupBoxOrdesFields.Name = "groupBoxOrdesFields";
            this.groupBoxOrdesFields.Size = new System.Drawing.Size(168, 176);
            this.groupBoxOrdesFields.TabIndex = 11;
            this.groupBoxOrdesFields.TabStop = false;
            this.groupBoxOrdesFields.Text = "Поля данных";
            // 
            // checkBoxStatus
            // 
            this.checkBoxStatus.AutoSize = true;
            this.checkBoxStatus.Location = new System.Drawing.Point(15, 126);
            this.checkBoxStatus.Name = "checkBoxStatus";
            this.checkBoxStatus.Size = new System.Drawing.Size(55, 17);
            this.checkBoxStatus.TabIndex = 16;
            this.checkBoxStatus.Text = "Готов";
            this.checkBoxStatus.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(59, 103);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(66, 13);
            this.label11.TabIndex = 23;
            this.label11.Text = "Количество";
            // 
            // textBoxQuantityTable
            // 
            this.textBoxQuantityTable.Location = new System.Drawing.Point(15, 100);
            this.textBoxQuantityTable.Name = "textBoxQuantityTable";
            this.textBoxQuantityTable.Size = new System.Drawing.Size(38, 20);
            this.textBoxQuantityTable.TabIndex = 24;
            this.textBoxQuantityTable.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxQuantityTable_KeyPress);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(59, 77);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(63, 13);
            this.label12.TabIndex = 21;
            this.label12.Text = "ID изделия";
            // 
            // textBoxIDProduct
            // 
            this.textBoxIDProduct.Location = new System.Drawing.Point(15, 74);
            this.textBoxIDProduct.Name = "textBoxIDProduct";
            this.textBoxIDProduct.Size = new System.Drawing.Size(38, 20);
            this.textBoxIDProduct.TabIndex = 22;
            this.textBoxIDProduct.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxIDProduct_KeyPress);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(59, 51);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(76, 13);
            this.label13.TabIndex = 19;
            this.label13.Text = "ID материала";
            // 
            // textBoxIDMaterial
            // 
            this.textBoxIDMaterial.Location = new System.Drawing.Point(15, 48);
            this.textBoxIDMaterial.Name = "textBoxIDMaterial";
            this.textBoxIDMaterial.Size = new System.Drawing.Size(38, 20);
            this.textBoxIDMaterial.TabIndex = 20;
            this.textBoxIDMaterial.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxIDMaterial_KeyPress);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(59, 25);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(57, 13);
            this.label14.TabIndex = 17;
            this.label14.Text = "ID заказа";
            // 
            // textBoxIDOrder
            // 
            this.textBoxIDOrder.Location = new System.Drawing.Point(15, 22);
            this.textBoxIDOrder.Name = "textBoxIDOrder";
            this.textBoxIDOrder.Size = new System.Drawing.Size(38, 20);
            this.textBoxIDOrder.TabIndex = 18;
            this.textBoxIDOrder.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxIDOrder_KeyPress);
            // 
            // groupBoxStatus
            // 
            this.groupBoxStatus.Controls.Add(this.label6);
            this.groupBoxStatus.Controls.Add(this.textBoxIDOrderManager);
            this.groupBoxStatus.Controls.Add(this.buttonUpdateStatus);
            this.groupBoxStatus.Controls.Add(this.checkBoxStatusManager);
            this.groupBoxStatus.Location = new System.Drawing.Point(302, 227);
            this.groupBoxStatus.Name = "groupBoxStatus";
            this.groupBoxStatus.Size = new System.Drawing.Size(168, 176);
            this.groupBoxStatus.TabIndex = 10;
            this.groupBoxStatus.TabStop = false;
            this.groupBoxStatus.Text = "Статус";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(88, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "ID заказа";
            // 
            // textBoxIDOrderManager
            // 
            this.textBoxIDOrderManager.Location = new System.Drawing.Point(17, 19);
            this.textBoxIDOrderManager.Name = "textBoxIDOrderManager";
            this.textBoxIDOrderManager.Size = new System.Drawing.Size(65, 20);
            this.textBoxIDOrderManager.TabIndex = 1;
            this.textBoxIDOrderManager.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxIDOrderManager_KeyPress);
            // 
            // buttonUpdateStatus
            // 
            this.buttonUpdateStatus.Location = new System.Drawing.Point(17, 68);
            this.buttonUpdateStatus.Name = "buttonUpdateStatus";
            this.buttonUpdateStatus.Size = new System.Drawing.Size(75, 23);
            this.buttonUpdateStatus.TabIndex = 6;
            this.buttonUpdateStatus.Text = "Изменить";
            this.buttonUpdateStatus.UseVisualStyleBackColor = true;
            this.buttonUpdateStatus.Click += new System.EventHandler(this.buttonUpdateStatus_Click);
            // 
            // checkBoxStatusManager
            // 
            this.checkBoxStatusManager.AutoSize = true;
            this.checkBoxStatusManager.Location = new System.Drawing.Point(17, 45);
            this.checkBoxStatusManager.Name = "checkBoxStatusManager";
            this.checkBoxStatusManager.Size = new System.Drawing.Size(55, 17);
            this.checkBoxStatusManager.TabIndex = 5;
            this.checkBoxStatusManager.Text = "Готов";
            this.checkBoxStatusManager.UseVisualStyleBackColor = true;
            // 
            // dataGridViewOrders
            // 
            this.dataGridViewOrders.AutoGenerateColumns = false;
            this.dataGridViewOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOrders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.materialIDDataGridViewTextBoxColumn,
            this.productIDDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.statusDoneDataGridViewCheckBoxColumn});
            this.dataGridViewOrders.DataSource = this.ordersBindingSource;
            this.dataGridViewOrders.Location = new System.Drawing.Point(302, 71);
            this.dataGridViewOrders.Name = "dataGridViewOrders";
            this.dataGridViewOrders.Size = new System.Drawing.Size(543, 150);
            this.dataGridViewOrders.TabIndex = 0;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // materialIDDataGridViewTextBoxColumn
            // 
            this.materialIDDataGridViewTextBoxColumn.DataPropertyName = "Material_ID";
            this.materialIDDataGridViewTextBoxColumn.HeaderText = "Material_ID";
            this.materialIDDataGridViewTextBoxColumn.Name = "materialIDDataGridViewTextBoxColumn";
            // 
            // productIDDataGridViewTextBoxColumn
            // 
            this.productIDDataGridViewTextBoxColumn.DataPropertyName = "Product_ID";
            this.productIDDataGridViewTextBoxColumn.HeaderText = "Product_ID";
            this.productIDDataGridViewTextBoxColumn.Name = "productIDDataGridViewTextBoxColumn";
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            // 
            // statusDoneDataGridViewCheckBoxColumn
            // 
            this.statusDoneDataGridViewCheckBoxColumn.DataPropertyName = "Status_Done";
            this.statusDoneDataGridViewCheckBoxColumn.HeaderText = "Status_Done";
            this.statusDoneDataGridViewCheckBoxColumn.Name = "statusDoneDataGridViewCheckBoxColumn";
            // 
            // ordersBindingSource
            // 
            this.ordersBindingSource.DataMember = "Orders";
            this.ordersBindingSource.DataSource = this.zueVTypographyDbDataSet;
            // 
            // pageProducts
            // 
            this.pageProducts.BackColor = System.Drawing.Color.Coral;
            this.pageProducts.Controls.Add(this.groupBox1);
            this.pageProducts.Controls.Add(this.groupBox2);
            this.pageProducts.Controls.Add(this.dataGridView2);
            this.pageProducts.Location = new System.Drawing.Point(4, 22);
            this.pageProducts.Name = "pageProducts";
            this.pageProducts.Padding = new System.Windows.Forms.Padding(3);
            this.pageProducts.Size = new System.Drawing.Size(1135, 575);
            this.pageProducts.TabIndex = 0;
            this.pageProducts.Text = "Изделия";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonBackProducts);
            this.groupBox1.Controls.Add(this.buttonInsertProducts);
            this.groupBox1.Controls.Add(this.buttonSearchProducts);
            this.groupBox1.Controls.Add(this.buttonUpdateProducts);
            this.groupBox1.Controls.Add(this.buttonDeleteProducts);
            this.groupBox1.Location = new System.Drawing.Point(553, 262);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(195, 165);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Операции";
            // 
            // buttonDeleteProducts
            // 
            this.buttonDeleteProducts.Location = new System.Drawing.Point(32, 73);
            this.buttonDeleteProducts.Name = "buttonDeleteProducts";
            this.buttonDeleteProducts.Size = new System.Drawing.Size(140, 23);
            this.buttonDeleteProducts.TabIndex = 12;
            this.buttonDeleteProducts.Text = "Удалить";
            this.buttonDeleteProducts.UseVisualStyleBackColor = true;
            this.buttonDeleteProducts.Click += new System.EventHandler(this.buttonDeleteProducts_Click);
            // 
            // buttonUpdateProducts
            // 
            this.buttonUpdateProducts.Location = new System.Drawing.Point(32, 44);
            this.buttonUpdateProducts.Name = "buttonUpdateProducts";
            this.buttonUpdateProducts.Size = new System.Drawing.Size(140, 23);
            this.buttonUpdateProducts.TabIndex = 10;
            this.buttonUpdateProducts.Text = "Изменить";
            this.buttonUpdateProducts.UseVisualStyleBackColor = true;
            this.buttonUpdateProducts.Click += new System.EventHandler(this.buttonUpdateProducts_Click);
            // 
            // buttonInsertProducts
            // 
            this.buttonInsertProducts.Location = new System.Drawing.Point(32, 17);
            this.buttonInsertProducts.Name = "buttonInsertProducts";
            this.buttonInsertProducts.Size = new System.Drawing.Size(140, 23);
            this.buttonInsertProducts.TabIndex = 9;
            this.buttonInsertProducts.Text = "Добавить";
            this.buttonInsertProducts.UseVisualStyleBackColor = true;
            this.buttonInsertProducts.Click += new System.EventHandler(this.buttonInsertProducts_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.textBoxProductName);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.textBoxProductID);
            this.groupBox2.Location = new System.Drawing.Point(379, 262);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(168, 165);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Поля данных";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(59, 51);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Название";
            // 
            // textBoxProductName
            // 
            this.textBoxProductName.Location = new System.Drawing.Point(15, 48);
            this.textBoxProductName.Name = "textBoxProductName";
            this.textBoxProductName.Size = new System.Drawing.Size(38, 20);
            this.textBoxProductName.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(59, 25);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "ID изделия";
            // 
            // textBoxProductID
            // 
            this.textBoxProductID.Location = new System.Drawing.Point(15, 22);
            this.textBoxProductID.Name = "textBoxProductID";
            this.textBoxProductID.Size = new System.Drawing.Size(38, 20);
            this.textBoxProductID.TabIndex = 18;
            this.textBoxProductID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxProductID_KeyPress);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn1,
            this.nameDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.productsBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(379, 95);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(369, 150);
            this.dataGridView2.TabIndex = 0;
            // 
            // iDDataGridViewTextBoxColumn1
            // 
            this.iDDataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn1.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn1.Name = "iDDataGridViewTextBoxColumn1";
            this.iDDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // productsBindingSource
            // 
            this.productsBindingSource.DataMember = "Products";
            this.productsBindingSource.DataSource = this.zueVTypographyDbDataSet;
            // 
            // pageMaterials
            // 
            this.pageMaterials.BackColor = System.Drawing.Color.Coral;
            this.pageMaterials.Controls.Add(this.groupBox3);
            this.pageMaterials.Controls.Add(this.groupBox4);
            this.pageMaterials.Controls.Add(this.dataGridView1);
            this.pageMaterials.Location = new System.Drawing.Point(4, 22);
            this.pageMaterials.Name = "pageMaterials";
            this.pageMaterials.Padding = new System.Windows.Forms.Padding(3);
            this.pageMaterials.Size = new System.Drawing.Size(1135, 575);
            this.pageMaterials.TabIndex = 2;
            this.pageMaterials.Text = "Материалы";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.buttonBackMaterials);
            this.groupBox3.Controls.Add(this.buttonSearchMaterials);
            this.groupBox3.Controls.Add(this.buttonInsertMaterials);
            this.groupBox3.Controls.Add(this.buttonDeleteMaterials);
            this.groupBox3.Controls.Add(this.buttonUpdateMaterials);
            this.groupBox3.Location = new System.Drawing.Point(542, 263);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(195, 174);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Операции (admin only)";
            // 
            // buttonDeleteMaterials
            // 
            this.buttonDeleteMaterials.Location = new System.Drawing.Point(29, 74);
            this.buttonDeleteMaterials.Name = "buttonDeleteMaterials";
            this.buttonDeleteMaterials.Size = new System.Drawing.Size(140, 23);
            this.buttonDeleteMaterials.TabIndex = 12;
            this.buttonDeleteMaterials.Text = "Удалить";
            this.buttonDeleteMaterials.UseVisualStyleBackColor = true;
            this.buttonDeleteMaterials.Click += new System.EventHandler(this.buttonDeleteMaterials_Click);
            // 
            // buttonUpdateMaterials
            // 
            this.buttonUpdateMaterials.Location = new System.Drawing.Point(29, 45);
            this.buttonUpdateMaterials.Name = "buttonUpdateMaterials";
            this.buttonUpdateMaterials.Size = new System.Drawing.Size(140, 23);
            this.buttonUpdateMaterials.TabIndex = 10;
            this.buttonUpdateMaterials.Text = "Изменить";
            this.buttonUpdateMaterials.UseVisualStyleBackColor = true;
            this.buttonUpdateMaterials.Click += new System.EventHandler(this.buttonUpdateMaterials_Click);
            // 
            // buttonInsertMaterials
            // 
            this.buttonInsertMaterials.Location = new System.Drawing.Point(29, 18);
            this.buttonInsertMaterials.Name = "buttonInsertMaterials";
            this.buttonInsertMaterials.Size = new System.Drawing.Size(140, 23);
            this.buttonInsertMaterials.TabIndex = 9;
            this.buttonInsertMaterials.Text = "Добавить";
            this.buttonInsertMaterials.UseVisualStyleBackColor = true;
            this.buttonInsertMaterials.Click += new System.EventHandler(this.buttonInsertMaterials_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.textBoxMaterialCost);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Controls.Add(this.textBoxMaterialName);
            this.groupBox4.Controls.Add(this.label16);
            this.groupBox4.Controls.Add(this.textBoxMaterialID);
            this.groupBox4.Location = new System.Drawing.Point(368, 263);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(168, 174);
            this.groupBox4.TabIndex = 13;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Поля данных";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(59, 77);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "Цена/шт";
            // 
            // textBoxMaterialCost
            // 
            this.textBoxMaterialCost.Location = new System.Drawing.Point(15, 74);
            this.textBoxMaterialCost.Name = "textBoxMaterialCost";
            this.textBoxMaterialCost.Size = new System.Drawing.Size(38, 20);
            this.textBoxMaterialCost.TabIndex = 22;
            this.textBoxMaterialCost.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxMaterialCost_KeyPress);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(59, 51);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(57, 13);
            this.label15.TabIndex = 19;
            this.label15.Text = "Название";
            // 
            // textBoxMaterialName
            // 
            this.textBoxMaterialName.Location = new System.Drawing.Point(15, 48);
            this.textBoxMaterialName.Name = "textBoxMaterialName";
            this.textBoxMaterialName.Size = new System.Drawing.Size(38, 20);
            this.textBoxMaterialName.TabIndex = 20;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(59, 25);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(76, 13);
            this.label16.TabIndex = 17;
            this.label16.Text = "ID материала";
            // 
            // textBoxMaterialID
            // 
            this.textBoxMaterialID.Location = new System.Drawing.Point(15, 22);
            this.textBoxMaterialID.Name = "textBoxMaterialID";
            this.textBoxMaterialID.Size = new System.Drawing.Size(38, 20);
            this.textBoxMaterialID.TabIndex = 18;
            this.textBoxMaterialID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxMaterialID_KeyPress);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn2,
            this.nameDataGridViewTextBoxColumn1,
            this.unitcostDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.materialsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(368, 95);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(369, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // iDDataGridViewTextBoxColumn2
            // 
            this.iDDataGridViewTextBoxColumn2.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn2.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn2.Name = "iDDataGridViewTextBoxColumn2";
            this.iDDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn1
            // 
            this.nameDataGridViewTextBoxColumn1.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn1.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
            // 
            // unitcostDataGridViewTextBoxColumn
            // 
            this.unitcostDataGridViewTextBoxColumn.DataPropertyName = "Unit_cost";
            this.unitcostDataGridViewTextBoxColumn.HeaderText = "Unit_cost";
            this.unitcostDataGridViewTextBoxColumn.Name = "unitcostDataGridViewTextBoxColumn";
            // 
            // materialsBindingSource
            // 
            this.materialsBindingSource.DataMember = "Materials";
            this.materialsBindingSource.DataSource = this.zueVTypographyDbDataSet;
            // 
            // rolesBindingSource
            // 
            this.rolesBindingSource.DataMember = "Roles";
            this.rolesBindingSource.DataSource = this.zueVTypographyDbDataSet;
            // 
            // ordersTableAdapter
            // 
            this.ordersTableAdapter.ClearBeforeFill = true;
            // 
            // productsTableAdapter
            // 
            this.productsTableAdapter.ClearBeforeFill = true;
            // 
            // materialsTableAdapter
            // 
            this.materialsTableAdapter.ClearBeforeFill = true;
            // 
            // employeesTableAdapter
            // 
            this.employeesTableAdapter.ClearBeforeFill = true;
            // 
            // rolesTableAdapter
            // 
            this.rolesTableAdapter.ClearBeforeFill = true;
            // 
            // buttonBackOrders
            // 
            this.buttonBackOrders.Location = new System.Drawing.Point(30, 132);
            this.buttonBackOrders.Name = "buttonBackOrders";
            this.buttonBackOrders.Size = new System.Drawing.Size(140, 23);
            this.buttonBackOrders.TabIndex = 16;
            this.buttonBackOrders.Text = "Вернуть таблицу";
            this.buttonBackOrders.UseVisualStyleBackColor = true;
            this.buttonBackOrders.Click += new System.EventHandler(this.buttonBackOrders_Click);
            // 
            // buttonSearchOrders
            // 
            this.buttonSearchOrders.Location = new System.Drawing.Point(30, 103);
            this.buttonSearchOrders.Name = "buttonSearchOrders";
            this.buttonSearchOrders.Size = new System.Drawing.Size(140, 23);
            this.buttonSearchOrders.TabIndex = 15;
            this.buttonSearchOrders.Text = "Найти по ID";
            this.buttonSearchOrders.UseVisualStyleBackColor = true;
            this.buttonSearchOrders.Click += new System.EventHandler(this.buttonSearchOrders_Click);
            // 
            // buttonBackProducts
            // 
            this.buttonBackProducts.Location = new System.Drawing.Point(32, 131);
            this.buttonBackProducts.Name = "buttonBackProducts";
            this.buttonBackProducts.Size = new System.Drawing.Size(140, 23);
            this.buttonBackProducts.TabIndex = 16;
            this.buttonBackProducts.Text = "Вернуть таблицу";
            this.buttonBackProducts.UseVisualStyleBackColor = true;
            this.buttonBackProducts.Click += new System.EventHandler(this.buttonBackProducts_Click);
            // 
            // buttonSearchProducts
            // 
            this.buttonSearchProducts.Location = new System.Drawing.Point(32, 102);
            this.buttonSearchProducts.Name = "buttonSearchProducts";
            this.buttonSearchProducts.Size = new System.Drawing.Size(140, 23);
            this.buttonSearchProducts.TabIndex = 15;
            this.buttonSearchProducts.Text = "Найти по ID";
            this.buttonSearchProducts.UseVisualStyleBackColor = true;
            this.buttonSearchProducts.Click += new System.EventHandler(this.buttonSearchProducts_Click);
            // 
            // buttonBackMaterials
            // 
            this.buttonBackMaterials.Location = new System.Drawing.Point(29, 130);
            this.buttonBackMaterials.Name = "buttonBackMaterials";
            this.buttonBackMaterials.Size = new System.Drawing.Size(140, 23);
            this.buttonBackMaterials.TabIndex = 16;
            this.buttonBackMaterials.Text = "Вернуть таблицу";
            this.buttonBackMaterials.UseVisualStyleBackColor = true;
            this.buttonBackMaterials.Click += new System.EventHandler(this.buttonBackMaterials_Click);
            // 
            // buttonSearchMaterials
            // 
            this.buttonSearchMaterials.Location = new System.Drawing.Point(29, 101);
            this.buttonSearchMaterials.Name = "buttonSearchMaterials";
            this.buttonSearchMaterials.Size = new System.Drawing.Size(140, 23);
            this.buttonSearchMaterials.TabIndex = 15;
            this.buttonSearchMaterials.Text = "Найти по ID";
            this.buttonSearchMaterials.UseVisualStyleBackColor = true;
            this.buttonSearchMaterials.Click += new System.EventHandler(this.buttonSearchMaterials_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1167, 629);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.tabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "TypogrphyDb";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl.ResumeLayout(false);
            this.tabPageSignIn.ResumeLayout(false);
            this.tabPageSignIn.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.pageEmployees.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zueVTypographyDbDataSet)).EndInit();
            this.pageOrders.ResumeLayout(false);
            this.groupBoxOrdersOperations.ResumeLayout(false);
            this.groupBoxOrdesFields.ResumeLayout(false);
            this.groupBoxOrdesFields.PerformLayout();
            this.groupBoxStatus.ResumeLayout(false);
            this.groupBoxStatus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).EndInit();
            this.pageProducts.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            this.pageMaterials.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rolesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPageSignIn;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonSignIn;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxFIO;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonOrder;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxQuantity;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage pageProducts;
        private System.Windows.Forms.TabPage pageOrders;
        private System.Windows.Forms.TabPage pageMaterials;
        private System.Windows.Forms.TabPage pageEmployees;
        private System.Windows.Forms.DataGridView dataGridViewOrders;
        private ZueVTypographyDbDataSet zueVTypographyDbDataSet;
        private System.Windows.Forms.BindingSource ordersBindingSource;
        private ZueVTypographyDbDataSetTableAdapters.OrdersTableAdapter ordersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn materialIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn statusDoneDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private ZueVTypographyDbDataSetTableAdapters.ProductsTableAdapter productsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button buttonUpdateStatus;
        private System.Windows.Forms.TextBox textBoxIDOrderManager;
        private System.Windows.Forms.CheckBox checkBoxStatusManager;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBoxOrdersOperations;
        private System.Windows.Forms.Button buttonOrdersDelete;
        private System.Windows.Forms.Button buttonOrdersUpdate;
        private System.Windows.Forms.Button buttonOrdersInsert;
        private System.Windows.Forms.GroupBox groupBoxOrdesFields;
        private System.Windows.Forms.CheckBox checkBoxStatus;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBoxQuantityTable;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBoxIDProduct;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBoxIDMaterial;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBoxIDOrder;
        private System.Windows.Forms.GroupBox groupBoxStatus;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonDeleteProducts;
        private System.Windows.Forms.Button buttonUpdateProducts;
        private System.Windows.Forms.Button buttonInsertProducts;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxProductName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxProductID;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource materialsBindingSource;
        private ZueVTypographyDbDataSetTableAdapters.MaterialsTableAdapter materialsTableAdapter;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button buttonDeleteMaterials;
        private System.Windows.Forms.Button buttonUpdateMaterials;
        private System.Windows.Forms.Button buttonInsertMaterials;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxMaterialCost;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textBoxMaterialName;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox textBoxMaterialID;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitcostDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.BindingSource employeesBindingSource;
        private ZueVTypographyDbDataSetTableAdapters.EmployeesTableAdapter employeesTableAdapter;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button buttonDeleteEmployees;
        private System.Windows.Forms.Button buttonUpdateEmployees;
        private System.Windows.Forms.Button buttonInsertEmployees;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxEmployeePassword;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox textBoxEmployeeRoleID;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox textBoxEmployeeFIO;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox textBoxEmployeeID;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn fIODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roleIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn positionDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox textBoxEmployeePos;
        private System.Windows.Forms.BindingSource rolesBindingSource;
        private ZueVTypographyDbDataSetTableAdapters.RolesTableAdapter rolesTableAdapter;
        private System.Windows.Forms.Button buttonSearchEmployees;
        private System.Windows.Forms.Button buttonBackEmployees;
        private System.Windows.Forms.Button buttonBackOrders;
        private System.Windows.Forms.Button buttonSearchOrders;
        private System.Windows.Forms.Button buttonBackProducts;
        private System.Windows.Forms.Button buttonSearchProducts;
        private System.Windows.Forms.Button buttonBackMaterials;
        private System.Windows.Forms.Button buttonSearchMaterials;
    }
}

