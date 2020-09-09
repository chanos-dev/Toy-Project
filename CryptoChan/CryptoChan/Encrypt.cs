using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptChan
{
    public class Encrypt
    {
        private Encrypt() { }

        private static Encrypt _instance;
        
        public static Encrypt Instance
        {
            get
            {
                if(_instance is null)
                {
                    _instance = new Encrypt();
                }

                return _instance;
            }
        } 

        public bool EncyptPass(string passWord)
        {

            return true;
        }
    }
}
