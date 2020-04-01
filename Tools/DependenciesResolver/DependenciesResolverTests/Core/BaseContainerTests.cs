using DependenciesResolver.Core;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DependenciesResolverTests.Core
{
    public class TestA { }

    public class TestB : TestA { }

    public class TestB1 : TestA 
    {
    
        public string Value { get; set; }

        public TestB1(string value)
        {
            Value = value;
        }
    }

    public class TestC { }

    [TestFixture]
    public class BaseContainerTests
    {
        private BaseContainer _container;

        [SetUp]
        public void SetUp()
        {
            _container = new BaseContainer();
        }

        [Test]
        public void Register_RegistersFine_WhenRegisterEntityWithOutConstructorParameters()
        {
            //action 
            _container.Register<TestA, TestB>();

        }

        [Test]
        public void Get_ReturnsExpectedInstance_WhenRegisterEntityWithOutConstructorParameters()
        {
            //action
            _container.Register<TestA, TestB>();
            var instance = _container.Get<TestA>();

            //assert
            Assert.IsInstanceOf<TestB>(instance);
        }

        [Test]
        public void Get_ReturnsExpectedInstance_WhenRegisterEntityWithConstructorParameters()
        {
            //arrange
            var testString = "TEST";

            //action
            _container.Register<TestA, TestB1>(() => new TestB1("TEST"));
            var instance = _container.Get<TestA>();

            //assert
            Assert.IsInstanceOf<TestB1>(instance);
            Assert.AreEqual(testString, ((TestB1)instance).Value);
        }

        [Test]
        public void Get_ReturnsLastRegisteredInstance_WhenRegisterSeveralEntities()
        {
            //arrange
            var testString = "TEST";

            //action
            _container.Register<TestA, TestB>();
            _container.Register<TestA, TestB1>(() => new TestB1("TEST"));
            var instance = _container.Get<TestA>();

            //assert
            Assert.IsInstanceOf<TestB1>(instance);
            Assert.AreEqual(testString, ((TestB1)instance).Value);
        }

        [Test]
        public void GetAllRegistered_ReturnsExpectedCollection_WhenRegisterSeveralEntities()
        {
            //arrange
            var testString = "TEST";
            var expectedCount = 2;

            //action
            _container.Register<TestA, TestB>();
            _container.Register<TestA, TestB1>(() => new TestB1("TEST"));
            var instancesCollection = _container.GetAllRegistered<TestA>().ToList();

            //assert
            Assert.AreEqual(expectedCount, instancesCollection.Count);
            Assert.IsInstanceOf<TestB>(instancesCollection[0]);
            Assert.IsInstanceOf<TestB1>(instancesCollection[1]);
            Assert.AreEqual(testString, ((TestB1)instancesCollection[1]).Value);
        }

    }
}
