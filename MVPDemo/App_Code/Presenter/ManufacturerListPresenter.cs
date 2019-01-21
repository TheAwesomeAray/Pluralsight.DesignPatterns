using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

public class ManufacturerListPresenter
{
    readonly IManufacturerListView _listView;

    public ManufacturerListPresenter(IManufacturerListView listView)
    {
        _listView = listView;
    }

    public void Init()
    {
        var viewModel = GetViewModel();
        _listView.Show(viewModel);
    }

    public void Sort(bool isSorted)
    {
        var vm = GetViewModel();

        if (!isSorted)
            vm.Manufacturers = vm.Manufacturers.OrderBy(x => x.Name);

        vm.IsSorted = !isSorted;

        _listView.Show(vm);
    }

    private ManufacturerListVM GetViewModel()
    {
        return new ManufacturerListVM()
        {
            Manufacturers = new List<ManufacturerVM>()
            {
                new ManufacturerVM() { Name = "Toyota" },
                new ManufacturerVM() { Name = "Nissan" },
                new ManufacturerVM() { Name = "BMW" },
                new ManufacturerVM() { Name = "Honda" },
                new ManufacturerVM() { Name = "Mercedes" }

            }

        };
    }
}