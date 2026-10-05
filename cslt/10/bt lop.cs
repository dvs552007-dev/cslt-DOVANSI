using System;
using System.Collections.Generic;
using System.Text;

namespace cslt._10
{
    internal class bt_lop
    {
        private static string filePath;

        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            /*
            string filePath = "test.txt";
            using (FileStream fs = File.Create(filePath)) { }
            Console.WriteLine("Đã tạo tệp rỗng thành công.");
            if (File.Exists(filePath))
            {
                File.Delete(filePath);
                Console.WriteLine("Đã xóa tệp thành công.");
            }
            else
            {
                Console.WriteLine("Tệp không tồn tại.");
            }*/
            /* {
                 string filePath = "test.txt";
                 string content = "Xin chào";
                 File.WriteAllText(filePath, content);
                 Console.WriteLine("Đã tạo tệp và ghi văn bản.");
             }*/
            /*{
                string filePath = "test.txt";
                File.WriteAllText(filePath, "Lập trình C# File .");

                string readText = File.ReadAllText(filePath);
                Console.WriteLine("Nội dung trong tệp:\n" + readText);
            }*/
            /*{
                string filePath = "test.txt";
                string[] lines = { "a", "b", "c" };
                File.WriteAllLines(filePath, lines);
                Console.WriteLine("chuoi");
            }*/
            /*string filePath = "test.txt";
            string appendText = "\nDòng văn bản được thêm vào sau.";
            File.AppendAllText(filePath, appendText);
            Console.WriteLine("Đã nối thêm văn bản vào tệp.");*/

            /*{
                string sourceFile = "source.txt";
                string destFile = "copy.txt";

                File.WriteAllText(sourceFile, "Nội dung gốc của file.");
                File.Copy(sourceFile, destFile, true);

                Console.WriteLine("Nội dung tệp sau khi sao chép:");
                Console.WriteLine(File.ReadAllText(destFile));
            }*/

        }
    }
}
