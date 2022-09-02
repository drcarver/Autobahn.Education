//***************************************************************************
//* DomainName: Common Models
//* FileName:   FinancialAidApplicationEntity.g.cs
//***************************************************************************

/// <summary>
/// The IFinancialAidApplication file
/// </summary>
[Table("FinancialAidApplication", Schema = "Common")]
public partial class FinancialAidApplicationEntity : EntityBase, IFinancialAidApplication
{
    #region "IFinancialAidApplication Properties"
    /// <summary>
    /// Financial Aid Year Designator
    /// <para>
    /// The school year for which the student's financial aid application and award data apply.  Generally, this is the 12-month period from July 1 to June 30.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20590">Financial Aid Year Designator</a>
    /// </para>
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(9,ErrorMessage="The {0} must be less then {1} characters.")]
    [Comment("The school year for which the student's financial aid application and award data apply.  Generally, this is the 12-month period from July 1 to June 30.")]
    public System.String FinancialAidYearDesignator { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("OrganizationPersonRole")]
    public Guid OrganizationPersonRoleId { get; set; }

    /// <summary>
    /// Financial Aid Application Type
    /// <para>
    /// The type of financial application completed by an individual.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20186">Financial Aid Application Type</a>
    /// </para>
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("RefFinancialAidApplicationType")]
    [Comment("The type of financial application completed by an individual.")]
    public Guid RefFinancialAidApplicationTypeId { get; set; }

    #endregion

    #region "Virtual Properties for foreign keys"
    /// <summary>
    /// The type of financial application completed by an individual.
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20186">Financial Aid Application Type</a>
    /// </para>
    /// <remarks>
    /// This entity is in the Common domain
    /// </remarks>
    /// </summary>
    public virtual RefFinancialAidApplicationTypeEntity RefFinancialAidApplicationTypeEntity { get; set; }

    #endregion
}
