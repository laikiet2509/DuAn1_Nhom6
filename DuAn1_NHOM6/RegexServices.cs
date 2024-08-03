using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PRL
{
    public class RegexServices
    {
        // regex tên không được nhập số
        public bool RegexChu(string str) 
        {
            string pattern = @"^[^\d]*$";
            Regex regex = new Regex(pattern);
            return regex.IsMatch(str);
        }
        // regex số không được nhập chữ
        public bool RegexSo(string str)
        {
            string pattern = @"^[^a-zA-Z]*$";
            Regex regex = new Regex(pattern);
            return regex.IsMatch(str);
        }
        // regex số từ 1-99
        public bool RegexSo1_99(string str)
        {
            string pattern = @"^([1-9][0-9]?|99)$";
            Regex regex = new Regex(pattern);
            return regex.IsMatch(str);
        }
        // regex k số âm
        public bool RegexSoAm(string str)
        {
            string pattern = @"^-.*$";
            Regex regex = new Regex(pattern);
            return !regex.IsMatch(str);
        }
        // regex chỉ được 10 số
        public bool Regex10so(string str)
        {
            string pattern = @"^09\d{8}$";
            Regex regex = new Regex(pattern);
            return regex.IsMatch(str);
        }
        public bool RegexEmail(string tr)
        {
            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            Regex regex = new Regex(pattern);
            return regex.IsMatch(tr);
        }
        public bool RegexMaSanPham(string str)
        {
            string pattern = @"^(?=.*[a-zA-Z])(?=.*\d)[a-zA-Z\d]+$";
            Regex regex = new Regex(pattern);
            return regex.IsMatch(str);
        }
    }
}
