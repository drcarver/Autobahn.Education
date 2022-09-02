//***************************************************************************
//* DomainName: Common Models
//* FileName:   FinancialAccountProgramViewModel.g.cs
//***************************************************************************

/// <summary>
/// The IFinancialAccountProgram file
/// </summary>
public partial class FinancialAccountProgramViewModel : ObservableValidator, IFinancialAccountProgram
{
    #region "FinancialAccountProgramViewModel Constructor"
    /// </summary>
    /// The service provider instance.
    /// <summary>
    private System.IServiceProvider? serviceProvider;

    /// <summary>
    /// FinancialAccountProgramViewModel Constructor
    /// </summary>
    public FinancialAccountProgramViewModel(System.IServiceProvider provider)
    {
        serviceProvider = provider;
        OnFinancialAccountProgramViewModelConstruction();
    }

    /// <summary>
    /// FinancialAccountProgramViewModel Constructor partial method
    /// <para>
    /// This method is called by the view model constructor
    /// to allow the inclusion of custom processing in
    /// the view models construction
    /// </para>
    /// </summary>
    partial void OnFinancialAccountProgramViewModelConstruction();
    #endregion"

    #region "Backing Fields"
    // Every viewmodel has a Title property
    private string viewTitle = "Hello from FinancialAccountProgram";

    // The isNew property is set if the view model has been created but not saved to the database
    private bool isNew = false;

    /// The isDeleted property is set if the view model is to be deleted from the database
    private bool isDeleted = false;

    /// The view model is changed and needs to be save to the database.
    public bool isChanged = false;

    /// The view model is performing a long running task
    public bool isBusy = false;

    // Name -- (backing property for Financial Account Program Name)
    private System.String name;

    // ProgramNumber -- (backing property for Financial Account Program Number)
    private System.String programNumber;

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

    #region "IFinancialAccountProgram Properties"
    /// <summary>
    /// Financial Account Program Name
    /// <para>
    /// The name given to the program area in an educational institution's accounting system.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20626">Financial Account Program Name</a>
    /// </para>
    /// </summary>
    [DisplayName("Financial Account Program Name")]
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(100,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String Name { get => name; set => SetProperty(ref name, value, true); }

    /// <summary>
    /// Financial Account Program Number
    /// <para>
    /// A number given to a program area within an educational institution's accounting system.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20627">Financial Account Program Number</a>
    /// </para>
    /// </summary>
    [DisplayName("Financial Account Program Number")]
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(30,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String ProgramNumber { get => programNumber; set => SetProperty(ref programNumber, value, true); }

    #endregion

    /// <summary>
    /// Load the viewmodel from a model
    /// </summary>
    public void Load(IFinancialAccountProgram model)
    {
        IsBusy = true;
        Id = model.Id;
        Name = model.Name; // Financial Account Program Name
        ProgramNumber = model.ProgramNumber; // Financial Account Program Number
        IsChanged = false;
        IsNew = false;
        IsBusy = false;
    }
}
