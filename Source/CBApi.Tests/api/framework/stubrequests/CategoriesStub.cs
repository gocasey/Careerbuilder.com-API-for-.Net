﻿using com.careerbuilder.api;
using com.careerbuilder.api.framework.requests;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Tests.com.careerbuilder.api.models.service;

namespace Tests.com.careerbuilder.api.models.requests {
    internal class CategoriesStub : CategoriesRequest {
        public CategoriesStub(string key, string domain, string cobrand, string siteid)
            : base(new APISettings() { DevKey = key, CobrandCode = cobrand, SiteId = siteid, TargetSite = new TargetSiteMock(domain) }) {
        }

        public string DevKey {
            get { return _Settings.DevKey; }
        }

        public string Domain {
            get { return _Settings.TargetSite.Domain; }
        }

        public string CountryCode {
            get { return _countryCode; }
        }

        public string RequestURL {
            get { return base.GetRequestURL(); }
        }

        public IRestClient Client {
            get { return _client; }
            set { _client = value; }
        }

        public IRestRequest Request {
            get { return _request; }
            set { _request = value; }
        }

        protected override void CheckForErrors(IRestResponse response) {

        }
    }
}