namespace Builder
{
    // Gerçek inşaatçı (Concrete Builder) sınıfı
    internal class ComputerBuilder : IBuilder
    {
        private Computer _computer;

        public ComputerBuilder()
        {
            _computer = new Computer();
        }

        public void SetCPU(string cpu)
        {
            _computer.CPU = cpu;
        }

        public void SetRAM(string ram)
        {
            _computer.RAM = ram;
        }

        public void SetStorage(string storage)
        {
            _computer.Storage = storage;
        }

        public void SetGraphicsCard(string graphicsCard)
        {
            _computer.GraphicsCard = graphicsCard;
        }

        public Computer GetComputer()
        {
            return _computer;
        }
    }
}
