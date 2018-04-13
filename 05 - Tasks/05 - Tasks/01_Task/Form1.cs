using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;

namespace _01_Task {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        //private void btnBaixar_Click(object sender, EventArgs e) { // erro no await

        private async void btnBaixar_Click(object sender, EventArgs e) {

            string endereco = txtSite.Text;

            WebClient web = new WebClient();
            // string html = web.DownloadString(endereco); // sem thread - lento

            string html = await web.DownloadStringTaskAsync(new Uri(endereco));

            txtResultado.Text = html;
        }
    }
}
