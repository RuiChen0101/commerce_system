using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commerce_system
{
    class CategoryInfo
    {
        private const string INITILA_FILE_PATH = ".//category.ini";

        private List<string> _categoryList = new List<string>();

        private InitialFiles _initial;

        public CategoryInfo()
        {
            this._initial = new InitialFiles(INITILA_FILE_PATH);
        }
    }
}
