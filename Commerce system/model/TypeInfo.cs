using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commerce_system
{
    public class TypeInfo
    {
        private const string INITIAL_FILE_PATH = ".//type.ini";

        private const string NAME_KEY = "name";

        private List<string> _typeList = new List<string>();
        private List<string> _typeNameList = new List<string>();

        private InitialFiles _initial;

        public TypeInfo()
        {
            this._initial = new InitialFiles(INITIAL_FILE_PATH);
            this.InitialAllCategoryIdList();
        }

        //get total type list
        public List<string> GetTypeList()
        {
            return this._typeList;
        }

        //get total type list
        public List<string> GetTypeNameList()
        {
            return this._typeNameList;
        }

        // get type name by type id
        public string GetTypeIdByName(string name)
        {
            int typeIndex = _typeNameList.FindIndex(x => x == name);
            return _typeList[typeIndex];
        }

        // get type name by type id
        public string GetTypeName(string type)
        {
            int typeIndex = _typeList.FindIndex(x => x == type);
            return _typeNameList[typeIndex];
        }

        //initial all category list
        private void InitialAllCategoryIdList()
        {
            this._typeList.Clear();
            this._typeNameList.Clear();
            string[] allSections = _initial.GetSectionNames();
            foreach (String section in allSections)
            {
                this._typeList.Add(section);
                this._typeNameList.Add(this._initial.ReadInitial(section, NAME_KEY));
            }
        }
    }
}
