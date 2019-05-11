using System;
using System.Collections.Generic;
using System.IO;


//Main application class for name-sorter application
namespace name_sorter
{
    /// <summary>
    /// MainApp startup class for name-sorter
    /// </summary>
    class Program
    {
        /// <summary>
        /// Entry point into console application.
        /// </summary>
        static void Main(string[] args)
        {


            // To check the length of  
            // Command line arguments 
            // Should atleast one
            if (args.Length != 1)
            {
                Console.WriteLine("Please, Pass Valid number of Argument to proceed! Pass only one argument for text file");
                return;
            }

            //Getting file name from command line argument
            string textFile =  args[0];

            // Validate existance of file
            // If file does not exist will return immediately
            // After prompt custom error message
            if (!File.Exists(textFile))
            {
                Console.WriteLine("File does not exist; Please enter valid file name");
                return;
            }


            // Initializing empty Person object list
            List<SortPersonRepository> personNamelist = new List<SortPersonRepository>();

            // Initalize reader to read data 
            // From text file unsorted-names-list.txt 
            using (StreamReader reader = new StreamReader(textFile))
            {
                string personName = string.Empty;
 
                //Console.WriteLine($"{args[0]}");
                // Iterating thorugh text file to fetch all lines
                while ((personName = reader.ReadLine()) != null)
                {
                
                    //Validate - A name must have at least 1 given name 
                    //and may have up to 3 given names.
                    if (personName == string.Empty || personName.Split(" " , StringSplitOptions.RemoveEmptyEntries).Length > 3 )
                        continue;

                    //Parsing the name of the person and split into
                    // FirstName, MiddleName and LastName
                    SortPersonRepository splitPersonName = new SortPersonRepository(new SortPersonRepository().GetSplitPersonName(personName));
                                        
                    // Adding into PersonList after splitting
                    personNamelist.Add(splitPersonName);
                }
            }
       
            // Sorting Person List by LastName and 
            // Then by FirstName
            SortPersonRepository.SortPersonNames(personNamelist);    
                       
            // Open file to write sorted Person List
            using (StreamWriter writer = new StreamWriter("sorted-names-list.txt",false))
            {
            
                // Iterating thorugh Person list and 
                // Write into file named sorted-names-list.txt 
                foreach (var line in personNamelist)
                    writer.WriteLine(line);
            }

            Console.WriteLine("Success");
            Console.ReadLine();

        }
    }
}
