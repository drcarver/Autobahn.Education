//***************************************************************************
//* DomainName: Facilities
//* FileName:   BuildingSystemCategoryViewModel.g.cs
//***************************************************************************

/// <summary>
/// The IBuildingSystemCategory file
/// </summary>
public partial class BuildingSystemCategoryViewModel : ObservableValidator, IBuildingSystemCategory
{
    #region "BuildingSystemCategoryViewModel Constructor"
    /// </summary>
    /// The service provider instance.
    /// <summary>
    private System.IServiceProvider? serviceProvider;

    /// <summary>
    /// BuildingSystemCategoryViewModel Constructor
    /// </summary>
    public BuildingSystemCategoryViewModel(System.IServiceProvider provider)
    {
        serviceProvider = provider;
        OnBuildingSystemCategoryViewModelConstruction();
    }

    /// <summary>
    /// BuildingSystemCategoryViewModel Constructor partial method
    /// <para>
    /// This method is called by the view model constructor
    /// to allow the inclusion of custom processing in
    /// the view models construction
    /// </para>
    /// </summary>
    partial void OnBuildingSystemCategoryViewModelConstruction();
    #endregion"

    #region "Backing Fields"
    // Every viewmodel has a Title property
    private string viewTitle = "Hello from BuildingSystemCategory";

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

    #region "IBuildingSystemCategory Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IBuildingSystemComponent"/> model
    /// </summary>
    public Guid BuildingSystemComponentId { get; set; }

    /// <summary>
    /// Building Air Distribution System Type
    /// <para>
    /// The primary means by which air is circulated, freshened, and exhausted.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20771">Building Air Distribution System Type</a>
    /// </para>
    /// </summary>
    [DisplayName("Building Air Distribution System Type")]
    public Guid? RefBuildingAirDistributionSystemTypeId { get; set; }

    /// <summary>
    /// Building Communications Management Component System Type
    /// <para>
    /// The type of system, interface, and management components for carrying voice, video, and data throughout a building.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20772">Building Communications Management Component System Type</a>
    /// </para>
    /// </summary>
    [DisplayName("Building Communications Management Component System Type")]
    public Guid? RefBuildingCommMgmtComponentSystemTypeId { get; set; }

    /// <summary>
    /// Building Cooling Generation System Type
    /// <para>
    /// The type of mechanical systems and building designs used for cooling.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20775">Building Cooling Generation System Type</a>
    /// </para>
    /// </summary>
    [DisplayName("Building Cooling Generation System Type")]
    public Guid? RefBuildingCoolingGenerationSystemTypeId { get; set; }

    /// <summary>
    /// Building Electrical System Type
    /// <para>
    /// The components and system required to distribute electricity throughout the building or site.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20776">Building Electrical System Type</a>
    /// </para>
    /// </summary>
    [DisplayName("Building Electrical System Type")]
    public Guid? RefBuildingElectricalSystemTypeId { get; set; }

    /// <summary>
    /// Building Fire Protection System Type
    /// <para>
    /// The type of system that protects the facility against fire.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20779">Building Fire Protection System Type</a>
    /// </para>
    /// </summary>
    [DisplayName("Building Fire Protection System Type")]
    public Guid? RefBuildingFireProtectionSystemTypeId { get; set; }

    /// <summary>
    /// Building Heating Generation System Type
    /// <para>
    /// The method by which the heat is distributed and delivered throughout the room(s) or building.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20780">Building Heating Generation System Type</a>
    /// </para>
    /// </summary>
    [DisplayName("Building Heating Generation System Type")]
    public Guid? RefBuildingHeatingGenerationSystemTypeId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefBuildingHvacsystemType"/> model
    /// </summary>
    public Guid? RefBuildingHvacsystemTypeId { get; set; }

    /// <summary>
    /// Building Mechanical Conveying System Type
    /// <para>
    /// Mechanical means for moving people and equipment within buildings.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20783">Building Mechanical Conveying System Type</a>
    /// </para>
    /// </summary>
    [DisplayName("Building Mechanical Conveying System Type")]
    public Guid? RefBuildingMechanicalConveyingSystemTypeId { get; set; }

    /// <summary>
    /// Building Mechanical System Type
    /// <para>
    /// The major manufactured systems required to operate a building.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20790">Building Mechanical System Type</a>
    /// </para>
    /// </summary>
    [DisplayName("Building Mechanical System Type")]
    public Guid? RefBuildingMechanicalSystemTypeId { get; set; }

    /// <summary>
    /// Building Plumbing System Type
    /// <para>
    /// The component of an on-site system for supplying, eliminating, and treating water.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20784">Building Plumbing System Type</a>
    /// </para>
    /// </summary>
    [DisplayName("Building Plumbing System Type")]
    public Guid? RefBuildingPlumbingSystemTypeId { get; set; }

    /// <summary>
    /// Building Security System Type
    /// <para>
    /// The type of system that protects the facility from intrusion.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20785">Building Security System Type</a>
    /// </para>
    /// </summary>
    [DisplayName("Building Security System Type")]
    public Guid? RefBuildingSecuritySystemTypeId { get; set; }

    /// <summary>
    /// Building System Type
    /// <para>
    /// The type of system that is installed in the building or site.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20792">Building System Type</a>
    /// </para>
    /// </summary>
    [DisplayName("Building System Type")]
    public Guid? RefBuildingSystemTypeId { get; set; }

    /// <summary>
    /// Building Technology Wiring System Type
    /// <para>
    /// The means through which voice, video, audio, and data information are conveyed.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20788">Building Technology Wiring System Type</a>
    /// </para>
    /// </summary>
    [DisplayName("Building Technology Wiring System Type")]
    public Guid? RefBuildingTechnologyWiringSystemTypeId { get; set; }

    /// <summary>
    /// Building Vertical Transportation System Type
    /// <para>
    /// The type of system used to convey persons or freight between floors.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20793">Building Vertical Transportation System Type</a>
    /// </para>
    /// </summary>
    [DisplayName("Building Vertical Transportation System Type")]
    public Guid? RefBuildingVerticalTransportationSystemTypeId { get; set; }

    #endregion

    /// <summary>
    /// Load the viewmodel from a model
    /// </summary>
    public void Load(IBuildingSystemCategory model)
    {
        IsBusy = true;
        Id = model.Id;
        BuildingSystemComponentId = model.BuildingSystemComponentId; // 
        RefBuildingAirDistributionSystemTypeId = model.RefBuildingAirDistributionSystemTypeId; // Building Air Distribution System Type
        RefBuildingCommMgmtComponentSystemTypeId = model.RefBuildingCommMgmtComponentSystemTypeId; // Building Communications Management Component System Type
        RefBuildingCoolingGenerationSystemTypeId = model.RefBuildingCoolingGenerationSystemTypeId; // Building Cooling Generation System Type
        RefBuildingElectricalSystemTypeId = model.RefBuildingElectricalSystemTypeId; // Building Electrical System Type
        RefBuildingFireProtectionSystemTypeId = model.RefBuildingFireProtectionSystemTypeId; // Building Fire Protection System Type
        RefBuildingHeatingGenerationSystemTypeId = model.RefBuildingHeatingGenerationSystemTypeId; // Building Heating Generation System Type
        RefBuildingHvacsystemTypeId = model.RefBuildingHvacsystemTypeId; // 
        RefBuildingMechanicalConveyingSystemTypeId = model.RefBuildingMechanicalConveyingSystemTypeId; // Building Mechanical Conveying System Type
        RefBuildingMechanicalSystemTypeId = model.RefBuildingMechanicalSystemTypeId; // Building Mechanical System Type
        RefBuildingPlumbingSystemTypeId = model.RefBuildingPlumbingSystemTypeId; // Building Plumbing System Type
        RefBuildingSecuritySystemTypeId = model.RefBuildingSecuritySystemTypeId; // Building Security System Type
        RefBuildingSystemTypeId = model.RefBuildingSystemTypeId; // Building System Type
        RefBuildingTechnologyWiringSystemTypeId = model.RefBuildingTechnologyWiringSystemTypeId; // Building Technology Wiring System Type
        RefBuildingVerticalTransportationSystemTypeId = model.RefBuildingVerticalTransportationSystemTypeId; // Building Vertical Transportation System Type
        IsChanged = false;
        IsNew = false;
        IsBusy = false;
    }
}
