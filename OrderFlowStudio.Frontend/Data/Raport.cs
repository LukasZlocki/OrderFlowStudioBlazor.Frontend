namespace OrderFlowStudio.Frontend.Data
{
    public class Raport
    {
        public int Id { get; set; }
        public int QuantityFinished { get; set; }
        public bool isStarted { get; set; } 
        public bool isMasked { get; set; } 
        public bool isProcessed { get; set; } 
        public bool isProcessOK { get; set; } 
        public bool isCorrectionStarted { get; set; } 
        public bool isCorrectionFinished { get; set; } 
        public bool isOrderFinished { get; set; } 
    }
}
