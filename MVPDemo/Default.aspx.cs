using System;
using System.Web.UI;

public partial class _Default : Page, IManufacturerListView
{
    ManufacturerListPresenter presenter;
    public ManufacturerListVM ViewModel { get; private set; }

    protected void Page_Load(object sender, EventArgs e)
    {
        presenter = new ManufacturerListPresenter(this);

        if (!IsPostBack)
            presenter.Init();
    }

    public void Show(ManufacturerListVM viewModel)
    {
        ViewModel = viewModel;
        sortedHiddenField.Value = viewModel.IsSorted.ToString();

        manufacturersRepeater.DataSource = ViewModel.Manufacturers;
        manufacturersRepeater.DataBind();
    }

    protected void Sort_Click(object sender, EventArgs e)
    {
        presenter.Sort(bool.Parse(sortedHiddenField.Value));
    }
}