using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tst2 {
    class Image {
        public Image( byte[] data) {
            Data = data;
        }

        public int Id { get; private set; }
        public string FileName { get; private set; }
        public string Title { get; private set; }
        public byte[] Data { get; private set; }
        
    }
}
