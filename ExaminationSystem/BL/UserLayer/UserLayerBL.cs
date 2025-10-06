using ExaminationSystem.Data;
using ExaminationSystem.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExaminationSystem.BL.UserLayer
{
    public class UserLayerBL
    {
        public static List<User> getAllUsers()
        {
            using (var db = new ExaminationSystemContext())
            {
                return db.Users.ToList();
            }
        }

        public static List<User> SearchUserById(int id)
        {
            using (var db = new ExaminationSystemContext())
            {
                return db.Users.Where(c => c.Id == id).ToList();
            }
        }
        public static List<User> SearchUserByName(string name)
        {
            using (var db = new ExaminationSystemContext())
            {
                return db.Users
                  .Where(c => c.FullName.Contains(name))
                  .ToList();
            }
        }

        public static User GetUserById(int id)
        {
            using (var db = new ExaminationSystemContext())
            {
                return db.Users.FirstOrDefault(c => c.Id == id);
            }
        }

        public static User AuthenticateUser(string username, string password)
        {
            using (var db = new ExaminationSystemContext())
            {
                string hashedPassword = Encrypt(password); // استخدمي نفس دالة التشفير

                return db.Users.FirstOrDefault(u => u.UserName == username && u.PasswordHash == hashedPassword);
            }
        }
        public static string Encrypt(string password)
        {
            string strmsg = string.Empty;
            byte[] encode = new byte[password.Length];
            encode = Encoding.UTF8.GetBytes(password);
            strmsg = Convert.ToBase64String(encode);
            return strmsg;
        }
        public static int InsertUser(string _fullname, string _username, string _password, string _usertype)
        {
            using (var db = new ExaminationSystemContext())
            {
                var result = db.Users.
                    FirstOrDefault(u => u.UserName == _username);
                if (result != null)
                {
                    return -2;
                }
                else
                {
                    User? user = _usertype switch
                    {
                        "Admin" => new Admin
                        {
                            FullName = _fullname,
                            PasswordHash = Encrypt(_password), // استخدم دالة التشفير
                            UserName = _username,
                            Role = _usertype
                        },
                        "Student" => new Student
                        {
                            FullName = _fullname,
                            PasswordHash = Encrypt(_password),
                            UserName = _username,
                            Role = _usertype
                        },
                        "Teacher" => new Teacher
                        {
                            FullName = _fullname,
                            PasswordHash = Encrypt(_password),
                            UserName = _username,
                            Role = _usertype
                        },
                        _ => null
                    };

                    if (user == null)
                    {
                        MessageBox.Show("UserType Not Valid");
                        return -1;
                    }

                    db.Users.Add(user);
                    return db.SaveChanges();
                }


            }
        }
        public static int DeleteUser(int _id)
        {
            using (var db = new ExaminationSystemContext())
            {
                var user = db.Users.FirstOrDefault(u => u.Id == _id);
                if (user != null)
                {
                    db.Users.Remove(user);
                    return db.SaveChanges();
                }
                return 0;
            }
        }
        public static int UpdateUser(int _id, string _fullname, string _username, string _password, string _usertype)
        {
            using (var db = new ExaminationSystemContext())
            {
                var user = db.Users.FirstOrDefault(u => u.Id == _id);
                if (user != null)
                {
                    var result = db.Users.Where(h => h.Id != _id)
                                         .FirstOrDefault(z => z.UserName == _username);
                    if (result != null)
                    {
                        return -1;
                    }

                    user.FullName = _fullname;
                    user.UserName = _username;

                    if (!string.IsNullOrWhiteSpace(_password))
                    {
                        user.PasswordHash = Encrypt(_password);
                    }

                    user.Role = _usertype;

                    return db.SaveChanges();
                }
                return 0;
            }
        }
    }
}
