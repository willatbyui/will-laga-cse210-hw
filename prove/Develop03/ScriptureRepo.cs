using System;
using System.Collections.Generic;

public class ScriptureRepo
{
    private Dictionary<string, (Reference, string)> scriptures;

    public ScriptureRepo()
    {
        scriptures = new Dictionary<string, (Reference, string)>();

/* single verse scriptures */
        scriptures.Add("1 Nephi 3:7", (new Reference("1 Nephi", "3", "7"), "I will go and do the things which the Lord hath commanded."));
        scriptures.Add("Mosiah 2:17", (new Reference("Mosiah", "2", "17"), "When ye are in the service of your fellow beings ye are only in the service of your God."));
/* multiple verse scripture */
        scriptures.Add("Alma 37:6-7", (new Reference("Alma", "37", "6", "7"), "By small and simple things are great things brought to pass. And, in the first place, it was by the power of God that they were brought forth."));

        scriptures.Add("Ether 12:27", (new Reference("Ether", "12", "27"), "And if men come unto me I will show unto them their weakness. I give unto men weakness that they may be humble; and my grace is sufficient for all men that humbly seek me."));
        
        scriptures.Add("2 Nephi 2:25", (new Reference("2 Nephi", "2", "25"), "Adam fell that men might have joy."));

    }

    public (Reference, string) GetScripture(string key)
    {
        if (scriptures.TryGetValue(key, out var scripture))
        {
            return scripture;
        }
        return (null, null);
    }
}
