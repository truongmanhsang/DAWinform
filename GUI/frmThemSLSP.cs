using BUS;
using ClassLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmThemSLSP : Form
    {
        public enum Loai
        {
            Them,
            ChinhSua,
            Mua,
            ChinhSuaMua
        }

        Loai loai;

        clsSanPham_BUS _SanPhamBUS = new clsSanPham_BUS();
        int iSLMua;
        string strMaSP;
        DataTable dtSP;
        public frmThemSLSP(string strMaSP, int iSLMua, Loai loai)
        {
            InitializeComponent();
            this.strMaSP = strMaSP;
            dtSP = _SanPhamBUS.LayBangSanPham(strMaSP);
            picHinh.Image = new Bitmap(dtSP.Rows[0]["Hinh"].ToString());
            lblTenSP.Text = dtSP.Rows[0]["TenSanPham"].ToString();
            this.iSLMua = iSLMua;
            this.loai = loai;

            if (loai == Loai.ChinhSua || loai == Loai.ChinhSuaMua)
            {
                numSL.Value = iSLMua;
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmMuaSP_Load(object sender, EventArgs e)
        {

        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            if (numSL.Value > 0)
            {
                int iSLCon = Convert.ToInt16(dtSP.Rows[0]["SoLuong"].ToString());
                if (loai == Loai.Them)
                {
                    if ((iSLMua + numSL.Value) <= iSLCon)
                    {
                        iSLMua += Convert.ToInt16(numSL.Value);
                        this.Close();
                    }
                    else
                    {
                        FormMessage.Show("Sản phẩm còn trong kho không đủ. Còn " + iSLCon + "!", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (loai == Loai.ChinhSua)
                {
                    if (numSL.Value <= iSLCon)
                    {
                        iSLMua = Convert.ToInt16(numSL.Value);
                        this.Close();
                    }
                    else
                    {
                        FormMessage.Show("Sản phẩm còn trong kho không đủ. Còn " + iSLCon + "!", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }else if (loai == Loai.Mua)
                {
                    iSLMua += Convert.ToInt16(numSL.Value);
                    this.Close();
                }else if (loai == Loai.ChinhSuaMua)
                {
                    iSLMua = Convert.ToInt16(numSL.Value);
                    this.Close();
                }
            }
            else
            {
                FormMessage.Show("Sản phẩm thêm không được nhỏ hơn 0!", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public int LaySoLuong()
        {
            return iSLMua;
        }
    }
}
