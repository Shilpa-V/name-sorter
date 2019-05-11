using System;

namespace NameSorter.Library
{
    /// <summary>
    /// 'PersonName' class
    /// </summary>
    public class PeronName
    {
        //Split Person name by Space
        //To get First Name, Middle Name and Last Name
        public static string[] SplitFullName(string fullName)
        {
            string nameParts = fullName.Trim();
            string[] bits = nameParts.Split(' ');
            return bits;
        }
    }
}
