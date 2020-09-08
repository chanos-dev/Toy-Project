using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CryptChan
{
    class DB
    {
        private SQLiteConnection conn = null;

        //public string Path => @"C:\CryptoChan\db.sqlite"; 
        public string dBPath => $"{Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)}\\CryptoChan\\db.sqlite";

        public DB() { }

        public bool CreateDataBase(string path)
        {            
            try
            {
                SQLiteConnection.CreateFile(path);                
            }
            catch
            {
                throw new Exception();
            }

            return true;
        }

        public bool ConnectionDataBase()
        {
            bool isCreateDB = false;

            try
            {
                FileInfo fileInfo = new FileInfo(dBPath);

                if (!fileInfo.Exists)
                {
                    isCreateDB = true;
                }

                if (isCreateDB)
                {
                    if (!Directory.Exists(dBPath))
                    {
                        Directory.CreateDirectory(Path.GetDirectoryName(dBPath));
                    }

                    if (CreateDataBase(dBPath))
                    {
                        //Success
                        ConnectionDataBase(dBPath);
                        CreateTable();
                    }
                    else
                    {
                        //Fail
                    }
                } 

                if (ConnectionDataBase(dBPath))
                {
                    //Success
                }
                else
                {
                    //Fail
                }
            }
            catch
            {
                return false;
            }

            return true;
        }

        public bool ConnectionDataBase(string path)
        {
            try
            {
                if (conn is null)
                {
                    conn = new SQLiteConnection($"Data Source={path};Version=3;");
                    conn.Open();
                }
            }
            catch
            {
                throw new Exception();
            } 
            return true;
        } 

        public int CreateTable()
        {
            int result;

            try
            {
                StringBuilder sbQuery = new StringBuilder();   

                sbQuery.Append("create table files (file_name varchar(256))");

                SQLiteCommand command = new SQLiteCommand(sbQuery.ToString(), conn);
                result = command.ExecuteNonQuery();                
            }
            catch (Exception e)
            {
                throw e;
            }

            return result;
        }
    }
}
