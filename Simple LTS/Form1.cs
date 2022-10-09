using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simple_LTS
{
    public partial class Form1 : Form
    {
        DataClasses1DataContext db;


        public Form1()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            db = new DataClasses1DataContext();
            dataGridView1.DataSource = db.students;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddF ad = new AddF();
            ad.Show();
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            Form1_Load(sender, e);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int ind = (int)dataGridView1.CurrentRow.Index;
            DialogResult dig = MessageBox.Show("wanna delete it?","Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(dig == System.Windows.Forms.DialogResult.Yes)
            {
                var q = (from p in db.students where p.sid == (int)dataGridView1.Rows[ind].Cells[0].Value select p).Single();
                db.students.DeleteOnSubmit(q);
                db.SubmitChanges();
                Form1_Load(sender, e);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Program.sid =(int)dataGridView1.CurrentRow.Cells[0].Value;
            editF ef = new editF();
            ef.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var q = (from p in db.students select p).Where(p => p.sname.Contains(textBox1.Text) || p.sfamily.Contains(textBox1.Text));
                dataGridView1.DataSource = q;
            }   
            catch
            {

            }
        }
    }
}
