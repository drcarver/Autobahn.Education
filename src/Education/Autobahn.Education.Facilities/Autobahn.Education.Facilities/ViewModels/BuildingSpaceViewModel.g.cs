//***************************************************************************
//* DomainName: Facilities
//* FileName:   BuildingSpaceViewModel.g.cs
//***************************************************************************

/// <summary>
/// The IBuildingSpace file
/// </summary>
public partial class BuildingSpaceViewModel : ObservableValidator, IBuildingSpace
{
    #region "BuildingSpaceViewModel Constructor"
    /// </summary>
    /// The service provider instance.
    /// <summary>
    private System.IServiceProvider? serviceProvider;

    /// <summary>
    /// BuildingSpaceViewModel Constructor
    /// </summary>
    public BuildingSpaceViewModel(System.IServiceProvider provider)
    {
        serviceProvider = provider;
        OnBuildingSpaceViewModelConstruction();
    }

    /// <summary>
    /// BuildingSpaceViewModel Constructor partial method
    /// <para>
    /// This method is called by the view model constructor
    /// to allow the inclusion of custom processing in
    /// the view models construction
    /// </para>
    /// </summary>
    partial void OnBuildingSpaceViewModelConstruction();
    #endregion"

    #region "Backing Fields"
    // Every viewmodel has a Title property
    private string viewTitle = "Hello from BuildingSpace";

    // The isNew property is set if the view model has been created but not saved to the database
    private bool isNew = false;

    /// The isDeleted property is set if the view model is to be deleted from the database
    private bool isDeleted = false;

    /// The view model is changed and needs to be save to the database.
    public bool isChanged = false;

    /// The view model is performing a long running task
    public bool isBusy = false;

    // SpaceDescription -- (backing property for Facility Space Description)
    private System.String spaceDescription;

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

    #region "IBuildingSpace Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IFacility"/> model
    /// </summary>
    public Guid FacilityId { get; set; }

    /// <summary>
    /// Building Administrative Space Type
    /// <para>
    /// The space designed primarily for conducting administrative and business functions.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20794">Building Administrative Space Type</a>
    /// </para>
    /// </summary>
    [DisplayName("Building Administrative Space Type")]
    public Guid? RefBuildingAdministrativeSpaceTypeId { get; set; }

    /// <summary>
    /// Building Art Specialty Space Type
    /// <para>
    /// The space designed to support the teaching and learning of 2 dimensional or 3 dimensional visual arts.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20795">Building Art Specialty Space Type</a>
    /// </para>
    /// </summary>
    [DisplayName("Building Art Specialty Space Type")]
    public Guid? RefBuildingArtSpecialtySpaceTypeId { get; set; }

    /// <summary>
    /// Building Assembly Space Type
    /// <para>
    /// An area designed primarily for theater productions, assemblies, and other large gatherings.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20817">Building Assembly Space Type</a>
    /// </para>
    /// </summary>
    [DisplayName("Building Assembly Space Type")]
    public Guid? RefBuildingAssemblySpaceTypeId { get; set; }

    /// <summary>
    /// Building Basic Classroom Design Type
    /// <para>
    /// A classroom designed for instruction of a particular age group, but not a specific subject.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20796">Building Basic Classroom Design Type</a>
    /// </para>
    /// </summary>
    [DisplayName("Building Basic Classroom Design Type")]
    public Guid? RefBuildingBasicClassroomDesignTypeId { get; set; }

    /// <summary>
    /// Building Career-Technical Education Space Type
    /// <para>
    /// The classroom, laboratory, or shop specially located, designed, furnished, and equipped to support instruction of technical and technology related curriculum, usually tied to particular industry, for example, bio-tech, construction, or agriculture.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20798">Building Career-Technical Education Space Type</a>
    /// </para>
    /// </summary>
    [DisplayName("Building Career-Technical Education Space Type")]
    public Guid? RefBuildingCareerTechEducationSpaceTypeId { get; set; }

    /// <summary>
    /// Building Circulation Space Type
    /// <para>
    /// A space designed to enable people to move within the building.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20799">Building Circulation Space Type</a>
    /// </para>
    /// </summary>
    [DisplayName("Building Circulation Space Type")]
    public Guid? RefBuildingCirculationSpaceTypeId { get; set; }

    /// <summary>
    /// Building Food Service Space Type
    /// <para>
    /// The space located, designed, furnished and equipped to support meal programs.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20802">Building Food Service Space Type</a>
    /// </para>
    /// </summary>
    [DisplayName("Building Food Service Space Type")]
    public Guid? RefBuildingFoodServiceSpaceTypeId { get; set; }

    /// <summary>
    /// Building Full Service Kitchen Type
    /// <para>
    /// The type of kitchen housed in the facility as defined by whether it prepares food to be served onsite and/or at additional locations.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20824">Building Full Service Kitchen Type</a>
    /// </para>
    /// </summary>
    [DisplayName("Building Full Service Kitchen Type")]
    public Guid? RefBuildingFullServiceKitchenTypeId { get; set; }

    /// <summary>
    /// Building Indoor Athletic or Physical Education Space Type
    /// <para>
    /// The indoor space designed, located, furnished, and equipped for instruction and support of a physical education curriculum and athletic program.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20803">Building Indoor Athletic or Physical Education Space Type</a>
    /// </para>
    /// </summary>
    [DisplayName("Building Indoor Athletic or Physical Education Space Type")]
    public Guid? RefBuildingIndoorAthleticOrPhysEdSpaceTypeId { get; set; }

    /// <summary>
    /// Building Library or Media Center Specialty Space Type
    /// <para>
    /// The primary and auxiliary space designed to provide and support student and staff access to books, periodicals, software, videos, and the Internet.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20804">Building Library or Media Center Specialty Space Type</a>
    /// </para>
    /// </summary>
    [DisplayName("Building Library or Media Center Specialty Space Type")]
    public Guid? RefBuildingLibMediaCenterSpecialtySpaceTypeId { get; set; }

    /// <summary>
    /// Building Operations or Maintenance Space Type
    /// <para>
    /// The area designed primarily for conducting activities concerned with maintaining the grounds, buildings, and equipment.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20805">Building Operations or Maintenance Space Type</a>
    /// </para>
    /// </summary>
    [DisplayName("Building Operations or Maintenance Space Type")]
    public Guid? RefBuildingOperationsOrMaintSpaceTypeId { get; set; }

    /// <summary>
    /// Building Outdoor Athletic or Physical Education Space Type
    /// <para>
    /// The outdoor space designed, located, furnished, and equipped for instruction and support of a physical education curriculum and athletic program.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20806">Building Outdoor Athletic or Physical Education Space Type</a>
    /// </para>
    /// </summary>
    [DisplayName("Building Outdoor Athletic or Physical Education Space Type")]
    public Guid? RefBuildingOutdoorAthleticOrPhysEdSpaceTypeId { get; set; }

    /// <summary>
    /// Building Outdoor or Non-athletic Space Type
    /// <para>
    /// The outdoor space located, designed, furnished, and equipped primarily for recreation, play and outdoor environmental education.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20807">Building Outdoor or Non-athletic Space Type</a>
    /// </para>
    /// </summary>
    [DisplayName("Building Outdoor or Non-athletic Space Type")]
    public Guid? RefBuildingOutdoorOrNonathleticSpaceTypeId { get; set; }

    /// <summary>
    /// Building Performing Arts Specialty Space Type
    /// <para>
    /// The space designed, located, furnished, and equipped for instruction and support of music and drama curricula and productions.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20808">Building Performing Arts Specialty Space Type</a>
    /// </para>
    /// </summary>
    [DisplayName("Building Performing Arts Specialty Space Type")]
    public Guid? RefBuildingPerformingArtsSpecialtySpaceTypeId { get; set; }

    /// <summary>
    /// Building Science Specialty Space Type
    /// <para>
    /// The space designed, located, furnished, and equipped for instruction and experimentation in science.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20810">Building Science Specialty Space Type</a>
    /// </para>
    /// </summary>
    [DisplayName("Building Science Specialty Space Type")]
    public Guid? RefBuildingScienceSpecialtySpaceTypeId { get; set; }

    /// <summary>
    /// Building Space Design Type
    /// <para>
    /// The primary design or purpose of a space, as determined by its physical layout and built-in systems and equipment, regardless of its current use.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20812">Building Space Design Type</a>
    /// </para>
    /// </summary>
    [DisplayName("Building Space Design Type")]
    public Guid? RefBuildingSpaceDesignTypeId { get; set; }

    /// <summary>
    /// Building Special Education Specialty Space Type
    /// <para>
    /// The space designed, located, furnished, and equipped to support instruction of children with special physical, emotional, and/or educational needs.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20813">Building Special Education Specialty Space Type</a>
    /// </para>
    /// </summary>
    [DisplayName("Building Special Education Specialty Space Type")]
    public Guid? RefBuildingSpecEdSpecialtySpaceTypeId { get; set; }

    /// <summary>
    /// Building Student Support Space Type
    /// <para>
    /// The space designed to provide student support services such as administrative, technical (e.g., guidance and health), and logistical support to facilitate and enhance instruction.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20814">Building Student Support Space Type</a>
    /// </para>
    /// </summary>
    [DisplayName("Building Student Support Space Type")]
    public Guid? RefBuildingStudentSupportSpaceTypeId { get; set; }

    /// <summary>
    /// Facility Space Use Type
    /// <para>
    /// The primary use of a space, as determined by its physical layout and built-in systems and equipment, regardless of its original design.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20175">Facility Space Use Type</a>
    /// </para>
    /// </summary>
    [DisplayName("Facility Space Use Type")]
    public Guid? RefSpaceUseTypeId { get; set; }

    /// <summary>
    /// Facility Space Description
    /// <para>
    /// A description of the space, as determined by its physical layout and built-in systems and equipment.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20174">Facility Space Description</a>
    /// </para>
    /// </summary>
    [DisplayName("Facility Space Description")]
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(300,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String SpaceDescription { get => spaceDescription; set => SetProperty(ref spaceDescription, value, true); }

    #endregion

    /// <summary>
    /// Load the viewmodel from a model
    /// </summary>
    public void Load(IBuildingSpace model)
    {
        IsBusy = true;
        Id = model.Id;
        FacilityId = model.FacilityId; // 
        RefBuildingAdministrativeSpaceTypeId = model.RefBuildingAdministrativeSpaceTypeId; // Building Administrative Space Type
        RefBuildingArtSpecialtySpaceTypeId = model.RefBuildingArtSpecialtySpaceTypeId; // Building Art Specialty Space Type
        RefBuildingAssemblySpaceTypeId = model.RefBuildingAssemblySpaceTypeId; // Building Assembly Space Type
        RefBuildingBasicClassroomDesignTypeId = model.RefBuildingBasicClassroomDesignTypeId; // Building Basic Classroom Design Type
        RefBuildingCareerTechEducationSpaceTypeId = model.RefBuildingCareerTechEducationSpaceTypeId; // Building Career-Technical Education Space Type
        RefBuildingCirculationSpaceTypeId = model.RefBuildingCirculationSpaceTypeId; // Building Circulation Space Type
        RefBuildingFoodServiceSpaceTypeId = model.RefBuildingFoodServiceSpaceTypeId; // Building Food Service Space Type
        RefBuildingFullServiceKitchenTypeId = model.RefBuildingFullServiceKitchenTypeId; // Building Full Service Kitchen Type
        RefBuildingIndoorAthleticOrPhysEdSpaceTypeId = model.RefBuildingIndoorAthleticOrPhysEdSpaceTypeId; // Building Indoor Athletic or Physical Education Space Type
        RefBuildingLibMediaCenterSpecialtySpaceTypeId = model.RefBuildingLibMediaCenterSpecialtySpaceTypeId; // Building Library or Media Center Specialty Space Type
        RefBuildingOperationsOrMaintSpaceTypeId = model.RefBuildingOperationsOrMaintSpaceTypeId; // Building Operations or Maintenance Space Type
        RefBuildingOutdoorAthleticOrPhysEdSpaceTypeId = model.RefBuildingOutdoorAthleticOrPhysEdSpaceTypeId; // Building Outdoor Athletic or Physical Education Space Type
        RefBuildingOutdoorOrNonathleticSpaceTypeId = model.RefBuildingOutdoorOrNonathleticSpaceTypeId; // Building Outdoor or Non-athletic Space Type
        RefBuildingPerformingArtsSpecialtySpaceTypeId = model.RefBuildingPerformingArtsSpecialtySpaceTypeId; // Building Performing Arts Specialty Space Type
        RefBuildingScienceSpecialtySpaceTypeId = model.RefBuildingScienceSpecialtySpaceTypeId; // Building Science Specialty Space Type
        RefBuildingSpaceDesignTypeId = model.RefBuildingSpaceDesignTypeId; // Building Space Design Type
        RefBuildingSpecEdSpecialtySpaceTypeId = model.RefBuildingSpecEdSpecialtySpaceTypeId; // Building Special Education Specialty Space Type
        RefBuildingStudentSupportSpaceTypeId = model.RefBuildingStudentSupportSpaceTypeId; // Building Student Support Space Type
        RefSpaceUseTypeId = model.RefSpaceUseTypeId; // Facility Space Use Type
        SpaceDescription = model.SpaceDescription; // Facility Space Description
        IsChanged = false;
        IsNew = false;
        IsBusy = false;
    }
}
