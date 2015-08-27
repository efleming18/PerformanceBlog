namespace Api.Models
{
    public class QuarterbackModel
    {
        public string Name { get; set; }
        public int PassingYards { get; set; }
        public int Touchdowns { get; set; }
        public int Interceptions { get; set; }
        public int QBR { get; set; }
    }
}