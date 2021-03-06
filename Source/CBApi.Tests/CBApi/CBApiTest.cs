﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using CBApi;
using CBApi.Models;
using CBApi.Models.Service;

namespace Tests.CBApi
{
    [TestClass]
    public class CbApiTest
    {
        [TestMethod]
        public void Constructor_DefaultsToCareerbuilderCom()
        {
            var svc = new CBApiStub();
            Assert.IsInstanceOfType(svc.Site, typeof (CareerBuilderCom));
        }

        [TestMethod]
        public void GetCategories_ReturnsCategoriesRequest()
        {
            var svc = new CbApi();
            Assert.IsInstanceOfType(svc.GetCategories(), typeof (ICategoryRequest));
        }

        [TestMethod]
        public void GetEmployeeTypes_ReturnsEmpRequest()
        {
            var svc = new CbApi();
            Assert.IsInstanceOfType(svc.GetEmployeeTypes(), typeof (IEmployeeTypesRequest));
        }

        //[TestMethod]
        //public void JobSearch_ReturnsJobSearchRequest()
        //{
        //    CBApi svc = new CBApi();
        //    Assert.IsInstanceOfType(svc.GetBlankApplication(), typeof(BlankApplication));
        //}

        [TestMethod]
        public void JobSearch_ReturnsJobSearchRequest()
        {
            var svc = new CbApi();
            Assert.IsInstanceOfType(svc.JobSearch(), typeof (IJobSearch));
        }
    }

    public class CBApiStub : CbApi
    {
        public TargetSite Site
        {
            get { return _Settings.TargetSite; }
        }
    }
}