using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace beginnerCrypto
{
    public partial class Beginner : Form
    {
        Label lbNotificatin = new Label();

        public Beginner()
        {
            InitializeComponent();
        }

        #region function thao tác

        public void hideLabelMain()
        {
            lbDichVong.Visible = false;
            lbThayThe.Visible = false;
            lbAffine.Visible = false;
            lbVigenere.Visible = false;
            lbHill.Visible = false;
            lbRSA.Visible = false;
            lbAES.Visible = false;
            lbDES.Visible = false;
        }

        public void showLabelMain()
        {
            lbDichVong.Visible = true;
            lbThayThe.Visible = true;
            lbAffine.Visible = true;
            lbVigenere.Visible = true;
            lbHill.Visible = true;
            lbRSA.Visible = true;
            lbAES.Visible = true;
            lbDES.Visible = true;
        }

        public void paintPanelMain()
        {
            lbNotificatin.Text = "Chức năng đang được cập nhật...";
            lbNotificatin.SetBounds(15, 100, 200, 20);
            this.pnlMain.Controls.Add(lbNotificatin);
        }

        public void ShowDichVong()
        {
            paintPanelMain();
        }

        public void ShowThayThe()
        {

        }

        public void ShowAffine()
        {

        }

        public void ShowVigenere()
        {

        }

        public void ShowHill()
        {

        }

        public void ShowRSA()
        {

        }

        public void ShowAES()
        {

        }

        public void ShowDES()
        {

        }

        #endregion

        #region function call mã hóa

        //gọi các hàm mã hóa để thao tác trên form tại đây

        #endregion

        #region properties :V

        private void lbDichVong_Click(object sender, EventArgs e)
        {
            hideLabelMain();
            ShowDichVong();
        }

        private void lbThayThe_Click(object sender, EventArgs e)
        {
            hideLabelMain();
            ShowThayThe();
        }

        private void lbAffine_Click(object sender, EventArgs e)
        {
            hideLabelMain();
            ShowAffine();
        }

        private void lbVigenere_Click(object sender, EventArgs e)
        {
            hideLabelMain();
            ShowVigenere();
        }

        private void lbHill_Click(object sender, EventArgs e)
        {
            hideLabelMain();
            ShowHill();
        }

        private void lbRSA_Click(object sender, EventArgs e)
        {
            hideLabelMain();
            ShowRSA();
        }

        private void lbAES_Click(object sender, EventArgs e)
        {
            hideLabelMain();
            ShowAES();
        }

        private void lbDES_Click(object sender, EventArgs e)
        {
            hideLabelMain();
            ShowDES();
        }

        private void frmBeginner_Load(object sender, EventArgs e)
        {
            showLabelMain();
        }

        private void Beginner_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("You are really exit!", "Quession", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) != DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void mnuHome_Click(object sender, EventArgs e)
        {
            frmBeginner_Load(sender, e);
            lbNotificatin.Text = "";
        }

        private void mnuHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Mọi vấn đề vui lòng gửi về hòm thư nguyenvanlocmta@gmail.com","Infomation");
        }



        #endregion
    }
}
