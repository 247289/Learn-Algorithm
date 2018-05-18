using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace lnkFile.CLASS
{
    public class TreeFile
    {

        /* directory file
        private string fcreationTime, flastAcessTime, flength, fattributes;
        private string direcinfo_creationTime, direcinfo_lastAcessTime, direcinfo_getfile;
        private string driveinfo_name, driveinfo_type, driveinfo_format, driveinfo_af;

        public string FcreationTime
        {
            get
            {
                return fcreationTime;
            }

            set
            {
                fcreationTime = value;
            }
        }

        public string FlastAcessTime
        {
            get
            {
                return flastAcessTime;
            }

            set
            {
                flastAcessTime = value;
            }
        }

        public string Flength
        {
            get
            {
                return flength;
            }

            set
            {
                flength = value;
            }
        }

        public string Fattributes
        {
            get
            {
                return fattributes;
            }

            set
            {
                fattributes = value;
            }
        }

        public string Direcinfo_creationTime
        {
            get
            {
                return direcinfo_creationTime;
            }

            set
            {
                direcinfo_creationTime = value;
            }
        }

        public string Direcinfo_lastAcessTime
        {
            get
            {
                return direcinfo_lastAcessTime;
            }

            set
            {
                direcinfo_lastAcessTime = value;
            }
        }

        public string Direcinfo_getfile
        {
            get
            {
                return direcinfo_getfile;
            }

            set
            {
                direcinfo_getfile = value;
            }
        }

        public string Driveinfo_name
        {
            get
            {
                return driveinfo_name;
            }

            set
            {
                driveinfo_name = value;
            }
        }

        public string Driveinfo_type
        {
            get
            {
                return driveinfo_type;
            }

            set
            {
                driveinfo_type = value;
            }
        }

        public string Driveinfo_format
        {
            get
            {
                return driveinfo_format;
            }

            set
            {
                driveinfo_format = value;
            }
        }

        public string Driveinfo_af
        {
            get
            {
                return driveinfo_af;
            }

            set
            {
                driveinfo_af = value;
            }
        }

        public void Execute(string fpath)
        {
            FileInfo finfo = new FileInfo(fpath);
            if (finfo.Exists)
            {
                FcreationTime = finfo.CreationTime.ToString();
                FlastAcessTime = finfo.LastAccessTime.ToString();
                Flength = finfo.Length.ToString();
                Fattributes = finfo.Attributes.ToString();
            }
            DirectoryInfo direcinfo = finfo.Directory;
            if (direcinfo.Exists)
            {
                direcinfo_creationTime = direcinfo.CreationTime.ToString();
                direcinfo_lastAcessTime = direcinfo.LastAccessTime.ToString();
                direcinfo_getfile = direcinfo.GetFiles().Length.ToString();
            }
            DriveInfo driverinfo = new DriveInfo(finfo.FullName);
            if (driverinfo.IsReady)
            {
                driveinfo_name = driverinfo.Name;
                driveinfo_type = driverinfo.DriveType.ToString();
                driveinfo_format = driverinfo.DriveFormat.ToString();
                driveinfo_af = driverinfo.AvailableFreeSpace.ToString();
            }
        }*/
        
        

    }
}

