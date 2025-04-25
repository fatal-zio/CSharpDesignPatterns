﻿using Strategy;

Console.Title = "Strategy";

var order = new Order("Marvin Software", 5, "Visual Studio License")
{
    ExportService = new CsvExportService()
};
order.Export();

order.ExportService = new JsonExportService();
order.Export();

order.ExportService = new XmlExportService();
order.Export();

Console.ReadKey();