using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lnkFile.TreeView
{
    public partial class treeView : Form
    {
        public treeView()
        {
            InitializeComponent();
        }

        //bắt đầu load form đồng thời khởi tạo các ổ đĩa có trong máy lên TreeView
        private void Form1_Load(object sender, EventArgs e)
        {
            String[] drives = Directory.GetLogicalDrives(); //Lấy tất cả ổ đĩa và lưu vào mảng drives
            for (int i = 0; i < drives.Length; i++) //Thêm các ổ đĩa vào TreeView đồng thời tạo các nút con "giả" (*) cho nó
            {
                TreeNode tn = new TreeNode(drives[i]);
                treeView1.Nodes.Add(tn); // Ổ đĩa
                tn.Nodes.Add(new TreeNode("*")); // Nút con "giả"
            }
        }
        //trước khi người dùng mở các nút cha thì đồng thời thêm vào danh sách thư mục thật bên trong nhánh cha đó
        private void treeView1_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            treeView.ActiveForm.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            if (e.Node.Nodes.Count != 0)
                e.Node.Nodes.RemoveAt(0); //Xóa nút con "giả"
            String[] dirs;
            try
            {

                dirs = Directory.GetDirectories(e.Node.FullPath); //Lấy danh sách thư mục
                Array.Sort(dirs); //và sắp xếp chúng
            }
            catch (Exception pe) //Bẫy lỗi
            {
                MessageBox.Show(pe.Message, "Error!");
                goto err;
            }
            for (int i = 0; i < dirs.Length; i++) //thêm danh sách thư mục vào nút con đó
            {
                String dirName = dirs[i];
                TreeNode tn = new TreeNode(Path.GetFileName(dirName));
                e.Node.Nodes.Add(tn);
                String[] subdirs;
                try
                {
                    subdirs = Directory.GetDirectories(dirs[i]); // kiểm tra xem thư mục mới vừa thêm có thư mục con hay không. Nếu có thì thêm một nút con "giả" vào.
                    if (subdirs.Length > 0)
                        tn.Nodes.Add("temp");
                }
                catch
                { goto err; }

            }
        err:
            treeView.ActiveForm.Cursor = System.Windows.Forms.Cursors.Default;
        }

        private void treeView1_BeforeSelect(object sender, TreeViewCancelEventArgs e)
        {
            treeView.ActiveForm.Text = e.Node.FullPath;
        }
    }
}
