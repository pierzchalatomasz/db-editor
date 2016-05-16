using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_Editor.DB_Handlers
{
    static class Column
    {
        #region Methods
        public static void RenameField(string field) 
        {
            
        }
        public static void AlterType(string type) 
        { 
            
        }
        public static void AddPrimaryKey()
        {
            
        }
        public static void AddForeignKey(string field, string referenceField, string referenceTable)//tutaj pewnie bedzie cos innego
        {

        }
        public static void DropKey()
        {
            
        }
        public static void AlterDefault(string def) 
        {
            
        }
        public static void AlterCanBeNull(bool canBeNull) 
        {
            
        }
        public static void AlterExtra(bool isAutoIncrement) //chyba, ze moze miec jeszcze jakies inne wartosci
        {
            
        }
        #endregion
    }
}
