//***************************************************************************
//* DomainName: Common Models
//* FileName:   PersonFamilyViewModel.g.cs
//***************************************************************************

/// <summary>
/// The IPersonFamily file
/// </summary>
public partial class PersonFamilyViewModel : ObservableValidator, IPersonFamily
{
    #region "PersonFamilyViewModel Constructor"
    /// </summary>
    /// The service provider instance.
    /// <summary>
    private System.IServiceProvider? serviceProvider;

    /// <summary>
    /// PersonFamilyViewModel Constructor
    /// </summary>
    public PersonFamilyViewModel(System.IServiceProvider provider)
    {
        serviceProvider = provider;
        OnPersonFamilyViewModelConstruction();
    }

    /// <summary>
    /// PersonFamilyViewModel Constructor partial method
    /// <para>
    /// This method is called by the view model constructor
    /// to allow the inclusion of custom processing in
    /// the view models construction
    /// </para>
    /// </summary>
    partial void OnPersonFamilyViewModelConstruction();
    #endregion"

    #region "Backing Fields"
    // Every viewmodel has a Title property
    private string viewTitle = "Hello from PersonFamily";

    // The isNew property is set if the view model has been created but not saved to the database
    private bool isNew = false;

    /// The isDeleted property is set if the view model is to be deleted from the database
    private bool isDeleted = false;

    /// The view model is changed and needs to be save to the database.
    public bool isChanged = false;

    /// The view model is performing a long running task
    public bool isBusy = false;

    // FamilyIdentifier -- (backing property for Family Identifier)
    private System.String familyIdentifier;

    // FamilyIncome -- (backing property for Family Income)
    private Decimal? familyIncome;

    // IncludedInCountedFamilySize -- (backing property for Included in Counted Family Size)
    private Boolean? includedInCountedFamilySize;

    // NumberOfHouseholdCollegeStudents -- (backing property for Number of Household College Students)
    private Int32? numberOfHouseholdCollegeStudents;

    // NumberOfPeopleInFamily -- (backing property for Number of People in Family)
    private Int32? numberOfPeopleInFamily;

    // NumberOfPeopleInHousehold -- (backing property for Number of People in Household)
    private Int32? numberOfPeopleInHousehold;

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

    #region "IPersonFamily Properties"
    /// <summary>
    /// Family Identifier
    /// <para>
    /// A unique number or alphanumeric code assigned to a family by a school, school system, a state, or other agency or entity.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19784">Family Identifier</a>
    /// </para>
    /// </summary>
    [DisplayName("Family Identifier")]
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(40,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String FamilyIdentifier { get => familyIdentifier; set => SetProperty(ref familyIdentifier, value, true); }

    /// <summary>
    /// Family Income
    /// <para>
    /// Total income of family from all sources. Income includes money, wages or salary before deductions; net income from non-farm self-employment; net income from farm self-employment; regular payments from Social Security or railroad retirement; payments from unemployment compensation, strike benefits from union funds, workers' compensation, veterans benefits (with the exception noted below), public assistance (including Temporary Assistance for Needy Families, Supplemental Security Income, Emergency Assistance money payments, and non-Federally funded General Assistance or General Relief money payments); training stipends; alimony, child support, and military family allotments or other regular support from an absent family member or someone not living in the household; private pensions, government employee pensions (including military retirement pay), and regular insurance or annuity payments; college or university scholarships, grants, fellowships, and assistantships; and dividends, interest, net rental income, net royalties, and periodic receipts from estates or trusts; and net gambling or lottery winnings.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19331">Family Income</a>
    /// </para>
    /// </summary>
    [DisplayName("Family Income")]
    public Decimal? FamilyIncome { get => familyIncome; set => SetProperty(ref familyIncome, value, false); }

    /// <summary>
    /// Included in Counted Family Size
    /// <para>
    /// Denotes whether this family member is counted in the family size as it pertains to the federal poverty level
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20591">Included in Counted Family Size</a>
    /// </para>
    /// </summary>
    [DisplayName("Included in Counted Family Size")]
    public Boolean? IncludedInCountedFamilySize { get => includedInCountedFamilySize; set => SetProperty(ref includedInCountedFamilySize, value, false); }

    /// <summary>
    /// Number of Household College Students
    /// <para>
    /// Number of people, including the student, who will attend at least half-time in the current academic year, a program that leads to a college degree or certificate
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20950">Number of Household College Students</a>
    /// </para>
    /// </summary>
    [DisplayName("Number of Household College Students")]
    public Int32? NumberOfHouseholdCollegeStudents { get => numberOfHouseholdCollegeStudents; set => SetProperty(ref numberOfHouseholdCollegeStudents, value, false); }

    /// <summary>
    /// Number of People in Family
    /// <para>
    /// Total number of persons in immediate family. Family means for the purposes of the regulations in this part all persons: (i) Living in the same household who are: (A) Supported by the income of the parent(s) or guardian(s) of the child enrolling or participating in the program; or (B) Related to the child by blood, marriage, or adoption; or &#x0D;
    /// </para>
    /// <para>
    /// <a href="">Number of People in Family</a>
    /// </para>
    /// </summary>
    [DisplayName("Number of People in Family")]
    public Int32? NumberOfPeopleInFamily { get => numberOfPeopleInFamily; set => SetProperty(ref numberOfPeopleInFamily, value, false); }

    /// <summary>
    /// Number of People in Household
    /// <para>
    /// Total number of persons residing in the same household.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19330">Number of People in Household</a>
    /// </para>
    /// </summary>
    [DisplayName("Number of People in Household")]
    public Int32? NumberOfPeopleInHousehold { get => numberOfPeopleInHousehold; set => SetProperty(ref numberOfPeopleInHousehold, value, false); }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IPerson"/> model
    /// </summary>
    public Guid PersonId { get; set; }

    /// <summary>
    /// Parent Communication Method
    /// <para>
    /// The types of communication methods with parents.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19857">Parent Communication Method</a>
    /// </para>
    /// </summary>
    [DisplayName("Parent Communication Method")]
    public Guid? RefCommunicationMethodId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefElprogramEligibility"/> model
    /// </summary>
    public Guid? RefElprogramEligibilityId { get; set; }

    /// <summary>
    /// Source of Family Income
    /// <para>
    /// Sources of total family income.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19332">Source of Family Income</a>
    /// </para>
    /// </summary>
    [DisplayName("Source of Family Income")]
    public Guid? RefFamilyIncomeSourceId { get; set; }

    /// <summary>
    /// Highest Level of Education Completed
    /// <para>
    /// The extent of formal instruction a person has received (e.g., the highest grade in school completed or its equivalent or the highest degree received).
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19141">Highest Level of Education Completed</a>
    /// </para>
    /// </summary>
    [DisplayName("Highest Level of Education Completed")]
    public Guid? RefHighestEducationLevelCompletedId { get; set; }

    /// <summary>
    /// Income Calculation Method
    /// <para>
    /// The calculation method used by a program to determine total family income.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19333">Income Calculation Method</a>
    /// </para>
    /// </summary>
    [DisplayName("Income Calculation Method")]
    public Guid? RefIncomeCalculationMethodId { get; set; }

    /// <summary>
    /// Proof of Residency Type
    /// <para>
    /// An accepted form of proof of residency in the district/county/other locality.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19305">Proof of Residency Type</a>
    /// </para>
    /// </summary>
    [DisplayName("Proof of Residency Type")]
    public Guid? RefProofOfResidencyTypeId { get; set; }

    #endregion

    /// <summary>
    /// Load the viewmodel from a model
    /// </summary>
    public void Load(IPersonFamily model)
    {
        IsBusy = true;
        Id = model.Id;
        FamilyIdentifier = model.FamilyIdentifier; // Family Identifier
        FamilyIncome = model.FamilyIncome; // Family Income
        IncludedInCountedFamilySize = model.IncludedInCountedFamilySize; // Included in Counted Family Size
        NumberOfHouseholdCollegeStudents = model.NumberOfHouseholdCollegeStudents; // Number of Household College Students
        NumberOfPeopleInFamily = model.NumberOfPeopleInFamily; // Number of People in Family
        NumberOfPeopleInHousehold = model.NumberOfPeopleInHousehold; // Number of People in Household
        PersonId = model.PersonId; // 
        RefCommunicationMethodId = model.RefCommunicationMethodId; // Parent Communication Method
        RefElprogramEligibilityId = model.RefElprogramEligibilityId; // 
        RefFamilyIncomeSourceId = model.RefFamilyIncomeSourceId; // Source of Family Income
        RefHighestEducationLevelCompletedId = model.RefHighestEducationLevelCompletedId; // Highest Level of Education Completed
        RefIncomeCalculationMethodId = model.RefIncomeCalculationMethodId; // Income Calculation Method
        RefProofOfResidencyTypeId = model.RefProofOfResidencyTypeId; // Proof of Residency Type
        IsChanged = false;
        IsNew = false;
        IsBusy = false;
    }
}
