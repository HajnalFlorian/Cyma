using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

public class DataManager
{
    public static void save(object entity, string filename)
    {
        BinaryFormatter formatter = new BinaryFormatter();
        FileStream stream= File.Create(Application.persistentDataPath + '/' + filename);
        formatter.Serialize(stream, entity);
        stream.Close();
    }
    public static object Load(string filename)
    {
        BinaryFormatter formatter = new BinaryFormatter();
        FileStream stream = File.Open(Application.persistentDataPath + "/" + filename, FileMode.Open);
        Datas entity = (Datas)formatter.Deserialize(stream);
        stream.Close();
        return entity;

    }
   
}
