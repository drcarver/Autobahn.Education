//***************************************************************************
//* DomainName: Facilities
//* FileName:   FacilityMandateViewModel.g.cs
//***************************************************************************

/// <summary>
/// The IFacilityMandate file
/// </summary>
public partial class FacilityMandateViewModel : ObservableValidator, IFacilityMandate
{
    #region "FacilityMandateViewModel Constructor"
    /// </summary>
    /// The service provider instance.
    /// <summary>
    private System.IServiceProvider? serviceProvider;

    /// <summary>
    /// FacilityMandateViewModel Constructor
    /// </summary>
    public FacilityMandateViewModel(System.IServiceProvider provider)
    {
        serviceProvider = provider;
        OnFacilityMandateViewModelConstruction();
    }

    /// <summary>
    /// FacilityMandateViewModel Constructor partial method
    /// <para>
    /// This method is called by the view model constructor
    /// to allow the inclusion of custom processing in
    /// the view models construction
    /// </para>
    /// </summary>
    partial void OnFacilityMandateViewModelConstruction();
    #endregion"

    #region "Backing Fields"
    // Every viewmodel has a Title property
    private string viewTitle = "Hello from FacilityMandate";

    // The isNew property is set if the view model has been created but not saved to the database
    private bool isNew = false;

    /// The isDeleted property is set if the view model is to be deleted from the database
    private bool isDeleted = false;

    /// The view model is changed and needs to be save to the database.
    public bool isChanged = false;

    /// The view model is performing a long running task
    public bool isBusy = false;

    // FacilityStateOrLocalMandateName -- (backing property for Facility State or Local Mandate Name)
    private System.String facilityStateOrLocalMandateName;

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

    #region "IFacilityMandate Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IFacility"/> model
    /// </summary>
    public Guid FacilityId { get; set; }

    /// <summary>
    /// Facility State or Local Mandate Name
    /// <para>
    /// The specific law, rule, regulation, or standard of a state or local government that pertains to public school facilities.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20787">Facility State or Local Mandate Name</a>
    /// </para>
    /// </summary>
    [DisplayName("Facility State or Local Mandate Name")]
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(60,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String FacilityStateOrLocalMandateName { get => facilityStateOrLocalMandateName; set => SetProperty(ref facilityStateOrLocalMandateName, value, true); }

    /// <summary>
    /// Facilities Mandate Authority Type
    /// <para>
    /// The authority that mandates through law, regulation, or standard that pertains to a specific mandate.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20866">Facilities Mandate Authority Type</a>
    /// </para>
    /// </summary>
    [DisplayName("Facilities Mandate Authority Type")]
    public Guid? RefFacilitiesMandateAuthorityTypeId { get; set; }

    /// <summary>
    /// Facility Applicable Federal Mandate Type
    /// <para>
    /// The particular federal law, regulation, or standard that pertains to a school facility.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20777">Facility Applicable Federal Mandate Type</a>
    /// </para>
    /// </summary>
    [DisplayName("Facility Applicable Federal Mandate Type")]
    public Guid? RefFacilityApplicableFederalMandateTypeId { get; set; }

    /// <summary>
    /// Facility Federal Mandate Interest Type
    /// <para>
    /// The area of interest controlled by a federal law, regulation, or standard that pertains to a school facility.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20778">Facility Federal Mandate Interest Type</a>
    /// </para>
    /// </summary>
    [DisplayName("Facility Federal Mandate Interest Type")]
    public Guid? RefFacilityFederalMandateInterestTypeId { get; set; }

    /// <summary>
    /// Facility State or Local Mandate Interest Type
    /// <para>
    /// The area of interest controlled by a law, rule, regulation, or standard of state and local governments that pertains to public school facilities.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20786">Facility State or Local Mandate Interest Type</a>
    /// </para>
    /// </summary>
    [DisplayName("Facility State or Local Mandate Interest Type")]
    public Guid? RefFacilityStateOrLocalMandateInterestTypeId { get; set; }

    #endregion

    /// <summary>
    /// Load the viewmodel from a model
    /// </summary>
    public void Load(IFacilityMandate model)
    {
        IsBusy = true;
        Id = model.Id;
        FacilityId = model.FacilityId; // 
        FacilityStateOrLocalMandateName = model.FacilityStateOrLocalMandateName; // Facility State or Local Mandate Name
        RefFacilitiesMandateAuthorityTypeId = model.RefFacilitiesMandateAuthorityTypeId; // Facilities Mandate Authority Type
        RefFacilityApplicableFederalMandateTypeId = model.RefFacilityApplicableFederalMandateTypeId; // Facility Applicable Federal Mandate Type
        RefFacilityFederalMandateInterestTypeId = model.RefFacilityFederalMandateInterestTypeId; // Facility Federal Mandate Interest Type
        RefFacilityStateOrLocalMandateInterestTypeId = model.RefFacilityStateOrLocalMandateInterestTypeId; // Facility State or Local Mandate Interest Type
        IsChanged = false;
        IsNew = false;
        IsBusy = false;
    }
}
