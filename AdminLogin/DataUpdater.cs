using System;
using System.Data.SqlClient;
using System.IO;
using Newtonsoft.Json;

public class DataUpdater
{
    private string connectionString;
    private string jsonFilePath;

    public DataUpdater(string dbConnectionString, string jsonFilePath)
    {
        this.connectionString = dbConnectionString;
        this.jsonFilePath = jsonFilePath;
    }

    public void UpdateDataFromJsonToDatabase()
    {
        try
        {
            string jsonData = File.ReadAllText(jsonFilePath);
            dynamic jsonObject = JsonConvert.DeserializeObject(jsonData);

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "INSERT INTO Manager (TenTaiKhoan, soLanDangNhap, level, [x-positon], [y-position], [z-position], [y-rotation], " +
                    "scence, currentHealth, maxHealth, healthLevel, currentStamina, " +
                    "maxStamina, staminaLevel, currentAttackDamge, currrentSouls, healthSliderValue, staminaSliderValue) " +
               "VALUES (@TenTaiKhoan, @soLanDangNhap, @level, @xPosition, @yPosition, @zPosition, @yRotation, " +
               "@_sceneNow, @currentHealth, @maxHealth, @healthLevel, @currentStamina, @maxStamina, @staminaLevel, " +
               "@currentAttackDamage, @currentSouls, @healthSliderValue, @staminaSliderValue)";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@TenTaiKhoan", jsonObject.characterName);
                command.Parameters.AddWithValue("@timeplay", 0); // Đổi giá trị này thành giá trị phù hợp
                command.Parameters.AddWithValue("@soLanDangNhap", 0); // Đổi giá trị này thành giá trị phù hợp
                command.Parameters.AddWithValue("@luongBossTieuDiet", 0); // Đổi giá trị này thành giá trị phù hợp
                command.Parameters.AddWithValue("@level", jsonObject.characterLevel);
                command.Parameters.AddWithValue("@diemCaoNhat", 0); // Đổi giá trị này thành giá trị phù hợp
                command.Parameters.AddWithValue("@xPosition", jsonObject.xPosition);
                command.Parameters.AddWithValue("@yPosition", jsonObject.yPosition);
                command.Parameters.AddWithValue("@zPosition", jsonObject.zPosition);
                command.Parameters.AddWithValue("@yRotation", jsonObject.yRotation);
                command.Parameters.AddWithValue("@_sceneNow", jsonObject._sceneNow);
                command.Parameters.AddWithValue("@currentHealth", jsonObject.currentHealth);
                command.Parameters.AddWithValue("@maxHealth", jsonObject.maxHealth);
                command.Parameters.AddWithValue("@healthLevel", jsonObject.healthLevel);
                command.Parameters.AddWithValue("@currentStamina", jsonObject.currentStamina);
                command.Parameters.AddWithValue("@maxStamina", jsonObject.maxStamina);
                command.Parameters.AddWithValue("@staminaLevel", jsonObject.staminaLevel);
                command.Parameters.AddWithValue("@currentAttackDamage", jsonObject.currentAttackDamage);
                command.Parameters.AddWithValue("@currentSouls", jsonObject.currentSouls);
                command.Parameters.AddWithValue("@healthSliderValue", jsonObject.healthSliderValue);
                command.Parameters.AddWithValue("@staminaSliderValue", jsonObject.staminaSliderValue);
                // Sửa

                command.ExecuteNonQuery();
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("An error occurred while updating data from JSON to database: " + ex.Message);
        }
    }

    public void UpdateDataFromDatabaseToJson()
    {
        try
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT TOP 1 * FROM Manager ORDER BY Id DESC";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    dynamic jsonObject = new
                    {
                        characterName = reader["TenTaiKhoan"],
                        characterLevel = reader["level"],
                        xPosition = reader["x-positon"],
                        yPosition = reader["y-position"],
                        zPosition = reader["z-position"],
                        yRotation = reader["y-rotation"],
                        _sceneNow = reader["scence"],
                        currentHealth = reader["currentHealth"],
                        maxHealth = reader["maxHealth"],
                        healthLevel = reader["healthLevel"],
                        currentStamina = reader["currentStamina"],
                        maxStamina = reader["maxStamina"],
                        staminaLevel = reader["staminaLevel"],
                        currentAttackDamage = reader["currentAttackDamge"],
                        currentSouls = reader["currrentSouls"],
                        healthSliderValue = reader["healthSliderValue"],
                        staminaSliderValue = reader["staminaSliderValue"]
                    };

                    string jsonData = JsonConvert.SerializeObject(jsonObject, Formatting.Indented);
                    File.WriteAllText(jsonFilePath, jsonData);
                }

                reader.Close();
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("An error occurred while updating data from database to JSON: " + ex.Message);
        }
    }
}
