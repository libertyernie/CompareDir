using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CompareDir
{
    public partial class Loading : Form
    {
		public string Caption {
			get {
				return label1.Text;
			}
			set {
				label1.Text = value;
			}
		}

        public Loading(string s)
        {
            InitializeComponent();
            label1.Text = s;
        }
    }
}
