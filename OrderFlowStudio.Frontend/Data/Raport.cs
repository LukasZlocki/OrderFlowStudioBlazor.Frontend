namespace OrderFlowStudio.Frontend.Data
{
    public class Raport
    {
        public int Id { get; set; }
        public int QuantityFinished { get; set; }
        public int OrderId { get; set; }
        public ProductionStatus statusDto { get; set; }
    }
}
