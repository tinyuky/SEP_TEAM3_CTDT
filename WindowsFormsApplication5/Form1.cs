﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication5
{
    public partial class Form1 : Form
    {
        private List<string> mtc = new List<string>();
        private List<string> mtct_pc = new List<string>();
        private List<string> mtct_kt = new List<string>();
        private List<string> mtct_kn = new List<string>();
        private List<string> mtct_td = new List<string>();

        string itemcontent = "";
        int itemposition = 0;

        public Form1()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            //wbCơsởvậtchất.Navigate(Path.GetDirectoryName(Application.ExecutablePath).Replace(@"bin\Debug", "") + "ckeditor.html");
            //wbKhốilượngkt.Navigate(Path.GetDirectoryName(Application.ExecutablePath).Replace(@"bin\Debug", "") + "ckeditor.html");
            //wbĐốitượng.Navigate(Path.GetDirectoryName(Application.ExecutablePath).Replace(@"bin\Debug", "") + "ckeditor.html");
            //wbQuytrình.Navigate(Path.GetDirectoryName(Application.ExecutablePath).Replace(@"bin\Debug", "") + "ckeditor.html");

            wbCơsởvậtchất.Navigate(Path.GetDirectoryName(Application.StartupPath).Replace(@"\bin", "") + @"\ckeditor.html");
            string c = Path.GetDirectoryName(Application.StartupPath);
            wbKhốilượngkt.Navigate(Path.GetDirectoryName(Application.StartupPath).Replace(@"\bin", "") + @"\ckeditor.html");
            wbĐốitượng.Navigate(Path.GetDirectoryName(Application.StartupPath).Replace(@"\bin", "") + @"\ckeditor.html");
            wbQuytrình.Navigate(Path.GetDirectoryName(Application.StartupPath).Replace(@"\bin", "") + @"\ckeditor.html");


            btnMụctiêu_hủy.Visible = false;
            btnMụctiêu_sửa.Visible = false;


        }

        //SET UP MỤC LỤC
        private void kếHoạchGiảngDạydựKiếnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tclMain.SelectedIndex = 5;
        }

        private void toolStripStatusLabel2_MouseHover(object sender, EventArgs e)
        {
            msMụclục.ShowDropDown();
        }

        private void thôngTinChungToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tclMain.SelectedIndex = 0;
        }

        private void mụcTiêuĐàoTạoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tclMain.SelectedIndex = 1;
        }

        private void thờiGianĐàoTạoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tclMain.SelectedIndex = 2;
        }

        private void khốiLượngKiếnThứcToànKhóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tclMain.SelectedIndex = 2;
        }

        private void đốiTượngTuyểnSinhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tclMain.SelectedIndex = 2;
        }

        private void quyTrìnhĐàoTạoĐiềuKiệnTốtNghiệpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tclMain.SelectedIndex = 2;
        }

        private void thangĐiểmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tclMain.SelectedIndex = 2;
        }

        private void nộiDungChươngTrìnhtênVàKhốiLượngCácHọcPhầnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tclMain.SelectedIndex = 4;
        }

        private void hướngDẫnThựcHiệnChươngTrìnhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tclMain.SelectedIndex = 6;
        }

        private void danhSáchĐộiNgũGiảngViênThựcHiệnChươngTrìnhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tclMain.SelectedIndex = 7;
        }

        private void cơSởVậtChấtPhụcVụHọcTậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tclMain.SelectedIndex = 8;
        }


        private void quảnLíMônHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tclMain.SelectedIndex = 3;
        }

        private void panel13_Paint(object sender, PaintEventArgs e)
        {

        }

        //NÚT PREVIOUS
        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (tclMain.SelectedIndex > 0)
            {
                tclMain.SelectedIndex = tclMain.SelectedIndex - 1;
            }

        }

        //NÚT NEXT
        private void btnNext_Click(object sender, EventArgs e)
        {
            if (tclMain.SelectedIndex < 8)
            {
                tclMain.SelectedIndex = tclMain.SelectedIndex + 1;
            }
        }

        //MỤC TIÊU ĐÀO TẠO
        //nút nhập
        //nút xóa
        private void btnĐàotạo_add_Click(object sender, EventArgs e)
        {
            //kiem tra chức năng
            if (btnĐàotạo_add.Text == ">>>")
            {
                //làm sạch view
                lwĐàotạo_view.Items.Clear();
                // lấy, kiểm tra dữ liệu
                string lv = cboĐàotạo_level.Text;

                if (lv != "")
                {
                    if (txtĐàotạo_content.Text != "")
                    {
                        if (lv == "Mục tiêu chung")
                        {
                            mtc.Add(txtĐàotạo_content.Text);
                        }
                        if (lv == "Mục tiêu cụ thể - Phẩm chất")
                        {
                            mtct_pc.Add(txtĐàotạo_content.Text);
                        }
                        if (lv == "Mục tiêu cụ thể - Kiến thức")
                        {
                            mtct_kt.Add(txtĐàotạo_content.Text);
                        }
                        if (lv == "Mục tiêu cụ thể - Kĩ năng")
                        {
                            mtct_kn.Add(txtĐàotạo_content.Text);
                        }
                        if (lv == "Mục tiêu cụ thể - Thái độ")
                        {
                            mtct_td.Add(txtĐàotạo_content.Text);
                        }
                        //show list view 
                        ShowMuctieudaotao();
                        txtĐàotạo_content.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Hãy điền nội dung");
                    }
                }
                else
                {
                    MessageBox.Show("Hãy chọn mục cần điền");
                }
            }
            //Xóa item
            if (btnĐàotạo_add.Text == "Xóa")
            {
                //confirm xóa
                DialogResult a = MessageBox.Show("Bạn có muốn xóa đối tượng này không?", "Thông báo", MessageBoxButtons.OKCancel);
                if (a == DialogResult.OK)
                {

                    //thuc hien xoa
                    DeleteItem(itemcontent, itemposition);

                    //vẽ lại view
                    lwĐàotạo_view.Items.Clear();
                    ShowMuctieudaotao();

                    //làm sạch content
                    txtĐàotạo_content.Text = "";

                    //visible 2 nút sửa, hủy
                    btnMụctiêu_sửa.Visible = false;
                    btnMụctiêu_hủy.Visible = false;
                    btnĐàotạo_add.Text = ">>>";

                    //thông báo
                    MessageBox.Show("Đã xóa đối tượng thành công");
                }


            }



        }


        //MỤC TIÊU ĐÀO TẠO
        //Hàm vẽ list view
        private void ShowMuctieudaotao()
        {
            lwĐàotạo_view.Items.Add("I/ Mục tiêu chung: ");
            for (int i = 0; i < mtc.Count; i++)
            {
                lwĐàotạo_view.Items.Add("\n     - " + mtc[i]);
            }
            lwĐàotạo_view.Items.Add("II/ Mục tiêu cụ thể: ");
            lwĐàotạo_view.Items.Add("\n     1. Phẩm chất");
            for (int i = 0; i < mtct_pc.Count; i++)
            {
                lwĐàotạo_view.Items.Add("\n         - " + mtct_pc[i]);
            }
            lwĐàotạo_view.Items.Add("\n     2. Kiến thức");
            for (int i = 0; i < mtct_kt.Count; i++)
            {
                lwĐàotạo_view.Items.Add("\n         - " + mtct_kt[i]);
            }
            lwĐàotạo_view.Items.Add("\n     3. Kĩ năng");
            for (int i = 0; i < mtct_kn.Count; i++)
            {
                lwĐàotạo_view.Items.Add("\n         - " + mtct_kn[i]);
            }

            lwĐàotạo_view.Items.Add("\n     4. Thái độ");
            for (int i = 0; i < mtct_td.Count; i++)
            {
                lwĐàotạo_view.Items.Add("\n         - " + mtct_td[i]);
            }
        }

        //MỤC TIÊU ĐÀO TẠO
        //load dữ liệu item dc chọn trong view
        private void lwĐàotạo_view_DoubleClick(object sender, EventArgs e)
        {
            if (lwĐàotạo_view.SelectedItems.Count == 1)
            {
                if ((lwĐàotạo_view.SelectedItem.ToString() != "I/ Mục tiêu chung: ") && (lwĐàotạo_view.SelectedItem.ToString() != "II/ Mục tiêu cụ thể: ") && (lwĐàotạo_view.SelectedItem.ToString() != "\n     1. Phẩm chất") && (lwĐàotạo_view.SelectedItem.ToString() != "\n     2. Kiến thức") && (lwĐàotạo_view.SelectedItem.ToString() != "\n     3. Kĩ năng") && (lwĐàotạo_view.SelectedItem.ToString() != "\n     4. Thái độ"))
                {
                    btnMụctiêu_sửa.Visible = true;
                    btnMụctiêu_hủy.Visible = true;
                    btnĐàotạo_add.Text = "Xóa";

                    txtĐàotạo_content.Text = lwĐàotạo_view.SelectedItem.ToString().Replace("\n     - ", "").Replace("\n         - ", "");

                    itemcontent = lwĐàotạo_view.SelectedItem.ToString().Replace("\n     - ", "").Replace("\n         - ", "");
                    itemposition = lwĐàotạo_view.SelectedIndex;

                    int s1 = 0;
                    int s2 = mtc.Count + 2;
                    int s3 = s2 + mtct_pc.Count + 1;
                    int s4 = s3 + mtct_kt.Count + 1;
                    int s5 = s4 + mtct_kn.Count + 1;

                    int[] arr = new[] { s1, s2, s3, s4, s5 };

                    int selectindex = 0;

                    for (int i = 0; i < 4; i++)
                    {
                        if ((itemposition > arr[i]) && (itemposition < arr[i + 1]))
                        {
                            if (i == 0)
                            {
                                selectindex = 0;
                                break;
                            }
                            if (i == 1)
                            {
                                selectindex = 1;
                                break;
                            }
                            if (i == 2)
                            {
                                selectindex = 2;
                                break;
                            }
                            if (i == 3)
                            {
                                selectindex = 3;
                                break;
                            }

                        }
                        else
                        {
                            if (i == 3)
                            {
                                selectindex = 4;
                            }
                        }
                    }

                    cboĐàotạo_level.SelectedIndex = selectindex;
                }

            }
        }

        //MỤC TIÊU ĐÀO TẠO
        //Nút hủy edit/xóa trong view
        private void btnMụctiêu_hủy_Click(object sender, EventArgs e)
        {
            btnĐàotạo_add.Text = ">>>";
            btnMụctiêu_sửa.Visible = false;
            btnMụctiêu_hủy.Visible = false;

            txtĐàotạo_content.Text = "";
        }

        //MỤC TIÊU ĐÀO TẠO
        //Thuật toán xóa
        private void DeleteItem(string item, int local)
        {
            int s1 = 0;
            int s2 = mtc.Count + 2;
            int s3 = s2 + mtct_pc.Count + 1;
            int s4 = s3 + mtct_kt.Count + 1;
            int s5 = s4 + mtct_kn.Count + 1;

            int[] arr = new[] { s1, s2, s3, s4, s5 };

            for (int i = 0; i < 4; i++)
            {
                if ((local > arr[i]) && (local < arr[i + 1]))
                {
                    if (i == 0)
                    {
                        mtc.Remove(item);
                        break;
                    }
                    if (i == 1)
                    {
                        mtct_pc.Remove(item);
                        break;
                    }
                    if (i == 2)
                    {
                        mtct_kt.Remove(item);
                        break;
                    }
                    if (i == 3)
                    {
                        mtct_kn.Remove(item);
                        break;
                    }

                }
                else
                {
                    if (i == 3)
                    {
                        mtct_td.Remove(item);
                    }
                }
            }

        }


        //MỤC TIÊU ĐÀO TẠO
        //Thuật toán sửa item trong view
        private void EditItem(string item, int position, ComboBox cbo)
        {

            // tìm ra list cũ
            int s1 = 0;
            int s2 = mtc.Count + 2;
            int s3 = s2 + mtct_pc.Count + 1;
            int s4 = s3 + mtct_kt.Count + 1;
            int s5 = s4 + mtct_kn.Count + 1;

            int[] arr = new[] { s1, s2, s3, s4, s5 };

            List<List<string>> sum_arr = new List<List<string>> { mtc, mtct_pc, mtct_kt, mtct_kn, mtct_td };

            List<string> work = new List<string>();

            int editint = 0;

            for (int g = 0; g < 4; g++)
            {
                if ((position > arr[g]) && (position < arr[g + 1]))
                {
                    work = sum_arr[g];
                    editint = g;
                    break;
                }
                else
                {
                    if (g == 3)
                    {
                        work = sum_arr[g + 1];
                        editint = g + 1;
                    }
                }
            }

            //Trường hợp edit list cũ
            if ((cbo.SelectedIndex == editint) && (editint == 0))
            {
                work[position - 1] = txtĐàotạo_content.Text;
            }
            else
            {
                if ((cbo.SelectedIndex == editint) && (editint == 1))
                {
                    work[position - (3 + mtc.Count)] = txtĐàotạo_content.Text;
                }
                else
                {
                    if ((cbo.SelectedIndex == editint) && (editint == 2))
                    {
                        work[position - (4 + mtc.Count + mtct_pc.Count)] = txtĐàotạo_content.Text;
                    }
                    else
                    {
                        if ((cbo.SelectedIndex == editint) && (editint == 3))
                        {
                            work[position - (5 + mtc.Count + mtct_pc.Count + mtct_kt.Count)] = txtĐàotạo_content.Text;
                        }
                        else
                        {
                            if ((cbo.SelectedIndex == editint) && (editint == 4))
                            {
                                work[position - (6 + mtc.Count + mtct_pc.Count + mtct_kt.Count + mtct_kn.Count)] = txtĐàotạo_content.Text;
                            }
                            
                        }
                    }
                }

            }

            //Trường hợp edit list khác
            if (cbo.SelectedIndex != editint)
            {
                DeleteItem(itemcontent, itemposition);
                sum_arr[cbo.SelectedIndex].Add(txtĐàotạo_content.Text);

            }



        }

        private void btnMụctiêu_sửa_Click(object sender, EventArgs e)
        {
            DialogResult a = MessageBox.Show("Bạn có muốn sửa đối tượng này không?", "Thông báo", MessageBoxButtons.OKCancel);
            if (a == DialogResult.OK)
            {
                if (txtĐàotạo_content.Text != "")
                {
                    //Xóa sach item trong view
                    lwĐàotạo_view.Items.Clear();

                    //Chạy thuật toán edit
                    EditItem(itemcontent, itemposition, cboĐàotạo_level);

                    //xóa content
                    txtĐàotạo_content.Text = "";

                    //vẽ lại view
                    ShowMuctieudaotao();

                    //visible 2 nút sửa, hủy           
                    btnMụctiêu_sửa.Visible = false;
                    btnMụctiêu_hủy.Visible = false;
                    btnĐàotạo_add.Text = ">>>";

                    //thông báo
                    MessageBox.Show("Đã sửa đối tượng thành công");
                }
                else
                {
                    MessageBox.Show("Hãy điền nội dung");
                }
               
            }



        }

        //


    }
}
