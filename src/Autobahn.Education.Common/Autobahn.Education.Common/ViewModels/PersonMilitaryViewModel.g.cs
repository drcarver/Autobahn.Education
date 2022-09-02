//***************************************************************************
//* DomainName: Common Models
//* FileName:   PersonMilitaryViewModel.g.cs
//***************************************************************************

/// <summary>
/// The IPersonMilitary file
/// </summary>
public partial class PersonMilitaryViewModel : ObservableValidator, IPersonMilitary
{
    #region "PersonMilitaryViewModel Constructor"
    /// </summary>
    /// The service provider instance.
    /// <summary>
    private System.IServiceProvider? serviceProvider;

    /// <summary>
    /// PersonMilitaryViewModel Constructor
    /// </summary>
    public PersonMilitaryViewModel(System.IServiceProvider provider)
    {
        serviceProvider = provider;
        OnPersonMilitaryViewModelConstruction();
    }

    /// <summary>
    /// PersonMilitaryViewModel Constructor partial method
    /// <para>
    /// This method is called by the view model constructor
    /// to allow the inclusion of custom processing in
    /// the view models construction
    /// </para>
    /// </summary>
    partial void OnPersonMilitaryViewModelConstruction();
    #endregion"

    #region "Backing Fields"
    // Every viewmodel has a Title property
    private string viewTitle = "Hello from PersonMilitary";

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

    #region "IPersonMilitary Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IPerson"/> model
    /// </summary>
    public Guid PersonId { get; set; }

    /// <summary>
    /// Military Active Student Indicator
    /// <para>
    /// An indication that the student is currently serving on Active Duty, in the National Guard, or in the Reserve components of the United States military services
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20556">Military Active Student Indicator</a>
    /// </para>
    /// </summary>
    [DisplayName("Military Active Student Indicator")]
    public Guid? RefMilitaryActiveStudentIndicatorId { get; set; }

    /// <summary>
    /// Military Branch
    /// <para>
    /// A branch of the U.S. Military applicable for specifying more details when using Military Connected Student Indicator, Military Active Student Indicator,  Military Veteran Student Indicator, and Military Enlistment After Exit elements.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20621">Military Branch</a>
    /// </para>
    /// </summary>
    [DisplayName("Military Branch")]
    public Guid? RefMilitaryBranchId { get; set; }

    /// <summary>
    /// Military Connected Student Indicator
    /// <para>
    /// An indication that the student's parent or guardian is on Active Duty, in the National Guard, or in the Reserve components of the United States military services
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20555">Military Connected Student Indicator</a>
    /// </para>
    /// </summary>
    [DisplayName("Military Connected Student Indicator")]
    public Guid? RefMilitaryConnectedStudentIndicatorId { get; set; }

    /// <summary>
    /// Military Veteran Student Indicator
    /// <para>
    /// An indication that the student is a veteran who served on Active Duty, in the National Guard, or in the Reserve components of the United States military services
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20557">Military Veteran Student Indicator</a>
    /// </para>
    /// </summary>
    [DisplayName("Military Veteran Student Indicator")]
    public Guid? RefMilitaryVeteranStudentIndicatorId { get; set; }

    #endregion

    /// <summary>
    /// Load the viewmodel from a model
    /// </summary>
    public void Load(IPersonMilitary model)
    {
        IsBusy = true;
        Id = model.Id;
        PersonId = model.PersonId; // 
        RefMilitaryActiveStudentIndicatorId = model.RefMilitaryActiveStudentIndicatorId; // Military Active Student Indicator
        RefMilitaryBranchId = model.RefMilitaryBranchId; // Military Branch
        RefMilitaryConnectedStudentIndicatorId = model.RefMilitaryConnectedStudentIndicatorId; // Military Connected Student Indicator
        RefMilitaryVeteranStudentIndicatorId = model.RefMilitaryVeteranStudentIndicatorId; // Military Veteran Student Indicator
        IsChanged = false;
        IsNew = false;
        IsBusy = false;
    }
}
