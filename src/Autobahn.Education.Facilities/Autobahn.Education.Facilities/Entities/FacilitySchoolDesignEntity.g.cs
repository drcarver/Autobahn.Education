//***************************************************************************
//* DomainName: Facilities
//* FileName:   FacilitySchoolDesignEntity.g.cs
//***************************************************************************

/// <summary>
/// The IFacilitySchoolDesign file
/// </summary>
[Table("FacilitySchoolDesign", Schema = "Facilities")]
public partial class FacilitySchoolDesignEntity : EntityBase, IFacilitySchoolDesign
{
    #region "IFacilitySchoolDesign Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IFacilityDesign"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("FacilityDesign")]
    public Guid FacilityDesignId { get; set; }

    /// <summary>
    /// Building School Design Type
    /// <para>
    /// The physical layout and character of a school facility, as determined by age groups served and educational programs provided.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20809">Building School Design Type</a>
    /// </para>
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("RefBuildingSchoolDesignType")]
    [Comment("The physical layout and character of a school facility, as determined by age groups served and educational programs provided.")]
    public Guid RefBuildingSchoolDesignTypeId { get; set; }

    #endregion

    #region "Virtual Properties for foreign keys"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IFacilityDesign"/> implementation
    /// <remarks>
    /// This entity is in the Facilities domain
    /// </remarks>
    /// </summary>
    public virtual FacilityDesignEntity FacilityDesignEntity { get; set; }

    /// <summary>
    /// The physical layout and character of a school facility, as determined by age groups served and educational programs provided.
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20809">Building School Design Type</a>
    /// </para>
    /// <remarks>
    /// This entity is in the Facilities domain
    /// </remarks>
    /// </summary>
    public virtual RefBuildingSchoolDesignTypeEntity RefBuildingSchoolDesignTypeEntity { get; set; }

    #endregion
}
