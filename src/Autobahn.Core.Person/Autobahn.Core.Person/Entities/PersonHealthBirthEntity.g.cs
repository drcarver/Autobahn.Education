//***************************************************************************
//* DomainName: Person Models
//* FileName:   PersonHealthBirthEntity.g.cs
//***************************************************************************

/// <summary>
/// The IPersonHealthBirth file
/// </summary>
[Table("PersonHealthBirth", Schema = "Autobahn.Core.Person")]
public partial class PersonHealthBirthEntity : EntityBase, IPersonHealthBirth
{
    #region "IPersonHealthBirth Properties"
    /// <summary>
    /// Multiple Birth Indicator
    /// <para>
    /// An indication that the person is a twin, triplet, etc.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19421">Multiple Birth Indicator</a>
    /// </para>
    /// </summary>
    [Comment("An indication that the person is a twin, triplet, etc.")]
    public Boolean? MultipleBirthIndicator { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IPerson"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("Person")]
    public Guid PersonId { get; set; }

    /// <summary>
    /// Trimester When Prenatal Care Began
    /// <para>
    /// The trimester of pregnancy in which a child's mother began receiving prenatal health care.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20611">Trimester When Prenatal Care Began</a>
    /// </para>
    /// </summary>
    [ForeignKey("RefTrimesterWhenPrenatalCareBegan")]
    [Comment("The trimester of pregnancy in which a child's mother began receiving prenatal health care.")]
    public Guid? RefTrimesterWhenPrenatalCareBeganId { get; set; }

    /// <summary>
    /// Weeks of Gestation
    /// <para>
    /// The number of weeks during gestational period.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19313">Weeks of Gestation</a>
    /// </para>
    /// </summary>
    [Comment("The number of weeks during gestational period.")]
    public Int32? WeeksOfGestation { get; set; }

    /// <summary>
    /// Weight at Birth
    /// <para>
    /// The weight of a child at birth in pounds and ounces.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19312">Weight at Birth</a>
    /// </para>
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(20,ErrorMessage="The {0} must be less then {1} characters.")]
    [Comment("The weight of a child at birth in pounds and ounces.")]
    public System.String WeightAtBirth { get; set; }

    #endregion

    #region "Virtual Properties for foreign keys"
    /// <summary>
    /// The trimester of pregnancy in which a child's mother began receiving prenatal health care.
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20611">Trimester When Prenatal Care Began</a>
    /// </para>
    /// <remarks>
    /// This entity is in the Autobahn.Core.Person domain
    /// </remarks>
    /// </summary>
    public virtual RefTrimesterWhenPrenatalCareBeganEntity? RefTrimesterWhenPrenatalCareBeganEntity { get; set; }

    #endregion
}
