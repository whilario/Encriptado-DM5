using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// se necesita importar esta libreria
using System.Security.Cryptography;


namespace ConsoleApp1
{
    internal class encrypmd5
    {
        //metodo de encriptado 
        public string encrypt(string Mensaje)
        {
            string hash = "vivo";
            byte[] data = UTF8Encoding.UTF8.GetBytes(Mensaje);

            MD5 md5 = MD5.Create();
            TripleDES tripledes = TripleDES.Create();

            tripledes.Key = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(hash));
            tripledes.Mode = CipherMode.ECB;

            ICryptoTransform transform = tripledes.CreateEncryptor();
            byte[] result = transform.TransformFinalBlock(data, 0, data.Length);

            return Convert.ToBase64String(result);
        }

        // metodo de desencriptado
        public string decryp(string Mensaje)
        {
            string hash = "vivo";
            byte[] data = Convert.FromBase64String(Mensaje);

            MD5 md5 = MD5.Create();
            TripleDES tripledes = TripleDES.Create();

            tripledes.Key = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(hash));
            tripledes.Mode = CipherMode.ECB;

            ICryptoTransform transform = tripledes.CreateDecryptor();
            byte[] result = transform.TransformFinalBlock(data, 0, data.Length);

            return UTF8Encoding.UTF8.GetString(result);
        }

    }
}
