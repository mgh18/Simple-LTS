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
    public partial class editF : Form
    {
        public editF()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataClasses1DataContext db = new DataClasses1DataContext();
            var q = (from p in db.students where p.sid == Program.sid select p).Single();
            q.sname = textBox1.Text;
            q.sfamily = textBox2.Text;
            q.scmeli = textBox3.Text;

            db.SubmitChanges();
            Close();
        }

        private void editF_Load(object sender, EventArgs e)
        {

            if (Program.sid != 0)
            {
                DataClasses1DataContext db = new DataClasses1DataContext();
                var q = (from p in db.students where p.sid == Program.sid select p).Single();
                textBox1.Text = q.sname;
                textBox2.Text = q.sfamily;
                textBox3.Text = q.scmeli;
                textBox3.Enabled = false;
            }
        }
    }
}
