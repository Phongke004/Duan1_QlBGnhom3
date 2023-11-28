
﻿using DAL.DomainClass;



using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRL.View
{
    public partial class frmHoaDon : Form
    {
        HoaDonServices _hoaDonServices;
        Guid _idClick;
        public frmHoaDon()
        {
            InitializeComponent();
            _hoaDonServices = new HoaDonServices();

        }

        private void mnStripDoiMk_Click(object sender, EventArgs e)
        {
            frmDoiMatKhau frmDoiMatKhau = new frmDoiMatKhau();
            this.Hide();

            frmDoiMatKhau.ShowDialog();

        }
    }
}
