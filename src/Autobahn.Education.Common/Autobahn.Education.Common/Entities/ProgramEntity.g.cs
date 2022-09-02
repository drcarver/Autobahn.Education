//***************************************************************************
//* DomainName: Common Models
//* FileName:   ProgramEntity.g.cs
//***************************************************************************

/// <summary>
/// The IProgram file
/// </summary>
[Table("Program", Schema = "Common")]
public partial class ProgramEntity : EntityBase, IProgram
{
    #region "IProgram Properties"
    /// <summary>
    /// Credits Required
    /// <para>
    /// The total number of credits required for a student to graduate from the school of enrollment or complete a program.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20553">Credits Required</a>
    /// </para>
    /// </summary>
    [Comment("The total number of credits required for a student to graduate from the school of enrollment or complete a program.")]
    public Decimal? CreditsRequired { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganization"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("Organization")]
    public Guid OrganizationId { get; set; }

    #endregion

    #region "Virtual Properties for foreign keys"
    #endregion
}
