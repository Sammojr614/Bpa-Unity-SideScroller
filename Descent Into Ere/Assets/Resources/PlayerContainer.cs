using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Xml.Serialization;
using System.Xml;
using System.IO;
[XmlRoot("PlayerDataCollection")]
public class PlayerContainer 
{
    [XmlArray("Player")]
    [XmlArrayItem("Health")]
   public List<Player> PlayerSaveData =  new List<Player>();
    public static PlayerContainer Load(string path)
    {
        TextAsset _xml = Resources.Load<TextAsset>(path);
        XmlSerializer dataFinder = new XmlSerializer(typeof(PlayerContainer));
        StringReader reader = new StringReader(_xml.text);
        PlayerContainer player = dataFinder.Deserialize(reader) as PlayerContainer;
        reader.Close();
        return player;
    }
   
}
