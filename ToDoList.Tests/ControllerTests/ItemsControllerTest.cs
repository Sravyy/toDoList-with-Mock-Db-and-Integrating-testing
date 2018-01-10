using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ToDoList.Controllers;
using ToDoList.Models;



namespace ToDoList.Tests
{
    [TestClass]
    public class ItemsControllerTest
    {
        [TestMethod]
        public void ItemsController_AddsItemToIndexModelData_Collection()
        {
            // Arrange
            ItemsController controller = new ItemsController();
            Item testItem = new Item();
            testItem.Description = "test item";
            testItem.CategoryId = 1;

            // Act
            controller.Create(testItem);
            ViewResult indexView = new ItemsController().Index() as ViewResult;
            var collection = indexView.ViewData.Model as List<Item>;

           
            // Assert
            CollectionAssert.Contains(collection, testItem);
        }
    }
}