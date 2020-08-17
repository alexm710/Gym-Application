using GymModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Transactions;

namespace GymController
{
    public class LoginController
    {
        public User SelectedUser { get; set; }


        // Encryption key commented out until bonus functionality for the project has been completed.
        //public string Decrypt(string cipherText)
        //{
        //    string EncryptionKey = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        //    cipherText = cipherText.Replace(" ", "+");
        //    byte[] cipherBytes = Convert.FromBase64String(cipherText);
        //    using (Aes encryptor = Aes.Create())
        //    {
        //        Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(EncryptionKey, new byte[] {
        //        0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76
        //        });
        //        encryptor.Key = pdb.GetBytes(32);
        //        encryptor.IV = pdb.GetBytes(16);
        //        using (MemoryStream ms = new MemoryStream())
        //        {
        //            using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateDecryptor(), CryptoStreamMode.Write))
        //            {
        //                cs.Write(cipherBytes, 0, cipherBytes.Length);
        //                cs.Close();
        //            }
        //            cipherText = Encoding.Unicode.GetString(ms.ToArray());
        //        }
        //    }
        //    return cipherText;
        //}
        public bool Login(string username, string password)
        {
            using var db = new GymContext();
            {
                User selectedUser = db.Users.Where(u => u.UserName == username).FirstOrDefault();
                var details =
                    (from user in db.Users
                     where user.UserName == username
                     select new
                     {
                         user.UserId,
                         user.FirstName,
                         user.LastName,
                         user.Email
                     }).ToList();

                if  (details.FirstOrDefault() != null && selectedUser.Password == password)
                {
                    int currentUserId = details.FirstOrDefault().UserId;
                    string currentFirstName = details.FirstOrDefault().FirstName;
                    string currentLastName = details.FirstOrDefault().LastName;
                    string currentEmail = details.FirstOrDefault().Email;
                    GetCurrentUser(currentUserId, currentFirstName, currentLastName, currentEmail);
                    return true;
                }
                return false;
            }
        }
        public void GetCurrentUser(int currentUserId, string currentFirstName, string currentLastName, string currentEmail)
        {
            CurrentUser.Id = currentUserId;
            CurrentUser.FirstName = currentFirstName;
            CurrentUser.LastName = currentLastName;
            CurrentUser.Email = currentEmail;
        }
    }
}