/*
   Furkan BAŞARAN - <furkan.basaran@ogr.sakarya.edu.tr> - g120910018
   Form üzerinden HTML düzenleme - Programlama2 Ödev 2
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;

namespace htmlParse {
    public partial class Form1 : Form {
        private HtmlParse html;

        public Form1() {
            InitializeComponent();
            html = HtmlParse.getInstance();
        }

        public void refresh() {
            webBrowser1.Navigate(Application.StartupPath+"\\index.html");
        }

        private void bootstrapToolStripMenuItem_Click(object sender, EventArgs e) {
            
        }

        private void Form1_Load(object sender, EventArgs e) {
            webBrowser1.Navigate(Application.StartupPath+"\\index.html");
        }

        private void emailToolStripMenuItem_Click(object sender, EventArgs e) {
            String emailInput = "<div class='form-group col-sm-10'><label for='exampleInputEmail1'>Email</label><input type='email' class='form-control' id='exampleInputEmail1' placeholder='Email'></div>";
            html.AddTextToBody(Application.StartupPath+"\\index.html", emailInput);
            refresh();
        }

        private void passwordToolStripMenuItem_Click(object sender, EventArgs e) {
            String passwordInput = "<div class='form-group col-sm-10'><label for='exampleInputPassword1'>Password</label><input type='password' class='form-control' id='exampleInputPassword1' placeholder='Password'></div>";
            html.AddTextToBody(Application.StartupPath+"\\index.html", passwordInput);
            refresh();
        }

        private void textareaToolStripMenuItem_Click(object sender, EventArgs e) {
            String input = "<div class='form-group col-sm-10'><label for='exampleInputTextarea1'>Metin Girisi</label><textarea id='exampleInputTextarea1' class='form-control' rows='3'></textarea></div>";
            html.AddTextToBody(Application.StartupPath+"\\index.html", input);
            refresh();
        }

        private void buttonToolStripMenuItem_Click(object sender, EventArgs e) {
            String input = "<div class='form-group col-sm-10'><a href='#' class='btn btn-default btn-lg btn-block'>Submit</a></div>";
            html.AddTextToBody(Application.StartupPath+"\\index.html", input);
            refresh();
        }

        private void tabloToolStripMenuItem_Click(object sender, EventArgs e) {
            Form2 form = new Form2(this);
            form.ShowDialog();
        }

        private void başlıkToolStripMenuItem_Click(object sender, EventArgs e) {
            Form3 form = new Form3(this);
            form.ShowDialog();
        }
    }
}
