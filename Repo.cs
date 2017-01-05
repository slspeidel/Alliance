using System.IO;
public class Repo {
    public Repo() {
        // initialize file path
        
    }

    public int Co_Save(Company co) 
    {
        var fileStream = File.OpenWrite(".\\companies");
        var index = Find(co.Co_Name);
        if (!found)
        {
            using (StreamWriter writer = new StreamWriter(fileStream))
            {
                writer.WriteLine(string.Format("{0};{1};{2};{3};{4};{5}",
                    co.Id,
                    co.Co_Name, 
                    co.Co_Address.Street,
                    co.Co_Address.City,
                    co.Co_Address.State,
                    co.Co_Address.Zip
                ));
            }
        }
        return co.Id;
    }

    public int Cust_Save(Customer cust) 
    {
        return 0;
    }

    public int Find(string name)
    {
        var index = 0;
        return index;
    }
}