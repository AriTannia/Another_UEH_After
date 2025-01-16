using Newtonsoft.Json;
using System;

public class CharacterData
{
    public string characterName { get; set; }
    public int characterLevel { get; set; }
    public double xPosition { get; set; }
    public double yPosition { get; set; }
    public double zPosition { get; set; }
    public double yRotation { get; set; }
    public string _sceneNow { get; set; }
    public int currentHealth { get; set; }
    public int maxHealth { get; set; }
    public int healthLevel { get; set; }
    public float currentStamina { get; set; }
    public float maxStamina { get; set; }
    public int staminaLevel { get; set; }
    public int currentAttackDamage { get; set; }
    public int currentSouls { get; set; }
    public float healthSliderValue { get; set; }
    public float staminaSliderValue { get; set; }

}

public class DataDeserializer
{
    public static CharacterData DeserializeTextData(string textData)
    {
        try
        {
            CharacterData userData = JsonConvert.DeserializeObject<CharacterData>(textData);
            return userData;
        }
        catch (Exception ex)
        {
            // Xử lý lỗi nếu có
            Console.WriteLine($"Lỗi khi deserializing dữ liệu từ text: {ex.Message}");
            return null;
        }
    }
}
