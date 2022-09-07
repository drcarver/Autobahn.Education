//***************************************************************************
//* DomainName: Facilities
//* FileName:   FacilityJointUseViewModel.g.cs
//***************************************************************************

/// <summary>
/// The IFacilityJointUse file
/// </summary>
public partial class FacilityJointUseViewModel : ObservableValidator, IFacilityJointUse
{
    #region "FacilityJointUseViewModel Constructor"
    /// </summary>
    /// The service provider instance.
    /// <summary>
    private System.IServiceProvider? serviceProvider;

    /// <summary>
    /// FacilityJointUseViewModel Constructor
    /// </summary>
    public FacilityJointUseViewModel(System.IServiceProvider provider)
    {
        serviceProvider = provider;
        OnFacilityJointUseViewModelConstruction();
    }

    /// <summary>
    /// FacilityJointUseViewModel Constructor partial method
    /// <para>
    /// This method is called by the view model constructor
    /// to allow the inclusion of custom processing in
    /// the view models construction
    /// </para>
    /// </summary>
    partial void OnFacilityJointUseViewModelConstruction();
    #endregion"

    #region "Backing Fields"
    // Every viewmodel has a Title property
    private string viewTitle = "Hello from FacilityJointUse";

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

    #region "IFacilityJointUse Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IFacility"/> model
    /// </summary>
    public Guid FacilityId { get; set; }

    /// <summary>
    /// Building Joint Use Rationale Type
    /// <para>
    /// The reasons for permitting and participating in joint-use.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20833">Building Joint Use Rationale Type</a>
    /// </para>
    /// </summary>
    [DisplayName("Building Joint Use Rationale Type")]
    public Guid? RefBuildingJointUseRationaleTypeId { get; set; }

    /// <summary>
    /// Building Joint User Type
    /// <para>
    /// The types of users sharing school district controlled, owned, or utilized facilities.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20835">Building Joint User Type</a>
    /// </para>
    /// </summary>
    [DisplayName("Building Joint User Type")]
    public Guid? RefBuildingJointUserTypeId { get; set; }

    /// <summary>
    /// Building Joint Use Scheduling Type
    /// <para>
    /// The type of designation of non school district users by the amount of time they have access to public school for joint use.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20834">Building Joint Use Scheduling Type</a>
    /// </para>
    /// </summary>
    [DisplayName("Building Joint Use Scheduling Type")]
    public Guid? RefBuildingJointUseSchedulingTypeId { get; set; }

    #endregion

    /// <summary>
    /// Load the viewmodel from a model
    /// </summary>
    public void Load(IFacilityJointUse model)
    {
        IsBusy = true;
        Id = model.Id;
        FacilityId = model.FacilityId; // 
        RefBuildingJointUseRationaleTypeId = model.RefBuildingJointUseRationaleTypeId; // Building Joint Use Rationale Type
        RefBuildingJointUserTypeId = model.RefBuildingJointUserTypeId; // Building Joint User Type
        RefBuildingJointUseSchedulingTypeId = model.RefBuildingJointUseSchedulingTypeId; // Building Joint Use Scheduling Type
        IsChanged = false;
        IsNew = false;
        IsBusy = false;
    }
}
