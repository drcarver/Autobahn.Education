//***************************************************************************
//* DomainName: Person Models
//* FileName:   PersonAddressNcesSideEntity.g.cs
//***************************************************************************

/// <summary>
/// The IPersonAddressNcesSide file
/// </summary>
[Table("PersonAddressNcesSide", Schema = "Person")]
public partial class PersonAddressNcesSideEntity : EntityBase, IPersonAddressNcesSide
{
    #region "IPersonAddressNcesSide Properties"
    /// <summary>
    /// NCES SIDE Date Processed
    /// <para>
    /// The year, month, and day on which the National Center for Education Statistics (NCES) spatially interpolated demographic estimate (SIDE) was processed through the BlindSIDE resource.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20943">NCES SIDE Date Processed</a>
    /// </para>
    /// </summary>
    [Comment("The year, month, and day on which the National Center for Education Statistics (NCES) spatially interpolated demographic estimate (SIDE) was processed through the BlindSIDE resource.")]
    public DateTime? NcesSideDateProcessed { get; set; }

    /// <summary>
    /// NCES SIDE Estimate
    /// <para>
    /// The National Center for Education Statistics (NCES) spatially interpolated demographic estimate (SIDE) based on the person's latitude and longitude location.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20944">NCES SIDE Estimate</a>
    /// </para>
    /// </summary>
    [Comment("The National Center for Education Statistics (NCES) spatially interpolated demographic estimate (SIDE) based on the person's latitude and longitude location.")]
    public Decimal? NcesSideEstimate { get; set; }

    /// <summary>
    /// NCES SIDE Standard Error
    /// <para>
    /// The standard error applied to the National Center for Education Statistics (NCES) spatially interpolated demographic estimate (SIDE).
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20945">NCES SIDE Standard Error</a>
    /// </para>
    /// </summary>
    [Comment("The standard error applied to the National Center for Education Statistics (NCES) spatially interpolated demographic estimate (SIDE).")]
    public Decimal? NcesSideStandardError { get; set; }

    /// <summary>
    /// NCES SIDE Vintage Begin Year
    /// <para>
    /// The begin year for the American Community Survey (ACS) period estimates used to construct the National Center for Education Statistics (NCES) spatially interpolated demographic estimate (SIDE).
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20946">NCES SIDE Vintage Begin Year</a>
    /// </para>
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(4,ErrorMessage="The {0} must be less then {1} characters.")]
    [Comment("The begin year for the American Community Survey (ACS) period estimates used to construct the National Center for Education Statistics (NCES) spatially interpolated demographic estimate (SIDE).")]
    public System.String NcesSideVintageBeginYear { get; set; }

    /// <summary>
    /// NCES SIDE Vintage End Year
    /// <para>
    /// The end year for the American Community Survey (ACS) period estimates used to construct the National Center for Education Statistics (NCES) spatially interpolated demographic estimate (SIDE).
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20947">NCES SIDE Vintage End Year</a>
    /// </para>
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(4,ErrorMessage="The {0} must be less then {1} characters.")]
    [Comment("The end year for the American Community Survey (ACS) period estimates used to construct the National Center for Education Statistics (NCES) spatially interpolated demographic estimate (SIDE).")]
    public System.String NcesSideVintageEndYear { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IPersonAddress"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("PersonAddress")]
    public Guid PersonAddressId { get; set; }

    #endregion

    #region "Virtual Properties for foreign keys"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IPersonAddress"/> implementation
    /// <remarks>
    /// This entity is in the Person domain
    /// </remarks>
    /// </summary>
    public virtual PersonAddressEntity PersonAddressEntity { get; set; }

    #endregion
}
