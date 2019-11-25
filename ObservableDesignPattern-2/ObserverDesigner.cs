using System;

namespace ObservableDesignPattern_2
{

    public class Computer
    {
        public int cores { get; set; }
        public int frequency { get; set; }
        public int ram { get; set; }
        public string dataType { get; set; }
    }



    public abstract class ComputerBuilder
    {
        protected readonly Computer _computer = new Computer();

        public abstract void setCores();
        public abstract void setFrequency();
        public abstract void setRam();
        public abstract void setDataType();

        public virtual Computer getObject()
        {
            return _computer;
        }
        
    }


    public class SuperComputerBuilder : ComputerBuilder
    {
        public override void setCores()
        {
            _computer.cores = 64;

        }
        public override void setFrequency()
        {
            _computer.frequency = 50;
        }

        public override void setRam()
        {
            _computer.ram = 4;
        }

        public override void setDataType()
        {
            _computer.dataType = "Super Computation";
        }

    }


    public class NormalComputerBuilder : ComputerBuilder
    {
        public override void setCores()
        {
            _computer.cores = 1;

        }
        public override void setFrequency()
        {
            _computer.frequency = 10;
        }

        public override void setRam()
        {
            _computer.ram = 1;
        }

        public override void setDataType()
        {
            _computer.dataType = "Normal Computation";
        }
    }



    public class ComputerStore
    {
        public Computer buildComputer(ComputerBuilder cb)
        {
            cb.setCores();
            cb.setFrequency();
            cb.setRam();
            cb.setDataType();

            return
            cb.getObject();
        }
    }
    
}
