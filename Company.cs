using System;
using System.IO;
using System.Runtime.Serialization;

[Serializable()]
public class Company : Repo, ISerializable
{
    public string Co_Name {get; set;}
    public Address Co_Address {get; set;}
    public int Id {get; set;}

    public Company (string name, Address address) {
        Co_Name = name;
        Co_Address = address;
    }

    public void Save()
    {
        Id = base.Co_Save(this);
    }
}