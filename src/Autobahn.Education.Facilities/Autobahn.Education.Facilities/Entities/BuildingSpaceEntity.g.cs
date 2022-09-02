//***************************************************************************
//* DomainName: Facilities
//* FileName:   BuildingSpaceEntity.g.cs
//***************************************************************************

/// <summary>
/// The IBuildingSpace file
/// </summary>
[Table("BuildingSpace", Schema = "Facilities")]
public partial class BuildingSpaceEntity : EntityBase, IBuildingSpace
{
    #region "IBuildingSpace Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IFacility"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("Facility")]
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
    [ForeignKey("RefBuildingAdministrativeSpaceType")]
    [Comment("The space designed primarily for conducting administrative and business functions.")]
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
    [ForeignKey("RefBuildingArtSpecialtySpaceType")]
    [Comment("The space designed to support the teaching and learning of 2 dimensional or 3 dimensional visual arts.")]
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
    [ForeignKey("RefBuildingAssemblySpaceType")]
    [Comment("An area designed primarily for theater productions, assemblies, and other large gatherings.")]
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
    [ForeignKey("RefBuildingBasicClassroomDesignType")]
    [Comment("A classroom designed for instruction of a particular age group, but not a specific subject.")]
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
    [ForeignKey("RefBuildingCareerTechEducationSpaceType")]
    [Comment("The classroom, laboratory, or shop specially located, designed, furnished, and equipped to support instruction of technical and technology related curriculum, usually tied to particular industry, for example, bio-tech, construction, or agriculture.")]
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
    [ForeignKey("RefBuildingCirculationSpaceType")]
    [Comment("A space designed to enable people to move within the building.")]
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
    [ForeignKey("RefBuildingFoodServiceSpaceType")]
    [Comment("The space located, designed, furnished and equipped to support meal programs.")]
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
    [ForeignKey("RefBuildingFullServiceKitchenType")]
    [Comment("The type of kitchen housed in the facility as defined by whether it prepares food to be served onsite and/or at additional locations.")]
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
    [ForeignKey("RefBuildingIndoorAthleticOrPhysEdSpaceType")]
    [Comment("The indoor space designed, located, furnished, and equipped for instruction and support of a physical education curriculum and athletic program.")]
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
    [ForeignKey("RefBuildingLibMediaCenterSpecialtySpaceType")]
    [Comment("The primary and auxiliary space designed to provide and support student and staff access to books, periodicals, software, videos, and the Internet.")]
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
    [ForeignKey("RefBuildingOperationsOrMaintSpaceType")]
    [Comment("The area designed primarily for conducting activities concerned with maintaining the grounds, buildings, and equipment.")]
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
    [ForeignKey("RefBuildingOutdoorAthleticOrPhysEdSpaceType")]
    [Comment("The outdoor space designed, located, furnished, and equipped for instruction and support of a physical education curriculum and athletic program.")]
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
    [ForeignKey("RefBuildingOutdoorOrNonathleticSpaceType")]
    [Comment("The outdoor space located, designed, furnished, and equipped primarily for recreation, play and outdoor environmental education.")]
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
    [ForeignKey("RefBuildingPerformingArtsSpecialtySpaceType")]
    [Comment("The space designed, located, furnished, and equipped for instruction and support of music and drama curricula and productions.")]
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
    [ForeignKey("RefBuildingScienceSpecialtySpaceType")]
    [Comment("The space designed, located, furnished, and equipped for instruction and experimentation in science.")]
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
    [ForeignKey("RefBuildingSpaceDesignType")]
    [Comment("The primary design or purpose of a space, as determined by its physical layout and built-in systems and equipment, regardless of its current use.")]
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
    [ForeignKey("RefBuildingSpecEdSpecialtySpaceType")]
    [Comment("The space designed, located, furnished, and equipped to support instruction of children with special physical, emotional, and/or educational needs.")]
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
    [ForeignKey("RefBuildingStudentSupportSpaceType")]
    [Comment("The space designed to provide student support services such as administrative, technical (e.g., guidance and health), and logistical support to facilitate and enhance instruction.")]
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
    [ForeignKey("RefSpaceUseType")]
    [Comment("The primary use of a space, as determined by its physical layout and built-in systems and equipment, regardless of its original design.")]
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
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(300,ErrorMessage="The {0} must be less then {1} characters.")]
    [Comment("A description of the space, as determined by its physical layout and built-in systems and equipment.")]
    public System.String SpaceDescription { get; set; }

    #endregion

    #region "Virtual Properties for foreign keys"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IFacility"/> implementation
    /// <remarks>
    /// This entity is in the Facilities domain
    /// </remarks>
    /// </summary>
    public virtual FacilityEntity FacilityEntity { get; set; }

    /// <summary>
    /// The primary use of a space, as determined by its physical layout and built-in systems and equipment, regardless of its original design.
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20175">Facility Space Use Type</a>
    /// </para>
    /// <remarks>
    /// This entity is in the Facilities domain
    /// </remarks>
    /// </summary>
    public virtual RefSpaceUseTypeEntity RefSpaceUseTypeEntity { get; set; }

    /// <summary>
    /// The space designed primarily for conducting administrative and business functions.
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20794">Building Administrative Space Type</a>
    /// </para>
    /// <remarks>
    /// This entity is in the Facilities domain
    /// </remarks>
    /// </summary>
    public virtual RefBuildingAdministrativeSpaceTypeEntity RefBuildingAdministrativeSpaceTypeEntity { get; set; }

    /// <summary>
    /// The space designed to support the teaching and learning of 2 dimensional or 3 dimensional visual arts.
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20795">Building Art Specialty Space Type</a>
    /// </para>
    /// <remarks>
    /// This entity is in the Facilities domain
    /// </remarks>
    /// </summary>
    public virtual RefBuildingArtSpecialtySpaceTypeEntity RefBuildingArtSpecialtySpaceTypeEntity { get; set; }

    /// <summary>
    /// An area designed primarily for theater productions, assemblies, and other large gatherings.
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20817">Building Assembly Space Type</a>
    /// </para>
    /// <remarks>
    /// This entity is in the Facilities domain
    /// </remarks>
    /// </summary>
    public virtual RefBuildingAssemblySpaceTypeEntity RefBuildingAssemblySpaceTypeEntity { get; set; }

    /// <summary>
    /// A classroom designed for instruction of a particular age group, but not a specific subject.
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20796">Building Basic Classroom Design Type</a>
    /// </para>
    /// <remarks>
    /// This entity is in the Facilities domain
    /// </remarks>
    /// </summary>
    public virtual RefBuildingBasicClassroomDesignTypeEntity RefBuildingBasicClassroomDesignTypeEntity { get; set; }

    /// <summary>
    /// The classroom, laboratory, or shop specially located, designed, furnished, and equipped to support instruction of technical and technology related curriculum, usually tied to particular industry, for example, bio-tech, construction, or agriculture.
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20798">Building Career-Technical Education Space Type</a>
    /// </para>
    /// <remarks>
    /// This entity is in the Facilities domain
    /// </remarks>
    /// </summary>
    public virtual RefBuildingCareerTechEducationSpaceTypeEntity RefBuildingCareerTechEducationSpaceTypeEntity { get; set; }

    /// <summary>
    /// A space designed to enable people to move within the building.
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20799">Building Circulation Space Type</a>
    /// </para>
    /// <remarks>
    /// This entity is in the Facilities domain
    /// </remarks>
    /// </summary>
    public virtual RefBuildingCirculationSpaceTypeEntity RefBuildingCirculationSpaceTypeEntity { get; set; }

    /// <summary>
    /// The space located, designed, furnished and equipped to support meal programs.
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20802">Building Food Service Space Type</a>
    /// </para>
    /// <remarks>
    /// This entity is in the Facilities domain
    /// </remarks>
    /// </summary>
    public virtual RefBuildingFoodServiceSpaceTypeEntity RefBuildingFoodServiceSpaceTypeEntity { get; set; }

    /// <summary>
    /// The type of kitchen housed in the facility as defined by whether it prepares food to be served onsite and/or at additional locations.
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20824">Building Full Service Kitchen Type</a>
    /// </para>
    /// <remarks>
    /// This entity is in the Facilities domain
    /// </remarks>
    /// </summary>
    public virtual RefBuildingFullServiceKitchenTypeEntity RefBuildingFullServiceKitchenTypeEntity { get; set; }

    /// <summary>
    /// The indoor space designed, located, furnished, and equipped for instruction and support of a physical education curriculum and athletic program.
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20803">Building Indoor Athletic or Physical Education Space Type</a>
    /// </para>
    /// <remarks>
    /// This entity is in the Facilities domain
    /// </remarks>
    /// </summary>
    public virtual RefBuildingIndoorAthleticOrPhysEdSpaceTypeEntity RefBuildingIndoorAthleticOrPhysEdSpaceTypeEntity { get; set; }

    /// <summary>
    /// The primary and auxiliary space designed to provide and support student and staff access to books, periodicals, software, videos, and the Internet.
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20804">Building Library or Media Center Specialty Space Type</a>
    /// </para>
    /// <remarks>
    /// This entity is in the Facilities domain
    /// </remarks>
    /// </summary>
    public virtual RefBuildingLibMediaCenterSpecialtySpaceTypeEntity RefBuildingLibMediaCenterSpecialtySpaceTypeEntity { get; set; }

    /// <summary>
    /// The area designed primarily for conducting activities concerned with maintaining the grounds, buildings, and equipment.
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20805">Building Operations or Maintenance Space Type</a>
    /// </para>
    /// <remarks>
    /// This entity is in the Facilities domain
    /// </remarks>
    /// </summary>
    public virtual RefBuildingOperationsOrMaintSpaceTypeEntity RefBuildingOperationsOrMaintSpaceTypeEntity { get; set; }

    /// <summary>
    /// The outdoor space designed, located, furnished, and equipped for instruction and support of a physical education curriculum and athletic program.
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20806">Building Outdoor Athletic or Physical Education Space Type</a>
    /// </para>
    /// <remarks>
    /// This entity is in the Facilities domain
    /// </remarks>
    /// </summary>
    public virtual RefBuildingOutdoorAthleticOrPhysEdSpaceTypeEntity RefBuildingOutdoorAthleticOrPhysEdSpaceTypeEntity { get; set; }

    /// <summary>
    /// The outdoor space located, designed, furnished, and equipped primarily for recreation, play and outdoor environmental education.
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20807">Building Outdoor or Non-athletic Space Type</a>
    /// </para>
    /// <remarks>
    /// This entity is in the Facilities domain
    /// </remarks>
    /// </summary>
    public virtual RefBuildingOutdoorOrNonathleticSpaceTypeEntity RefBuildingOutdoorOrNonathleticSpaceTypeEntity { get; set; }

    /// <summary>
    /// The space designed, located, furnished, and equipped for instruction and support of music and drama curricula and productions.
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20808">Building Performing Arts Specialty Space Type</a>
    /// </para>
    /// <remarks>
    /// This entity is in the Facilities domain
    /// </remarks>
    /// </summary>
    public virtual RefBuildingPerformingArtsSpecialtySpaceTypeEntity RefBuildingPerformingArtsSpecialtySpaceTypeEntity { get; set; }

    /// <summary>
    /// The space designed, located, furnished, and equipped for instruction and experimentation in science.
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20810">Building Science Specialty Space Type</a>
    /// </para>
    /// <remarks>
    /// This entity is in the Facilities domain
    /// </remarks>
    /// </summary>
    public virtual RefBuildingScienceSpecialtySpaceTypeEntity RefBuildingScienceSpecialtySpaceTypeEntity { get; set; }

    /// <summary>
    /// The primary design or purpose of a space, as determined by its physical layout and built-in systems and equipment, regardless of its current use.
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20812">Building Space Design Type</a>
    /// </para>
    /// <remarks>
    /// This entity is in the Facilities domain
    /// </remarks>
    /// </summary>
    public virtual RefBuildingSpaceDesignTypeEntity RefBuildingSpaceDesignTypeEntity { get; set; }

    /// <summary>
    /// The space designed, located, furnished, and equipped to support instruction of children with special physical, emotional, and/or educational needs.
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20813">Building Special Education Specialty Space Type</a>
    /// </para>
    /// <remarks>
    /// This entity is in the Facilities domain
    /// </remarks>
    /// </summary>
    public virtual RefBuildingSpecEdSpecialtySpaceTypeEntity RefBuildingSpecEdSpecialtySpaceTypeEntity { get; set; }

    /// <summary>
    /// The space designed to provide student support services such as administrative, technical (e.g., guidance and health), and logistical support to facilitate and enhance instruction.
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20814">Building Student Support Space Type</a>
    /// </para>
    /// <remarks>
    /// This entity is in the Facilities domain
    /// </remarks>
    /// </summary>
    public virtual RefBuildingStudentSupportSpaceTypeEntity RefBuildingStudentSupportSpaceTypeEntity { get; set; }

    #endregion
}
