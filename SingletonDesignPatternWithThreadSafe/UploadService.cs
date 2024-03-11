using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDesignPatternWithThreadSafe
{
    public class UploadService
    {
        private UploadService(){}

        private static UploadService _instance;
        public int id { get; private set; }

        private static readonly object _instanceLock = new object();
        public static UploadService Instance(int id)
        {
            
            if (_instance == null)
            {
                lock (_instanceLock) 
                {
                    _instance = new UploadService();
                    _instance.id = id;
                }
            }
            return _instance;
        }

    }
}
