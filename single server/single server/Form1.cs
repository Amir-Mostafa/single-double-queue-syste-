using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace single_server
{
    public partial class Form1 : Form
    {
        public DataTable g1 = new DataTable();
        public DataTable g2 = new DataTable();
        public DataTable g3n = new DataTable();
        public DataTable g3 = new DataTable();
        public DataTable g4 = new DataTable();
        public DataTable g5 = new DataTable();
        public DataTable g6 = new DataTable();

        public DataTable g7 = new DataTable();
        public DataTable g8 = new DataTable();


        public DataTable gs1 = new DataTable();
        public DataTable gs2 = new DataTable();
        int max_arrive_size = 0;
        int max_service_size = 0;
        int max_service_size1 = 0;
        public Form1()
        {
            InitializeComponent();

            g1.Columns.Add("Time Between Arrivals ");
            g1.Columns.Add("Probability");
            dataGridView1.DataSource = g1;


            g2.Columns.Add("Service Time");
            g2.Columns.Add("Probability");
            dataGridView2.DataSource = g2;

            g3n.Columns.Add("Service Time");
            g3n.Columns.Add("Probability");
            dataGridView3.DataSource = g3n;

            g3.Columns.Add("Time Between Arrivals");
            g3.Columns.Add("Probability");
            g3.Columns.Add("Cumulative Probability");
            g3.Columns.Add("from");
            g3.Columns.Add("To");

            g4.Columns.Add("Service Time");
            g4.Columns.Add("Probability");
            g4.Columns.Add("Cumulative Probability");
            g4.Columns.Add("from");
            g4.Columns.Add("To");

            gs1.Columns.Add("Service Time");
            gs1.Columns.Add("Probability");
            gs1.Columns.Add("Cumulative Probability");
            gs1.Columns.Add("from");
            gs1.Columns.Add("To");


            g5.Columns.Add("customer");
            g5.Columns.Add("Random Digits");
            g5.Columns.Add("Time Between Arrivals");



            g6.Columns.Add("customer");
            g6.Columns.Add("Random Digits");
            g6.Columns.Add("Service Time");

            gs2.Columns.Add("customer");
            gs2.Columns.Add("Random Digits");
            gs2.Columns.Add("Service Time");

            g7.Columns.Add("Customer No");
            g7.Columns.Add("Time Between Arrivals ");
            g7.Columns.Add("Arrival Time");
            g7.Columns.Add("Service Time ");
            g7.Columns.Add("Time Service Begins ");
            g7.Columns.Add("Time  customer wait in queue");
            g7.Columns.Add("Time ServiceEnds");
            g7.Columns.Add("Time  Customer spends in system");
            g7.Columns.Add("Idle  Time ofServer ");


            g8.Columns.Add("Customer No");              //0
            g8.Columns.Add("Time Between Arrivals ");   //1
            g8.Columns.Add("Arrival Time");

            g8.Columns.Add("Time Service Begins ");
            g8.Columns.Add("Service Time ");
            g8.Columns.Add("Time ServiceEnds");

            g8.Columns.Add("Time Service Begins 2 ");
            g8.Columns.Add("Service Time 2");
            g8.Columns.Add("Time ServiceEnds 2");

            g8.Columns.Add("Idle  Time of Server ");

            /*
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.Blue;
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGridView1.BackgroundColor = Color.Tan;

            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            dataGridView2.BorderStyle = BorderStyle.None;
            dataGridView2.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridView2.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView2.DefaultCellStyle.SelectionBackColor = Color.Blue;
            dataGridView2.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGridView2.BackgroundColor = Color.Tan;

            dataGridView2.EnableHeadersVisualStyles = false;
            dataGridView2.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView2.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dataGridView2.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            */
        }

        public int randomnumber(int max)
        {
            Random rand = new Random();
           return rand.Next(max);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void textBox1_MouseDown(object sender, MouseEventArgs e)
        {
            
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter &&textBox1.Text!=""&&textBox2.Text!="" )
            {
                DataRow r = g1.NewRow();

                r[0] = textBox1.Text;
                r[1] = textBox2.Text;

                if ((textBox2.Text.Length - 2) > max_arrive_size)
                    max_arrive_size = textBox2.Text.Length-2;
                textBox1.Text = "";
                textBox2.Text = "";
                g1.Rows.Add(r);

                dataGridView1.DataSource = g1;
            }
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && textBox1.Text != "" && textBox2.Text != "")
            {
                DataRow r = g1.NewRow();

                r[0] = textBox1.Text;
                r[1] = textBox2.Text;
                if ((textBox2.Text.Length - 2) > max_arrive_size)
                    max_arrive_size = textBox2.Text.Length-2;
                g1.Rows.Add(r);
                textBox1.Text = "";
                textBox2.Text = "";
                dataGridView1.DataSource = g1;
                textBox1.Focus();
            }
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                dataGridView1.Rows.Remove(dataGridView1.CurrentRow);

            }
            catch
            { }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && textBox3.Text != "" && textBox4.Text != "")
            {
                DataRow r = g2.NewRow();

                r[0] = textBox3.Text;
                r[1] = textBox4.Text;
                if ((textBox4.Text.Length - 2) > max_service_size)
                    max_service_size = textBox4.Text.Length-2;
                textBox3.Text = "";
                textBox4.Text = "";
                g2.Rows.Add(r);

                dataGridView2.DataSource = g2;
            }
        }

        private void textBox4_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && textBox3.Text != "" && textBox4.Text != "")
            {
                DataRow r = g2.NewRow();

                r[0] = textBox3.Text;
                r[1] = textBox4.Text;
                if ((textBox4.Text.Length - 2) > max_service_size)
                    max_service_size = textBox4.Text.Length - 2;
                textBox3.Text = "";
                textBox4.Text = "";
                g2.Rows.Add(r);

                dataGridView2.DataSource = g2;
                textBox3.Focus();
            }
        }

        private void dataGridView2_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                textBox3.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();
                textBox4.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString();
                dataGridView2.Rows.Remove(dataGridView2.CurrentRow);

            }
            catch
            { }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count != 0)
            {
                g3.Clear();
                double cumulative = 0;
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    DataRow r = g3.NewRow();

                    r[0] = dataGridView1.Rows[i].Cells[0].Value.ToString();
                    r[1] = dataGridView1.Rows[i].Cells[1].Value.ToString();
                    r[3] = (cumulative * Math.Pow(10, max_arrive_size) + 1).ToString();
                    cumulative += double.Parse(dataGridView1.Rows[i].Cells[1].Value.ToString());
                    r[2] = cumulative.ToString();
                    r[4] = (cumulative * Math.Pow(10, max_arrive_size)).ToString();

                    g3.Rows.Add(r);
                }

                table_1 f = new table_1();

                table_1.table1.dataGridView1.DataSource = g3;
                f.Show();


                //show table 2


                g4.Clear();
                cumulative = 0;
                for (int i = 0; i < dataGridView2.Rows.Count; i++)
                {
                    DataRow r = g4.NewRow();

                    r[0] = dataGridView2.Rows[i].Cells[0].Value.ToString();
                    r[1] = dataGridView2.Rows[i].Cells[1].Value.ToString();
                    r[3] = (cumulative * Math.Pow(10, max_service_size) + 1).ToString();
                    cumulative += double.Parse(dataGridView2.Rows[i].Cells[1].Value.ToString());
                    r[2] = cumulative.ToString();
                    r[4] = (cumulative * Math.Pow(10, max_service_size)).ToString();

                    g4.Rows.Add(r);
                }

                table_2 f1 = new table_2();

                table_2.table2.dataGridView1.DataSource = g4;
                f1.Show();


                //show table 3
                g5.Clear();

                DataRow rr = g5.NewRow();
                rr[0] = "1";
                rr[1] = "---";
                rr[2] = "---";
                g5.Rows.Add(rr);
                int k = 100;
                int[] arr = new int[100];
                Random random = new Random();
                int max = Convert.ToInt32(Math.Pow(10, max_arrive_size));
                for (int i = 0; i < 100; i++)
                    arr[i] = random.Next(max);
                for (int i = 2; i <= 20; i++)
                {
                    DataRow r = g5.NewRow();
                    r[0] = i.ToString();
                    int rand = arr[i];
                    r[1] = rand.ToString();

                    int val = 0;
                    for (int j = 0; j < g3.Rows.Count; j++)
                    {
                        if (rand >= int.Parse(g3.Rows[j][3].ToString()) && rand <= int.Parse(g3.Rows[j][4].ToString()))
                        {
                            val = int.Parse(g3.Rows[j][0].ToString());
                            break;
                        }
                    }
                    r[2] = val.ToString();

                    g5.Rows.Add(r);

                }
                table_3 ft3 = new table_3();
                ft3.Show();
                table_3.table3.dataGridView1.DataSource = g5;



                //show table 4
                g6.Clear();
                int[] rand_service = new int[100];
                Random random_s = new Random();
                int max_len = Convert.ToInt32(Math.Pow(10, max_service_size));
                for (int i = 0; i < 100; i++)
                    rand_service[i] = random_s.Next(max_len);
                for (int i = 1; i <= 20; i++)
                {
                    DataRow r = g6.NewRow();
                    r[0] = i.ToString();
                    int rand = rand_service[i];
                    r[1] = rand.ToString();

                    int val = 0;
                    for (int j = 0; j < g4.Rows.Count; j++)
                    {
                        if (rand >= int.Parse(g4.Rows[j][3].ToString()) && rand <= int.Parse(g4.Rows[j][4].ToString()))
                        {
                            val = int.Parse(g4.Rows[j][0].ToString());
                            break;
                        }
                    }
                    r[2] = val.ToString();

                    g6.Rows.Add(r);

                }
                table_4 ft4 = new table_4();
                ft4.Show();
                table_4.table4.dataGridView1.DataSource = g6;

                if (radioButton2.Checked)
                {
                    //show table second server
                    gs1.Clear();
                    cumulative = 0;
                    for (int i = 0; i < dataGridView3.Rows.Count; i++)
                    {
                        DataRow r = gs1.NewRow();
                        r[0] = dataGridView3.Rows[i].Cells[0].Value.ToString();
                        r[1] = dataGridView3.Rows[i].Cells[1].Value.ToString();
                        r[3] = (cumulative * Math.Pow(10, max_service_size1) + 1).ToString();
                        cumulative += double.Parse(dataGridView3.Rows[i].Cells[1].Value.ToString());
                        r[2] = cumulative.ToString();
                        r[4] = (cumulative * Math.Pow(10, max_service_size1)).ToString();
                        gs1.Rows.Add(r);
                    }
                    form_s1 s1 = new form_s1();
                    s1.Show();
                    form_s1.forms1.dataGridView1.DataSource = gs1;


                    //show second table of second server

                    gs2.Clear();
                    int[] service = new int[100];
                    Random s = new Random();
                    int max_le = Convert.ToInt32(Math.Pow(10, max_service_size1));
                    for (int i = 0; i < 100; i++)
                        service[i] = s.Next(max_le);
                    for (int i = 1; i <= 20; i++)
                    {
                        DataRow r = gs2.NewRow();
                        r[0] = i.ToString();
                        int rand = service[i];
                        r[1] = rand.ToString();

                        int val = 0;
                        for (int j = 0; j < gs1.Rows.Count; j++)
                        {
                            if (rand >= int.Parse(gs1.Rows[j][3].ToString()) && rand <= int.Parse(gs1.Rows[j][4].ToString()))
                            {
                                val = int.Parse(gs1.Rows[j][0].ToString());
                                break;
                            }
                        }
                        r[2] = val.ToString();

                        gs2.Rows.Add(r);

                    }

                    table_s2 s2 = new table_s2();
                    s2.Show();
                    table_s2.tables2.dataGridView1.DataSource = gs2;


                    //////////////////////     table for 2 server    ////////////////////////////



                    g8.Clear();

                    DataRow rf = g8.NewRow();

                    rf[0] = 1;
                    rf[1] = "---";
                    rf[2] = 0;


                    rf[3] = 0;
                    rf[4] = g6.Rows[0][2].ToString(); ;
                    rf[5] = g6.Rows[0][2].ToString();


                    rf[9] = 0;
                    g8.Rows.Add(rf);

                    for (int i = 2; i <= 20; i++)
                    {


                        int maxs1 = 0;
                        int maxs2 = 0;
                        int a = 0, b = 0;
                        for (int j = 0; j < g8.Rows.Count; j++)
                        {

                            if (g8.Rows[j][5].ToString() != "")
                                a = int.Parse(g8.Rows[j][5].ToString());
                            else
                                a = 0;
                            if (g8.Rows[j][8].ToString() != "")
                                b = int.Parse(g8.Rows[j][8].ToString());
                            else
                                b = 0;
                            if (a > maxs1)
                                maxs1 = a;
                            if (b > maxs2)
                                maxs2 = b;
                        }


                        DataRow r = g8.NewRow();

                        r[0] = i.ToString();
                        r[1] = g6.Rows[i - 1][2].ToString();


                        r[2] = (int.Parse(r[1].ToString()) + int.Parse(g8.Rows[i - 2][2].ToString()));


                        if (maxs2 >= maxs1 || int.Parse(r[2].ToString()) >= maxs1)
                        {
                            r[3] = Math.Max(maxs1, int.Parse(r[2].ToString())).ToString();

                            r[4] = g6.Rows[i - 1][2].ToString();

                            r[5] = int.Parse(r[4].ToString()) + int.Parse(r[3].ToString());

                            if (maxs1 < int.Parse(r[2].ToString()) && maxs2 < int.Parse(r[2].ToString()))
                            {
                                r[9] = int.Parse(r[2].ToString()) - Math.Max(maxs1, maxs2);
                            }
                            else
                                r[9] = 0;

                        }

                        else
                        {
                            r[6] = Math.Max(maxs2, int.Parse(r[2].ToString())).ToString();

                            r[7] = gs2.Rows[i - 1][2].ToString();

                            r[8] = int.Parse(r[7].ToString()) + int.Parse(r[6].ToString());

                            if (maxs1 < int.Parse(r[2].ToString()) && maxs2 < int.Parse(r[2].ToString()))
                            {
                                r[9] = int.Parse(r[2].ToString()) - Math.Max(maxs1, maxs2);
                            }
                            else
                                r[9] = 0;
                        }

                        //else
                        //{
                        //    if (g8.Rows[i - 2][9].ToString() == "")
                        //        r[7] = Math.Max(int.Parse(r[2].ToString()), int.Parse(g8.Rows[i - 2][6].ToString()));
                        //    else
                        //        r[7] = Math.Max(int.Parse(r[2].ToString()), int.Parse(g8.Rows[i - 2][9].ToString()));

                        //    r[8] = int.Parse(r[7].ToString()) - int.Parse(r[2].ToString());

                        //    r[9] = int.Parse(r[7].ToString()) + int.Parse(r[3].ToString());
                        //    if (r[9].ToString() == "")
                        //        r[10] = int.Parse(r[6].ToString()) - int.Parse(r[2].ToString());
                        //    else
                        //        r[10] = int.Parse(r[9].ToString()) - int.Parse(r[2].ToString());
                        //    if (g8.Rows[i - 2][9].ToString() == "")
                        //    {
                        //        int a = int.Parse(g8.Rows[i - 2][6].ToString());
                        //        int b = int.Parse(g8.Rows[i - 2][2].ToString());
                        //        if (a < b)
                        //            r[11] = int.Parse(g8.Rows[i - 1][2].ToString()) - int.Parse(g8.Rows[i - 1][6].ToString());
                        //        else
                        //            r[11] = 0;
                        //    }
                        //    else
                        //    {
                        //        int a = int.Parse(g8.Rows[i - 2][9].ToString());
                        //        int b = int.Parse(g8.Rows[i - 2][2].ToString());
                        //        if (a < b)
                        //            r[11] = int.Parse(g8.Rows[i - 1][2].ToString()) - int.Parse(g8.Rows[i - 1][9].ToString());
                        //        else
                        //            r[11] = 0;
                        //    }

                        //}

                        g8.Rows.Add(r);
                    }


                    table_2server g = new table_2server();
                    g.Show();

                    table_2server.table2server.dataGridView1.DataSource = g8;


                }


                else
                {
                    /////////////  table 5   ///////////////////////
                    g7.Clear();

                    DataRow rf = g7.NewRow();

                    rf[0] = 1;
                    rf[1] = "---";
                    rf[2] = 0;
                    rf[3] = g6.Rows[0][2].ToString();
                    rf[4] = 0;
                    rf[5] = 0;
                    rf[6] = g6.Rows[0][2].ToString();
                    rf[7] = g6.Rows[0][2].ToString();
                    rf[8] = 0;

                    g7.Rows.Add(rf);
                    for (int i = 2; i <= 20; i++)
                    {
                        DataRow r = g7.NewRow();

                        r[0] = i.ToString();
                        r[1] = g5.Rows[i - 1][2].ToString();

                        r[2] = (int.Parse(r[1].ToString()) + int.Parse(g7.Rows[i - 2][2].ToString()));
                        r[3] = g6.Rows[i - 1][2].ToString();

                        r[4] = Math.Max(int.Parse(r[2].ToString()), int.Parse(g7.Rows[i - 2][6].ToString()));

                        r[5] = int.Parse(r[4].ToString()) - int.Parse(r[2].ToString());

                        r[6] = int.Parse(r[4].ToString()) + int.Parse(r[3].ToString());

                        r[7] = int.Parse(r[6].ToString()) - int.Parse(r[2].ToString());

                        int a = int.Parse(g7.Rows[i - 2][6].ToString());
                        int b = int.Parse(r[2].ToString());
                        if (a < b)
                            r[8] = b - int.Parse(g7.Rows[i - 2][6].ToString());
                        else
                            r[8] = 0;
                        g7.Rows.Add(r);
                    }
                    table_5 ft5 = new table_5();
                    ft5.Show();

                    table_5.table5.dataGridView1.DataSource = g7;
                }

            }
            else
            {
                MessageBox.Show("You Should Enter Data");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

            this.Size = new Size(638, 472);
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            this.Size = new Size(938, 472);
        }

        private void textBox5_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && textBox5.Text != "" && textBox6.Text != "")
            {
                DataRow r = g3n.NewRow();

                r[0] = textBox5.Text;
                r[1] = textBox6.Text;
                if ((textBox6.Text.Length - 2) > max_service_size1)
                    max_service_size1 = textBox6.Text.Length - 2;
                textBox5.Text = "";
                textBox6.Text = "";
                g3n.Rows.Add(r);

                dataGridView3.DataSource = g3n;
            }
        }

        private void textBox6_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && textBox5.Text != "" && textBox6.Text != "")
            {
                DataRow r = g3n.NewRow();

                r[0] = textBox5.Text;
                r[1] = textBox6.Text;
                if ((textBox6.Text.Length - 2) > max_service_size1)
                    max_service_size1 = textBox6.Text.Length - 2;
                textBox5.Text = "";
                textBox6.Text = "";
                g3n.Rows.Add(r);

                dataGridView3.DataSource = g3n;
                textBox5.Focus();
            }
        }
    }
}
