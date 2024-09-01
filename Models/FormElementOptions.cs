namespace ElemPut.Models
{
    public class FormElementOptions
    {
        public string Label { get; set; }
        public string Title { get; set; }
        public string Placeholder { get; set; }
        public string Pattern { get; set; }
        public string Style { get; set; }
        public string Class { get; set; }
        public bool Disabled { get; set; }
        public List<string> Data { get; set; }
        public int Rows { get; set; }
    }
}