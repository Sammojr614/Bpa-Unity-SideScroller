using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Xml.Serialization;
using System.Xml;


public class Player 
{
    [XmlAttribute("PlayerData")]
    public string playerData;

    [XmlElement("PlayerHealth")]
    public int Health;
    
    [XmlElement("PlayerLives")]
    public int lives;

}
