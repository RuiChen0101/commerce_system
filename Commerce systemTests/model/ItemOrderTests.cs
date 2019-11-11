using Microsoft.VisualStudio.TestTools.UnitTesting;
using Commerce_system;
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commerce_system.Tests
{
    [TestClass()]
    public class ItemOrderTests
    {
        const string FILE_PATH = ".//testItem.ini";
        const string TEST_FILE_PATH = ".//test.ini";
        private TypeInfo _typeInfo;
        private ItemInfo _itemInfo;
        private ItemOrder _itemOrder;
        private PrivateObject _testTarget;

        //init
        [TestInitialize]
        [DeploymentItem("Commerce system.exe")]
        public void Initialize()
        {
            File.Copy(FILE_PATH, TEST_FILE_PATH, true);
            _typeInfo = new TypeInfo();
            _itemInfo = new ItemInfo(_typeInfo, TEST_FILE_PATH);
            _itemOrder = new ItemOrder(_itemInfo);
            _testTarget = new PrivateObject(_itemOrder);
            _itemInfo._stockChangeEvent += this.EventTriggerTest;
            _itemInfo._itemDataUpdateEvent += this.EventTriggerTest;
        }

        //ut
        [TestMethod()]
        public void ItemOrderTest()
        {
            Assert.IsNotNull(_testTarget.GetFieldOrProperty("_itemInfo"));
            Assert.AreEqual(0, _testTarget.GetFieldOrProperty("_totalPrice"));
        }

        //ut
        [TestMethod()]
        public void AddToOrderTest()
        {
            int totalPrice = 0;
            totalPrice += _itemInfo.GetItemPrice("item0");
            _itemOrder.AddToOrder("item0");
            Assert.AreEqual(totalPrice, _itemOrder.GetTotalPrice());

            _itemOrder.AddToOrder("noExsitItem");
            Assert.AreEqual(totalPrice, _itemOrder.GetTotalPrice());
        }

        //ut
        [TestMethod()]
        public void DeleteFromOrderTest()
        {
            int totalPrice = 0;
            totalPrice += _itemInfo.GetItemPrice("item0");
            _itemOrder.AddToOrder("item0");
            Assert.AreEqual(totalPrice, _itemOrder.GetTotalPrice());

            _itemOrder.DeleteFromOrder(-1);
            Assert.AreEqual(totalPrice, _itemOrder.GetTotalPrice());

            _itemOrder.DeleteFromOrder(1);
            Assert.AreEqual(totalPrice, _itemOrder.GetTotalPrice());


            totalPrice -= _itemInfo.GetItemPrice("item0");
            _itemOrder.DeleteFromOrder(0);
            Assert.AreEqual(totalPrice, _itemOrder.GetTotalPrice());
        }

        //ut
        [TestMethod()]
        public void UpdateQuantityTest()
        {
            int totalPrice = 0;
            totalPrice += _itemInfo.GetItemPrice("item0");
            _itemOrder.AddToOrder("item0");
            Assert.AreEqual(totalPrice, _itemOrder.GetTotalPrice());

            Assert.AreEqual(10, _itemOrder.UpdateQuantity(0, 10));
            Assert.AreEqual(totalPrice * 10, _itemOrder.GetTotalPrice());

            Assert.AreEqual(10, _itemOrder.UpdateQuantity(0, 20));
            Assert.AreEqual(totalPrice * 10, _itemOrder.GetTotalPrice());

            Assert.AreEqual(1, _itemOrder.UpdateQuantity(0, 1));
            Assert.AreEqual(totalPrice, _itemOrder.GetTotalPrice());

            Assert.AreEqual(0, _itemOrder.UpdateQuantity(-1, 10));
            Assert.AreEqual(totalPrice, _itemOrder.GetTotalPrice());

            Assert.AreEqual(0, _itemOrder.UpdateQuantity(1, 10));
            Assert.AreEqual(totalPrice, _itemOrder.GetTotalPrice());
        }

        //ut
        [TestMethod()]
        public void GetItemTotalPriceTest()
        {
            _itemOrder.AddToOrder("item0");
            _itemOrder.UpdateQuantity(0, 5);
            Assert.AreEqual(_itemInfo.GetItemPrice("item0") * 5, _itemOrder.GetItemTotalPrice(0));

            Assert.AreEqual(0, _itemOrder.GetItemTotalPrice(-1));

            Assert.AreEqual(0, _itemOrder.GetItemTotalPrice(1));
        }

        //ut
        [TestMethod()]
        public void GetItemTotalPriceByIdTest()
        {
            string id = "item0";
            _itemOrder.AddToOrder(id);
            _itemOrder.UpdateQuantity(0, 5);
            Assert.AreEqual(_itemInfo.GetItemPrice(id) * 5, _itemOrder.GetItemTotalPriceById(id));

            Assert.AreEqual(0, _itemOrder.GetItemTotalPriceById("notExitId"));
        }

        //ut
        [TestMethod()]
        public void GetItemQuantityTest()
        {
            string id = "item0";
            _itemOrder.AddToOrder(id);
            _itemOrder.UpdateQuantity(0, 5);
            Assert.AreEqual(5, _itemOrder.GetItemQuantity(id));

            Assert.AreEqual(0, _itemOrder.GetItemQuantity("notExitId"));
        }

        //ut
        [TestMethod()]
        public void IsInOrderTest()
        {
            string id = "item0";
            _itemOrder.AddToOrder(id);

            Assert.IsTrue(_itemOrder.IsInOrder(id));

            Assert.IsFalse(_itemOrder.IsInOrder("notExitId"));

            Assert.IsFalse(_itemOrder.IsInOrder(null));
        }

        //ut
        [TestMethod()]
        public void IsCheckOutEnableTest()
        {
            Assert.IsFalse(_itemOrder.IsCheckOutEnable());

            _itemOrder.AddToOrder("item0");
            Assert.IsTrue(_itemOrder.IsCheckOutEnable());
        }

        //ut
        [TestMethod()]
        public void ProceedCheckOutTest()
        {
            string id = "item0";
            int initStock = _itemInfo.GetItemStock(id);
            _itemOrder.AddToOrder(id);
            _itemOrder.UpdateQuantity(0, 5);
            _itemOrder.ProceedCheckOut();

            Assert.AreEqual(0, _itemOrder.GetTotalPrice());
            Assert.AreEqual(initStock - 5, _itemInfo.GetItemStock(id));
        }

        //ut
        [TestMethod()]
        public void GetTotalPriceTest()
        {
            _itemOrder.AddToOrder("item0");

            Assert.AreEqual(_itemInfo.GetItemPrice("item0"), _itemOrder.GetTotalPrice());
        }

        //ut
        [TestMethod()]
        public void GetOrderIdListTest()
        {
            string[] idList = { "item0", "item1" };
            _itemOrder.AddToOrder(idList[0]);
            _itemOrder.AddToOrder(idList[1]);
            Assert.AreEqual(2, _itemOrder.GetOrderIdList().Count);

            foreach(string id in idList)
            {
                Assert.IsTrue(_itemOrder.GetOrderIdList().Contains(id));
            }
        }

        //ut
        [TestMethod()]
        public void HandleItemUpdateEventTest()
        {
            string id = "item0";
            string[] data = { "testName", "cat99", "testInage.jpg", "desp", "999" };
            _itemOrder.AddToOrder(id);
            _itemOrder.UpdateQuantity(0, 5);
            _itemInfo.UpdateItem(id, data);
            _itemOrder.HandleItemUpdateEvent();
            Assert.AreEqual(999 * 5, _itemOrder.GetTotalPrice());
        }

        //event
        public void EventTriggerTest()
        {
            Assert.IsTrue(true);
        }
    }
}