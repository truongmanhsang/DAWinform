using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassLibrary
{
    public class FormMessage
    {
        public static DialogResult Show(string strNoiDung, string strTieuDe, MessageBoxButtons msbButtons, MessageBoxIcon msbIcon)
        {
            Bitmap bmpBieuTuong = null;
            if (msbIcon == MessageBoxIcon.Asterisk)
            {
                bmpBieuTuong = SystemIcons.Asterisk.ToBitmap();
            }
            if (msbIcon == MessageBoxIcon.Error)
            {
                bmpBieuTuong = SystemIcons.Error.ToBitmap();
            }
            if (msbIcon == MessageBoxIcon.Exclamation)
            {
                bmpBieuTuong = SystemIcons.Exclamation.ToBitmap();
            }
            if (msbIcon == MessageBoxIcon.Hand)
            {
                bmpBieuTuong = SystemIcons.Hand.ToBitmap();
            }
            if (msbIcon == MessageBoxIcon.Information)
            {
                bmpBieuTuong = SystemIcons.Information.ToBitmap();
            }
            if (msbIcon == MessageBoxIcon.Question)
            {
                bmpBieuTuong = SystemIcons.Question.ToBitmap();
            }
            if (msbIcon == MessageBoxIcon.Stop)
            {
                bmpBieuTuong = SystemIcons.Error.ToBitmap();
            }
            if (msbIcon == MessageBoxIcon.Warning)
            {
                bmpBieuTuong = SystemIcons.Warning.ToBitmap();
            }
            frmMessage frm = new frmMessage(strNoiDung, strTieuDe, msbButtons, bmpBieuTuong);
            frm.ShowDialog();
            return frm.LayDialogResult();
        }
    }
}
