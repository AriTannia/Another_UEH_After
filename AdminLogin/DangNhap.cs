using Microsoft.Office.Interop.Excel;
using Newtonsoft.Json;
using System;
using System.Data.SqlClient;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace AdminLogin
{
    public partial class DangNhap : Form
    {
        public string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\84967\OneDrive\Documents\GitHub\Another_UEH_2\AdminLogin\Database1.mdf;Integrated Security=True";
        public DangNhap()
        {
            InitializeComponent();
        }

        private void linkLabel_QuenMK_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            QuenMatKhau quenMatKhau = new QuenMatKhau();
            quenMatKhau.ShowDialog();
        }

        private void linkLabel_DKy_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DangKy dangKy = new DangKy();
            dangKy.ShowDialog();
        }

        Modify modify = new Modify();

        private void button_DangNhap_Click(object sender, EventArgs e)
        {
            string tentk = textBox_user.Text;
            string mk = textBox_password.Text;
            if (tentk.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập tên tài khoản!");
            }
            else if (mk.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập mật khẩu!");
            }
            else
            {
                string query = "Select * from TaiKhoan where TenTaiKhoan = '" + tentk + "' and MatKhau = '" + mk + "' and isAdmin = 0";
                string query1 = "Select * from TaiKhoan where TenTaiKhoan = '" + tentk + "' and MatKhau = '" + mk + "' and isAdmin = 1";
                if (modify.TaiKhoans(query).Count() != 0)
                {
                    MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    string updateQuery = $"UPDATE Manager SET soLanDangNhap = soLanDangNhap + 1 WHERE TenTaiKhoan = '{tentk}'";
                    modify.Command(updateQuery);
                    this.Hide();
                    //update

                    string jsonFilePath = @"C:\Users\84967\OneDrive\Documents\GitHub\Another_UEH_2\AdminLogin\bin\Debug\AnotherUEHSaveFile";
                    DataUpdater updater = new DataUpdater(connectionString, jsonFilePath);

                    if (File.Exists(jsonFilePath))
                    {
                        string textData = File.ReadAllText(jsonFilePath);
                        // Sử dụng hàm DeserializeTextData từ DataDeserializer
                        CharacterData userData = DataDeserializer.DeserializeTextData(textData);
                        // Lúc đăng nhập lại trên winform, kiểm tra tên username đăng nhập có giống với trên
                        // file json không, nếu giống thì cập nhật dữ liệu từ json lên database
                        // (file json không thay đổi để tiếp tục màn chơi), còn không giống thì lấy dữ liệu từ database
                        // xuống file json (để bắt đầu màn chơi mới) và update dữ liệu từ file json lên database tương ứng với tên tk.

                        if (userData.characterName == tentk)
                        {
                            updater.UpdateDataFromJsonToDatabase();
                        }
                        else
                        {
                            updater.UpdateDataFromDatabaseToJson();
                            updater.UpdateDataFromJsonToDatabase();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Không tồn tại file");
                    }

                    Process.Start(@"C:\Users\84967\Downloads\UEH_GAME\NOZ_C.exe");
                }
                else if (modify.TaiKhoans(query1).Count() != 0)
                {
                    MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    string updateQuery = $"UPDATE Manager SET soLanDangNhap = soLanDangNhap + 1 WHERE TenTaiKhoan = '{tentk}'";
                    modify.Command(updateQuery);
                    this.Hide();
                    Home home = new Home();
                    home.WindowState = FormWindowState.Maximized;
                    home.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Tên tài khoản và mật khẩu không chính xác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }


        private dynamic DeserializeTextData(string textData)
        {
            try
            {
                dynamic userData = JsonConvert.DeserializeObject(textData);
                return userData;
            }
            catch (Exception ex)
            {
                // Xử lý lỗi nếu có
                Console.WriteLine($"Lỗi khi deserializing dữ liệu từ text: {ex.Message}");
                return null;
            }
        }


        private void UpdateDatabaseFromTextDataAndSaveToFile(string tentk, string textData)
        {
            try
            {  

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string updateQuery = $"UPDATE Manager SET TenTaiKhoan = '{textData}' WHERE TenTaiKhoan = '{tentk}'";
                    SqlCommand command = new SqlCommand(updateQuery, connection);
                    command.ExecuteNonQuery();
                }

                string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "AnotherUEHSaveFile.txt");
                File.WriteAllText(filePath, textData);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi khi cập nhật cơ sở dữ liệu và ghi dữ liệu vào file text: {ex.Message}");
            }
        }

        private void UpdateDatabaseFromTextData(dynamic userData)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    // Thực hiện việc cập nhật dữ liệu từ text vào cơ sở dữ liệu
                    // Sử dụng thông tin từ userData để cập nhật các trường dữ liệu trong bảng Manager
                    // Ví dụ:
                    string updateQuery = $"UPDATE Manager SET characterLevel = {userData.characterLevel}, " +
                     $"[x-positon] = {userData.xPosition}, " +
                     $"[y-position] = {userData.yPosition}, " +
                     $"[z-position] = {userData.zPosition}, " +
                     $"[y-rotation] = {userData.yRotation}, " +
                     $"scence = '{userData._sceneNow}', " +
                     $"currentHealth = {userData.currentHealth}, " +
                     $"maxHealth = {userData.maxHealth}, " +
                     $"healthLevel = {userData.healthLevel}, " +
                     $"currentStamina = {userData.currentStamina}, " +
                     $"maxStamina = {userData.maxStamina}, " +
                     $"staminaLevel = {userData.staminaLevel}, " +
                     $"currentAttackDamge = {userData.currentAttackDamage}, " +
                     $"currrentSouls = {userData.currentSouls}, " +
                     $"healthSliderValue = {userData.healthSliderValue}, " +
                     $"staminaSliderValue = {userData.staminaSliderValue} " +
                     $"WHERE TenTaiKhoan = '{userData.characterName}'";
                    // Sửa
                    SqlCommand command = new SqlCommand(updateQuery, connection);
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi khi cập nhật cơ sở dữ liệu: {ex.Message}");
            }
        }

    }
}
