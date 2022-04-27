using System.Collections.Generic;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using UnityEngine;

public static class SaveManager
{
    public static void InitData()
    {
        if (!File.Exists(Application.persistentDataPath + "/SaveData.dat"))
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream file = File.Create(Application.persistentDataPath + "/SaveData.dat");
            SaveData data = new SaveData();
            bf.Serialize(file, data);
            file.Close();
        }
    }

    public static void SaveData()
    {
        BinaryFormatter bf = new BinaryFormatter();
        FileStream file = File.Create(Application.persistentDataPath + "/SaveData.dat");
        SaveData data = new SaveData();
        bf.Serialize(file, data);
        file.Close();
    }

    public static List<int> LoadTypeTileGameForOne()
    {
        BinaryFormatter bf = new BinaryFormatter();
        FileStream file = File.Open(Application.persistentDataPath + "/SaveData.dat", FileMode.Open);
        SaveData data = (SaveData)bf.Deserialize(file);
        file.Close();
        return data.typeTileGameForOne;
    }

    public static List<int> LoadTypeTileGameForTwo()
    {
        BinaryFormatter bf = new BinaryFormatter();
        FileStream file = File.Open(Application.persistentDataPath + "/SaveData.dat", FileMode.Open);
        SaveData data = (SaveData)bf.Deserialize(file);
        file.Close();
        return data.typeTileGameForTwo;
    }
}

public class SaveData
{
    public List<int> typeTileGameForOne = new List<int>();
    public List<int> typeTileGameForTwo = new List<int>();
}

