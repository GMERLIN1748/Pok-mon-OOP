using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon
{
    public abstract class Pokemon
    {
        public abstract string Name { get; }
        public abstract string Type { get; }
        public abstract int HP { get; }
        public abstract int Attack { get; }
        public abstract int Defense { get; }
        public abstract int Speed { get; }

        // ฟังก์ชันโหลดรูปภาพ
        public virtual Image? GetImage()
        {
            string path = Path.Combine(Application.StartupPath, "picture", Name + ".png");

            if (File.Exists(path))
            {
                using (var stream = new MemoryStream(File.ReadAllBytes(path)))
                {
                    return Image.FromStream(stream);
                }
            }

            return null;
        }
    }
}
