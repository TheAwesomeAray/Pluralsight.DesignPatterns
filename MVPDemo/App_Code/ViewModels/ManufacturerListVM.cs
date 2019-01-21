using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for ManufacturerListVM
/// </summary>
public class ManufacturerListVM
{
    public string Title { get; set; } = "Manufacturers";
    public bool IsSorted { get; set; }
    
    public IEnumerable<ManufacturerVM> Manufacturers { get; set; }
}