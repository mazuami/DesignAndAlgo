using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ObservableDesignPattern_2;

namespace TestProject2
{
    [TestClass]
    public class ComputerBuilderTest
    {
        [TestMethod]
        public void IsSuperComputer()
        {
            var N412 = new Computer()
            {
                cores = 64,
                frequency = 50,
                ram = 4,
                dataType = "Super Computation"
            };

            var superComputer = new SuperComputerBuilder();
            var ComputerStore = new ComputerStore();
            var SC = ComputerStore.buildComputer(superComputer);

            Assert.AreEqual(N412.cores, SC.cores);
            Assert.AreEqual(N412.frequency, SC.frequency);
            Assert.AreEqual(N412.ram, SC.ram);
            Assert.AreEqual(N412.dataType, SC.dataType);
        }
    }
}
