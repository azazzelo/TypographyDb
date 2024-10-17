using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TypographyDb;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestTypographyDb
{
    [TestClass]
    public class UnitTest1
    {
        private SqlConnection connection;

        [TestInitialize]

        public void Initialize()
        {
            connection = Form1.getSqlConn();
            connection.Open();
        }

        [TestCleanup]
        public void Cleanup()
        {
            connection.Close();
        }
        Form1 form = new Form1();
        [TestMethod]
        public void CheckTextBoxes()
        {
            string FIO = "";
            string password = "112233";
            Initialize();

            form.login(FIO, password);
            Cleanup();
            Assert.IsTrue(form.isShowed);
        }

        [TestMethod]
        public void CheckPassword()
        {
            string FIO = "Зуев Герман";
            string password = "";

            Initialize();
            form.login(FIO, password);
            Cleanup();
            Assert.IsTrue(form.falsePassword);
        }

        [TestMethod]
        public void Search()
        {
            string ID = "1";

            Initialize();
            form.Search(ID);
            Cleanup();
            Assert.IsTrue(form.hasRows);
        }

        [TestMethod]
        public void SearchEx()
        {
            string ID = "asdas";
            Initialize();
            form.Search(ID);
            Cleanup();
            Assert.IsTrue(form.exIsShowed);
        }

        [TestMethod]
        public void delMsg()
        {
            string ID = "1";
            Initialize();
            form.del(ID);
            Cleanup();
            Assert.IsTrue(form.msgIsShowed);
        }

        [TestMethod]
        public void delete()
        {
            string ID = "2";
            Initialize();
            form.del(ID);
            Cleanup();
            Assert.IsTrue(form.deleted);
        }

        [TestMethod]
        public void insert()
        {
            string Name = "Chris";
            Initialize();
            form.insert(Name);
            Cleanup();
            Assert.IsTrue(form.inserted);
        }

        [TestMethod]
        public void update()
        {
            string ID = "1";
            string Name = "Chris";
            Initialize();
            form.update(ID, Name);
            Cleanup();
            Assert.IsTrue(form.updated);
        }

        [TestMethod]
        public void Notinsert()
        {
            string Name = "Chris";
            Initialize();
            form.insert(Name);
            Cleanup();
            bool expected = true;
            Assert.AreEqual(form.inserted, expected);
        }

        [TestMethod]
        public void Notupdate()
        {
            string ID = "1";
            string Name = "Chris";
            Initialize();
            form.update(ID, Name);
            Cleanup();
            bool expected = false;
            Assert.AreEqual(!form.updated, expected);
        }
    }
}
