using System.IO;

namespace VideoSystem.Codes
{
    public static class GetImg
    {
        public static System.Drawing.Image GetImgFrom_File (string path)
        {
            FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read);
            int byteLength = (int)fs.Length;
            byte[] fileBytes = new byte[byteLength];
            fs.Read(fileBytes, 0, byteLength);
            fs.Close();
            return System.Drawing.Image.FromStream(new MemoryStream(fileBytes));
        }
    }
}
