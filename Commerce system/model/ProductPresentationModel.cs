using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commerce_system
{
    public class ProductPresentationModel
    {
        private ItemInfo _itemInfo;
        private TypeInfo _typeInfo;

        public ProductPresentationModel(ItemInfo itemInfo, TypeInfo typeInfo)
        {
            this._itemInfo = itemInfo;
            this._typeInfo = typeInfo;
        }

        //is number only input
        public bool IsNumberInput(char input)
        {
            return Char.IsDigit(input) || Char.IsControl(input);
        }
    }
}
