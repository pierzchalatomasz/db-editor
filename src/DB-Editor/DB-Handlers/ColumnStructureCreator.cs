using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_Editor.DB_Handlers
{
    public class ColumnStructureCreator
    {
        public ColumnStructureCreator(string name, string type, bool isNotNull = false, bool primary_key = false, string def = "", bool isAutoIncrement = false)
        {
            Field = name;
            Type = type;
            NullValue = isNotNull;
            Primary_Key = primary_key;
            if (isAutoIncrement)
                Primary_Key = true;
            if (!isAutoIncrement)
                Default = def;
            else
                Default = "";

            Extra = isAutoIncrement;
        }
        #region Properties
        public string Field { get; set; }///przeprowadzic walidacje, czy taka nazwa jest dozwolona       
        public string Type { get; set; }//walidacja w innym miejscu
        public bool NullValue { get; set; } //true = NULL
        public bool Primary_Key { get; set; } //true = PRIMARY KEY
        public string Default { get; set; }
        public bool Extra { get; set; } //true = auto_increment
        #endregion

        public override string ToString()
        {
            string nullValueString = "";
            string primaryKeyString = "";
            string extraString = "";
            string tmp = "";
            if (!NullValue)
                nullValueString = "NOT NULL";
            if (Primary_Key)
                primaryKeyString = "PRIMARY KEY";
            if (Extra)
                extraString = "auto_increment";
            if(Default != String.Empty)
            {
                Default = "DEFAULT \"" + Default + "\"";
                tmp =  Field + " " + Type + " " + nullValueString + " " + Default + " " + extraString + " " + primaryKeyString;
            }
            else
                tmp = Field + " " + Type + " " + nullValueString + " " + extraString + " " + primaryKeyString;
            return tmp.TrimEnd();
        }
    }
}
