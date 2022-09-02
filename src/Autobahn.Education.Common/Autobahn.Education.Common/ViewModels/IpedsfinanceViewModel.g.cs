//***************************************************************************
//* DomainName: Common Models
//* FileName:   IpedsfinanceViewModel.g.cs
//***************************************************************************

/// <summary>
/// The IIpedsfinance file
/// </summary>
public partial class IpedsfinanceViewModel : ObservableValidator, IIpedsfinance
{
    #region "IpedsfinanceViewModel Constructor"
    /// </summary>
    /// The service provider instance.
    /// <summary>
    private System.IServiceProvider? serviceProvider;

    /// <summary>
    /// IpedsfinanceViewModel Constructor
    /// </summary>
    public IpedsfinanceViewModel(System.IServiceProvider provider)
    {
        serviceProvider = provider;
        OnIpedsfinanceViewModelConstruction();
    }

    /// <summary>
    /// IpedsfinanceViewModel Constructor partial method
    /// <para>
    /// This method is called by the view model constructor
    /// to allow the inclusion of custom processing in
    /// the view models construction
    /// </para>
    /// </summary>
    partial void OnIpedsfinanceViewModelConstruction();
    #endregion"

    #region "Backing Fields"
    // Every viewmodel has a Title property
    private string viewTitle = "Hello from Ipedsfinance";

    // The isNew property is set if the view model has been created but not saved to the database
    private bool isNew = false;

    /// The isDeleted property is set if the view model is to be deleted from the database
    private bool isDeleted = false;

    /// The view model is changed and needs to be save to the database.
    public bool isChanged = false;

    /// The view model is performing a long running task
    public bool isBusy = false;

    #endregion

    #region "IAutobahnBase Properties"
    /// <summary>
    /// The title of the View Model
    /// </summary>
    public string ViewTitle { get => viewTitle; set => SetProperty(ref viewTitle, value, false); }

    /// <summary>
    /// The IsNew property is set if the view model has been created but not saved to the database
    /// </summary>
    public bool IsNew { get => isNew; set => SetProperty(ref isNew, value, false); }

    /// <summary>
    /// The IsDeleted property is set if the view model is to be delted from the database
    /// </summary>
    public bool IsDeleted { get => isDeleted; set => SetProperty(ref isDeleted, value, false); }

    /// <summary>
    /// The primary key of the view model
    /// </summary>
    public Guid Id { get; set; }

    /// <summary>
    /// The view model is changed and needs to be save to the database.
    /// </summary>
    public bool IsChanged { get => isChanged; private set => SetProperty(ref isChanged, value, false); }

    /// <summary>
    /// The view model is performing a long running task
    /// </summary>
    public bool IsBusy { get => isBusy; private set => SetProperty(ref isBusy, value, false); }

    /// <summary>
    /// The view model's changes have been save so update its tracking properties
    /// </summary>
    public void AcceptChanges()
    {
        IsNew = false;
        IsChanged = false;
    }
    #endregion

    #region "IIpedsfinance Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganizationFinancial"/> model
    /// </summary>
    public Guid OrganizationFinancialId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefIpedsfasbfinancialPosition"/> model
    /// </summary>
    public Guid? RefIpedsfasbfinancialPositionId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefIpedsfasbfunctionalExpense"/> model
    /// </summary>
    public Guid? RefIpedsfasbfunctionalExpenseId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefIpedsfasbpellGrantTransactions"/> model
    /// </summary>
    public Guid? RefIpedsfasbpellGrantTransactionsId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefIpedsfasbrevenue"/> model
    /// </summary>
    public Guid? RefIpedsfasbrevenueId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefIpedsfasbrevenueRestriction"/> model
    /// </summary>
    public Guid? RefIpedsfasbrevenueRestrictionId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefIpedsfasbscholarshipsandFellowshipsRevenue"/> model
    /// </summary>
    public Guid? RefIpedsfasbscholarshipsandFellowshipsRevenueId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefIpedsgasbfinancialPosition"/> model
    /// </summary>
    public Guid? RefIpedsgasbfinancialPositionId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefIpedsgasbfunctionalExpense"/> model
    /// </summary>
    public Guid? RefIpedsgasbfunctionalExpenseId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefIpedsgasbrevenue"/> model
    /// </summary>
    public Guid? RefIpedsgasbrevenueId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefIpedsgasbscholarshipsandFellowshipsRevenue"/> model
    /// </summary>
    public Guid? RefIpedsgasbscholarshipsandFellowshipsRevenueId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefIpedsintercollegiateAthleticsExpenses"/> model
    /// </summary>
    public Guid? RefIpedsintercollegiateAthleticsExpensesId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefIpedsnaturalExpense"/> model
    /// </summary>
    public Guid? RefIpedsnaturalExpenseId { get; set; }

    #endregion

    /// <summary>
    /// Load the viewmodel from a model
    /// </summary>
    public void Load(IIpedsfinance model)
    {
        IsBusy = true;
        Id = model.Id;
        OrganizationFinancialId = model.OrganizationFinancialId; // 
        RefIpedsfasbfinancialPositionId = model.RefIpedsfasbfinancialPositionId; // 
        RefIpedsfasbfunctionalExpenseId = model.RefIpedsfasbfunctionalExpenseId; // 
        RefIpedsfasbpellGrantTransactionsId = model.RefIpedsfasbpellGrantTransactionsId; // 
        RefIpedsfasbrevenueId = model.RefIpedsfasbrevenueId; // 
        RefIpedsfasbrevenueRestrictionId = model.RefIpedsfasbrevenueRestrictionId; // 
        RefIpedsfasbscholarshipsandFellowshipsRevenueId = model.RefIpedsfasbscholarshipsandFellowshipsRevenueId; // 
        RefIpedsgasbfinancialPositionId = model.RefIpedsgasbfinancialPositionId; // 
        RefIpedsgasbfunctionalExpenseId = model.RefIpedsgasbfunctionalExpenseId; // 
        RefIpedsgasbrevenueId = model.RefIpedsgasbrevenueId; // 
        RefIpedsgasbscholarshipsandFellowshipsRevenueId = model.RefIpedsgasbscholarshipsandFellowshipsRevenueId; // 
        RefIpedsintercollegiateAthleticsExpensesId = model.RefIpedsintercollegiateAthleticsExpensesId; // 
        RefIpedsnaturalExpenseId = model.RefIpedsnaturalExpenseId; // 
        IsChanged = false;
        IsNew = false;
        IsBusy = false;
    }
}
