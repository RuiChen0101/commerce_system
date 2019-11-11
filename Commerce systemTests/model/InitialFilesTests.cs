using Microsoft.VisualStudio.TestTools.UnitTesting;
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
    public class InitialFilesTests
    {
        const string FILE_PATH = ".//testItem.ini";
        const string TEST_FILE_PATH = ".//test.ini";
        private PrivateObject _testTarget;
        private InitialFiles _files;
        //init
        [TestInitialize]
        [DeploymentItem("Commerce system.exe")]
        public void Initialize()
        {
            File.Copy(FILE_PATH, TEST_FILE_PATH,true);
            _files = new InitialFiles(TEST_FILE_PATH);
            _testTarget = new PrivateObject(_files);
        }

        //ut
        [TestMethod()]
        public void InitialFilesTest()
        {
            Assert.AreEqual(TEST_FILE_PATH, _testTarget.GetFieldOrProperty("_filePath"));
        }

        //ut
        [TestMethod()]
        public void ReadInitialTest()
        {
            string name = _files.ReadInitial("item0","name");
            Assert.AreEqual("ASUS PRIME H370M-PLUS/CSM", name);

            string result = _files.ReadInitial("item0", "no esist field","defaultValue");
            Assert.AreEqual("defaultValue", result);
        }

        //ut
        [TestMethod()]
        public void WriteInitialTest()
        {
            string section = "testSection";
            string name = "testItem";
            string type = "cat9";
            _files.WriteInitial(section, "name", name);
            _files.WriteInitial(section, "type", type);
            Assert.AreEqual(name, _files.ReadInitial(section, "name"));
            Assert.AreEqual(type, _files.ReadInitial(section, "type"));
        }

        //ut
        [TestMethod()]
        public void GetSectionNamesTest()
        {
            string[] sections = { "item0", "item1", "item2", "item3", "item4", "item5" };
            foreach(string section in _files.GetSectionNames())
            {
                Assert.IsTrue(sections.Contains(section));
            }

            _files = new InitialFiles(".//notExit.ini");
            Assert.AreEqual(null, _files.GetSectionNames());
        }
    }
}