using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HQHomebrewCards
{
    using System.IO;
    using System.Xml;
    using System.Xml.Serialization;

    public class CardSerializer
    {
       public CardSerializer()
        {

        }

        public void Serialize (ICardController cardController, string path)
        {
            System.Xml.Serialization.XmlSerializer x = new System.Xml.Serialization.XmlSerializer(cardController.GetType());

            // Create a new StreamWriter
            TextWriter writer = new StreamWriter(path);

            x.Serialize(writer, cardController);

            writer.Close();
        }

        public GenericCardController Deserialize(String path, Type type)
        {   
            // Create a new serializer
            XmlSerializer serializer = new XmlSerializer(type);

            // Create a StreamReader
            TextReader reader = new StreamReader(path);

            // Deserialize the file
            GenericCardController file;

            try
            {
                file = (GenericCardController)serializer.Deserialize(reader);
                // Close the reader
                reader.Close();
                // Return the object
                return file;
            }
            catch(Exception e)
            {                
                throw new Exception(String.Format("Error loading xml card design file: {0}", e.Message));
            }
        }

    }
}
