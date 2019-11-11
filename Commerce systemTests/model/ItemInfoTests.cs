﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using Commerce_system;
using System.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commerce_system.Tests
{
    [TestClass()]
    public class ItemInfoTests
    {
        const string FILE_PATH = ".//testItem.ini";
        const string TEST_FILE_PATH = ".//test.ini";
        private TypeInfo _typeInfo;
        private ItemInfo _itemInfo;
        private PrivateObject _testTarget;

        //init
        [TestInitialize]
        [DeploymentItem("Commerce system.exe")]
        public void Initialize()
        {
            File.Copy(FILE_PATH, TEST_FILE_PATH, true);
            _typeInfo = new TypeInfo();
            _itemInfo = new ItemInfo(_typeInfo, TEST_FILE_PATH);
            _testTarget = new PrivateObject(_itemInfo);
        }

        //ut
        [TestMethod()]
        public void ItemInfoTest()
        {
            Assert.IsNotNull(_testTarget.GetFieldOrProperty("_itemList"));
            Assert.IsNotNull(_testTarget.GetFieldOrProperty("_totalItemList"));
        }

        //ut
        [TestMethod()]
        public void GetItemNameTest()
        {
            string result = _itemInfo.GetItemName("item0");
            Assert.AreEqual("ASUS PRIME H370M-PLUS/CSM", result);

            result = _itemInfo.GetItemName("notExist");
            Assert.AreEqual("null", result);

            result = _itemInfo.GetItemName(null);
            Assert.AreEqual("", result);
        }

        //ut
        [TestMethod()]
        public void GetItemTypeTest()
        {
            string result = _itemInfo.GetItemType("item0");
            Assert.AreEqual("cat00", result);

            result = _itemInfo.GetItemType("notExist");
            Assert.AreEqual("null", result);

            result = _itemInfo.GetItemType(null);
            Assert.AreEqual("", result);
        }

        //ut
        [TestMethod()]
        public void GetItemImageReferenceTest()
        {
            string result = _itemInfo.GetItemImageReference("item0");
            Assert.AreEqual("ASUS PRIME H370M-PLUS.jpg", result);

            result = _itemInfo.GetItemImageReference("notExist");
            Assert.AreEqual("null", result);

            result = _itemInfo.GetItemImageReference(null);
            Assert.AreEqual("", result);
        }

        //ut
        [TestMethod()]
        public void GetItemDescriptionTest()
        {
            string result = _itemInfo.GetItemDescription("item0");
            Assert.AreEqual("M-ATX/1A1D1H", result);

            result = _itemInfo.GetItemDescription("notExist");
            Assert.AreEqual("null", result);

            result = _itemInfo.GetItemDescription(null);
            Assert.AreEqual("", result);
        }

        //ut
        [TestMethod()]
        public void GetItemPriceTest()
        {
            int result = _itemInfo.GetItemPrice("item0");
            Assert.AreEqual(3890, result);

            result = _itemInfo.GetItemPrice("notExist");
            Assert.AreEqual(-1, result);

            result = _itemInfo.GetItemPrice(null);
            Assert.AreEqual(-1, result);
        }

        //ut
        [TestMethod()]
        public void GetItemStockTest()
        {
            int result = _itemInfo.GetItemStock("item0");
            Assert.AreEqual(10, result);

            result = _itemInfo.GetItemStock("notExist");
            Assert.AreEqual(-1, result);

            result = _itemInfo.GetItemStock(null);
            Assert.AreEqual(-1, result);
        }

        //ut
        [TestMethod()]
        public void GetItemTypeNameTest()
        {
            string result = _itemInfo.GetItemTypeName("item1");
            Assert.AreEqual("CPU", result);

            result = _itemInfo.GetItemTypeName("notExist");
            Assert.AreEqual("null", result);

            result = _itemInfo.GetItemTypeName(null);
            Assert.AreEqual("", result);
        }

        //ut
        [TestMethod()]
        public void WriteBackStockQuantityTest()
        {
            int quantity = _itemInfo.GetItemStock("item0");
            int delta1 = 5;
            int delta2 = -3;
            _itemInfo.WriteBackStockQuantity("item0", delta1);
            quantity += delta1;
            Assert.AreEqual(quantity, _itemInfo.GetItemStock("item0"));

            _itemInfo.WriteBackStockQuantity("item0", delta2);
            quantity += delta2;
            Assert.AreEqual(quantity, _itemInfo.GetItemStock("item0"));
        }

        //ut
        [TestMethod()]
        public void UpdateItemTest()
        {
            Assert.Fail();
        }

        //ut
        [TestMethod()]
        public void CreateItemTest()
        {
            Assert.Fail();
        }

        //ut
        [TestMethod()]
        public void GetItemIdListByTypeTest()
        {
            Assert.Fail();
        }

        //ut
        [TestMethod()]
        public void GetTotalIdListTest()
        {
            Assert.Fail();
        }
    }
}