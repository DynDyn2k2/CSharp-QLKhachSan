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
    public partial class dialogSuaQuyen : Form
    {
        QuyenBUS quyenBUS = new QuyenBUS();
        String maquyen;
        public dialogSuaQuyen( string maquyen)
        {
            InitializeComponent();
            this.maquyen = maquyen;
            txtSuaMaQuyen.Text = maquyen;
        }
        
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSuaQuyen_Click(object sender, EventArgs e)
        {
            if (txtSuaTenQuyen.Text == "")
                MessageBox.Show("Sửa thất bại , tên Quyền trống !");
           
            else
            {
                QuyenDTO quyen = new QuyenDTO(maquyen , txtSuaTenQuyen.Text);
                // Them
                if (quyenBUS.SuaTQuyen(quyen))
                {
                    MessageBox.Show("Sửa thành công");
                }
            }
        }
    }
}
