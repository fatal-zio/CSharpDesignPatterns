namespace Strategy
{
    /// <summary>
    /// Strategy
    /// </summary>
    public interface IExportService
    {
        void Export(Order order);
    }

    /// <summary>
    /// Concrete Strategy
    /// </summary>
    public class JsonExportService : IExportService
    {
        public void Export(Order order)
        {
            Console.WriteLine($"Exporting order {order.Name} to JSON format.");
        }
    }

    /// <summary>
    /// Concrete Strategy
    /// </summary>
    public class XmlExportService : IExportService
    {
        public void Export(Order order)
        {
            Console.WriteLine($"Exporting order {order.Name} to XML format.");
        }
    }

    /// <summary>
    /// Concrete Strategy
    /// </summary>
    public class CsvExportService : IExportService
    {
        public void Export(Order order)
        {
            Console.WriteLine($"Exporting order {order.Name} to CSV format.");
        }
    }

    public class Order(string customer, int amount, string name)
    {
        public string Customer { get; set; } = customer;
        public int Amount { get; set; } = amount;
        public string Name { get; set; } = name;
        public string? Description { get; set; }

        public IExportService? ExportService { get; set; } = new CsvExportService();

        public void Export()
        {
            ExportService?.Export(this);
        }
    }
}
