﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Tester : Form
    {
        public Tester()
        {
            InitializeComponent();
        }

        private void SubmitProb_Click(object sender, EventArgs e)
        {
            var sub = new SubmitProblems();
            sub.Show();
        }

        private void CurrentProb_Click(object sender, EventArgs e)
        {
            var curr = new CurrentProblems();
            curr.Show();
        }

        private void Tester_Load(object sender, EventArgs e)
        {

        }
    }
}
