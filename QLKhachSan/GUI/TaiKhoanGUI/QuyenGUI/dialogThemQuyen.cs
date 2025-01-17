﻿using QLKhachSan.BUS;
using QLKhachSan.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLKhachSan.GUI.TaiKhoanGUI.QuyenGUI
{
    public partial class dialogThemQuyen : Form
    {
        QuyenBUS quyenBUS = new QuyenBUS();
        public dialogThemQuyen()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThemQuyen_Click(object sender, EventArgs e)
        {
            if (txtTenQuyen.Text == "")
                MessageBox.Show("Thêm thất bại , tên quyền trống !");
            else
            {
                string maquyen = quyenBUS.TaoMaQuyen();
                QuyenDTO quyen = new QuyenDTO(maquyen, txtTenQuyen.Text);
                // Them
                if (quyenBUS.ThemQuyen(quyen))
                {
                    MessageBox.Show("Thêm thành công");
                }
            }
        }
    }
}
