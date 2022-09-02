//***************************************************************************
//* DomainName: Facilities
//* FileName:   FacilityJointUseEntity.g.cs
//***************************************************************************

/// <summary>
/// The IFacilityJointUse file
/// </summary>
[Table("FacilityJointUse", Schema = "Facilities")]
public partial class FacilityJointUseEntity : EntityBase, IFacilityJointUse
{
    #region "IFacilityJointUse Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IFacility"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("Facility")]
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
    [ForeignKey("RefBuildingJointUseRationaleType")]
    [Comment("The reasons for permitting and participating in joint-use.")]
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
    [ForeignKey("RefBuildingJointUserType")]
    [Comment("The types of users sharing school district controlled, owned, or utilized facilities.")]
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
    [ForeignKey("RefBuildingJointUseSchedulingType")]
    [Comment("The type of designation of non school district users by the amount of time they have access to public school for joint use.")]
    public Guid? RefBuildingJointUseSchedulingTypeId { get; set; }

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
    /// The reasons for permitting and participating in joint-use.
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20833">Building Joint Use Rationale Type</a>
    /// </para>
    /// <remarks>
    /// This entity is in the Facilities domain
    /// </remarks>
    /// </summary>
    public virtual RefBuildingJointUseRationaleTypeEntity RefBuildingJointUseRationaleTypeEntity { get; set; }

    /// <summary>
    /// The types of users sharing school district controlled, owned, or utilized facilities.
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20835">Building Joint User Type</a>
    /// </para>
    /// <remarks>
    /// This entity is in the Facilities domain
    /// </remarks>
    /// </summary>
    public virtual RefBuildingJointUserTypeEntity RefBuildingJointUserTypeEntity { get; set; }

    /// <summary>
    /// The type of designation of non school district users by the amount of time they have access to public school for joint use.
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20834">Building Joint Use Scheduling Type</a>
    /// </para>
    /// <remarks>
    /// This entity is in the Facilities domain
    /// </remarks>
    /// </summary>
    public virtual RefBuildingJointUseSchedulingTypeEntity RefBuildingJointUseSchedulingTypeEntity { get; set; }

    #endregion
}
