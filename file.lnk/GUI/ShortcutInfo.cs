using System;
using System.IO;
using Shell32;
using IWshRuntimeLibrary;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace lnkFile
{
    public partial class ShortcutInfo : Form
    {

        //[DllImport("shell32.dll")]
        //static extern bool SHGetSpecialFolderPath(IntPtr hwndOwner, [Out] StringBuilder lpszPath, int nFolder, bool fCreate);
        //const int CSIDL_COMMON_DESKTOPDIRECTORY = 0x19;

        public ShortcutInfo()
        {
            InitializeComponent();
            //Del_Lnk();
        }
        //public void Del_Lnk()
        //{
        //    //Current User: Delete current user's Desktop shortcut
        //    string desktopFolder = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
        //    string shortcut_link = Path.Combine(desktopFolder, "lnk.lnk");
        //    if (System.IO.File.Exists(shortcut_link))
        //    {
        //        System.IO.File.Delete(shortcut_link);
        //    }
        //    //All Users: Delete All User's Desktop shortcut
        //    StringBuilder allUserProfile = new StringBuilder(260);
        //    SHGetSpecialFolderPath(IntPtr.Zero, allUserProfile, CSIDL_COMMON_DESKTOPDIRECTORY, false);
        //    string common_shortcut_link = Path.Combine(allUserProfile.ToString(), "lnk.lnk");
        //    if (System.IO.File.Exists(common_shortcut_link))
        //    {
        //        System.IO.File.Delete(common_shortcut_link);
        //    }
        //    txtShowArgument.Text = shortcut_link;
        //}

        // Get information about this link.
        // Return an error message if there's a problem.
        private string GetShortcutInfo(string full_name, out string name, out string path, out string descr, out string working_dir, out string args)
        {
            name = "";
            path = "";
            descr = "";
            working_dir = "";
            args = "";
            try
            {
                // Make a Shell object.
                Shell32.Shell shell = new Shell32.Shell();
                // Get the shortcut's folder and name.
                string shortcut_path = full_name.Substring(0, full_name.LastIndexOf("\\"));
                string shortcut_name = full_name.Substring(full_name.LastIndexOf("\\") + 1);
                if (!shortcut_name.EndsWith(".lnk")) shortcut_name += ".lnk";
                // Get the shortcut's folder.
                Shell32.Folder shortcut_folder = shell.NameSpace(shortcut_path);
                // Get the shortcut's file.
                Shell32.FolderItem folder_item = shortcut_folder.Items().Item(shortcut_name);
                if (folder_item == null)
                    return "Cannot find shortcut file '" + full_name + "'";
                if (!folder_item.IsLink)
                    return "File '" + full_name + "' isn't a shortcut.";
                // Display the shortcut's information.
                Shell32.ShellLinkObject lnk = (Shell32.ShellLinkObject)folder_item.GetLink;
                name = folder_item.Name;
                descr = lnk.Description;
                path = lnk.Path;
                working_dir = lnk.WorkingDirectory;
                args = lnk.Arguments;
                return "";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            string name, descr, path, working_dir, args;

            string result =
                GetShortcutInfo(txtShortcut.Text, out name, out path, out descr, out working_dir, out args);

            if (result.Length > 0)
            {
                MessageBox.Show(result, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            txtName.Text = name;
            txtDescription.Text = descr;
            txtPath.Text = path;
            txtWorkingDirectory.Text = working_dir;
            txtArguments.Text = args;
        }
    }
}
