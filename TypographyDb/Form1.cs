using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace TypographyDb
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            tabControl1.Hide();
        }
        static string connectionString = "Data Source=ADCLG1;Initial Catalog=ZueVTypographyDb;Integrated Security=True;Encrypt=False";
        SqlConnection MyConnection = new SqlConnection(connectionString);

        public static SqlConnection getSqlConn()
        {
            string connectionString = "Data Source=ADCLG1;Initial Catalog=ZueVTypographyDb;Integrated Security=True;Encrypt=False";
            return new SqlConnection(connectionString);
        }


        private void buttonSignIn_MouseMove(object sender, MouseEventArgs e)
        {
            buttonSignIn.FlatStyle = FlatStyle.Flat;
            buttonSignIn.FlatAppearance.BorderColor = Color.Black;
            buttonSignIn.BackColor = Color.OrangeRed;
        }

        private void buttonSignIn_MouseLeave(object sender, EventArgs e)
        {
            buttonSignIn.FlatStyle = FlatStyle.Popup;
            buttonSignIn.BackColor = Color.Coral;

        }

        private void buttonSignIn_Click(object sender, EventArgs e)
        {
            if (textBoxFIO.Text == "" || textBoxPassword.Text == "")
            {
                MessageBox.Show("Не все поля заполнены", "Предупреждение");
            }
            else
            {
                string query = "SELECT FIO, Password, Role_ID FROM Employees WHERE FIO = @FIO";
                SqlCommand cmd = new SqlCommand(query, MyConnection);
                SqlParameter pr = new SqlParameter("@FIO", textBoxFIO.Text);
                cmd.Parameters.Add(pr);
                MyConnection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        if (reader[1].ToString().Trim() == textBoxPassword.Text.ToString())
                        {
                            tabControl.Hide();
                            tabControl1.Show();
                            if (reader[2].ToString() == "2")
                            {
                                tabControl1.TabPages.Remove(tabControl1.TabPages[1]);
                                tabControl1.TabPages.Remove(tabControl1.TabPages[2]);
                                tabControl1.TabPages.Remove(tabControl1.TabPages[tabControl1.TabPages.Count - 1]);


                                groupBoxOrdesFields.Hide();
                                groupBoxOrdersOperations.Hide();

                            }
                        }
                        else
                        {
                            MessageBox.Show("Неверный пароль!");
                            textBoxPassword.Text = "";
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Такой записи не найдено");
                    textBoxFIO.Text = "";
                    textBoxPassword.Text = "";
                }
                reader.Close();
                MyConnection.Close();
            }
        }

        private void buttonOrder_MouseLeave(object sender, EventArgs e)
        {
            buttonOrder.FlatStyle = FlatStyle.Popup;
            buttonOrder.BackColor = Color.Coral;
        }

        private void buttonOrder_MouseMove(object sender, MouseEventArgs e)
        {
            buttonOrder.FlatStyle = FlatStyle.Flat;
            buttonOrder.FlatAppearance.BorderColor = Color.Black;
            buttonOrder.BackColor = Color.OrangeRed;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "zueVTypographyDbDataSet.Roles". При необходимости она может быть перемещена или удалена.
            this.rolesTableAdapter.Fill(this.zueVTypographyDbDataSet.Roles);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "zueVTypographyDbDataSet.Employees". При необходимости она может быть перемещена или удалена.
            this.employeesTableAdapter.Fill(this.zueVTypographyDbDataSet.Employees);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "zueVTypographyDbDataSet.Materials". При необходимости она может быть перемещена или удалена.
            this.materialsTableAdapter.Fill(this.zueVTypographyDbDataSet.Materials);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "zueVTypographyDbDataSet.Products". При необходимости она может быть перемещена или удалена.
            this.productsTableAdapter.Fill(this.zueVTypographyDbDataSet.Products);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "zueVTypographyDbDataSet.Orders". При необходимости она может быть перемещена или удалена.
            this.ordersTableAdapter.Fill(this.zueVTypographyDbDataSet.Orders);

        }

        private void buttonOrder_Click(object sender, EventArgs e)
        {

            string query = "INSERT INTO Orders VALUES(@Material_ID, @Product_ID, @Quantity, )";
            SqlCommand cmd = new SqlCommand(query, MyConnection);
            SqlParameter pr1 = new SqlParameter("@Material_ID", comboBox1.SelectedIndex + 1);
            SqlParameter pr2 = new SqlParameter("@Product_ID", comboBox2.SelectedIndex + 1);
            SqlParameter pr3 = new SqlParameter("@Quantity", textBoxQuantity.Text);
            cmd.Parameters.Add(pr1);
            cmd.Parameters.Add(pr2);
            cmd.Parameters.Add(pr3);
            MyConnection.Open();
            cmd.ExecuteNonQuery();
            MyConnection.Close();
            this.ordersTableAdapter.Fill(this.zueVTypographyDbDataSet.Orders);
        }

        private void buttonUpdateStatus_Click(object sender, EventArgs e)
        {
            string query = "UPDATE Orders SET Status_Done = @Status_Done WHERE ID = @ID";
            SqlCommand cmd = new SqlCommand(query, MyConnection);
            SqlParameter pr1 = new SqlParameter("@Status_Done", checkBoxStatusManager.Checked);
            SqlParameter pr2 = new SqlParameter("@ID", textBoxIDOrderManager.Text);
            cmd.Parameters.Add(pr1);
            cmd.Parameters.Add(pr2);
            MyConnection.Open();
            cmd.ExecuteNonQuery();
            MyConnection.Close();
            this.ordersTableAdapter.Fill(this.zueVTypographyDbDataSet.Orders);
        }

        private void buttonOrdersInsert_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO Orders VALUES(@ID_Material, @ID_Product, @Quantity, @Status)";
            SqlCommand cmd = new SqlCommand(query, MyConnection);
            SqlParameter pr1 = new SqlParameter("@ID_Material", textBoxIDMaterial.Text);
            SqlParameter pr2 = new SqlParameter("@ID_Product", textBoxIDProduct.Text);
            SqlParameter pr3 = new SqlParameter("@Quantity", textBoxQuantityTable.Text);
            SqlParameter pr4 = new SqlParameter("@Status", checkBoxStatus.Checked);
            cmd.Parameters.Add(pr1);
            cmd.Parameters.Add(pr2);
            cmd.Parameters.Add(pr3);
            cmd.Parameters.Add(pr4);
            MyConnection.Open();
            cmd.ExecuteNonQuery();
            MyConnection.Close();
            this.ordersTableAdapter.Fill(this.zueVTypographyDbDataSet.Orders);
        }

        private void buttonOrdersUpdate_Click(object sender, EventArgs e)
        {
            string query = "UPDATE Orders SET Material_ID = @ID_Material, Product_ID = @ID_Product, Quantity = @Quantity, Status_Done = @Status WHERE ID = @ID";
            SqlCommand cmd = new SqlCommand(query, MyConnection);
            SqlParameter pr1 = new SqlParameter("@ID_Material", textBoxIDMaterial.Text);
            SqlParameter pr2 = new SqlParameter("@ID_Product", textBoxIDProduct.Text);
            SqlParameter pr3 = new SqlParameter("@Quantity", textBoxQuantityTable.Text);
            SqlParameter pr4 = new SqlParameter("@Status", checkBoxStatus.Checked);
            SqlParameter pr5 = new SqlParameter("@ID", textBoxIDOrder.Text);
            cmd.Parameters.Add(pr1);
            cmd.Parameters.Add(pr2);
            cmd.Parameters.Add(pr3);
            cmd.Parameters.Add(pr4);
            cmd.Parameters.Add(pr5);
            MyConnection.Open();
            cmd.ExecuteNonQuery();
            MyConnection.Close();
            this.ordersTableAdapter.Fill(this.zueVTypographyDbDataSet.Orders);
        }

        private void buttonOrdersDelete_Click(object sender, EventArgs e)
        {
            DialogResult Result = MessageBox.Show("Вы уверены, что хотите удалить запись?", "Предупреждение", MessageBoxButtons.YesNo);
            if (Result == DialogResult.No)
            {
                return;
            }
            else
            {
                string query = "DELETE FROM Orders WHERE ID = @ID";
                SqlCommand cmd = new SqlCommand(query, MyConnection);
                SqlParameter pr = new SqlParameter("@ID", textBoxIDOrder.Text);
                cmd.Parameters.Add(pr);
                MyConnection.Open();
                cmd.ExecuteNonQuery();
                MyConnection.Close();
                this.ordersTableAdapter.Fill(this.zueVTypographyDbDataSet.Orders);
            }
        }

        private void buttonInsertProducts_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO Products VALUES(@Name)";
            SqlCommand cmd = new SqlCommand(query, MyConnection);
            SqlParameter pr1 = new SqlParameter("@Name", textBoxProductName.Text);
            cmd.Parameters.Add(pr1);
            MyConnection.Open();
            cmd.ExecuteNonQuery();
            MyConnection.Close();
            this.productsTableAdapter.Fill(this.zueVTypographyDbDataSet.Products);
        }

        private void buttonUpdateProducts_Click(object sender, EventArgs e)
        {
            string query = "UPDATE Products SET Name = @Name WHERE ID = @ID";
            SqlCommand cmd = new SqlCommand(query, MyConnection);
            SqlParameter pr1 = new SqlParameter("@ID", textBoxProductID.Text);
            SqlParameter pr2 = new SqlParameter("@Name", textBoxProductName.Text);
            cmd.Parameters.Add(pr1);
            cmd.Parameters.Add(pr2);
            MyConnection.Open();
            cmd.ExecuteNonQuery();
            MyConnection.Close();
            this.productsTableAdapter.Fill(this.zueVTypographyDbDataSet.Products);
        }

        private void buttonDeleteProducts_Click(object sender, EventArgs e)
        {
            DialogResult Result = MessageBox.Show("Вы уверены, что хотите удалить запись?", "Предупреждение", MessageBoxButtons.YesNo);
            if (Result == DialogResult.No)
            {
                return;
            }
            else
            {
                string query = "DELETE FROM Products WHERE ID = @ID";
                SqlCommand cmd = new SqlCommand(query, MyConnection);
                SqlParameter pr = new SqlParameter("@ID", textBoxProductID.Text);
                cmd.Parameters.Add(pr);
                MyConnection.Open();
                cmd.ExecuteNonQuery();
                MyConnection.Close();
                this.productsTableAdapter.Fill(this.zueVTypographyDbDataSet.Products);
            }
        }

        private void buttonInsertMaterials_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO Materials VALUES(@Name, @Unit_Cost)";
            SqlCommand cmd = new SqlCommand(query, MyConnection);
            SqlParameter pr1 = new SqlParameter("@Name", textBoxMaterialName.Text);
            SqlParameter pr2 = new SqlParameter("@Unit_cost", textBoxMaterialCost.Text);
            cmd.Parameters.Add(pr1);
            cmd.Parameters.Add(pr2);
            MyConnection.Open();
            cmd.ExecuteNonQuery();
            MyConnection.Close();
            this.materialsTableAdapter.Fill(this.zueVTypographyDbDataSet.Materials);
        }

        private void buttonUpdateMaterials_Click(object sender, EventArgs e)
        {
            string query = "UPDATE Materials SET Name = @Name, Unit_cost = @Unit_cost WHERE ID = @ID";
            SqlCommand cmd = new SqlCommand(query, MyConnection);
            SqlParameter pr1 = new SqlParameter("@ID", textBoxMaterialID.Text);
            SqlParameter pr2 = new SqlParameter("@Name", textBoxMaterialName.Text);
            SqlParameter pr3 = new SqlParameter("@Unit_cost", textBoxMaterialCost.Text);
            cmd.Parameters.Add(pr1);
            cmd.Parameters.Add(pr2);
            cmd.Parameters.Add(pr3);
            MyConnection.Open();
            cmd.ExecuteNonQuery();
            MyConnection.Close();
            this.materialsTableAdapter.Fill(this.zueVTypographyDbDataSet.Materials);
        }

        private void buttonDeleteMaterials_Click(object sender, EventArgs e)
        {
            DialogResult Result = MessageBox.Show("Вы уверены, что хотите удалить запись?", "Предупреждение", MessageBoxButtons.YesNo);
            if (Result == DialogResult.No)
            {
                return;
            }
            else
            {
                string query = "DELETE FROM Materials WHERE ID = @ID";
                SqlCommand cmd = new SqlCommand(query, MyConnection);
                SqlParameter pr = new SqlParameter("@ID", textBoxMaterialID.Text);
                cmd.Parameters.Add(pr);
                MyConnection.Open();
                cmd.ExecuteNonQuery();
                MyConnection.Close();
                this.materialsTableAdapter.Fill(this.zueVTypographyDbDataSet.Materials);
            }
        }

        private void buttonInsertEmployees_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO Employees VALUES(@FIO, @Role_ID, @Password, @Position)";
            SqlCommand cmd = new SqlCommand(query, MyConnection);
            SqlParameter pr1 = new SqlParameter("@FIO", textBoxEmployeeFIO.Text);
            SqlParameter pr2 = new SqlParameter("@Role_ID", textBoxEmployeeRoleID.Text);
            SqlParameter pr3 = new SqlParameter("@Password", textBoxEmployeePassword.Text);
            SqlParameter pr4 = new SqlParameter("@Position", textBoxEmployeePos.Text);
            cmd.Parameters.Add(pr1);
            cmd.Parameters.Add(pr2);
            cmd.Parameters.Add(pr3);
            cmd.Parameters.Add(pr4);
            MyConnection.Open();
            cmd.ExecuteNonQuery();
            MyConnection.Close();
            this.employeesTableAdapter.Fill(this.zueVTypographyDbDataSet.Employees);
        }

        private void buttonUpdateEmployees_Click(object sender, EventArgs e)
        {
            string query = "UPDATE Employees SET FIO = @FIO, Role_ID = @Role_ID, Password = @Password, Position = @Position WHERE ID = @ID";
            SqlCommand cmd = new SqlCommand(query, MyConnection);
            SqlParameter pr1 = new SqlParameter("@FIO", textBoxEmployeeFIO.Text);
            SqlParameter pr2 = new SqlParameter("@Role_ID", textBoxEmployeeRoleID.Text);
            SqlParameter pr3 = new SqlParameter("@Password", textBoxEmployeePassword.Text);
            SqlParameter pr4 = new SqlParameter("@Position", textBoxEmployeePos.Text);
            SqlParameter pr5 = new SqlParameter("@ID", textBoxEmployeeID.Text);
            cmd.Parameters.Add(pr1);
            cmd.Parameters.Add(pr2);
            cmd.Parameters.Add(pr3);
            cmd.Parameters.Add(pr4);
            cmd.Parameters.Add(pr5);
            MyConnection.Open();
            cmd.ExecuteNonQuery();
            MyConnection.Close();
            this.employeesTableAdapter.Fill(this.zueVTypographyDbDataSet.Employees);
        }

        private void buttonDeleteEmployees_Click(object sender, EventArgs e)
        {
            DialogResult Result = MessageBox.Show("Вы уверены, что хотите удалить запись?", "Предупреждение", MessageBoxButtons.YesNo);
            if (Result == DialogResult.No)
            {
                return;
            }
            else
            {
                string query = "DELETE FROM Employees WHERE ID = @ID";
                SqlCommand cmd = new SqlCommand(query, MyConnection);
                SqlParameter pr = new SqlParameter("@ID", textBoxEmployeeID.Text);
                cmd.Parameters.Add(pr);
                MyConnection.Open();
                cmd.ExecuteNonQuery();
                MyConnection.Close();
                this.employeesTableAdapter.Fill(this.zueVTypographyDbDataSet.Employees);
            }
        }

        private void textBoxIDOrder_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
                return;
            if (e.KeyChar == (char)Keys.Back)
                return;
            e.KeyChar = '\0';
        }

        private void textBoxIDMaterial_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
                return;
            if (e.KeyChar == (char)Keys.Back)
                return;
            e.KeyChar = '\0';
        }

        private void textBoxIDProduct_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
                return;
            if (e.KeyChar == (char)Keys.Back)
                return;
            e.KeyChar = '\0';
        }

        private void textBoxQuantityTable_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
                return;
            if (e.KeyChar == (char)Keys.Back)
                return;
            e.KeyChar = '\0';
        }

        private void textBoxProductID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
                return;
            if (e.KeyChar == (char)Keys.Back)
                return;
            e.KeyChar = '\0';
        }

        private void textBoxMaterialID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
                return;
            if (e.KeyChar == (char)Keys.Back)
                return;
            e.KeyChar = '\0';
        }

        private void textBoxMaterialCost_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
                return;
            if (e.KeyChar == (char)Keys.Back)
                return;
            e.KeyChar = '\0';
        }

        private void textBoxIDOrderManager_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
                return;
            if (e.KeyChar == (char)Keys.Back)
                return;
            e.KeyChar = '\0';
        }

        private void textBoxEmployeeID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
                return;
            if (e.KeyChar == (char)Keys.Back)
                return;
            e.KeyChar = '\0';
        }

        private void textBoxEmployeeRoleID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
                return;
            if (e.KeyChar == (char)Keys.Back)
                return;
            e.KeyChar = '\0';
        }

        
        private void buttonSearchEmployees_Click(object sender, EventArgs e)
        {

            string query = "SELECT * FROM Employees WHERE ID = @ID";
            SqlCommand cmd = new SqlCommand(query, MyConnection);
            SqlParameter pr = new SqlParameter("@ID", textBoxEmployeeID.Text);
            cmd.Parameters.Add(pr);
            try
            {
                MyConnection.Open();
                SqlDataReader reader = cmd.ExecuteReader();


                DataTable dt = new DataTable();
                dt.Load(reader);


                dataGridView3.DataSource = dt;

                reader.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                MyConnection.Close();
            }
        }

        private void buttonBackEmployees_Click(object sender, EventArgs e)
        {
            dataGridView3.DataSource = employeesBindingSource;
        }

        private void buttonSearchOrders_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM Orders WHERE ID = @ID";
            SqlCommand cmd = new SqlCommand(query, MyConnection);
            SqlParameter pr = new SqlParameter("@ID", textBoxIDOrder.Text);
            cmd.Parameters.Add(pr);
            try
            {
                MyConnection.Open();
                SqlDataReader reader = cmd.ExecuteReader();


                DataTable dt = new DataTable();
                dt.Load(reader);


                dataGridViewOrders.DataSource = dt;

                reader.Close();
            }
            catch (Exception ex)
            {
                // Обработка ошибок
                MessageBox.Show(ex.Message);
            }
            finally
            {
                MyConnection.Close();
            }
        }

        private void buttonBackOrders_Click(object sender, EventArgs e)
        {
            dataGridViewOrders.DataSource = ordersBindingSource;
        }

        private void buttonSearchProducts_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM Products WHERE ID = @ID";
            SqlCommand cmd = new SqlCommand(query, MyConnection);
            SqlParameter pr = new SqlParameter("@ID", textBoxProductID.Text);
            cmd.Parameters.Add(pr);
            try
            {
                MyConnection.Open();
                SqlDataReader reader = cmd.ExecuteReader();


                DataTable dt = new DataTable();
                dt.Load(reader);


                dataGridView2.DataSource = dt;

                reader.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                MyConnection.Close();
            }
        }

        private void buttonBackProducts_Click(object sender, EventArgs e)
        {
            dataGridView2.DataSource = productsBindingSource;
        }

        

        private void buttonSearchMaterials_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM Materials WHERE ID = @ID";
            SqlCommand cmd = new SqlCommand(query, MyConnection);
            SqlParameter pr = new SqlParameter("@ID", textBoxMaterialID.Text);
            cmd.Parameters.Add(pr);
            try
            {
                MyConnection.Open();
                SqlDataReader reader = cmd.ExecuteReader();


                DataTable dt = new DataTable();
                dt.Load(reader);


                dataGridView1.DataSource = dt;
                hasRows = true;
                reader.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                MyConnection.Close();
            }
        }

        public bool hasRows = false;
        public bool exIsShowed = false;

        private void buttonBackMaterials_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = materialsBindingSource;
        }

        public void Search(string ID)
        {
            string query = "SELECT * FROM Materials WHERE ID = @ID";
            SqlCommand cmd = new SqlCommand(query, MyConnection);
            SqlParameter pr = new SqlParameter("@ID", ID);
            cmd.Parameters.Add(pr);
            try
            {
                MyConnection.Open();
                SqlDataReader reader = cmd.ExecuteReader();


                DataTable dt = new DataTable();
                dt.Load(reader);


                dataGridView1.DataSource = dt;
                hasRows = true;
                reader.Close();
            }
            catch (Exception ex)
            {
                exIsShowed = true;
                MessageBox.Show(ex.Message);
            }
            finally
            {
                MyConnection.Close();
            }
        }

        public bool falsePassword = false;
        public bool isShowed = false;
        public void login(string FIO, string Password)
        {
                string query = "SELECT FIO, Password, Role_ID FROM Employees WHERE FIO = @FIO";
                SqlCommand cmd = new SqlCommand(query, MyConnection);
                SqlParameter pr = new SqlParameter("@FIO", FIO);
                cmd.Parameters.Add(pr);
                MyConnection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        if (reader[1].ToString().Trim() == Password.ToString())
                        {
                        tabControl.Hide();
                            tabControl1.Show();
                            
                        if (reader[2].ToString() == "2")
                            {
                                tabControl1.TabPages.Remove(tabControl1.TabPages[1]);
                                tabControl1.TabPages.Remove(tabControl1.TabPages[2]);
                                tabControl1.TabPages.Remove(tabControl1.TabPages[tabControl1.TabPages.Count - 1]);
                                

                                groupBoxOrdesFields.Hide();
                                groupBoxOrdersOperations.Hide();

                            }
                        }
                        else
                        {
                            falsePassword = true;
                            MessageBox.Show("Неверный пароль!");
                            textBoxPassword.Text = "";
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Такой записи не найдено");
                    isShowed = true;
                    textBoxFIO.Text = "";
                    textBoxPassword.Text = "";
                }
                reader.Close();
                MyConnection.Close();
            
        }

        public bool msgIsShowed = false;
        public bool deleted =false;

        public void del(string ID)
        {
            DialogResult Result = MessageBox.Show("Вы уверены, что хотите удалить запись?", "Предупреждение", MessageBoxButtons.YesNo);
            msgIsShowed = true;
            if (Result == DialogResult.No)
            {
                return;
            }
            else
            {
                string query = "DELETE FROM Employees WHERE ID = @ID";
                SqlCommand cmd = new SqlCommand(query, MyConnection);
                SqlParameter pr = new SqlParameter("@ID", ID);
                cmd.Parameters.Add(pr);
                MyConnection.Open();
                cmd.ExecuteNonQuery();
                MyConnection.Close();
                this.employeesTableAdapter.Fill(this.zueVTypographyDbDataSet.Employees);
                deleted = true;
            }
        }

        public bool inserted = false;
        public bool updated = false;
        public void insert(string Name)
        {
            string query = "INSERT INTO Products VALUES(@Name)";
            SqlCommand cmd = new SqlCommand(query, MyConnection);
            SqlParameter pr1 = new SqlParameter("@Name", Name);
            cmd.Parameters.Add(pr1);
            MyConnection.Open();
            cmd.ExecuteNonQuery();
            MyConnection.Close();
            inserted = true;
            this.productsTableAdapter.Fill(this.zueVTypographyDbDataSet.Products);
        }

        public void update(string ID, string Name)
        {
            string query = "UPDATE Products SET Name = @Name WHERE ID = @ID";
            SqlCommand cmd = new SqlCommand(query, MyConnection);
            SqlParameter pr1 = new SqlParameter("@ID", textBoxProductID.Text);
            SqlParameter pr2 = new SqlParameter("@Name", textBoxProductName.Text);
            cmd.Parameters.Add(pr1);
            cmd.Parameters.Add(pr2);
            MyConnection.Open();
            cmd.ExecuteNonQuery();
            MyConnection.Close();
            updated = true;
            this.productsTableAdapter.Fill(this.zueVTypographyDbDataSet.Products);
        }
    }
}
