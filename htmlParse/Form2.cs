using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace htmlParse {
    public partial class Form2 : Form {
        
        private HtmlParse html;
        private Form1 parent;

        public Form2(Form1 parent) {
            InitializeComponent();
            html = HtmlParse.getInstance();
            this.parent = parent;
        }
        
        public int rowCount = 1;

        private void button1_Click(object sender, EventArgs e) {
            listBox1.Items.Add(textBox1.Text);
            textBox1.Clear();
        }

        private void button2_Click(object sender, EventArgs e) {
            listBox1.Items.RemoveAt(listBox1.SelectedIndex);
        }

        private void button4_Click(object sender, EventArgs e) {
            String input = "<table class='table table-striped table-hover'><thead><tr>";
            foreach(String sutun in listBox1.Items) {
                input += "<th>"+ sutun + "</th>";
            }
            input += "</tr></thead><tbody>";
            for (int i = 0; i < this.rowCount; i++) {
                input += "<tr class='active'>";
                for (int j = 0; j < listBox1.Items.Count; j++) {
                    input += "<td>Tablo Verisi</td>";
                }
                input += "</tr>";
            }
            input += "</tbody></table>";
            html.AddTextToBody(Application.StartupPath+"\\index.html", input);
            
        }

        private void button3_Click(object sender, EventArgs e) {
            this.rowCount = Convert.ToInt32(textBox2.Text);
        }
    }
}
