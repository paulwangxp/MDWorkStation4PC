using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Encoder
{
    public partial class CreateRSAKeysForm : Form
    {
        public CreateRSAKeysForm()
        {
            InitializeComponent();
        }

        private void CreateRSAKeysForm_Load(object sender, EventArgs e)
        {
            RSAKey keys = Encoder.CreateRSAKey();
            this.txtPrivateKey.Text = keys.PrivateKey;
            this.txtPublishKey.Text = keys.PublicKey;
        }
    }
}
