﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_Editor.DB_Handlers
{
    public class ColumnStructureCreator
    {
        public ColumnStructureCreator()
        {

        }
        public ColumnStructureCreator(string name, string type, bool isNotNull = false, bool primary_key = false, string typeLength = "", string def = "", bool isAutoIncrement = false)
        {
            Field = name;
            Type = type;
            NullValue = isNotNull;
            Primary_Key = primary_key;
            TypeLength = typeLength;
            if (isAutoIncrement)
                Primary_Key = true;
            if (!isAutoIncrement)
                Default = def;
            else
                Default = "";

            Extra = isAutoIncrement;         
        }
       
        #region Properties
        public string Field { get; set; }
        public string Type { get; set; }
        public string TypeLength { get; set; }
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
            if (TypeLength != "")
            {
                Type += "(";
                if (TypeLength.Any(char.IsDigit))
                    Type += TypeLength;
                else
                {
                    string[] tmpArray = TypeLength.Split(',');
                    foreach (string str in tmpArray)
                    {
                        Type += "'" + str.Trim() + "', ";
                    }
                    Type = Type.Substring(0, Type.Length - 2);
                }
                Type += ") ";
            }
            string tmp = "";
            if (!NullValue)
                nullValueString = " NOT NULL ";
            if (Primary_Key)
                primaryKeyString = " PRIMARY KEY";
            if (Extra)
                extraString = "auto_increment";
            if (Default != "")
            {
                Default = "DEFAULT \"" + Default + "\"";
                tmp = Field + " " + Type + nullValueString + Default + " " + extraString + primaryKeyString;
            }
            else
                tmp = Field + " " + Type + nullValueString + extraString + primaryKeyString;
            return tmp.TrimEnd();
        }
        public string ToStringWithoutPrimaryKeys()
        {
            string nullValueString = "";
            string extraString = "";
            if (TypeLength != "")
            {
                Type += "(";
                if (TypeLength.Any(char.IsDigit))
                    Type += TypeLength;
                else
                {
                    string[] tmpArray = TypeLength.Split(',');
                    foreach (string str in tmpArray)
                    {
                        Type += "'" + str.Trim() + "', ";
                    }
                    Type = Type.Substring(0, Type.Length - 2);
                }
                Type += ") ";
            }
            string tmp = "";
            if (!NullValue)
                nullValueString = " NOT NULL ";
            if (Extra)
                extraString = "auto_increment";
            if (Default != String.Empty)
            {
                Default = "DEFAULT \"" + Default + "\"";
                tmp = Field + " " + Type + nullValueString + Default + " " + extraString;
            }
            else
                tmp = Field + " " + Type + nullValueString + extraString;
            Console.WriteLine(tmp.TrimEnd());
            return tmp.TrimEnd();
        }

        public static bool operator ==(ColumnStructureCreator firstColumn, ColumnStructureCreator secondColumn)
        {
            if(firstColumn.Field == secondColumn.Field & firstColumn.Type == secondColumn.Type & firstColumn.TypeLength == secondColumn.TypeLength & firstColumn.NullValue == secondColumn.NullValue &
                firstColumn.Primary_Key == secondColumn.Primary_Key & firstColumn.Default == secondColumn.Default & firstColumn.Extra == secondColumn.Extra)
                return true;
            else
                return false;
        }
        public static bool operator !=(ColumnStructureCreator firstColumn, ColumnStructureCreator secondColumn)
        {
            if (firstColumn == secondColumn)
                return false;
            return true;
        }
    }
}
