using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_Editor.DB_Handlers
{
    public class ColumnStructureCreator
    {
        //nalezy pamietac, by jezeli isAutoIncrement = true, wtedy musi byc ustanowiony jakis klucz
        public ColumnStructureCreator(string name, string type, bool isNotNull = false, string def = "", bool isAutoIncrement = false)
        {
            Field = name;
            Type = type;
            NullValue = isNotNull;
            //przypisac odpowiedni klucz
            Default = def;
            Extra = isAutoIncrement;
        }
        public string Field { get; set; }///przeprowadzic walidacje, czy taka nazwa jest dozwolona       
        public string Type { get; set; }//walidacja w innym miejscu
        public bool NullValue { get; set; } //NOT NULL
        //key
        public string Default { get; set; }
        public bool Extra { get; set; }

        public override string ToString()
        {
            //odpowiednio zmodyfikowac w zaleznosci od klucza
            return Field + " " + Type + " " + NullValue + " " + Default + " " + Extra;
        }
    }
}
