using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows;

namespace Rewritten_File_Functions
{
    public class File_Functions
    {
        /* Please do not change any of the error/exception messages! */

        public void throwexception(string exception) 
        {
            throw new Exception(exception);
        }

        public void throwerror(string error) 
        {
            error = error + "";
            /* Implement your exploit api's execution function (below is code). */
            /* API.Execute(error); */
        }

        public void writefile(string filepath, string contents) 
        {
            if (contents == "") 
            {
                throwerror("content cannot be empty");
                throwexception("content(s) cannot be empty");
            }
            else if (filepath == "") 
            {
                throwerror("file path cannot be empty");
                throwexception("file path cannot be empty");
            }
            else if (filepath.Contains(".dll .exe .scr .bat .com .csh .msi .vb .vbs .vbe .ws .wsf .wsh .ps1 .psy"))
            {
                throwerror("file extension was blocked");
                throwexception("file extension was blocked");
            }
            else 
            {
                try 
                {
                    File.WriteAllText(filepath, contents);
                }
                catch (Exception) 
                {
                    throwerror("error while writting to " + filepath);
                    throwexception("check developer console for details");
                }
            }
        }

        public string readfile(string filepath) 
        {
            return File.ReadAllText(filepath);
        }

        public void appendfile(string filepath, string contents) /* Didn't work on this one because not good to feed skids */
        {
            filepath = "This one is for you to make!";
            contents = "https://www.youtube.com/watch?v=izGwDsrQ1eQ" + "https://www.youtube.com/watch?v=dQw4w9WgXcQ";
        }

        public void loadfile(string filepath) /* Didn't work on this one because not good to feed skids */
        {
            filepath = "This one is for you to make!" + "Never gonna give you up!" + "Swag means Secretly we are gay." + "Insert 1980 Gay Love Songs Here.";
        }

        public void listfiles(string folder)
        {
            int fileCount = Directory.GetFiles(folder, ".", SearchOption.TopDirectoryOnly).Length;
            string str = Convert.ToString(fileCount);
            throwerror(str + " files exist in " + folder);
            /* You can use 'str' to represent the amount of files exist in folder */
        }

        public bool isfile(string filepath) 
        {
            return File.Exists(filepath);
        }

        public bool isfolder(string folderpath)
        {
            return Directory.Exists(folderpath);
        }

        public void makefolder(string folderpath) 
        {
            if (Directory.Exists(folderpath)) 
            {
                throwerror("directory already exists");
                throwexception("directory path already exists");
            }
            else 
            {
                Directory.CreateDirectory(folderpath);
            }
        }

        public void delfolder(string folderpath)
        {
            if (Directory.Exists(folderpath))
            {
                Directory.Delete(folderpath);
            }
            else
            {
                throwerror("directory doesn't exist");
                throwexception("directory path doesn't exists");
            }
        }

        public void delfile(string filepath)
        {
            if (File.Exists(filepath))
            {
                File.Delete(filepath);
            }
            else
            {
                throwerror("file doesn't exist");
                throwexception("file path doesn't exists");
            }
        }

        public void createfile(string filepath) 
        {
            if (File.Exists(filepath))
            {
                throwerror("file already exists");
                throwexception("file path already exists");
            }
            else
            {
                if (filepath.Contains(".dll .exe .scr .bat .com .csh .msi .vb .vbs .vbe .ws .wsf .wsh .ps1 .psy"))
                {
                    throwerror("file extension was blocked");
                    throwexception("file extension was blocked");
                }
                else 
                {
                    File.Create(filepath);
                    System.Threading.Thread.Sleep(500);
                    File.WriteAllText(filepath, "--totally not commenting lmfao\n\nprint('hello im homo')\n\nwarn('did you know deez nuts are homo?')\n\nprint('your using clxyify file funcs please if this guy didnt credit me expose or report him')");
                }
            }
        }
    }
}
