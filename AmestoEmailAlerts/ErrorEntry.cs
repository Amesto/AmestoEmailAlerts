namespace AmestoEmailAlerts
{
    public enum Severity { Error, Warning, Information }
    public class ErrorEntry
    {
        public Severity Severity { get; set; }

        public string Message { get; set; }

        public DateTime TimeStamp { get; set; }
    }
}