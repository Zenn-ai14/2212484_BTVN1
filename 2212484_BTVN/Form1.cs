using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2212484_BTVN
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox2.PasswordChar = '•';
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Lấy giá trị username và password từ các TextBox
            string username = textBox1.Text;
            string password = textBox2.Text;

            // Kiểm tra thông tin đăng nhập (ví dụ: so sánh với thông tin cố định)
            if (username == "2212484" && password == "123456")
            {
                // Nếu thông tin đăng nhập đúng
                MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                // Nếu thông tin đăng nhập sai
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu. Vui lòng thử lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

                // Tùy chọn: Xóa nội dung TextBox
                textBox1.Text = string.Empty;
                textBox2.Text = string.Empty;

                // Đặt lại focus vào textBox1 để người dùng nhập lại thông tin
                textBox1.Focus();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            if (username.Length < 5)
            {
                // Thông báo cho người dùng hoặc cập nhật giao diện
                label1.Text = "Tên đăng nhập phải từ 5 kí tự";
            }
            else
            {
                // Nếu username hợp lệ
                label1.Text = "Tên đăng nhập hợp lệ.";
            }

            // Kiểm tra xem username có chứa ký tự đặc biệt không
            if (System.Text.RegularExpressions.Regex.IsMatch(username, @"[^a-zA-Z0-9_]"))
            {
                // Thông báo nếu có ký tự đặc biệt
                label1.Text = "Tên đăng nhập chỉ được chứa các ký tự chữ cái, số và dấu gạch dưới.";
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            string password = textBox2.Text;

            // Kiểm tra độ dài tối thiểu của mật khẩu (ví dụ: tối thiểu 8 ký tự)
            if (password.Length < 8)
            {
                // Thông báo cho người dùng hoặc cập nhật giao diện
                label1.Text = "Mật khẩu phải có ít nhất 8 ký tự.";
            }
            else
            {
                label1.Text = "";
            }

            // Kiểm tra mật khẩu có chứa cả chữ cái và số không
            bool hasLetter = false;
            bool hasDigit = false;

            foreach (char c in password)
            {
                if (char.IsLetter(c))
                    hasLetter = true;
                if (char.IsDigit(c))
                    hasDigit = true;
            }

            if (!hasLetter || !hasDigit)
            {
                label1.Text = "Mật khẩu phải chứa cả chữ cái và số.";
            }
            else if (password.Length >= 8)
            {
                label1.Text = "Mật khẩu hợp lệ.";
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            // Xóa nội dung của textBox1 (username)
            textBox1.Text = string.Empty;

            // Xóa nội dung của textBox2 (password)
            textBox2.Text = string.Empty;

            // Tùy chọn: Hiển thị thông báo hoặc cập nhật giao diện nếu cần
            label1.Text = "Tên đăng nhập và mật khẩu đã được xóa.";
        }
    }
}
