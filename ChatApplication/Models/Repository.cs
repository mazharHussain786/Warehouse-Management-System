using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatApplication.Models
{
    public class Repository
    {
     public bool CreateUser(Users U1)
     {
            ChatDataBaseContext cx=new ChatDataBaseContext();
            if(cx.Users.Any(c=>c.Email==U1.Email))
            {
                // already created ..
                return false;
            }
            cx.Users.Add(U1);
            cx.SaveChanges();
            return true;
     }

        public List<Users> GetAllUsers()
        {
            ChatDataBaseContext cx = new ChatDataBaseContext();
            var AllUsers = cx.Users.ToList();
            return AllUsers;
        }

        public bool AddProduct(int id , string Pname , int Quantity , int Price)
        {
            ChatDataBaseContext cx = new ChatDataBaseContext();
            Product p1 = new Product();
            var Data = cx.Products.FirstOrDefault(c => c.PId == id);
            if (Data != null && Data.Quantity==0)
            {
                cx.Products.Remove(Data);
            }
             Data = cx.Products.FirstOrDefault(c => c.PId == id);
            if (Data==null)
            {
                p1.PId = id;
                p1.Name = Pname;
                p1.Quantity = Quantity;
                p1.price = Price;
                cx.Products.Add(p1);
                cx.SaveChanges();
                return true;
            }
           
            return false;
        }
        public bool RemoveProduct(int id)
        {
            ChatDataBaseContext cx = new ChatDataBaseContext();
            var myProduct=cx.Products.FirstOrDefault(c=> c.PId == id);
            if (myProduct != null)
            {
                cx.Products.Remove(myProduct); cx.SaveChanges(); return true;
            }
            return false;
        }

    }
}
