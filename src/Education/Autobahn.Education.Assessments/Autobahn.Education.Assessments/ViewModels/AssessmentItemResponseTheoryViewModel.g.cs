//***************************************************************************
//* DomainName: Assessments
//* FileName:   AssessmentItemResponseTheoryViewModel.g.cs
//***************************************************************************

/// <summary>
/// The IAssessmentItemResponseTheory file
/// </summary>
public partial class AssessmentItemResponseTheoryViewModel : ObservableValidator, IAssessmentItemResponseTheory
{
    #region "AssessmentItemResponseTheoryViewModel Constructor"
    /// </summary>
    /// The service provider instance.
    /// <summary>
    private System.IServiceProvider? serviceProvider;

    /// <summary>
    /// AssessmentItemResponseTheoryViewModel Constructor
    /// </summary>
    public AssessmentItemResponseTheoryViewModel(System.IServiceProvider provider)
    {
        serviceProvider = provider;
        OnAssessmentItemResponseTheoryViewModelConstruction();
    }

    /// <summary>
    /// AssessmentItemResponseTheoryViewModel Constructor partial method
    /// <para>
    /// This method is called by the view model constructor
    /// to allow the inclusion of custom processing in
    /// the view models construction
    /// </para>
    /// </summary>
    partial void OnAssessmentItemResponseTheoryViewModelConstruction();
    #endregion"

    #region "Backing Fields"
    // Every viewmodel has a Title property
    private string viewTitle = "Hello from AssessmentItemResponseTheory";

    // The isNew property is set if the view model has been created but not saved to the database
    private bool isNew = false;

    /// The isDeleted property is set if the view model is to be deleted from the database
    private bool isDeleted = false;

    /// The view model is changed and needs to be save to the database.
    public bool isChanged = false;

    /// The view model is performing a long running task
    public bool isBusy = false;

    // member variable for the Difvalue property
    private Int32? difvalue;

    // KappaValue -- (backing property for Assessment Item Response Theory Kappa Value)
    private Int32? kappaValue;

    // ParameterA -- (backing property for Assessment Item Response Theory Parameter A)
    private Int32? parameterA;

    // ParameterB -- (backing property for Assessment Item Response Theory Parameter B)
    private Int32? parameterB;

    // ParameterC -- (backing property for Assessment Item Response Theory Parameter C)
    private Int32? parameterC;

    // ParameterD1 -- (backing property for Assessment Item Response Theory Parameter D1)
    private Int32? parameterD1;

    // ParameterD2 -- (backing property for Assessment Item Response Theory Parameter D2)
    private Int32? parameterD2;

    // ParameterD3 -- (backing property for Assessment Item Response Theory Parameter D3)
    private Int32? parameterD3;

    // ParameterD4 -- (backing property for Assessment Item Response Theory Parameter D4)
    private Int32? parameterD4;

    // ParameterD5 -- (backing property for Assessment Item Response Theory Parameter D5)
    private Int32? parameterD5;

    // ParameterD6 -- (backing property for Assessment Item Response Theory Parameter D6)
    private Int32? parameterD6;

    // PointBiserialCorrelationValue -- (backing property for Assessment Item Response Theory Point Biserial Correlation Value)
    private Int32? pointBiserialCorrelationValue;

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

    #region "IAssessmentItemResponseTheory Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IAssessmentItem"/> model
    /// </summary>
    public Guid AssessmentItemId { get; set; }

    public Int32? Difvalue { get => difvalue; set => SetProperty(ref difvalue, value, false); }

    /// <summary>
    /// Assessment Item Response Theory Kappa Value
    /// <para>
    /// The measure used to represent the degree of agreement among raters.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20231">Assessment Item Response Theory Kappa Value</a>
    /// </para>
    /// </summary>
    [DisplayName("Assessment Item Response Theory Kappa Value")]
    public Int32? KappaValue { get => kappaValue; set => SetProperty(ref kappaValue, value, false); }

    /// <summary>
    /// Assessment Item Response Theory Parameter A
    /// <para>
    /// The Item Response Theory value representing the discrimination of the item. The a parameter is found by taking the slope of the line tangent to the item characteristic curve at the inflection point, B. The parameter is the steepness of the curve at its steepest point.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20217">Assessment Item Response Theory Parameter A</a>
    /// </para>
    /// </summary>
    [DisplayName("Assessment Item Response Theory Parameter A")]
    public Int32? ParameterA { get => parameterA; set => SetProperty(ref parameterA, value, false); }

    /// <summary>
    /// Assessment Item Response Theory Parameter B
    /// <para>
    /// The Item Response Theory value representing the difficulty of the item.   It is the Theta value for the location of the inflection point of the item characteristic curve.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20218">Assessment Item Response Theory Parameter B</a>
    /// </para>
    /// </summary>
    [DisplayName("Assessment Item Response Theory Parameter B")]
    public Int32? ParameterB { get => parameterB; set => SetProperty(ref parameterB, value, false); }

    /// <summary>
    /// Assessment Item Response Theory Parameter C
    /// <para>
    /// The Item Response Theory value for multiple choice items representing the guessing of the item. The c parameter is a lower asymptote. It is the low point of the curve as it moves to negative infinity on the horizontal axis. You can think of c as the probability that a chicken would get the item right.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20220">Assessment Item Response Theory Parameter C</a>
    /// </para>
    /// </summary>
    [DisplayName("Assessment Item Response Theory Parameter C")]
    public Int32? ParameterC { get => parameterC; set => SetProperty(ref parameterC, value, false); }

    /// <summary>
    /// Assessment Item Response Theory Parameter D1
    /// <para>
    /// For   polytomous assessment items with more than two possible responses, this is the item response theory value representing the threshold between the first and second item characteristic functions.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20221">Assessment Item Response Theory Parameter D1</a>
    /// </para>
    /// </summary>
    [DisplayName("Assessment Item Response Theory Parameter D1")]
    public Int32? ParameterD1 { get => parameterD1; set => SetProperty(ref parameterD1, value, false); }

    /// <summary>
    /// Assessment Item Response Theory Parameter D2
    /// <para>
    /// For   polytomous assessment items with more than two possible responses, this is the item response theory value representing the threshold between the second and third item characteristic functions.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20222">Assessment Item Response Theory Parameter D2</a>
    /// </para>
    /// </summary>
    [DisplayName("Assessment Item Response Theory Parameter D2")]
    public Int32? ParameterD2 { get => parameterD2; set => SetProperty(ref parameterD2, value, false); }

    /// <summary>
    /// Assessment Item Response Theory Parameter D3
    /// <para>
    /// For   polytomous assessment items with more than three possible responses, this is the item response theory value representing the threshold between the third and fourth item characteristic functions.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20223">Assessment Item Response Theory Parameter D3</a>
    /// </para>
    /// </summary>
    [DisplayName("Assessment Item Response Theory Parameter D3")]
    public Int32? ParameterD3 { get => parameterD3; set => SetProperty(ref parameterD3, value, false); }

    /// <summary>
    /// Assessment Item Response Theory Parameter D4
    /// <para>
    /// For   polytomous assessment items with more than four possible responses, this is the item response theory value representing the threshold between the fourth and fifth item characteristic functions.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20224">Assessment Item Response Theory Parameter D4</a>
    /// </para>
    /// </summary>
    [DisplayName("Assessment Item Response Theory Parameter D4")]
    public Int32? ParameterD4 { get => parameterD4; set => SetProperty(ref parameterD4, value, false); }

    /// <summary>
    /// Assessment Item Response Theory Parameter D5
    /// <para>
    /// For   polytomous assessment items with more than five possible responses, this is the item response theory value representing the threshold between the fifth and sixth item characteristic functions.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20225">Assessment Item Response Theory Parameter D5</a>
    /// </para>
    /// </summary>
    [DisplayName("Assessment Item Response Theory Parameter D5")]
    public Int32? ParameterD5 { get => parameterD5; set => SetProperty(ref parameterD5, value, false); }

    /// <summary>
    /// Assessment Item Response Theory Parameter D6
    /// <para>
    /// For   polytomous assessment items with more than six possible responses, this is the item response theory value representing the threshold between the sixth and seventh item characteristic functions.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20226">Assessment Item Response Theory Parameter D6</a>
    /// </para>
    /// </summary>
    [DisplayName("Assessment Item Response Theory Parameter D6")]
    public Int32? ParameterD6 { get => parameterD6; set => SetProperty(ref parameterD6, value, false); }

    /// <summary>
    /// Assessment Item Response Theory Point Biserial Correlation Value
    /// <para>
    /// The correlation between correct answers on this item and total correct answers on the test during a previous administration.�
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20228">Assessment Item Response Theory Point Biserial Correlation Value</a>
    /// </para>
    /// </summary>
    [DisplayName("Assessment Item Response Theory Point Biserial Correlation Value")]
    public Int32? PointBiserialCorrelationValue { get => pointBiserialCorrelationValue; set => SetProperty(ref pointBiserialCorrelationValue, value, false); }

    /// <summary>
    /// Assessment Item Response Theory Parameter Difficulty Category
    /// <para>
    /// A category for the difficulty of the item based on the Item Response Theory value.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20219">Assessment Item Response Theory Parameter Difficulty Category</a>
    /// </para>
    /// </summary>
    [DisplayName("Assessment Item Response Theory Parameter Difficulty Category")]
    public Guid? RefItemResponseTheoryDifficultyCategoryId { get; set; }

    /// <summary>
    /// Assessment Item Response Theory Kappa Algorithm
    /// <para>
    /// The algorithm used to derive the Assessment Item Kappa Value
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20232">Assessment Item Response Theory Kappa Algorithm</a>
    /// </para>
    /// </summary>
    [DisplayName("Assessment Item Response Theory Kappa Algorithm")]
    public Guid? RefItemResponseTheoryKappaAlgorithmId { get; set; }

    #endregion

    /// <summary>
    /// Load the viewmodel from a model
    /// </summary>
    public void Load(IAssessmentItemResponseTheory model)
    {
        IsBusy = true;
        Id = model.Id;
        AssessmentItemId = model.AssessmentItemId; // 
        Difvalue = model.Difvalue; // 
        KappaValue = model.KappaValue; // Assessment Item Response Theory Kappa Value
        ParameterA = model.ParameterA; // Assessment Item Response Theory Parameter A
        ParameterB = model.ParameterB; // Assessment Item Response Theory Parameter B
        ParameterC = model.ParameterC; // Assessment Item Response Theory Parameter C
        ParameterD1 = model.ParameterD1; // Assessment Item Response Theory Parameter D1
        ParameterD2 = model.ParameterD2; // Assessment Item Response Theory Parameter D2
        ParameterD3 = model.ParameterD3; // Assessment Item Response Theory Parameter D3
        ParameterD4 = model.ParameterD4; // Assessment Item Response Theory Parameter D4
        ParameterD5 = model.ParameterD5; // Assessment Item Response Theory Parameter D5
        ParameterD6 = model.ParameterD6; // Assessment Item Response Theory Parameter D6
        PointBiserialCorrelationValue = model.PointBiserialCorrelationValue; // Assessment Item Response Theory Point Biserial Correlation Value
        RefItemResponseTheoryDifficultyCategoryId = model.RefItemResponseTheoryDifficultyCategoryId; // Assessment Item Response Theory Parameter Difficulty Category
        RefItemResponseTheoryKappaAlgorithmId = model.RefItemResponseTheoryKappaAlgorithmId; // Assessment Item Response Theory Kappa Algorithm
        IsChanged = false;
        IsNew = false;
        IsBusy = false;
    }
}
