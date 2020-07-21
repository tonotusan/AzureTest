using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace AzureTest
{

    public partial class Form1 : Form
    {
        public String conectionLocal = "";

        public static int x = 0;

        public static String[] tables = {

"c_research_check",
//"holiday",
"m_media_group",
//"o_th_hansya",
//"old_納品リスト",
//"qrerror",
//"t_delivery",
//"t_keyword_tests",
//"t_last_post_time",
//"t_last_update_time",
//"t_loginout",
//"t_media_old",
"t_new_media",
//"t_old_test_keywords",
"t_option",
"t_QRCheck",
"t_se",
"t_search_conditions",
//"t_test_results",


"t_user_open",
//"temp_nipou",
//"th_config",
//"th_hansya",
//"th_imageList",
//"th_list",
//"th_order",
//"th_order_sp",
//"ts_chat",
//"ts_holiday",
"ts_mailInfo",
"ts_nouhin",
"ts_order_spe",
//"ts_rtf",
//"ts_rtfMemo",
//"ts_rtfSiyou",
"ts_schedule",
"ts_staff2",
"ts_syomei",
//"納品マスタ",
"t_media_memo",
"t_media",
"t_media_order",

"t_research_report",
"t_label_print",
"t_unclear_report",
"t_order_memo",
"t_order",
"t_reference_number",
"t_research",
"t_order_info",

"ts_order_sub",
//"納品リスト",
"t_staff",
"ts_orderSort",
"ts_nipou",
"t_old_user",
//"t_old_keywords",
"t_notification",
"t_foresee",
"ta_replicate"
            };


        ///////////////////////////////////////// ★★★ Splashフォーム ★★★
        private static FSplash _form = null;

        /// Splashフォーム
        public static FSplash Form
        {
            get { return _form; }
        }

        /// Splashフォームを表示する
        public static void ShowSplash()
        {
            if (_form == null)
            {
                //Application.IdleイベントハンドラでSplashフォームを閉じる
                Application.Idle += new EventHandler(Application_Idle);
                //Splashフォームを表示する
                _form = new FSplash();
                _form.Show();
                _form.Refresh();
            }
        }

        //アプリケーションがアイドル状態になった時
        private static void Application_Idle(object sender, EventArgs e)
        {
            //Splashフォームがあるか調べる
            if (_form != null && _form.IsDisposed == false)
            {
                //Splashフォームを閉じる
                _form.Close();
            }
            _form = null;
            //Application.Idleイベントハンドラの削除
            Application.Idle -= new EventHandler(Application_Idle);
        }

        DataTable dtTemp = new DataTable();
        DataTable dtTemp2 = new DataTable();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            conectionLocal = Program.ConnectionLocal;

            comboBox1.Items.Clear();
            comboBox1.Items.Add("");
            foreach (String t in tables)
            {
                comboBox1.Items.Add(t);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ShowSplash();

            String SQLString = "select * from c_research_check order by id";
            if (comboBox1.Text != "")
            {
                SQLString = "select * from " + comboBox1.Text + " order by id";
            }

            SqlConnection connection = new SqlConnection();
            SqlCommand sCommand = new SqlCommand();
            connection.ConnectionString = Program.ConnectionAzure;

            try
            {
                dtTemp.Clear();
            }
            catch (Exception)
            {
            }

            using (SqlDataAdapter adapter = new SqlDataAdapter())
            {
                sCommand.Connection = connection;
                sCommand.CommandText = SQLString;
                adapter.SelectCommand = sCommand;

                int lsw = 0;
                while (lsw == 0)
                {
                    try
                    {
                        adapter.Fill(dtTemp);

                        lsw = 1;
                    }
                    catch (SqlException ex)
                    {
                        DialogResult result = MessageBox.Show("データベースに接続できません。\n再接続を試みますか？",
                            "Caution", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
                        if (result == DialogResult.Cancel)
                        {
                            Environment.Exit(0);
                        }
                    }
                }
            }

            dataGridView1.DataSource = dtTemp;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ShowSplash();

            String SQLString = "select * from c_research_check order by id";
            if (comboBox1.Text != "")
            {
                SQLString = "select * from " + comboBox1.Text + " order by id";
            }

            SqlConnection connection = new SqlConnection();
            SqlCommand sCommand = new SqlCommand();
            connection.ConnectionString = conectionLocal;

            try
            {
                dtTemp2.Clear();
            }
            catch (Exception)
            {
            }

            using (SqlDataAdapter adapter = new SqlDataAdapter())
            {
                sCommand.Connection = connection;
                sCommand.CommandText = SQLString;
                adapter.SelectCommand = sCommand;

                int lsw = 0;
                while (lsw == 0)
                {
                    try
                    {
                        adapter.Fill(dtTemp2);

                        lsw = 1;
                    }
                    catch (SqlException ex)
                    {
                        DialogResult result = MessageBox.Show("データベースに接続できません。\n再接続を試みますか？",
                            "Caution", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
                        if (result == DialogResult.Cancel)
                        {
                            Environment.Exit(0);
                        }
                    }
                }
            }

            dataGridView2.DataSource = null;
            dataGridView2.Columns.Clear();
            dataGridView2.Rows.Clear();
            dataGridView2.DataSource = dtTemp2;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ShowSplash();

            if (comboBox1.Text !="")
            {
                BulkCopy(comboBox1.Text);
            }
            else
            {
                foreach (String tb in tables)
                {
                    BulkCopy(tb);
                }
            }
        }

        private void BulkCopy(String tb)
        {
            SqlConnection connection = new SqlConnection();
            SqlCommand sCommand = new SqlCommand();
            connection.ConnectionString = conectionLocal;

            SqlConnection connection2 = new SqlConnection();
            SqlCommand sCommand2 = new SqlCommand();
            connection2.ConnectionString = Program.ConnectionAzure;

            label1.Text = tb;
            label1.Refresh();

            String SQLString = "select * from " + tb;

            DataTable dtTemp3 = new DataTable();

            using (SqlDataAdapter adapter = new SqlDataAdapter())
            {
                sCommand.Connection = connection;
                sCommand.CommandText = SQLString;
                adapter.SelectCommand = sCommand;

                int lsw = 0;
                while (lsw == 0)
                {
                    try
                    {
                        adapter.Fill(dtTemp3);

                        lsw = 1;
                    }
                    catch (SqlException ex)
                    {
                        DialogResult result = MessageBox.Show("データベースに接続できません。\n再接続を試みますか？",
                            "Caution", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
                        if (result == DialogResult.Cancel)
                        {
                            Environment.Exit(0);
                        }
                    }
                }
            }

            label1.Text = tb + " " + dtTemp3.Rows.Count.ToString();
            label1.Refresh();

            //                String Delete_String = "delete " + tb;
            String Delete_String = "truncate table " + tb;

            connection2.Open();

            sCommand2.CommandText = Delete_String;
            sCommand2.Connection = connection2;
            sCommand2.CommandTimeout = 1000 * 60 * 5;
            int num = sCommand2.ExecuteNonQuery();

            var bc = new SqlBulkCopy(connection2);
            bc.BulkCopyTimeout = 1000 * 60 * 10;
            bc.DestinationTableName = tb;
            bc.WriteToServer(dtTemp3);

            connection2.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection();
            SqlCommand sCommand = new SqlCommand();
            connection.ConnectionString = conectionLocal;



            sCommand.CommandText = "update c_research_check set theme = 'AAAAAAAAAAAAAAAAAAAAAAAAAAA', updated_at = GETDATE() where id = 6";
            sCommand.Connection = connection;

            var sw = new System.Diagnostics.Stopwatch();

            // 計測開始
            sw.Start();



            for (int i = 0; i < 1000; i++)
            {
                connection.Open();
                int num = sCommand.ExecuteNonQuery();
                connection.Close();
            }


            sw.Stop();

            TimeSpan ts = sw.Elapsed;

            label2.Text = ts.ToString();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection();
            SqlCommand sCommand = new SqlCommand();
            connection.ConnectionString = conectionLocal;



            sCommand.CommandText = "update c_research_check set theme = 'AAAAAAAAAAAAAAAAAAAAAAAAAAA', updated_at = GETDATE() where id = 6";
            sCommand.Connection = connection;

            var sw = new System.Diagnostics.Stopwatch();

            // 計測開始
            sw.Start();

            connection.Open();


            for (int i = 0; i < 1000; i++)
            {
                int num = sCommand.ExecuteNonQuery();

            }

            connection.Close();

            sw.Stop();

            TimeSpan ts = sw.Elapsed;

            label3.Text = ts.ToString();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection();
            SqlCommand sCommand = new SqlCommand();
            connection.ConnectionString = Program.ConnectionAzure;



            sCommand.CommandText = "update c_research_check set theme = 'AAAAAAAAAAAAAAAAAAAAAAAAAAA', updated_at = GETDATE() where id = 6";
            sCommand.Connection = connection;

            var sw = new System.Diagnostics.Stopwatch();

            // 計測開始
            sw.Start();



            for (int i = 0; i < 1000; i++)
            {
                connection.Open();
                int num = sCommand.ExecuteNonQuery();
                connection.Close();
            }


            sw.Stop();

            TimeSpan ts = sw.Elapsed;

            label4.Text = ts.ToString();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection();
            SqlCommand sCommand = new SqlCommand();
            connection.ConnectionString = Program.ConnectionAzure;



            sCommand.CommandText = "update c_research_check set theme = 'AAAAAAAAAAAAAAAAAAAAAAAAAAA', updated_at = GETDATE() where id = 6";
            sCommand.Connection = connection;

            var sw = new System.Diagnostics.Stopwatch();

            // 計測開始
            sw.Start();

            connection.Open();


            for (int i = 0; i < 1000; i++)
            {
                int num = sCommand.ExecuteNonQuery();

            }

            connection.Close();

            sw.Stop();

            TimeSpan ts = sw.Elapsed;

            label5.Text = ts.ToString();

        }

        private void button8_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection();
            SqlCommand sCommand = new SqlCommand();
            connection.ConnectionString = conectionLocal;



            sCommand.CommandText = "update c_research_check set theme = 'AAAAAAAAAAAAAAAAAAAAAAAAAAA', updated_at = GETDATE() where id = 6";
            sCommand.Connection = connection;

            var sw = new System.Diagnostics.Stopwatch();

            // 計測開始
            sw.Start();



            for (int i = 0; i < 1; i++)
            {
                connection.Open();
                int num = sCommand.ExecuteNonQuery();
                connection.Close();

                connection.ConnectionString = Program.ConnectionAzure;
                connection.Open();
                num = sCommand.ExecuteNonQuery();
                connection.Close();
            }


            sw.Stop();

            TimeSpan ts = sw.Elapsed;

            label6.Text = ts.ToString();
        }

        private void DB_select(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                conectionLocal = @"Data Source=(local);Initial Catalog=AtClipping;User Id=sa;Password=superuser;";
            }
            else
            {
                conectionLocal = @"Data Source = 192.168.1.6\AXELE_INSTANCE;Initial Catalog = AtClipping; User Id = sw_user; Password=miraiz;";
            }
        }
    }
}
