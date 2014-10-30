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
    public partial class Form3 : Form {
        
        private HtmlParse html;
        private Form1 parent;

        public Form3(Form1 parent) {
            InitializeComponent();
            html = HtmlParse.getInstance();
            this.parent = parent;
        }

        private void button1_Click(object sender, EventArgs e) {
            String input;
            String selected = comboBox1.Text;
            switch (selected) {
                case "h1":
                    input = "<h1>"+textBox1.Text+"</h1>";
                    html.AddTextToBody(Application.StartupPath+"\\index.html", input);
                break;
                case "h2":
                    input = "<h2>"+textBox1.Text+"</h2>";
                    html.AddTextToBody(Application.StartupPath+"\\index.html", input);
                break;
                case "h3":
                    input = "<h3>"+textBox1.Text+"</h3>";
                    html.AddTextToBody(Application.StartupPath+"\\index.html", input);
                break;
                case "h4":
                    input = "<h4>"+textBox1.Text+"</h4>";
                    html.AddTextToBody(Application.StartupPath+"\\index.html", input);
                break;
                case "h5":
                    input = "<h5>"+textBox1.Text+"</h5>";
                    html.AddTextToBody(Application.StartupPath+"\\index.html", input);
                break;
                
            }
            parent.refresh();

        }

        
    }
}
