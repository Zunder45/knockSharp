using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Sockets;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Microsoft.Data.Sqlite;




namespace knockSharp
{
    public partial class test : Form
    {
        public test()
        {           
            InitializeComponent();
        }
        private void test_Load(object sender, EventArgs e)
        {

            listView1.FullRowSelect = true; //выделение всей строки при нажатии на нее
            listView1.MultiSelect   = false; //запрет на выделения нескольких строк

            //чтение параметров из Settings.Default.SevedList
            var savedJSON           = Properties.Settings.Default.SevedList;
            if (savedJSON != "") { 
                var list = JsonSerializer.Deserialize<List<String[]>>(savedJSON);

                for (var i = 0; i < list.Count; i++)
                {
                        var row = list[i];

                        listView1.BeginUpdate();

                        ListViewItem listView = new ListViewItem(row[0]);
                        listView.SubItems.Add(row[1]);
                        listView.SubItems.Add(row[2]);
                        listView1.Items.Add(listView);

                        listView1.EndUpdate(); 
                }
            }
        }

        public struct Data_addr {
           public String ip;
           public String ports;
           public String deskript;
        }

        private void clear_imput_forms() //очитска полей ввода 
        {
            textBox_ip.Text         = "";
            textBox_ports.Text      = "";
            textBox_deskript.Text   = "";

        }

        private bool chek_complet_imput_form() // проверка корректных данных в полях ввода
        {
            string pattern = @"^(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)$";

            if (textBox_ip.Text == "")// если поле IP пустое 
            {
                MessageBox.Show("Поле 'IP адрес' пустое", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                return false;
            }
            else 
            { 
                if (!Regex.IsMatch(textBox_ip.Text, pattern)) // проверка ip на корректный ввод
                {
                    MessageBox.Show("IP введен не верно", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                    return false;
                }
            }
            if (textBox_ports.Text == "") { // если поле Порт пустое
                MessageBox.Show("Поле 'Порт' пустое", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                return false;
            }
            return true;
        }
        private void add_list_addr(Data_addr data) // Добавление запсей в таблицу
        {
            listView1.BeginUpdate(); // Блокирует перерисовку
            
            ListViewItem item = new ListViewItem(data.ip);
            item.SubItems.Add(data.ports);
            item.SubItems.Add(data.deskript);
            listView1.Items.Add(item);

            listView1.EndUpdate(); // Восстанавливает перерисовку
        }

        private bool knocking()// простукивание протов
        {
            
            String ip = textBox_ip.Text.Replace(" ", "");
            String ports = textBox_ports.Text;

            var port = ports.Split(',', '.');

            foreach (var item in port)
            {
                using (var client = new TcpClient())
                {
                    var conn = client.ConnectAsync(ip, Int32.Parse(item));
                    conn.Wait(100);
                }
            }
            return true;
        }

        private void save_list()// сохранение таблицы в Settings.Default.SevedList
        {
            dynamic cell    = null;
            dynamic row     = null;
            List<String[]> dataList = new List<String[]>();
            for (var i = 0; i < listView1.Items.Count; i++)
            {
                String[] cellMass = new String[3];
                for (var j = 0; j < listView1.Items[i].SubItems.Count; j++)
                {
                    cell        = listView1.Items[i].SubItems[j].Text;
                    row         = listView1.Items[i].Text;
                    cellMass[j] = cell;
                }
                dataList.Add(cellMass);
            }
            String dd = JsonSerializer.Serialize(dataList);
            Properties.Settings.Default.SevedList = JsonSerializer.Serialize(dataList);
            Properties.Settings.Default.Save();
            MessageBox.Show("Готово", "Сохранение", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);

        }

        private void remuve_select_item() //удаление выбьранных строк в таблице
        {
            for (int i = listView1.SelectedItems.Count - 1; i >= 0; i--)
            {
                listView1.Items.Remove(listView1.SelectedItems[i]);
            }
        }
        private void button_add_Click(object sender, EventArgs e) // добавление занчений с полей в таблицу
        {
            if (chek_complet_imput_form())// проверка валедации полей
            {
                Data_addr data  = new Data_addr();
                data.ip         = textBox_ip.Text;
                data.ports      = textBox_ports.Text;
                data.deskript   = textBox_deskript.Text;

                add_list_addr(data);

                clear_imput_forms();
            }
        }

        private void button_send_knock_Click(object sender, EventArgs e)// кнопка запускающая простукивания портов
        {
            if (chek_complet_imput_form())
            {
                if (knocking()) 
                { 
                    MessageBox.Show("Готово", "Отправка",
                        MessageBoxButtons.OK, 
                        MessageBoxIcon.Information, 
                        MessageBoxDefaultButton.Button1,
                        MessageBoxOptions.DefaultDesktopOnly); 
                }
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try // ошибка при выборе нескольких items
            {
                var list                = listView1.FocusedItem.SubItems;
                textBox_ip.Text         = list[0].Text;
                textBox_ports.Text      = list[1].Text;
                textBox_deskript.Text   = list[2].Text;
            }
            catch
            {

            }
        }
        private void toolStripMenuItem_Seve_Click(object sender, EventArgs e)
        {
            save_list();
        }

        private void toolStripMenuItem_DelItem_Click(object sender, EventArgs e)
        {
            remuve_select_item();
        }

        private void toolStripMenuItem_ClearList_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
        }

        private void toolStripButton_OpenFilderSetting_Click(object sender, EventArgs e)
        {
            string appDataPath = Environment.GetFolderPath(
            Environment.SpecialFolder.LocalApplicationData);

            Process.Start("explorer.exe", appDataPath);
        }
    }
 }

