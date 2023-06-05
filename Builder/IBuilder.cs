namespace Builder
{
    // Builder arayüzü
    internal interface IBuilder
    {
        void SetCPU(string cpu);
        void SetRAM(string ram);
        void SetStorage(string storage);
        void SetGraphicsCard(string graphicsCard);
        Computer GetComputer();
    }
}
