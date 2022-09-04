//***************************************************************************
//* DomainName: Assessments
//* FileName:   AssessmentNeedBrailleViewModel.g.cs
//***************************************************************************

/// <summary>
/// The IAssessmentNeedBraille file
/// </summary>
public partial class AssessmentNeedBrailleViewModel : ObservableValidator, IAssessmentNeedBraille
{
    #region "AssessmentNeedBrailleViewModel Constructor"
    /// </summary>
    /// The service provider instance.
    /// <summary>
    private System.IServiceProvider? serviceProvider;

    /// <summary>
    /// AssessmentNeedBrailleViewModel Constructor
    /// </summary>
    public AssessmentNeedBrailleViewModel(System.IServiceProvider provider)
    {
        serviceProvider = provider;
        OnAssessmentNeedBrailleViewModelConstruction();
    }

    /// <summary>
    /// AssessmentNeedBrailleViewModel Constructor partial method
    /// <para>
    /// This method is called by the view model constructor
    /// to allow the inclusion of custom processing in
    /// the view models construction
    /// </para>
    /// </summary>
    partial void OnAssessmentNeedBrailleViewModelConstruction();
    #endregion"

    #region "Backing Fields"
    // Every viewmodel has a Title property
    private string viewTitle = "Hello from AssessmentNeedBraille";

    // The isNew property is set if the view model has been created but not saved to the database
    private bool isNew = false;

    /// The isDeleted property is set if the view model is to be deleted from the database
    private bool isDeleted = false;

    /// The view model is changed and needs to be save to the database.
    public bool isChanged = false;

    /// The view model is performing a long running task
    public bool isBusy = false;

    // BrailleDotPressure -- (backing property for Assessment Need Braille Dot Pressure)
    private Decimal? brailleDotPressure;

    // NumberOfBrailleCells -- (backing property for Assessment Need Number of Braille Cells)
    private Int32? numberOfBrailleCells;

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

    #region "IAssessmentNeedBraille Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IAssessmentPersonalNeedsProfileDisplay"/> model
    /// </summary>
    public Guid? AssessmentPersonalNeedsProfileDisplayId { get; set; }

    /// <summary>
    /// Assessment Need Braille Dot Pressure
    /// <para>
    /// Defines as part of an Assessment Personal Needs Profile the resistance pressure of Braille display pins.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20040">Assessment Need Braille Dot Pressure</a>
    /// </para>
    /// </summary>
    [DisplayName("Assessment Need Braille Dot Pressure")]
    public Decimal? BrailleDotPressure { get => brailleDotPressure; set => SetProperty(ref brailleDotPressure, value, false); }

    /// <summary>
    /// Assessment Need Number of Braille Cells
    /// <para>
    /// Defines as part of an Assessment Personal Needs Profile the number of active Braille cells in a Braille display.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20037">Assessment Need Number of Braille Cells</a>
    /// </para>
    /// </summary>
    [DisplayName("Assessment Need Number of Braille Cells")]
    public Int32? NumberOfBrailleCells { get => numberOfBrailleCells; set => SetProperty(ref numberOfBrailleCells, value, false); }

    /// <summary>
    /// Assessment Need Braille Grade Type
    /// <para>
    /// Defines as part of an Assessment Personal Needs Profile the grade of Braille to use when using a Braille display.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20035">Assessment Need Braille Grade Type</a>
    /// </para>
    /// </summary>
    [DisplayName("Assessment Need Braille Grade Type")]
    public Guid? RefAssessmentNeedBrailleGradeTypeId { get; set; }

    /// <summary>
    /// Assessment Need Braille Mark Type
    /// <para>
    /// Defines as part of an Assessment Personal Needs Profile what textual properties to mark when using a Braille display.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20038">Assessment Need Braille Mark Type</a>
    /// </para>
    /// </summary>
    [DisplayName("Assessment Need Braille Mark Type")]
    public Guid? RefAssessmentNeedBrailleMarkTypeId { get; set; }

    /// <summary>
    /// Assessment Need Braille Status Cell Type
    /// <para>
    /// Defines as part of an Assessment Personal Needs Profile the preferred presence or location of a Braille display status cell.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20041">Assessment Need Braille Status Cell Type</a>
    /// </para>
    /// </summary>
    [DisplayName("Assessment Need Braille Status Cell Type")]
    public Guid? RefAssessmentNeedBrailleStatusCellTypeId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefAssessmentNeedNumberOfBrailleDot"/> model
    /// </summary>
    public Guid? RefAssessmentNeedNumberOfBrailleDotId { get; set; }

    /// <summary>
    /// Assessment Need Usage Type
    /// <para>
    /// Defines as part of an Assessment Personal Needs Profile the rating for the collection of Access for All (AfA) needs and preferences.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20028">Assessment Need Usage Type</a>
    /// </para>
    /// </summary>
    [DisplayName("Assessment Need Usage Type")]
    public Guid? RefAssessmentNeedUsageTypeId { get; set; }

    #endregion

    /// <summary>
    /// Load the viewmodel from a model
    /// </summary>
    public void Load(IAssessmentNeedBraille model)
    {
        IsBusy = true;
        Id = model.Id;
        AssessmentPersonalNeedsProfileDisplayId = model.AssessmentPersonalNeedsProfileDisplayId; // 
        BrailleDotPressure = model.BrailleDotPressure; // Assessment Need Braille Dot Pressure
        NumberOfBrailleCells = model.NumberOfBrailleCells; // Assessment Need Number of Braille Cells
        RefAssessmentNeedBrailleGradeTypeId = model.RefAssessmentNeedBrailleGradeTypeId; // Assessment Need Braille Grade Type
        RefAssessmentNeedBrailleMarkTypeId = model.RefAssessmentNeedBrailleMarkTypeId; // Assessment Need Braille Mark Type
        RefAssessmentNeedBrailleStatusCellTypeId = model.RefAssessmentNeedBrailleStatusCellTypeId; // Assessment Need Braille Status Cell Type
        RefAssessmentNeedNumberOfBrailleDotId = model.RefAssessmentNeedNumberOfBrailleDotId; // 
        RefAssessmentNeedUsageTypeId = model.RefAssessmentNeedUsageTypeId; // Assessment Need Usage Type
        IsChanged = false;
        IsNew = false;
        IsBusy = false;
    }
}
