//***************************************************************************
//* DomainName: Postsecondary (PS)
//* FileName:   PsInstitutionViewModel.g.cs
//***************************************************************************

/// <summary>
/// The IPsInstitution file
/// </summary>
public partial class PsInstitutionViewModel : ObservableValidator, IPsInstitution
{
    #region "PsInstitutionViewModel Constructor"
    /// </summary>
    /// The service provider instance.
    /// <summary>
    private System.IServiceProvider? serviceProvider;

    /// <summary>
    /// PsInstitutionViewModel Constructor
    /// </summary>
    public PsInstitutionViewModel(System.IServiceProvider provider)
    {
        serviceProvider = provider;
        OnPsInstitutionViewModelConstruction();
    }

    /// <summary>
    /// PsInstitutionViewModel Constructor partial method
    /// <para>
    /// This method is called by the view model constructor
    /// to allow the inclusion of custom processing in
    /// the view models construction
    /// </para>
    /// </summary>
    partial void OnPsInstitutionViewModelConstruction();
    #endregion"

    #region "Backing Fields"
    // Every viewmodel has a Title property
    private string viewTitle = "Hello from PsInstitution";

    // The isNew property is set if the view model has been created but not saved to the database
    private bool isNew = false;

    /// The isDeleted property is set if the view model is to be deleted from the database
    private bool isDeleted = false;

    /// The view model is changed and needs to be save to the database.
    public bool isChanged = false;

    /// The view model is performing a long running task
    public bool isBusy = false;

    // InstitutionallyControlledHousingStatus -- (backing property for Institutionally Controlled Housing Status)
    private Boolean? institutionallyControlledHousingStatus;

    // VirtualIndicator -- (backing property for Virtual Indicator)
    private Boolean? virtualIndicator;

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

    #region "IPsInstitution Properties"
    /// <summary>
    /// Institutionally Controlled Housing Status
    /// <para>
    /// An indication of whether an institution has any residence hall or housing facility located on- or off-campus that is owned or controlled by an institution and used by the institution in direct support of or in a manner related to, the institution's educational purposes.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19727">Institutionally Controlled Housing Status</a>
    /// </para>
    /// </summary>
    [DisplayName("Institutionally Controlled Housing Status")]
    public Boolean? InstitutionallyControlledHousingStatus { get => institutionallyControlledHousingStatus; set => SetProperty(ref institutionallyControlledHousingStatus, value, false); }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganization"/> model
    /// </summary>
    public Guid OrganizationId { get; set; }

    /// <summary>
    /// Administrative Funding Control
    /// <para>
    /// The type of education institution as classified by its funding source.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19012">Administrative Funding Control</a>
    /// </para>
    /// </summary>
    [DisplayName("Administrative Funding Control")]
    public Guid? RefAdministrativeFundingControlId { get; set; }

    /// <summary>
    /// Admission Consideration Level
    /// <para>
    /// The level of consideration given a type of admission criteria used at an institution during the selection process.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20558">Admission Consideration Level</a>
    /// </para>
    /// </summary>
    [DisplayName("Admission Consideration Level")]
    public Guid? RefAdmissionConsiderationLevelId { get; set; }

    /// <summary>
    /// Admission Consideration Type
    /// <para>
    /// The type of admission consideration used at an institution during the selection process.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20559">Admission Consideration Type</a>
    /// </para>
    /// </summary>
    [DisplayName("Admission Consideration Type")]
    public Guid? RefAdmissionConsiderationTypeId { get; set; }

    /// <summary>
    /// Carnegie Basic Classification
    /// <para>
    /// The Basic Classification is an update of the traditional classification framework developed by the Carnegie Commission on Higher Education in 1970 to support its research program, and later published in 1973 for use by other researchers.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19038">Carnegie Basic Classification</a>
    /// </para>
    /// </summary>
    [DisplayName("Carnegie Basic Classification")]
    public Guid? RefCarnegieBasicClassificationId { get; set; }

    /// <summary>
    /// Control of Institution
    /// <para>
    /// A classification of whether a postsecondary institution is operated by publicly elected or appointed officials (public control) or by privately elected or appointed officials and derives its major source of funds from private sources (private control). 
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19048">Control of Institution</a>
    /// </para>
    /// </summary>
    [DisplayName("Control of Institution")]
    public Guid? RefControlOfInstitutionId { get; set; }

    /// <summary>
    /// Increased Learning Time Type
    /// <para>
    /// The types of increased learning time provided.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19164">Increased Learning Time Type</a>
    /// </para>
    /// </summary>
    [DisplayName("Increased Learning Time Type")]
    public Guid? RefIncreasedLearningTimeTypeId { get; set; }

    /// <summary>
    /// Level of Institution
    /// <para>
    /// A classification of whether a postsecondary institution's highest level of offering is a program of 4-years or higher (4 year), 2-but-less-than 4-years (2 year), or less than 2-years.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19178">Level of Institution</a>
    /// </para>
    /// </summary>
    [DisplayName("Level of Institution")]
    public Guid? RefLevelOfInstitutionId { get; set; }

    /// <summary>
    /// Predominant Calendar System
    /// <para>
    /// The method by which an institution structures most of its courses for the academic year.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19705">Predominant Calendar System</a>
    /// </para>
    /// </summary>
    [DisplayName("Predominant Calendar System")]
    public Guid? RefPredominantCalendarSystemId { get; set; }

    /// <summary>
    /// Tenure System
    /// <para>
    /// An indicator of whether an institution has personnel positions that lead to consideration for tenure.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19715">Tenure System</a>
    /// </para>
    /// </summary>
    [DisplayName("Tenure System")]
    public Guid? RefTenureSystemId { get; set; }

    /// <summary>
    /// Virtual Indicator
    /// <para>
    /// Indicates a school, institution, program, or course section focuses primarily on instruction in which students and teachers are separated by time and/or location and interact through the use of computers and/or telecommunications technologies.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20167">Virtual Indicator</a>
    /// </para>
    /// </summary>
    [DisplayName("Virtual Indicator")]
    public Boolean? VirtualIndicator { get => virtualIndicator; set => SetProperty(ref virtualIndicator, value, false); }

    #endregion

    /// <summary>
    /// Load the viewmodel from a model
    /// </summary>
    public void Load(IPsInstitution model)
    {
        IsBusy = true;
        Id = model.Id;
        InstitutionallyControlledHousingStatus = model.InstitutionallyControlledHousingStatus; // Institutionally Controlled Housing Status
        OrganizationId = model.OrganizationId; // 
        RefAdministrativeFundingControlId = model.RefAdministrativeFundingControlId; // Administrative Funding Control
        RefAdmissionConsiderationLevelId = model.RefAdmissionConsiderationLevelId; // Admission Consideration Level
        RefAdmissionConsiderationTypeId = model.RefAdmissionConsiderationTypeId; // Admission Consideration Type
        RefCarnegieBasicClassificationId = model.RefCarnegieBasicClassificationId; // Carnegie Basic Classification
        RefControlOfInstitutionId = model.RefControlOfInstitutionId; // Control of Institution
        RefIncreasedLearningTimeTypeId = model.RefIncreasedLearningTimeTypeId; // Increased Learning Time Type
        RefLevelOfInstitutionId = model.RefLevelOfInstitutionId; // Level of Institution
        RefPredominantCalendarSystemId = model.RefPredominantCalendarSystemId; // Predominant Calendar System
        RefTenureSystemId = model.RefTenureSystemId; // Tenure System
        VirtualIndicator = model.VirtualIndicator; // Virtual Indicator
        IsChanged = false;
        IsNew = false;
        IsBusy = false;
    }
}
