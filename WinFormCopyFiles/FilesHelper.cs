using System;
using System.IO;
using System.Linq;

namespace WinFormCopyFiles
{
    class FilesHelper
    {

        /// <summary>
        /// AS -Crear un directorio vacio
        /// </summary>
        public static void CreateEmptyDirectory(string fullPath)
        {
            if (!Directory.Exists(fullPath))
            {
                Directory.CreateDirectory(fullPath);
            }
        }


        /// <summary>
        /// AS - Borrar un archivo
        /// </summary>
        public static void DeleteFile(string fullPath)
        {
            if (File.Exists(fullPath))
            {
                FileInfo info = new FileInfo(fullPath);
                info.Attributes = FileAttributes.Normal;
                File.Delete(fullPath);
            }
        }

        /// <summary>
        /// AS - Borrar un directorio y su contenido
        /// </summary>
        public static void DeleteFolder(string fullPath)
        {
            if (Directory.Exists(fullPath))
            {
                DirectoryInfo directory = new DirectoryInfo(fullPath)
                {
                    Attributes = FileAttributes.Normal
                };

                foreach (var info in directory.GetFileSystemInfos("*", SearchOption.AllDirectories))
                {
                    FileInfo fInfo = info as FileInfo;
                    if (fInfo != null) info.Attributes = FileAttributes.Normal;
                }
                System.Threading.Thread.Sleep(100);
                directory.Delete(true);
            }

        }

        /// <summary>
        /// AS - Copiar archivo
        /// </summary>
        public static void CopyFile(string origPath, string destPath, bool overwrite)
        {
            try
            {
                if (Path.GetExtension(destPath) == "")
                {
                    destPath = Path.Combine(destPath, Path.GetFileName(origPath));
                }
                if (!Directory.Exists(Path.GetDirectoryName(destPath)))
                {
                    CreateEmptyDirectory(Path.GetDirectoryName(destPath));
                }
                if (!File.Exists(destPath))
                {
                    File.Copy(origPath, destPath, true);
                }
                else
                {
                    if (overwrite == true)
                    {
                        DeleteFile(destPath);
                        File.Copy(origPath, destPath, true);
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// AS - Copiar el contenido de un directorio pasando fecha minima de archivo modificado
        /// </summary>
        private static void CopyDirectoryContentSpecific(string origPath, string destPath, bool overwrite, DateTime modifiedDate)
        {
            if (Directory.Exists(origPath))
            {
                foreach (string dirPath in Directory.GetDirectories(origPath, "*", SearchOption.AllDirectories))
                {
                    CreateEmptyDirectory(dirPath.Replace(origPath, destPath));
                }

                var files = Directory.GetFiles(origPath, "*.*", SearchOption.AllDirectories).Where(f => new FileInfo(f).LastWriteTime >= modifiedDate).ToArray();

                foreach (string newPath in files)
                {
                    CopyFile(newPath, newPath.Replace(origPath, destPath), overwrite);
                }
            }
        }

        /// <summary>
        /// AS - Copiar un directorio y su contenido pasando fecha minima de archivo modificado
        /// </summary>
        public static void CopyDirectorySpecific(string origPath, string destPath, bool replace, DateTime modifiedDate)
        {
            if (replace == true)
            {
                DeleteFolder(destPath);
                CreateEmptyDirectory(destPath);
                CopyDirectoryContentSpecific(origPath, destPath, true, modifiedDate);
            }
            else
            {
                CopyDirectoryContentSpecific(origPath, destPath, true, modifiedDate);
            }
        }

        /// <summary>
        /// AS - Borrar los directorios vacios
        /// </summary>
        public static void DeleteFoldersIfEmpty(DirectoryInfo tree)
        {
            foreach (DirectoryInfo di in tree.EnumerateDirectories())
            {
                DeleteFoldersIfEmpty(di);
            }
            tree.Refresh();
            if (!tree.EnumerateFiles().Any())
            {
                tree.Delete();
            }
            return;
        }

    }
}
