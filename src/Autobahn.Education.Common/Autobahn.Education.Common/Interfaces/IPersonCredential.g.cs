//***************************************************************************
//* DomainName: Common Models
//* FileName:   IPersonCredential.g.cs
//***************************************************************************

/// <summary>
/// The IPersonCredential file
/// </summary>
public partial interface IPersonCredential
{
    #region "IPersonCredential Properties"
    /// <summary>
    /// The Id of the Model
    /// </summary>
    Guid Id { get; set; }

    /// <summary>
    /// Name of Professional Credential or License
    /// <para>
    /// The name of the license/credential awarded by a given profession.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20064">Name of Professional Credential or License</a>
    /// </para>
    /// </summary>
    System.String CredentialName { get; set; }

    /// <summary>
    /// Credential or License Award Entity
    /// <para>
    /// The name of the organization awarding the individual's credential or license.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20566">Credential or License Award Entity</a>
    /// </para>
    /// </summary>
    System.String CredentialOrLicenseAwardEntity { get; set; }

    /// <summary>
    /// Credential Expiration Date
    /// <para>
    /// The year, month and day on which an active credential held by a person will expire.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19069">Credential Expiration Date</a>
    /// </para>
    /// </summary>
    DateTime? ExpirationDate { get; set; }

    /// <summary>
    /// Credential Issuance Date
    /// <para>
    /// The year, month and day on which an active credential was issued to a person.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19070">Credential Issuance Date</a>
    /// </para>
    /// </summary>
    DateTime? IssuanceDate { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IPerson"/> model
    /// </summary>
    Guid PersonId { get; set; }

    /// <summary>
    /// Professional Certificate or License Number
    /// <para>
    /// The number issued by the credentialing/licensing agency.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20398">Professional Certificate or License Number</a>
    /// </para>
    /// </summary>
    System.String ProfessionalCertificateOrLicenseNumber { get; set; }

    /// <summary>
    /// Credential Type
    /// <para>
    /// An indication of the category of credential a person holds.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19071">Credential Type</a>
    /// </para>
    /// </summary>
    Guid? RefCredentialTypeId { get; set; }

    /// <summary>
    /// State Issuing Professional Credential or License
    /// <para>
    /// State where the professional license/credential was issued.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19804">State Issuing Professional Credential or License</a>
    /// </para>
    /// </summary>
    Guid? RefIssuingStateId { get; set; }

    #endregion
}
