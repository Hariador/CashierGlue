using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CashierGlue;
using Newtonsoft.Json;
using System.Diagnostics.Tracing;


namespace CashierGlueTests
{
    /// <summary>
    /// Summary description for ActionTests
    /// </summary>
    [TestClass]
    public class ActionTests
    {
        public ActionTests()
        {
            //
            // TODO: Add constructor logic here
            //
        }

 

        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestMethod]
        public void addNoteActionTests()
        {
            AddNote addNoteAction = new AddNote("This is an order Note");
            Assert.AreEqual("ADD_NOTE", addNoteAction.Type);
            Assert.AreEqual("This is an order Note", addNoteAction.Note);
            Assert.AreEqual("{\"Note\":\"This is an order Note\",\"Type\":\"ADD_NOTE\"}", JsonConvert.SerializeObject(addNoteAction));
            
        }

        [TestMethod]
        public void AddFeeActionTests()
        {
            Currency currency = new Currency("USD",true, 10000,2);
            
            AddFee addFeeAction = new AddFee("123","Test Fee", currency,true );
            Assert.AreEqual("ADD_FEE", addFeeAction.Type);
            Assert.AreEqual( "{\"id\":\"123\",\"line_text\":\"Test Fee\",\"value\":\"100.00\",\"taxable\":true}",JsonConvert.SerializeObject(addFeeAction));
  
        
        }
    }
}
