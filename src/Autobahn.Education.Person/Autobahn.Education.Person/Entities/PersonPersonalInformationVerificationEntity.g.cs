//***************************************************************************
//* DomainName: Person Models
//* FileName:   PersonPersonalInformationVerificationEntity.g.cs
//***************************************************************************

/// <summary>
/// The IPersonPersonalInformationVerification file
/// </summary>
[Table("PersonPersonalInformationVerification", Schema = "Person")]
public partial class PersonPersonalInformationVerificationEntity : EntityBase, IPersonPersonalInformationVerification
{
    #region "IPersonPersonalInformationVerification Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IPersonAddress"/> model
    /// </summary>
    [ForeignKey("PersonAddress")]
    public Guid? PersonAddressId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IPersonDetail"/> model
    /// </summary>
    [ForeignKey("PersonDetail")]
    public Guid? PersonDetailId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IPerson"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("Person")]
    public Guid PersonId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IPersonTelephone"/> model
    /// </summary>
    [ForeignKey("PersonTelephone")]
    public Guid? PersonTelephoneId { get; set; }

    /// <summary>
    /// Personal Information Type
    /// <para>
    /// The type of personal information verified through the Personal Information Verification evidence.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20951">Personal Information Type</a>
    /// </para>
    /// </summary>
    [ForeignKey("RefPersonalInformationType")]
    [Comment("The type of personal information verified through the Personal Information Verification evidence.")]
    public Guid? RefPersonalInformationTypeId { get; set; }

    /// <summary>
    /// Personal Information Verification
    /// <para>
    /// The evidence by which a persons name, address, date of birth, etc. is confirmed.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19611">Personal Information Verification</a>
    /// </para>
    /// </summary>
    [ForeignKey("RefPersonalInformationVerification")]
    [Comment("The evidence by which a persons name, address, date of birth, etc. is confirmed.")]
    public Guid? RefPersonalInformationVerificationId { get; set; }

    #endregion

    #region "Virtual Properties for foreign keys"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IPersonAddress"/> implementation
    /// <remarks>
    /// This entity is in the Person domain
    /// </remarks>
    /// </summary>
    public virtual PersonAddressEntity? PersonAddressEntity { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IPersonDetail"/> implementation
    /// <remarks>
    /// This entity is in the Person domain
    /// </remarks>
    /// </summary>
    public virtual PersonDetailEntity? PersonDetailEntity { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IPersonTelephone"/> implementation
    /// <remarks>
    /// This entity is in the Person domain
    /// </remarks>
    /// </summary>
    public virtual PersonTelephoneEntity? PersonTelephoneEntity { get; set; }

    /// <summary>
    /// The type of personal information verified through the Personal Information Verification evidence.
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20951">Personal Information Type</a>
    /// </para>
    /// <remarks>
    /// This entity is in the Person domain
    /// </remarks>
    /// </summary>
    public virtual RefPersonalInformationTypeEntity? RefPersonalInformationTypeEntity { get; set; }

    /// <summary>
    /// The evidence by which a persons name, address, date of birth, etc. is confirmed.
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19611">Personal Information Verification</a>
    /// </para>
    /// <remarks>
    /// This entity is in the Person domain
    /// </remarks>
    /// </summary>
    public virtual RefPersonalInformationVerificationEntity? RefPersonalInformationVerificationEntity { get; set; }

    #endregion
}
