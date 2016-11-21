using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
             This code demonstrates the Facoty method offering fleibility in creating different documents. The derived Document
             * classes Report and Resume instatiate extended version of the document class. the factory method is called in the
             * constructor of the document base class.
             */
            Document[] documets = new Document[2];

            documets[0] = new Report();
            documets[1] = new Resume();

            foreach (var doc in documets)
            {
                Console.WriteLine("\n" + doc.GetType().Name + "--");
                foreach (var page in doc.Pages)
                {
                    Console.WriteLine(" " + page.GetType().Name );
                }
            }

            Console.ReadLine();

        }
    }
}
