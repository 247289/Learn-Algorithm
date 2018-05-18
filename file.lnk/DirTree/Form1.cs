using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using lnkFile.DirTree;

namespace lnkFile.DirTree
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //hàm tạo các phần tử miêu tả nội dung của thư mục strDir
        private void ExploreDir(String strDir, TreeNode hParent)
        {
            String strSearchDir;
            String strsubDir;
            strSearchDir = strDir + "\\*";
            FindData fd = new FindData();
            IntPtr hFile = MyFileFind.FindFirstFile(strSearchDir, fd);
            if (hFile == (IntPtr)(-1))
            {
                // the directory is empty; just close up and return.
                return;
            }

            TreeNode hThisItem;
            String strFileName;
            Boolean bContinue = true;
            while (bContinue)
            {// thêm từng phần tử trong thư mục hiện hành vào vị trí tương ứng của TreeView
                strFileName = fd.fileName;
                if (strFileName != "." && strFileName != "..")
                {
                    hThisItem = hParent.Nodes.Add(strFileName);
                    if ((fd.fileAttributes & 0x10) != 0)
                    {
                        strsubDir = strDir + "\\" + strFileName;
                        ExploreDir(strsubDir, hThisItem);
                    }
                }
                bContinue = MyFileFind.FindNextFile(hFile, fd);
            }
            return;
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            //xóa nội dung cây hiện có
            treeViewDir.Nodes.Clear();
            //tạo nút gốc tương ứng với thư mục bắt đầu
            TreeNode node = treeViewDir.Nodes.Add(txtStartDir.Text);
            //duyệt thư mục vào tạo các mục tương ứng trên DirTree
            ExploreDir(txtStartDir.Text, node);
            //hiển thị chi tiết nội dung của thư mục bắt đầu
            node.Expand();
        }
    }
}
