using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Type_Attr_Reflection
{
    // Type -> class, struct,...int, bool...
    // Attribute
    // Reflection: Thông tin kiểu dữ liệu, thời điểm thực thi 
    class Program
    {
        /*
            Description - thông tin chi tiết
        */
        [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method | AttributeTargets.Property)] // Thuộc tính description được sử dụng ở đâu(lớp, property, method...)
        class DescriptionAttribute : Attribute
        {
            public string DetailDescription { get; set; }
            public DescriptionAttribute(string _DetailDescription)
            {
                DetailDescription = _DetailDescription;
            }
        }

        [Description("Lớp chứa thông tin người dùng")]
        class User
        {
            [Description("Tên người dùng")]
            [Required(ErrorMessage = "Name phải thiết lặp")]
            [StringLength(50, MinimumLength = 3, ErrorMessage = "Tên phải dài từ 3 đến 50 ký tự")]
            public string Name { get; set; }

            [Description("Tuổi người dùng")]
            [Range(18, 80, ErrorMessage = "Tuổi phải từ 18 - 80")]
            public int Age { get; set; }

            [Description("Số điện thoại người dùng")]
            [Phone]
            public string PhoneNumber { get; set; }

            [Description("Email người dùng")]
            [EmailAddress(ErrorMessage = "Địa chỉ email sai cấu trúc")]
            public string Email { get; set; }

            [Obsolete("Phương thức này không nên sử dụng nữa cần thay bởi ShowInfo")]
            public void PrintInfo() => Console.WriteLine(Name);

            [Description("Phương thức in tên người dùng")]
            public void ShowInfo() => Console.WriteLine(Name);
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            //int[] a = { 1, 2, 3 };
            //Type t = a.GetType();
            //Console.WriteLine(t.FullName);

            //Console.WriteLine("-----Các thuộc tính");
            //t.GetProperties().ToList().ForEach((PropertyInfo o) => {
            //    Console.WriteLine(o.Name);
            //});

            //Console.WriteLine("-----Các trường dữ liệu");
            //t.GetFields().ToList().ForEach((FieldInfo f) => {
            //    Console.WriteLine(f.Name);
            //});

            //Console.WriteLine("-----Các phương thức");
            //t.GetMethods().ToList().ForEach((MethodInfo m) => {
            //    Console.WriteLine(m.Name);
            //});

            User user = new User()
            {
                Name = "XT",
                Age = 10,
                PhoneNumber = "0849497558",
                Email = "thaivkc@fsoft.com.vn"
            };

            //user.PrintInfo();

            //var properties = user.GetType().GetProperties();
            //foreach (PropertyInfo property in properties)
            //{
            //    foreach (var attr in property.GetCustomAttributes(false))
            //    {
            //        if (attr is DescriptionAttribute des)
            //        {
            //            var value = property.GetValue(user);
            //            var name = property.Name;
            //            Console.WriteLine($"{name} - {des.DetailDescription}: {value}");
            //        }
            //    }
            //}

            ValidationContext context = new ValidationContext(user);

            var result = new List<ValidationResult>();

            bool resultVal = Validator.TryValidateObject(user, context, result, true);

            if(resultVal == false)
            {
                result.ToList().ForEach((err) =>
                {
                    Console.WriteLine(err.MemberNames.First());
                    Console.WriteLine(err.ErrorMessage);
                });
            }

            Console.ReadLine();
        }
    }
}
