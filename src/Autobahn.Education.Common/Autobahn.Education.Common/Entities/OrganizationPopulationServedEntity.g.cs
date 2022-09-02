//***************************************************************************
//* DomainName: Common Models
//* FileName:   OrganizationPopulationServedEntity.g.cs
//***************************************************************************

/// <summary>
/// The IOrganizationPopulationServed file
/// </summary>
[Table("OrganizationPopulationServed", Schema = "Common")]
public partial class OrganizationPopulationServedEntity : EntityBase, IOrganizationPopulationServed
{
    #region "IOrganizationPopulationServed Properties"
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(10,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String AgeUnit { get; set; }

    /// <summary>
    /// Early Learning Oldest Age Authorized to Serve
    /// <para>
    /// The oldest age of children a class/group is authorized or licensed to serve.  (Age is specified in months)
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20189">Early Learning Oldest Age Authorized to Serve</a>
    /// </para>
    /// </summary>
    [Comment("The oldest age of children a class/group is authorized or licensed to serve.  (Age is specified in months)")]
    public Int32? OldestAgeServed { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganization"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("Organization")]
    public Guid OrganizationId { get; set; }

    /// <summary>
    /// Special Circumstances Population Served
    /// <para>
    /// Program provides services to meet the needs of children in special circumstances.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19852">Special Circumstances Population Served</a>
    /// </para>
    /// </summary>
    [ForeignKey("RefPopulationServed")]
    [Comment("Program provides services to meet the needs of children in special circumstances.")]
    public Guid? RefPopulationServedId { get; set; }

    /// <summary>
    /// Early Learning Youngest Age Authorized to Serve
    /// <para>
    /// The youngest age of children a class/group is authorized or licensed to serve.  (Age is specified in months)
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19626">Early Learning Youngest Age Authorized to Serve</a>
    /// </para>
    /// </summary>
    [Comment("The youngest age of children a class/group is authorized or licensed to serve.  (Age is specified in months)")]
    public Int32? YoungestAgeServed { get; set; }

    #endregion

    #region "Virtual Properties for foreign keys"
    /// <summary>
    /// Program provides services to meet the needs of children in special circumstances.
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19852">Special Circumstances Population Served</a>
    /// </para>
    /// <remarks>
    /// This entity is in the Common domain
    /// </remarks>
    /// </summary>
    public virtual RefPopulationServedEntity RefPopulationServedEntity { get; set; }

    #endregion
}
