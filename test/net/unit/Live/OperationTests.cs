﻿//-----------------------------------------------------------------------
// <copyright file="OperationTests.cs" company="Microsoft">Copyright 2012 Microsoft Corporation</copyright>
// <license>
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
// http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// </license>

using System;
using System.Net;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.WindowsAzure.MediaServices.Client.Tests.Common;
using Moq;

namespace Microsoft.WindowsAzure.MediaServices.Client.Tests.Unit.Live
{
    
    
    /// <summary>
    ///This is a test class for OperationBaseCollectionTest and is intended
    ///to contain all OperationBaseCollectionTest Unit Tests
    ///</summary>
    [TestClass()]
    public class OperationTests
    {
        private CloudMediaContext _mediaContext;
        [TestInitialize]
        public void SetupTest()
        {
            _mediaContext = Helper.GetMediaDataServiceContextForUnitTests();
        }

        /// <summary>
        ///A test for GetOperation
        ///</summary>
        [TestMethod()]
        [TestCategory("ClientSDK")]
        [Owner("ClientSDK")]
        public void GetOperationTest()
        {
            var data = new OperationData { Id = "1", State = OperationState.Succeeded.ToString() };

            var dataContextMock = new Mock<IMediaDataServiceContext>();

            var fakeException = new WebException("test", WebExceptionStatus.ConnectionClosed);

            var fakeResponse = new OperationData[] { data };
            int exceptionCount = 2;

            dataContextMock.Setup((ctxt) => ctxt
                .Execute<OperationData>(It.IsAny<Uri>()))
                .Returns(() =>
                {
                    if (--exceptionCount > 0) throw fakeException;
                    return fakeResponse;
                });

            _mediaContext.MediaServicesClassFactory = new TestMediaServicesClassFactory(dataContextMock.Object);
            var actual = _mediaContext.Operations.GetOperation(data.Id);
            Assert.AreEqual(data.Id, actual.Id);

            dataContextMock.Verify((ctxt) => ctxt.Execute<OperationData>(It.IsAny<Uri>()), Times.Exactly(2));
        }
    }
}
