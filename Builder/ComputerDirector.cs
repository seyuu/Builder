namespace Builder
{
    // Yönetici (Director) sınıfı
    internal class ComputerDirector
    {
        private IBuilder _builder;

        public ComputerDirector(IBuilder builder)
        {
            _builder = builder;
        }

        public void ConstructHighEndComputer()
        {
            _builder.SetCPU("Intel Core i9");
            _builder.SetRAM("32GB DDR4");
            _builder.SetStorage("1TB SSD");
            _builder.SetGraphicsCard("NVIDIA GeForce RTX 3080");
        }

        public void ConstructLowEndComputer()
        {
            _builder.SetCPU("Intel Core i5");
            _builder.SetRAM("8GB DDR4");
            _builder.SetStorage("500GB HDD");
            _builder.SetGraphicsCard("NVIDIA GeForce GTX 1650");
        }
    }
}
