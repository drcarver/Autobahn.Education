//***************************************************************************
//* DomainName: Facilities
//* FileName:   BuildingSystemCategoryEntity.g.cs
//***************************************************************************

/// <summary>
/// The IBuildingSystemCategory file
/// </summary>
[Table("BuildingSystemCategory", Schema = "Facilities")]
public partial class BuildingSystemCategoryEntity : EntityBase, IBuildingSystemCategory
{
    #region "IBuildingSystemCategory Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IBuildingSystemComponent"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("BuildingSystemComponent")]
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
    [ForeignKey("RefBuildingAirDistributionSystemType")]
    [Comment("The primary means by which air is circulated, freshened, and exhausted.")]
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
    [ForeignKey("RefBuildingCommMgmtComponentSystemType")]
    [Comment("The type of system, interface, and management components for carrying voice, video, and data throughout a building.")]
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
    [ForeignKey("RefBuildingCoolingGenerationSystemType")]
    [Comment("The type of mechanical systems and building designs used for cooling.")]
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
    [ForeignKey("RefBuildingElectricalSystemType")]
    [Comment("The components and system required to distribute electricity throughout the building or site.")]
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
    [ForeignKey("RefBuildingFireProtectionSystemType")]
    [Comment("The type of system that protects the facility against fire.")]
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
    [ForeignKey("RefBuildingHeatingGenerationSystemType")]
    [Comment("The method by which the heat is distributed and delivered throughout the room(s) or building.")]
    public Guid? RefBuildingHeatingGenerationSystemTypeId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefBuildingHvacsystemType"/> model
    /// </summary>
    [ForeignKey("RefBuildingHvacsystemType")]
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
    [ForeignKey("RefBuildingMechanicalConveyingSystemType")]
    [Comment("Mechanical means for moving people and equipment within buildings.")]
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
    [ForeignKey("RefBuildingMechanicalSystemType")]
    [Comment("The major manufactured systems required to operate a building.")]
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
    [ForeignKey("RefBuildingPlumbingSystemType")]
    [Comment("The component of an on-site system for supplying, eliminating, and treating water.")]
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
    [ForeignKey("RefBuildingSecuritySystemType")]
    [Comment("The type of system that protects the facility from intrusion.")]
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
    [ForeignKey("RefBuildingSystemType")]
    [Comment("The type of system that is installed in the building or site.")]
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
    [ForeignKey("RefBuildingTechnologyWiringSystemType")]
    [Comment("The means through which voice, video, audio, and data information are conveyed.")]
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
    [ForeignKey("RefBuildingVerticalTransportationSystemType")]
    [Comment("The type of system used to convey persons or freight between floors.")]
    public Guid? RefBuildingVerticalTransportationSystemTypeId { get; set; }

    #endregion

    #region "Virtual Properties for foreign keys"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IBuildingSystemComponent"/> implementation
    /// <remarks>
    /// This entity is in the Facilities domain
    /// </remarks>
    /// </summary>
    public virtual BuildingSystemComponentEntity BuildingSystemComponentEntity { get; set; }

    /// <summary>
    /// The primary means by which air is circulated, freshened, and exhausted.
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20771">Building Air Distribution System Type</a>
    /// </para>
    /// <remarks>
    /// This entity is in the Facilities domain
    /// </remarks>
    /// </summary>
    public virtual RefBuildingAirDistributionSystemTypeEntity RefBuildingAirDistributionSystemTypeEntity { get; set; }

    /// <summary>
    /// The type of system, interface, and management components for carrying voice, video, and data throughout a building.
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20772">Building Communications Management Component System Type</a>
    /// </para>
    /// <remarks>
    /// This entity is in the Facilities domain
    /// </remarks>
    /// </summary>
    public virtual RefBuildingCommMgmtComponentSystemTypeEntity RefBuildingCommMgmtComponentSystemTypeEntity { get; set; }

    /// <summary>
    /// The type of mechanical systems and building designs used for cooling.
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20775">Building Cooling Generation System Type</a>
    /// </para>
    /// <remarks>
    /// This entity is in the Facilities domain
    /// </remarks>
    /// </summary>
    public virtual RefBuildingCoolingGenerationSystemTypeEntity RefBuildingCoolingGenerationSystemTypeEntity { get; set; }

    /// <summary>
    /// The components and system required to distribute electricity throughout the building or site.
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20776">Building Electrical System Type</a>
    /// </para>
    /// <remarks>
    /// This entity is in the Facilities domain
    /// </remarks>
    /// </summary>
    public virtual RefBuildingElectricalSystemTypeEntity RefBuildingElectricalSystemTypeEntity { get; set; }

    /// <summary>
    /// The type of system that protects the facility against fire.
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20779">Building Fire Protection System Type</a>
    /// </para>
    /// <remarks>
    /// This entity is in the Facilities domain
    /// </remarks>
    /// </summary>
    public virtual RefBuildingFireProtectionSystemTypeEntity RefBuildingFireProtectionSystemTypeEntity { get; set; }

    /// <summary>
    /// The method by which the heat is distributed and delivered throughout the room(s) or building.
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20780">Building Heating Generation System Type</a>
    /// </para>
    /// <remarks>
    /// This entity is in the Facilities domain
    /// </remarks>
    /// </summary>
    public virtual RefBuildingHeatingGenerationSystemTypeEntity RefBuildingHeatingGenerationSystemTypeEntity { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IRefBuildingHvacsystemType"/> implementation
    /// <remarks>
    /// This entity is in the Facilities domain
    /// </remarks>
    /// </summary>
    public virtual RefBuildingHvacsystemTypeEntity RefBuildingHvacsystemTypeEntity { get; set; }

    /// <summary>
    /// Mechanical means for moving people and equipment within buildings.
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20783">Building Mechanical Conveying System Type</a>
    /// </para>
    /// <remarks>
    /// This entity is in the Facilities domain
    /// </remarks>
    /// </summary>
    public virtual RefBuildingMechanicalConveyingSystemTypeEntity RefBuildingMechanicalConveyingSystemTypeEntity { get; set; }

    /// <summary>
    /// The major manufactured systems required to operate a building.
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20790">Building Mechanical System Type</a>
    /// </para>
    /// <remarks>
    /// This entity is in the Facilities domain
    /// </remarks>
    /// </summary>
    public virtual RefBuildingMechanicalSystemTypeEntity RefBuildingMechanicalSystemTypeEntity { get; set; }

    /// <summary>
    /// The component of an on-site system for supplying, eliminating, and treating water.
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20784">Building Plumbing System Type</a>
    /// </para>
    /// <remarks>
    /// This entity is in the Facilities domain
    /// </remarks>
    /// </summary>
    public virtual RefBuildingPlumbingSystemTypeEntity RefBuildingPlumbingSystemTypeEntity { get; set; }

    /// <summary>
    /// The type of system that protects the facility from intrusion.
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20785">Building Security System Type</a>
    /// </para>
    /// <remarks>
    /// This entity is in the Facilities domain
    /// </remarks>
    /// </summary>
    public virtual RefBuildingSecuritySystemTypeEntity RefBuildingSecuritySystemTypeEntity { get; set; }

    /// <summary>
    /// The type of system that is installed in the building or site.
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20792">Building System Type</a>
    /// </para>
    /// <remarks>
    /// This entity is in the Facilities domain
    /// </remarks>
    /// </summary>
    public virtual RefBuildingSystemTypeEntity RefBuildingSystemTypeEntity { get; set; }

    /// <summary>
    /// The means through which voice, video, audio, and data information are conveyed.
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20788">Building Technology Wiring System Type</a>
    /// </para>
    /// <remarks>
    /// This entity is in the Facilities domain
    /// </remarks>
    /// </summary>
    public virtual RefBuildingTechnologyWiringSystemTypeEntity RefBuildingTechnologyWiringSystemTypeEntity { get; set; }

    /// <summary>
    /// The type of system used to convey persons or freight between floors.
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20793">Building Vertical Transportation System Type</a>
    /// </para>
    /// <remarks>
    /// This entity is in the Facilities domain
    /// </remarks>
    /// </summary>
    public virtual RefBuildingVerticalTransportationSystemTypeEntity RefBuildingVerticalTransportationSystemTypeEntity { get; set; }

    #endregion
}
