//***************************************************************************
//* DomainName: Competencies
//* FileName:   CompetencySetViewModel.g.cs
//***************************************************************************

/// <summary>
/// The ICompetencySet file
/// </summary>
public partial class CompetencySetViewModel : ObservableValidator, ICompetencySet
{
    #region "CompetencySetViewModel Constructor"
    /// </summary>
    /// The service provider instance.
    /// <summary>
    private System.IServiceProvider? serviceProvider;

    /// <summary>
    /// CompetencySetViewModel Constructor
    /// </summary>
    public CompetencySetViewModel(System.IServiceProvider provider)
    {
        serviceProvider = provider;
        OnCompetencySetViewModelConstruction();
    }

    /// <summary>
    /// CompetencySetViewModel Constructor partial method
    /// <para>
    /// This method is called by the view model constructor
    /// to allow the inclusion of custom processing in
    /// the view models construction
    /// </para>
    /// </summary>
    partial void OnCompetencySetViewModelConstruction();
    #endregion"

    #region "Backing Fields"
    // Every viewmodel has a Title property
    private string viewTitle = "Hello from CompetencySet";

    // The isNew property is set if the view model has been created but not saved to the database
    private bool isNew = false;

    /// The isDeleted property is set if the view model is to be deleted from the database
    private bool isDeleted = false;

    /// The view model is changed and needs to be save to the database.
    public bool isChanged = false;

    /// The view model is performing a long running task
    public bool isBusy = false;

    // member variable for the ChildOfCompetencySet property
    private Int32? childOfCompetencySet;

    // CompletionCriteriaThreshold -- (backing property for Competency Set Completion Criteria Threshold)
    private Int32? completionCriteriaThreshold;

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

    #region "ICompetencySet Properties"
    public Int32? ChildOfCompetencySet { get => childOfCompetencySet; set => SetProperty(ref childOfCompetencySet, value, false); }

    /// <summary>
    /// Competency Set Completion Criteria Threshold
    /// <para>
    /// The minimum number of competencies in the set that must be achieved for completion or partial completion of a unit, course, program, degree, certification, or other achievement/award.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19878">Competency Set Completion Criteria Threshold</a>
    /// </para>
    /// </summary>
    [DisplayName("Competency Set Completion Criteria Threshold")]
    public Int32? CompletionCriteriaThreshold { get => completionCriteriaThreshold; set => SetProperty(ref completionCriteriaThreshold, value, false); }

    /// <summary>
    /// Competency Set Completion Criteria
    /// <para>
    /// The criteria for the set of competencies that represent completion or partial completion of a unit, course, program, degree, certification, or other achievement/award. Specifies whether completion requires achievement of all items in the set or some number of items.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19877">Competency Set Completion Criteria</a>
    /// </para>
    /// </summary>
    [DisplayName("Competency Set Completion Criteria")]
    public Guid? RefCompletionCriteriaId { get; set; }

    #endregion

    /// <summary>
    /// Load the viewmodel from a model
    /// </summary>
    public void Load(ICompetencySet model)
    {
        IsBusy = true;
        Id = model.Id;
        ChildOfCompetencySet = model.ChildOfCompetencySet; // 
        CompletionCriteriaThreshold = model.CompletionCriteriaThreshold; // Competency Set Completion Criteria Threshold
        RefCompletionCriteriaId = model.RefCompletionCriteriaId; // Competency Set Completion Criteria
        IsChanged = false;
        IsNew = false;
        IsBusy = false;
    }
}
